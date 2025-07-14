using UnityEngine;
using UnityEditor;
using System.IO;

namespace SpaceColonyRPG.Editor
{
    public class AlienMaterialCreator : EditorWindow
    {
        [MenuItem("Tools/Colony/Create Alien Materials")]
        public static void ShowWindow()
        {
            GetWindow<AlienMaterialCreator>("Alien Materials");
        }
        
        void OnGUI()
        {
            GUILayout.Label("Alien Material Creator", EditorStyles.boldLabel);
            
            EditorGUILayout.Space();
            
            if (GUILayout.Button("Create All Alien Materials", GUILayout.Height(40)))
            {
                CreateAlienMaterials();
            }
            
            EditorGUILayout.Space();
            
            EditorGUILayout.HelpBox(
                "This will create:\n" +
                "• Alien Ground - Purple/gray terrain\n" +
                "• Alien Rock - Dark purple rocks\n" +
                "• Energy Crystal - Glowing blue crystals\n" +
                "• Alien Vegetation - Purple/pink plants", 
                MessageType.Info);
        }
        
        void CreateAlienMaterials()
        {
            string path = "Assets/_Project/Materials/Environment/";
            
            // Ensure directory exists
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                AssetDatabase.Refresh();
            }
            
            // Alien Ground
            CreateMaterial(path + "AlienGround.mat", 
                new Color(0.4f, 0.3f, 0.5f), // Purple-gray
                0.2f, // Low metallic
                0.1f  // Low smoothness
            );
            
            // Alien Rock
            CreateMaterial(path + "AlienRock.mat", 
                new Color(0.3f, 0.25f, 0.4f), // Dark purple
                0.3f, // Some metallic
                0.2f  // Rough
            );
            
            // Energy Crystal
            CreateEmissiveMaterial(path + "EnergyCrystal.mat", 
                new Color(0.3f, 0.8f, 1f), // Cyan
                2f // High emission
            );
            
            // Alien Vegetation
            CreateMaterial(path + "AlienVegetation.mat", 
                new Color(0.5f, 0.3f, 0.7f), // Purple-pink
                0.1f, // Non-metallic
                0.8f  // Smooth/waxy
            );
            
            // Alien Metal (for debris)
            CreateMaterial(path + "AlienMetal.mat",
                new Color(0.6f, 0.5f, 0.7f), // Light purple metal
                0.8f, // Metallic
                0.6f  // Semi-smooth
            );
            
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
            
            Debug.Log("Alien materials created successfully!");
            EditorUtility.DisplayDialog("Success", "Alien materials have been created in:\n" + path, "OK");
        }
        
        void CreateMaterial(string assetPath, Color color, float metallic, float smoothness)
        {
            // Check if material already exists
            if (File.Exists(assetPath))
            {
                if (!EditorUtility.DisplayDialog("Material Exists", 
                    $"Material already exists at {assetPath}. Overwrite?", 
                    "Yes", "No"))
                {
                    return;
                }
                AssetDatabase.DeleteAsset(assetPath);
            }
            
            Material mat = new Material(Shader.Find("Universal Render Pipeline/Lit"));
            if (mat.shader == null)
            {
                // Fallback to standard shader if URP not found
                mat = new Material(Shader.Find("Standard"));
            }
            
            mat.color = color;
            mat.SetFloat("_Metallic", metallic);
            mat.SetFloat("_Smoothness", smoothness);
            
            AssetDatabase.CreateAsset(mat, assetPath);
            Debug.Log($"Created material: {assetPath}");
        }
        
        void CreateEmissiveMaterial(string assetPath, Color color, float intensity)
        {
            // Check if material already exists
            if (File.Exists(assetPath))
            {
                if (!EditorUtility.DisplayDialog("Material Exists", 
                    $"Material already exists at {assetPath}. Overwrite?", 
                    "Yes", "No"))
                {
                    return;
                }
                AssetDatabase.DeleteAsset(assetPath);
            }
            
            Material mat = new Material(Shader.Find("Universal Render Pipeline/Lit"));
            if (mat.shader == null)
            {
                // Fallback to standard shader if URP not found
                mat = new Material(Shader.Find("Standard"));
            }
            
            mat.color = color;
            mat.EnableKeyword("_EMISSION");
            mat.SetColor("_EmissionColor", color * intensity);
            mat.SetFloat("_Metallic", 0.5f);
            mat.SetFloat("_Smoothness", 0.9f);
            
            // Make it glow
            mat.globalIlluminationFlags = MaterialGlobalIlluminationFlags.RealtimeEmissive;
            
            AssetDatabase.CreateAsset(mat, assetPath);
            Debug.Log($"Created emissive material: {assetPath}");
        }
    }
}