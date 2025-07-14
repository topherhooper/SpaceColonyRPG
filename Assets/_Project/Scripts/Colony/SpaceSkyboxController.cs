using UnityEngine;
using UnityEngine.Rendering;

namespace SpaceColonyRPG.Colony
{
    public class SpaceSkyboxController : MonoBehaviour
    {
        [Header("Skybox Settings")]
        public Material spaceSkybox;
        public Gradient skyGradient;
        public float rotationSpeed = 0.5f;

        [Header("Atmospheric Effects")]
        public GameObject dustParticlesPrefab;
        public Light sunLight;
        public Light ambientLight;

        [Header("Lighting Colors")]
        public Color sunColor = new Color(0.8f, 0.7f, 1f);
        public float sunIntensity = 1.2f;
        public Color ambientSkyColor = new Color(0.3f, 0.2f, 0.5f);
        public Color ambientEquatorColor = new Color(0.2f, 0.15f, 0.3f);
        public Color ambientGroundColor = new Color(0.1f, 0.08f, 0.15f);

        [Header("Particle Settings")]
        public int dustParticleCount = 100;
        public float dustLifetime = 20f;
        public float dustSpeed = 0.5f;
        public Color dustColor = new Color(0.6f, 0.5f, 0.8f, 0.3f);

        private Material runtimeSkybox;
        private ParticleSystem atmosphericDust;

        void Start()
        {
            SetupSkybox();
            SetupLighting();
            CreateAtmosphericEffects();
        }

        void SetupSkybox()
        {
            if (spaceSkybox)
            {
                // Create runtime copy to avoid modifying the asset
                runtimeSkybox = new Material(spaceSkybox);
                RenderSettings.skybox = runtimeSkybox;
            }
            else
            {
                // Create procedural skybox
                runtimeSkybox = CreateProceduralSkybox();
                RenderSettings.skybox = runtimeSkybox;
            }

            // Update skybox exposure for alien atmosphere
            RenderSettings.skybox.SetFloat("_Exposure", 0.8f);
        }

        Material CreateProceduralSkybox()
        {
            Material skyMat = null;

            // Try to find procedural skybox shader
            Shader proceduralShader = Shader.Find("Skybox/Procedural");
            if (proceduralShader)
            {
                skyMat = new Material(proceduralShader);
                skyMat.SetFloat("_SunSize", 0.02f);
                skyMat.SetFloat("_AtmosphereThickness", 0.5f);
                skyMat.SetColor("_SkyTint", new Color(0.2f, 0.1f, 0.3f));
                skyMat.SetColor("_GroundColor", new Color(0.1f, 0.05f, 0.15f));
            }
            else
            {
                // Fallback to a simple gradient skybox
                Debug.LogWarning("Procedural skybox shader not found, using fallback");
                skyMat = new Material(Shader.Find("Skybox/Gradient"));
                if (skyMat.shader)
                {
                    skyMat.SetColor("_Color1", new Color(0.1f, 0.05f, 0.15f));
                    skyMat.SetColor("_Color2", new Color(0.2f, 0.1f, 0.3f));
                }
            }

            return skyMat;
        }

        void SetupLighting()
        {
            // Find or setup main sun light
            if (!sunLight)
            {
                Light[] lights = FindObjectsOfType<Light>();
                foreach (var light in lights)
                {
                    if (light.type == LightType.Directional)
                    {
                        sunLight = light;
                        break;
                    }
                }
            }

            if (sunLight)
            {
                sunLight.color = sunColor;
                sunLight.intensity = sunIntensity;
                sunLight.transform.rotation = Quaternion.Euler(35f, -30f, 0);

                // Add subtle shadows
                sunLight.shadows = LightShadows.Soft;
                sunLight.shadowStrength = 0.7f;
            }
            else
            {
                Debug.LogWarning("No directional light found for sun");
            }

            // Ambient lighting
            RenderSettings.ambientMode = AmbientMode.Trilight;
            RenderSettings.ambientSkyColor = ambientSkyColor;
            RenderSettings.ambientEquatorColor = ambientEquatorColor;
            RenderSettings.ambientGroundColor = ambientGroundColor;

            // Fog for atmosphere
            RenderSettings.fog = true;
            RenderSettings.fogColor = new Color(0.2f, 0.15f, 0.3f, 1f);
            RenderSettings.fogMode = FogMode.Linear;
            RenderSettings.fogStartDistance = 30f;
            RenderSettings.fogEndDistance = 100f;
        }

