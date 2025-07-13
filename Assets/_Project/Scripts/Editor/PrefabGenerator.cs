#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;
using System.IO;
using Mirror;
using UnityEngine.AI;

public class PrefabGenerator : EditorWindow
{
    [MenuItem("SpaceColony/Generate All Prefabs")]
    public static void GenerateAllPrefabs()
    {
        CreateDirectoryStructure();
        
        GeneratePlayerPrefab();
        GenerateEnemyPrefab();
        GenerateProjectilePrefab();
        GenerateBuildingPrefabs();
        GenerateColonistPrefab();
        GenerateLootPickupPrefab();
        
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
        
        Debug.Log("All prefabs generated successfully!");
    }

    private static void CreateDirectoryStructure()
    {
        string[] directories = new string[]
        {
            "Assets/_Project/Prefabs/Players",
            "Assets/_Project/Prefabs/Enemies",
            "Assets/_Project/Prefabs/Projectiles",
            "Assets/_Project/Prefabs/Buildings",
            "Assets/_Project/Prefabs/UI",
            "Assets/_Project/Prefabs/VFX"
        };

        foreach (string dir in directories)
        {
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
        }
    }

    [MenuItem("SpaceColony/Prefabs/Generate Player")]
    public static void GeneratePlayerPrefab()
    {
        GameObject player = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        player.name = "Player";
        player.tag = "Player";
        player.layer = LayerMask.NameToLayer("Player");

        // Add components
        player.AddComponent<NetworkIdentity>().localPlayerAuthority = true;
        player.AddComponent<NetworkTransform>();
        player.AddComponent<NetworkAnimator>();
        
        CharacterController controller = player.AddComponent<CharacterController>();
        controller.height = 2f;
        controller.radius = 0.5f;
        controller.center = new Vector3(0, 1f, 0);
        
        player.AddComponent<PlayerController>();
        
        CombatStats combatStats = player.AddComponent<CombatStats>();
        combatStats.maxHealth = 100;
        combatStats.health = 100;
        
        player.AddComponent<Weapon>();
        player.AddComponent<PlayerProgression>();

        // Create fire point
        GameObject firePoint = new GameObject("FirePoint");
        firePoint.transform.SetParent(player.transform);
        firePoint.transform.localPosition = new Vector3(0, 0.5f, 1f);

        // Apply material if exists
        Material playerMat = AssetDatabase.LoadAssetAtPath<Material>("Assets/_Project/Materials/Player_Mat.mat");
        if (playerMat != null)
        {
            player.GetComponent<Renderer>().material = playerMat;
        }

        // Save prefab
        string prefabPath = "Assets/_Project/Prefabs/Players/Player.prefab";
        PrefabUtility.SaveAsPrefabAsset(player, prefabPath);
        DestroyImmediate(player);
        
        Debug.Log($"Player prefab created at: {prefabPath}");
    }

    [MenuItem("SpaceColony/Prefabs/Generate Enemy")]
    public static void GenerateEnemyPrefab()
    {
        GameObject enemy = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        enemy.name = "Enemy";
        enemy.tag = "Enemy";
        enemy.layer = LayerMask.NameToLayer("Enemy");

        // Add components
        enemy.AddComponent<NetworkIdentity>();
        enemy.AddComponent<NetworkTransform>();
        
        CapsuleCollider collider = enemy.GetComponent<CapsuleCollider>();
        collider.height = 2f;
        collider.radius = 0.5f;
        
        NavMeshAgent agent = enemy.AddComponent<NavMeshAgent>();
        agent.speed = 3f;
        agent.stoppingDistance = 2f;
        agent.radius = 0.5f;
        agent.height = 2f;
        
        SimpleEnemy simpleEnemy = enemy.AddComponent<SimpleEnemy>();
        simpleEnemy.detectionRange = 10f;
        simpleEnemy.attackRange = 2f;
        simpleEnemy.moveSpeed = 3f;
        
        CombatStats combatStats = enemy.AddComponent<CombatStats>();
        combatStats.maxHealth = 50;
        combatStats.health = 50;
        combatStats.damage = 10;
        
        LootDrop lootDrop = enemy.AddComponent<LootDrop>();

        // Apply material if exists
        Material enemyMat = AssetDatabase.LoadAssetAtPath<Material>("Assets/_Project/Materials/Enemy_Mat.mat");
        if (enemyMat != null)
        {
            enemy.GetComponent<Renderer>().material = enemyMat;
        }

        // Save prefab
        string prefabPath = "Assets/_Project/Prefabs/Enemies/Enemy.prefab";
        PrefabUtility.SaveAsPrefabAsset(enemy, prefabPath);
        DestroyImmediate(enemy);
        
        Debug.Log($"Enemy prefab created at: {prefabPath}");
    }

