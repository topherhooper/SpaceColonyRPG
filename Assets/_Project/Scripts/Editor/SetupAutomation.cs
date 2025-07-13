#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;
using System.Collections;

public class SetupAutomation
{
    [MenuItem("SpaceColony/Run Complete Setup")]
    public static void RunCompleteSetup()
    {
        Debug.Log("Starting complete project setup...");
        
        // Step 1: Create materials
        Debug.Log("Step 1: Creating materials...");
        QuickSetupHelper.CreateBasicMaterials();
        
        // Step 2: Setup layers and tags
        Debug.Log("Step 2: Setting up layers and tags...");
        QuickSetupHelper.SetupLayersAndTags();
        
        // Step 3: Generate all scenes
        Debug.Log("Step 3: Generating scenes...");
        SceneGenerator.GenerateAllScenes();
        
        // Step 4: Generate all prefabs
        Debug.Log("Step 4: Generating prefabs...");
        PrefabGenerator.GenerateAllPrefabs();
        
        // Step 5: Configure build settings
        Debug.Log("Step 5: Configuring build settings...");
        ConfigureBuildSettings();
        
        // Step 6: Assign prefabs to managers
        Debug.Log("Step 6: Assigning prefabs to managers...");
        AssignPrefabsToManagers();
        
        Debug.Log("Setup complete! Project is ready to build.");
    }
    
    public static void SetupProject()
    {
        // Entry point for command line builds
        RunCompleteSetup();
    }
    
    private static void ConfigureBuildSettings()
    {
        // Player settings
        PlayerSettings.companyName = "7DayHackathon";
        PlayerSettings.productName = "Space Colony RPG";
        PlayerSettings.defaultScreenWidth = 1920;
        PlayerSettings.defaultScreenHeight = 1080;
        
        // Graphics settings
        PlayerSettings.colorSpace = ColorSpace.Gamma;
        
        // Set quality level
        QualitySettings.SetQualityLevel(2); // Medium
        
        // Configure physics collision matrix
        ConfigurePhysicsLayers();
    }
    
    private static void ConfigurePhysicsLayers()
    {
        // Disable certain collisions
        int groundLayer = LayerMask.NameToLayer("Ground");
        int buildingLayer = LayerMask.NameToLayer("Building");
        int enemyLayer = LayerMask.NameToLayer("Enemy");
        int playerLayer = LayerMask.NameToLayer("Player");
        int projectileLayer = LayerMask.NameToLayer("Projectile");
        
        // Buildings don't collide with each other
        Physics.IgnoreLayerCollision(buildingLayer, buildingLayer, true);
        
        // Projectiles don't collide with each other
        Physics.IgnoreLayerCollision(projectileLayer, projectileLayer, true);
        
        // Players don't collide with each other
        Physics.IgnoreLayerCollision(playerLayer, playerLayer, true);
    }
    
    private static void AssignPrefabsToManagers()
    {
        // Try to find and assign prefabs to network manager
        GameObject playerPrefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/_Project/Prefabs/Players/Player.prefab");
        GameObject enemyPrefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/_Project/Prefabs/Enemies/Enemy.prefab");
        GameObject projectilePrefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/_Project/Prefabs/Projectiles/Projectile.prefab");
        GameObject lootPrefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/_Project/Prefabs/LootPickup.prefab");
        
        // Find building prefabs
        GameObject[] buildingPrefabs = new GameObject[5];
        string[] buildingNames = { "Generator", "Barracks", "Storage", "Mine", "Farm" };
        
        for (int i = 0; i < buildingNames.Length; i++)
        {
            buildingPrefabs[i] = AssetDatabase.LoadAssetAtPath<GameObject>($"Assets/_Project/Prefabs/Buildings/{buildingNames[i]}.prefab");
        }
        
        Debug.Log($"Loaded prefabs - Player: {playerPrefab != null}, Enemy: {enemyPrefab != null}, Projectile: {projectilePrefab != null}");
        
        // Note: Can't directly assign to scene objects from here, but prefabs are ready
    }
}
#endif