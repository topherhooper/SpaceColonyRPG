#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;
using System.IO;

public class SetupAutomation : EditorWindow
{
    [MenuItem("SpaceColony/Run Complete Setup")]
    public static void RunCompleteSetup()
    {
        Debug.Log("===============================================");
        Debug.Log("Starting Space Colony RPG Complete Setup");
        Debug.Log("===============================================");

        try
        {
            // 1. Create directory structure
            CreateProjectDirectories();

            // 2. Create materials
            MaterialGenerator.GenerateAllMaterials();

            // 3. Setup layers and tags
            SetupLayersAndTags();

            // 4. Generate missing scenes (won't overwrite existing)
            SceneGenerator.GenerateMissingScenesOnly();

            // 5. Generate all prefabs
            PrefabGenerator.GenerateAllPrefabs();

            // 6. Refresh asset database
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();

            Debug.Log("===============================================");
            Debug.Log("Setup Complete! Project is ready to play.");
            Debug.Log("===============================================");
            Debug.Log("Next steps:");
            Debug.Log("1. Open MainMenu scene");
            Debug.Log("2. Assign prefabs to NetworkManager");
            Debug.Log("3. Press Play to test!");
        }
        catch (System.Exception e)
        {
            Debug.LogError($"Setup failed with error: {e.Message}\n{e.StackTrace}");
        }
    }

    static void CreateProjectDirectories()
    {
        Debug.Log("Creating project directories...");

        string[] directories = new string[]
        {
            "Assets/_Project",
            "Assets/_Project/Scripts",
            "Assets/_Project/Scripts/Player",
            "Assets/_Project/Scripts/Combat",
            "Assets/_Project/Scripts/Colony",
            "Assets/_Project/Scripts/Networking",
            "Assets/_Project/Scripts/UI",
            "Assets/_Project/Scripts/Managers",
            "Assets/_Project/Scripts/Editor",
            "Assets/_Project/Scripts/Utilities",
            "Assets/_Project/Prefabs",
            "Assets/_Project/Prefabs/Players",
            "Assets/_Project/Prefabs/Enemies",
            "Assets/_Project/Prefabs/Projectiles",
            "Assets/_Project/Prefabs/Buildings",
            "Assets/_Project/Prefabs/UI",
            "Assets/_Project/Prefabs/VFX",
            "Assets/_Project/Materials",
            "Assets/_Project/Textures",
            "Assets/_Project/Audio",
            "Assets/_Project/Audio/SFX",
            "Assets/_Project/Audio/Music",
            "Assets/_Project/Scenes"
        };

        foreach (string dir in directories)
        {
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
                Debug.Log($"Created directory: {dir}");
            }
        }
    }

    static void SetupLayersAndTags()
    {
        Debug.Log("Setting up layers and tags...");

        // Add layers
        string[] layers = new string[]
        {
            "Player",      // Layer 8
            "Enemy",       // Layer 9
            "Projectile",  // Layer 10
            "Building",    // Layer 11
            "Ground",      // Layer 12
            "Environment", // Layer 13
            "UI",          // Layer 14
            "PostProcessing" // Layer 15
        };

        // Add tags
        string[] tags = new string[]
        {
            "Player",
            "Enemy",
            "Building",
            "Projectile",
            "SpawnPoint",
            "Resource",
            "Colonist"
        };

        // Get TagManager
        SerializedObject tagManager = new SerializedObject(AssetDatabase.LoadAllAssetsAtPath("ProjectSettings/TagManager.asset")[0]);

        // Add layers
        SerializedProperty layersProp = tagManager.FindProperty("layers");
        for (int i = 0; i < layers.Length; i++)
        {
            int layerIndex = 8 + i; // Start from layer 8
            if (layerIndex < layersProp.arraySize)
            {
                SerializedProperty sp = layersProp.GetArrayElementAtIndex(layerIndex);
                if (sp != null && string.IsNullOrEmpty(sp.stringValue))
                {
                    sp.stringValue = layers[i];
                    Debug.Log($"Added layer {layerIndex}: {layers[i]}");
                }
            }
        }

        // Add tags
        SerializedProperty tagsProp = tagManager.FindProperty("tags");
        foreach (string tag in tags)
        {
            bool found = false;
            for (int i = 0; i < tagsProp.arraySize; i++)
            {
                SerializedProperty t = tagsProp.GetArrayElementAtIndex(i);
                if (t.stringValue == tag)
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                tagsProp.InsertArrayElementAtIndex(0);
                SerializedProperty newTag = tagsProp.GetArrayElementAtIndex(0);
                newTag.stringValue = tag;
                Debug.Log($"Added tag: {tag}");
            }
        }

        tagManager.ApplyModifiedProperties();

        // Setup physics collision matrix
        SetupPhysicsCollisions();
    }

    static void SetupPhysicsCollisions()
    {
        Debug.Log("Setting up physics collision matrix...");

        // Get layer indices
        int playerLayer = LayerMask.NameToLayer("Player");
        int enemyLayer = LayerMask.NameToLayer("Enemy");
        int projectileLayer = LayerMask.NameToLayer("Projectile");
        int buildingLayer = LayerMask.NameToLayer("Building");
        int groundLayer = LayerMask.NameToLayer("Ground");
        int environmentLayer = LayerMask.NameToLayer("Environment");

        // Players don't collide with each other
        Physics.IgnoreLayerCollision(playerLayer, playerLayer, true);

        // Projectiles don't collide with each other
        Physics.IgnoreLayerCollision(projectileLayer, projectileLayer, true);

        // Buildings don't collide with ground (they're placed on it)
        Physics.IgnoreLayerCollision(buildingLayer, groundLayer, true);

        Debug.Log("Physics collision matrix configured");
    }

    [MenuItem("SpaceColony/Quick Setup Helper")]
    public static void ShowQuickSetupWindow()
    {
        EditorWindow window = GetWindow<SetupAutomation>("Space Colony Setup");
        window.minSize = new Vector2(400, 300);
    }

    void OnGUI()
    {
        GUILayout.Label("Space Colony RPG - Quick Setup", EditorStyles.boldLabel);
        GUILayout.Space(10);

        EditorGUILayout.HelpBox(
            "This will automatically set up your entire project:\n" +
            "• Create all directories\n" +
            "• Generate materials\n" +
            "• Configure layers and tags\n" +
            "• Create all scenes\n" +
            "• Generate all prefabs",
            MessageType.Info
        );

        GUILayout.Space(20);

        if (GUILayout.Button("Run Complete Setup", GUILayout.Height(40)))
        {
            RunCompleteSetup();
        }

        GUILayout.Space(10);

        GUILayout.Label("Individual Setup Steps:", EditorStyles.boldLabel);

        if (GUILayout.Button("1. Create Directories Only"))
        {
            CreateProjectDirectories();
            AssetDatabase.Refresh();
        }

        if (GUILayout.Button("2. Generate Materials Only"))
        {
            MaterialGenerator.GenerateAllMaterials();
        }

        if (GUILayout.Button("3. Setup Layers/Tags Only"))
        {
            SetupLayersAndTags();
        }

        if (GUILayout.Button("4. Generate Scenes Only"))
        {
            SceneGenerator.GenerateAllScenes();
        }

        if (GUILayout.Button("5. Generate Prefabs Only"))
        {
            PrefabGenerator.GenerateAllPrefabs();
        }

        GUILayout.Space(10);

        if (GUILayout.Button("Open Main Menu Scene"))
        {
            UnityEditor.SceneManagement.EditorSceneManager.OpenScene("Assets/_Project/Scenes/MainMenu.unity");
        }
    }
}
#endif