    [MenuItem("SpaceColony/Prefabs/Generate Projectile")]
    public static void GenerateProjectilePrefab()
    {
        GameObject projectile = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        projectile.name = "Projectile";
        projectile.tag = "Projectile";
        projectile.layer = LayerMask.NameToLayer("Projectile");
        projectile.transform.localScale = Vector3.one * 0.2f;

        // Add components
        projectile.AddComponent<NetworkIdentity>();
        projectile.AddComponent<NetworkTransform>();
        
        Rigidbody rb = projectile.AddComponent<Rigidbody>();
        rb.mass = 0.1f;
        rb.drag = 0f;
        rb.angularDrag = 0f;
        rb.useGravity = false;
        rb.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
        
        SphereCollider collider = projectile.GetComponent<SphereCollider>();
        collider.isTrigger = true;
        collider.radius = 0.5f;
        
        projectile.AddComponent<Projectile>();
        
        // Add trail renderer
        TrailRenderer trail = projectile.AddComponent<TrailRenderer>();
        trail.time = 0.5f;
        trail.startWidth = 0.1f;
        trail.endWidth = 0f;
        trail.material = new Material(Shader.Find("Sprites/Default"));
        trail.startColor = Color.yellow;
        trail.endColor = new Color(1f, 1f, 0f, 0f);

        // Save prefab
        string prefabPath = "Assets/_Project/Prefabs/Projectiles/Projectile.prefab";
        PrefabUtility.SaveAsPrefabAsset(projectile, prefabPath);
        DestroyImmediate(projectile);
        
        Debug.Log($"Projectile prefab created at: {prefabPath}");
    }

    [MenuItem("SpaceColony/Prefabs/Generate Buildings")]
    public static void GenerateBuildingPrefabs()
    {
        // Building configurations
        var buildingConfigs = new[]
        {
            new { name = "Generator", metalCost = 50, energyCost = 0, produces = "Energy", amount = 5 },
            new { name = "Barracks", metalCost = 75, energyCost = 25, produces = "", amount = 0 },
            new { name = "Storage", metalCost = 40, energyCost = 10, produces = "", amount = 0 },
            new { name = "Mine", metalCost = 60, energyCost = 20, produces = "Metal", amount = 3 },
            new { name = "Farm", metalCost = 30, energyCost = 15, produces = "Food", amount = 2 }
        };

        Material buildingMat = AssetDatabase.LoadAssetAtPath<Material>("Assets/_Project/Materials/Building_Mat.mat");
        Material ghostValid = AssetDatabase.LoadAssetAtPath<Material>("Assets/_Project/Materials/Building_Ghost_Valid.mat");

        foreach (var config in buildingConfigs)
        {
            GameObject building = new GameObject(config.name);
            
            // Add building component
            Building buildingComp = building.AddComponent<Building>();
            buildingComp.buildingName = config.name;
            buildingComp.metalCost = config.metalCost;
            buildingComp.energyCost = config.energyCost;
            
            if (!string.IsNullOrEmpty(config.produces))
            {
                buildingComp.isProducer = true;
                buildingComp.producedResource = config.produces;
                buildingComp.productionAmount = config.amount;
            }
            
            // Add collider
            BoxCollider collider = building.AddComponent<BoxCollider>();
            collider.size = new Vector3(2f, 3f, 2f);
            collider.center = new Vector3(0, 1.5f, 0);
            
            // Create model
            GameObject model = GameObject.CreatePrimitive(PrimitiveType.Cube);
            model.name = "Model";
            model.transform.SetParent(building.transform);
            model.transform.localScale = new Vector3(2f, 3f, 2f);
            model.transform.localPosition = new Vector3(0, 1.5f, 0);
            
            if (buildingMat != null)
            {
                model.GetComponent<Renderer>().material = buildingMat;
            }
            
            // Create construction site
            GameObject construction = new GameObject("ConstructionSite");
            construction.transform.SetParent(building.transform);
            
            GameObject constructModel = GameObject.CreatePrimitive(PrimitiveType.Cube);
            constructModel.transform.SetParent(construction.transform);
            constructModel.transform.localScale = new Vector3(2f, 0.5f, 2f);
            constructModel.transform.localPosition = new Vector3(0, 0.25f, 0);
            
            // Create work position
            GameObject workPos = new GameObject("WorkPosition");
            workPos.transform.SetParent(building.transform);
            workPos.transform.localPosition = new Vector3(2f, 0, 0);
            
            // Save prefab
            string prefabPath = $"Assets/_Project/Prefabs/Buildings/{config.name}.prefab";
            PrefabUtility.SaveAsPrefabAsset(building, prefabPath);
            DestroyImmediate(building);
            
            Debug.Log($"{config.name} prefab created at: {prefabPath}");
        }
    }

