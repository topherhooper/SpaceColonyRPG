#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;
using System.IO;
using SpaceColonyRPG.Colony;

public class QuickSetupHelper : EditorWindow
{
    [MenuItem("SpaceColony/Quick Setup Helper")]
    public static void ShowWindow()
    {
        GetWindow<QuickSetupHelper>("Quick Setup Helper");
    }

    void OnGUI()
    {
        GUILayout.Label("Space Colony RPG - Quick Setup", EditorStyles.boldLabel);

        GUILayout.Space(10);

        if (GUILayout.Button("1. Create Basic Materials"))
        {
            CreateBasicMaterials();
        }

        if (GUILayout.Button("2. Setup Layers and Tags"))
        {
            SetupLayersAndTags();
        }

        if (GUILayout.Button("3. Create Scene Templates"))
        {
            CreateSceneTemplates();
        }

        if (GUILayout.Button("4. Create Basic Prefabs"))
        {
            CreateBasicPrefabs();
        }

        GUILayout.Space(20);
        GUILayout.Label("Testing Helpers", EditorStyles.boldLabel);

        if (GUILayout.Button("Add Test Resources"))
        {
            AddTestResources();
        }

        if (GUILayout.Button("Spawn Test Enemy"))
        {
            SpawnTestEnemy();
        }
    }

    public static void CreateBasicMaterials()
    {
        string materialsPath = "Assets/_Project/Materials";
        if (!Directory.Exists(materialsPath))
        {
            Directory.CreateDirectory(materialsPath);
        }

        // Player Material
        CreateMaterial(materialsPath + "/Player_Mat.mat", new Color(0, 0.5f, 1f), 0.8f, 0.8f);

        // Enemy Material
        Material enemyMat = CreateMaterial(materialsPath + "/Enemy_Mat.mat", Color.red, 0.5f, 0.3f);
        enemyMat.EnableKeyword("_EMISSION");
        enemyMat.SetColor("_EmissionColor", new Color(0.5f, 0, 0));

        // Building Material
        CreateMaterial(materialsPath + "/Building_Mat.mat", Color.gray, 0.5f, 0.3f);

        // Building Ghost Valid
        Material ghostValid = CreateMaterial(materialsPath + "/Building_Ghost_Valid.mat", new Color(0, 1, 0, 0.5f), 0, 0);
        SetTransparent(ghostValid);

        // Building Ghost Invalid
        Material ghostInvalid = CreateMaterial(materialsPath + "/Building_Ghost_Invalid.mat", new Color(1, 0, 0, 0.5f), 0, 0);
        SetTransparent(ghostInvalid);

        Debug.Log("Basic materials created!");
        AssetDatabase.Refresh();
    }

    static Material CreateMaterial(string path, Color color, float metallic, float smoothness)
    {
        Material mat = new Material(Shader.Find("Universal Render Pipeline/Lit"));
        mat.SetColor("_BaseColor", color);
        mat.SetFloat("_Metallic", metallic);
        mat.SetFloat("_Smoothness", smoothness);
        AssetDatabase.CreateAsset(mat, path);
        return mat;
    }

    static void SetTransparent(Material mat)
    {
        mat.SetFloat("_Surface", 1); // Transparent
        mat.SetFloat("_Blend", 0); // Alpha
        mat.renderQueue = 3000;
        mat.SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
        mat.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
        mat.SetInt("_ZWrite", 0);
        mat.EnableKeyword("_ALPHAPREMULTIPLY_ON");
    }

    public static void SetupLayersAndTags()
    {
        // Add layers
        AddLayer("Ground", 8);
        AddLayer("Building", 9);
        AddLayer("Enemy", 10);
        AddLayer("Player", 11);
        AddLayer("Projectile", 12);

        // Add tags
        AddTag("Player");
        AddTag("Enemy");
        AddTag("Building");
        AddTag("Colonist");
        AddTag("Resource");
        AddTag("Projectile");

        Debug.Log("Layers and tags configured!");
    }

