using UnityEngine;

namespace SpaceColonyRPG.Colony
{
    public class EnergyCrystalPrefab : MonoBehaviour
    {
        [Header("Crystal Settings")]
        public float glowIntensity = 2f;
        public float pulseSpeed = 1f;
        public Color crystalColor = new Color(0.3f, 0.8f, 1f);
        
        [Header("Mesh Generation")]
        public bool generateMeshOnStart = true;
        public float crystalHeight = 2f;
        public float crystalWidth = 0.5f;
        
        [Header("Effects")]
        public bool enableRotation = true;
        public float rotationSpeed = 10f;
        public bool enableFloating = true;
        public float floatAmplitude = 0.1f;
        public float floatSpeed = 1f;
        
        private Material crystalMaterial;
        private float baseIntensity;
        private Vector3 startPosition;
        private MeshRenderer meshRenderer;
        
        void Start()
        {
            startPosition = transform.position;
            baseIntensity = glowIntensity;
            
            if (generateMeshOnStart)
            {
                SetupCrystal();
            }
            else
            {
                // Just setup the material if mesh already exists
                SetupMaterial();
            }
        }
        
        void SetupCrystal()
        {
            // Create crystal mesh
            MeshFilter mf = GetComponent<MeshFilter>();
            if (!mf) mf = gameObject.AddComponent<MeshFilter>();
            
            mf.mesh = CreateCrystalMesh();
            
            // Setup material
            SetupMaterial();
        }
        
        void SetupMaterial()
        {
            meshRenderer = GetComponent<MeshRenderer>();
            if (!meshRenderer) meshRenderer = gameObject.AddComponent<MeshRenderer>();
            
            // Create a new instance of the material
            crystalMaterial = new Material(Shader.Find("Universal Render Pipeline/Lit"));
            if (crystalMaterial.shader == null)
            {
                // Fallback to standard shader
                crystalMaterial = new Material(Shader.Find("Standard"));
            }
            
            crystalMaterial.EnableKeyword("_EMISSION");
            crystalMaterial.color = crystalColor;
            crystalMaterial.SetColor("_EmissionColor", crystalColor * glowIntensity);
            crystalMaterial.SetFloat("_Metallic", 0.5f);
            crystalMaterial.SetFloat("_Smoothness", 0.9f);
            
            // Make it glow
            crystalMaterial.globalIlluminationFlags = MaterialGlobalIlluminationFlags.RealtimeEmissive;
            
            meshRenderer.material = crystalMaterial;
            
            // Add light component for extra glow effect
            Light crystalLight = GetComponentInChildren<Light>();
            if (!crystalLight)
            {
                GameObject lightObj = new GameObject("CrystalLight");
                lightObj.transform.SetParent(transform);
                lightObj.transform.localPosition = Vector3.up * (crystalHeight / 2);
                crystalLight = lightObj.AddComponent<Light>();
            }
            
            crystalLight.type = LightType.Point;
            crystalLight.color = crystalColor;
            crystalLight.intensity = glowIntensity * 0.5f;
            crystalLight.range = 5f;
        }
        
        void Update()
        {
            if (!crystalMaterial) return;
            
            // Pulsing glow effect
            float pulse = Mathf.Sin(Time.time * pulseSpeed) * 0.5f + 0.5f;
            float currentIntensity = baseIntensity * (0.5f + pulse * 0.5f);
            
            crystalMaterial.SetColor("_EmissionColor", crystalColor * currentIntensity);
            
            // Update light intensity
            Light crystalLight = GetComponentInChildren<Light>();
            if (crystalLight)
            {
                crystalLight.intensity = currentIntensity * 0.5f;
            }
            
            // Rotation effect
            if (enableRotation)
            {
                transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
            }
            
            // Floating effect
            if (enableFloating)
            {
                float floatY = Mathf.Sin(Time.time * floatSpeed) * floatAmplitude;
                transform.position = startPosition + Vector3.up * floatY;
            }
        }
        
        Mesh CreateCrystalMesh()
        {
            Mesh mesh = new Mesh();
            mesh.name = "Crystal";
            
            float halfWidth = crystalWidth / 2f;
            
            // Define vertices for a hexagonal crystal
            Vector3[] vertices = new Vector3[]
            {
                // Base hexagon (6 vertices)
                new Vector3(halfWidth, 0, 0),
                new Vector3(halfWidth * 0.5f, 0, halfWidth * 0.866f),
                new Vector3(-halfWidth * 0.5f, 0, halfWidth * 0.866f),
                new Vector3(-halfWidth, 0, 0),
                new Vector3(-halfWidth * 0.5f, 0, -halfWidth * 0.866f),
                new Vector3(halfWidth * 0.5f, 0, -halfWidth * 0.866f),
                
                // Top point
                new Vector3(0, crystalHeight, 0),
                
                // Middle ring (6 vertices) for more detail
                new Vector3(halfWidth * 0.7f, crystalHeight * 0.3f, 0),
                new Vector3(halfWidth * 0.35f, crystalHeight * 0.3f, halfWidth * 0.606f),
                new Vector3(-halfWidth * 0.35f, crystalHeight * 0.3f, halfWidth * 0.606f),
                new Vector3(-halfWidth * 0.7f, crystalHeight * 0.3f, 0),
                new Vector3(-halfWidth * 0.35f, crystalHeight * 0.3f, -halfWidth * 0.606f),
                new Vector3(halfWidth * 0.35f, crystalHeight * 0.3f, -halfWidth * 0.606f),
            };
            
            // Define triangles
            int[] triangles = new int[]
            {
                // Base
                0, 1, 2,
                0, 2, 3,
                0, 3, 4,
                0, 4, 5,
                
                // Lower sides
                0, 7, 1,
                1, 7, 8,
                1, 8, 2,
                2, 8, 9,
                2, 9, 3,
                3, 9, 10,
                3, 10, 4,
                4, 10, 11,
                4, 11, 5,
                5, 11, 12,
                5, 12, 0,
                0, 12, 7,
                
                // Upper sides
                7, 6, 8,
                8, 6, 9,
                9, 6, 10,
                10, 6, 11,
                11, 6, 12,
                12, 6, 7
            };
            
            mesh.vertices = vertices;
            mesh.triangles = triangles;
            mesh.RecalculateNormals();
            mesh.RecalculateBounds();
            
            return mesh;
        }
        
        void OnDestroy()
        {
            // Clean up runtime material
            if (crystalMaterial)
            {
                Destroy(crystalMaterial);
            }
        }
        
        // Editor helper
        [ContextMenu("Regenerate Crystal Mesh")]
        public void RegenerateMesh()
        {
            SetupCrystal();
            Debug.Log("Crystal mesh regenerated!");
        }
    }
}