    [MenuItem("SpaceColony/Prefabs/Generate Colonist")]
    public static void GenerateColonistPrefab()
    {
        GameObject colonist = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        colonist.name = "Colonist";
        colonist.tag = "Colonist";
        colonist.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);

        // Add components
        NavMeshAgent agent = colonist.AddComponent<NavMeshAgent>();
        agent.speed = 3f;
        agent.radius = 0.35f;
        agent.height = 1.4f;
        
        colonist.AddComponent<Colonist>();
        
        // Make them visually distinct
        Renderer renderer = colonist.GetComponent<Renderer>();
        renderer.material.color = new Color(0.5f, 0.8f, 1f);

        // Save prefab
        string prefabPath = "Assets/_Project/Prefabs/Colonist.prefab";
        PrefabUtility.SaveAsPrefabAsset(colonist, prefabPath);
        DestroyImmediate(colonist);
        
        Debug.Log($"Colonist prefab created at: {prefabPath}");
    }

    [MenuItem("SpaceColony/Prefabs/Generate Loot Pickup")]
    public static void GenerateLootPickupPrefab()
    {
        GameObject loot = new GameObject("LootPickup");
        loot.tag = "Resource";
        loot.layer = LayerMask.NameToLayer("Default");

        // Add components
        loot.AddComponent<NetworkIdentity>();
        loot.AddComponent<NetworkTransform>();
        
        SphereCollider collider = loot.AddComponent<SphereCollider>();
        collider.isTrigger = true;
        collider.radius = 2f;
        
        Rigidbody rb = loot.AddComponent<Rigidbody>();
        rb.mass = 0.5f;
        rb.drag = 2f;
        
        loot.AddComponent<LootPickup>();
        
        // Create visual
        GameObject visual = GameObject.CreatePrimitive(PrimitiveType.Cube);
        visual.name = "Visual";
        visual.transform.SetParent(loot.transform);
        visual.transform.localScale = Vector3.one * 0.5f;
        
        // Make it glow
        Renderer renderer = visual.GetComponent<Renderer>();
        renderer.material.color = Color.yellow;
        renderer.material.EnableKeyword("_EMISSION");
        renderer.material.SetColor("_EmissionColor", Color.yellow * 0.5f);

        // Save prefab
        string prefabPath = "Assets/_Project/Prefabs/LootPickup.prefab";
        PrefabUtility.SaveAsPrefabAsset(loot, prefabPath);
        DestroyImmediate(loot);
        
        Debug.Log($"LootPickup prefab created at: {prefabPath}");
    }
}
#endif