    static void AddLayer(string layerName, int layerNumber)
    {
        SerializedObject tagManager = new SerializedObject(AssetDatabase.LoadAllAssetsAtPath("ProjectSettings/TagManager.asset")[0]);
        SerializedProperty layers = tagManager.FindProperty("layers");

        if (layers.GetArrayElementAtIndex(layerNumber).stringValue == "")
        {
            layers.GetArrayElementAtIndex(layerNumber).stringValue = layerName;
            tagManager.ApplyModifiedProperties();
        }
    }

    static void AddTag(string tagName)
    {
        SerializedObject tagManager = new SerializedObject(AssetDatabase.LoadAllAssetsAtPath("ProjectSettings/TagManager.asset")[0]);
        SerializedProperty tagsProp = tagManager.FindProperty("tags");

        bool found = false;
        for (int i = 0; i < tagsProp.arraySize; i++)
        {
            SerializedProperty t = tagsProp.GetArrayElementAtIndex(i);
            if (t.stringValue.Equals(tagName))
            {
                found = true;
                break;
            }
        }

        if (!found)
        {
            tagsProp.InsertArrayElementAtIndex(0);
            SerializedProperty n = tagsProp.GetArrayElementAtIndex(0);
            n.stringValue = tagName;
            tagManager.ApplyModifiedProperties();
        }
    }

    void CreateSceneTemplates()
    {
        Debug.Log("Scene templates creation - Please create scenes manually:");
        Debug.Log("1. MainMenu - Add GameManagers object with all manager scripts");
        Debug.Log("2. ColonyScene - Add BuildingSystem and spawn points");
        Debug.Log("3. RaidScene - Add RaidManager and enemy spawns");
    }

    void CreateBasicPrefabs()
    {
        string prefabsPath = "Assets/_Project/Prefabs";

        // Create Player prefab template
        GameObject player = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        player.name = "Player_Template";
        player.tag = "Player";
        player.layer = LayerMask.NameToLayer("Player");
        Debug.Log("Player template created - Add Mirror and game components!");

        // Create Enemy prefab template
        GameObject enemy = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        enemy.name = "Enemy_Template";
        enemy.tag = "Enemy";
        enemy.layer = LayerMask.NameToLayer("Enemy");
        enemy.GetComponent<Renderer>().material.color = Color.red;
        Debug.Log("Enemy template created - Add AI and combat components!");

        // Create Projectile template
        GameObject projectile = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        projectile.name = "Projectile_Template";
        projectile.transform.localScale = Vector3.one * 0.2f;
        projectile.layer = LayerMask.NameToLayer("Projectile");
        Debug.Log("Projectile template created - Add physics and network components!");
    }

    void AddTestResources()
    {
        if (ResourceManager.Instance != null)
        {
            ResourceManager.Instance.ModifyResource(ResourceType.Metal, 1000);
            ResourceManager.Instance.ModifyResource(ResourceType.Energy, 1000);
            ResourceManager.Instance.ModifyResource(ResourceType.Credits, 1000);
            Debug.Log("Added 1000 of each resource!");
        }
        else
        {
            Debug.LogError("ResourceManager not found! Make sure you're in play mode.");
        }
    }

    void SpawnTestEnemy()
    {
        if (!Application.isPlaying)
        {
            Debug.LogError("Must be in play mode to spawn enemies!");
            return;
        }

        GameObject enemyPrefab = Resources.Load<GameObject>("Enemy");
        if (enemyPrefab == null)
        {
            Debug.LogError("Enemy prefab not found in Resources folder!");
            return;
        }

        Vector3 spawnPos = Camera.main.transform.position + Camera.main.transform.forward * 10f;
        spawnPos.y = 0;

        Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
        Debug.Log("Test enemy spawned!");
    }
}
#endif