        void CreateAtmosphericEffects()
        {
            // Create floating dust particles
            GameObject dustObj = dustParticlesPrefab;
            if (!dustObj)
            {
                dustObj = new GameObject("AtmosphericDust");
            }
            else
            {
                dustObj = Instantiate(dustParticlesPrefab);
                dustObj.name = "AtmosphericDust";
            }

            atmosphericDust = dustObj.GetComponent<ParticleSystem>();
            if (!atmosphericDust)
            {
                atmosphericDust = dustObj.AddComponent<ParticleSystem>();
            }

            SetupDustParticles();
        }

        void SetupDustParticles()
        {
            if (!atmosphericDust) return;

            var main = atmosphericDust.main;
            main.maxParticles = dustParticleCount;
            main.startLifetime = dustLifetime;
            main.startSpeed = dustSpeed;
            main.startSize = 0.2f;
            main.startColor = dustColor;
            main.loop = true;

            var shape = atmosphericDust.shape;
            shape.shapeType = ParticleSystemShapeType.Box;
            shape.scale = new Vector3(100, 20, 100);
            shape.position = new Vector3(0, 10, 0);

            var velocityOverLifetime = atmosphericDust.velocityOverLifetime;
            velocityOverLifetime.enabled = true;
            velocityOverLifetime.space = ParticleSystemSimulationSpace.World;
            velocityOverLifetime.x = new ParticleSystem.MinMaxCurve(-0.5f, 0.5f);
            velocityOverLifetime.y = new ParticleSystem.MinMaxCurve(-0.1f, 0.1f);
            velocityOverLifetime.z = new ParticleSystem.MinMaxCurve(-0.5f, 0.5f);

            var colorOverLifetime = atmosphericDust.colorOverLifetime;
            colorOverLifetime.enabled = true;
            Gradient gradient = new Gradient();
            gradient.SetKeys(
                new GradientColorKey[] {
                    new GradientColorKey(Color.white, 0.0f),
                    new GradientColorKey(Color.white, 1.0f)
                },
                new GradientAlphaKey[] {
                    new GradientAlphaKey(0.0f, 0.0f),
                    new GradientAlphaKey(0.3f, 0.5f),
                    new GradientAlphaKey(0.0f, 1.0f)
                }
            );
            colorOverLifetime.color = gradient;

            // Use unlit material for particles
            var renderer = atmosphericDust.GetComponent<ParticleSystemRenderer>();
            if (renderer)
            {
                renderer.material = new Material(Shader.Find("Sprites/Default"));
                renderer.material.color = dustColor;
            }
        }

        void Update()
        {
            // Slowly rotate skybox for dynamic feel
            if (runtimeSkybox && rotationSpeed > 0)
            {
                float rotation = Time.time * rotationSpeed;
                runtimeSkybox.SetFloat("_Rotation", rotation % 360f);
            }
        }

        void OnDestroy()
        {
            // Clean up runtime materials
            if (runtimeSkybox)
            {
                Destroy(runtimeSkybox);
            }
        }

        // Editor helpers
        [ContextMenu("Apply Atmosphere Settings")]
        public void ApplyAtmosphereSettings()
        {
            SetupSkybox();
            SetupLighting();
            Debug.Log("Atmosphere settings applied!");
        }
    }
}
