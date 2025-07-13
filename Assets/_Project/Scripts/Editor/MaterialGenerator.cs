#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;
using System.IO;

public class MaterialGenerator : EditorWindow
{
    [MenuItem("SpaceColony/Generate All Materials")]
    public static void GenerateAllMaterials()
    {
        Debug.Log("Generating materials...");
        
        string materialsPath = "Assets/_Project/Materials";
        if (!Directory.Exists(materialsPath))
        {
            Directory.CreateDirectory(materialsPath);
        }
        
        // Create basic materials
        CreateMaterial("Player_Mat", Color.blue);
        CreateMaterial("Enemy_Mat", Color.red);
        CreateMaterial("Building_Mat", Color.gray);
        CreateMaterial("Ground_Mat", new Color(0.4f, 0.3f, 0.2f));
        CreateMaterial("Projectile_Mat", Color.yellow);
        CreateMaterial("Colonist_Mat", Color.green);
        CreateMaterial("Loot_Mat", Color.magenta);
        
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
        
        Debug.Log("Materials generated successfully!");
    }
    
    static void CreateMaterial(string name, Color color)
    {
        string path = $"Assets/_Project/Materials/{name}.mat";
        
        Material mat = new Material(Shader.Find("Universal Render Pipeline/Lit"));
        mat.color = color;
        
        AssetDatabase.CreateAsset(mat, path);
        Debug.Log($"Created material: {path}");
    }
}
#endif