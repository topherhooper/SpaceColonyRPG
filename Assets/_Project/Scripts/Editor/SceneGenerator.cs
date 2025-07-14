#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEngine.UI;
using Mirror;
//using kcp2k; // Not needed for scene generation
using UnityEngine.EventSystems;
using SpaceColonyRPG.Colony;
//using UnityEngine.InputSystem.UI; // Optional dependency
//using UnityEngine.Rendering.Universal; // Optional dependency

public class SceneGenerator : EditorWindow
{
    [MenuItem("SpaceColony/Generate All Scenes")]
    public static void GenerateAllScenes()
    {
        // Check if scenes already exist
        bool mainMenuExists = File.Exists("Assets/_Project/Scenes/MainMenu.unity");
        bool colonyExists = File.Exists("Assets/_Project/Scenes/ColonyScene.unity");
        bool raidExists = File.Exists("Assets/_Project/Scenes/RaidScene.unity");

        if (mainMenuExists || colonyExists || raidExists)
        {
            if (!EditorUtility.DisplayDialog("Scene Generation Warning",
                "One or more scenes already exist. This will OVERWRITE them!\n\n" +
                "Existing scenes:\n" +
                (mainMenuExists ? "- MainMenu.unity\n" : "") +
                (colonyExists ? "- ColonyScene.unity\n" : "") +
                (raidExists ? "- RaidScene.unity\n" : "") +
                "\nAre you sure you want to regenerate ALL scenes?",
                "Yes, Regenerate", "Cancel"))
            {
                Debug.Log("Scene generation cancelled by user.");
                return;
            }
        }

        GenerateMainMenuScene();
        GenerateColonyScene();
        GenerateRaidScene();

        // Add scenes to build settings
        AddScenesToBuildSettings();

        Debug.Log("All scenes generated successfully!");
    }

    // Command-line version that generates only missing scenes
    public static void GenerateMissingScenesOnly()
    {
        bool generatedAny = false;

        if (!File.Exists("Assets/_Project/Scenes/MainMenu.unity"))
        {
            Debug.Log("MainMenu.unity not found. Generating...");
            GenerateMainMenuScene();
            generatedAny = true;
        }

        if (!File.Exists("Assets/_Project/Scenes/ColonyScene.unity"))
        {
            Debug.Log("ColonyScene.unity not found. Generating...");
            GenerateColonyScene();
            generatedAny = true;
        }

        if (!File.Exists("Assets/_Project/Scenes/RaidScene.unity"))
        {
            Debug.Log("RaidScene.unity not found. Generating...");
            GenerateRaidScene();
            generatedAny = true;
        }

        if (generatedAny)
        {
            AddScenesToBuildSettings();
            Debug.Log("Missing scenes generated successfully!");
        }
        else
        {
            Debug.Log("All scenes already exist. No generation needed.");
        }
    }

    [MenuItem("SpaceColony/Scenes/Generate Main Menu")]
    public static void GenerateMainMenuScene()
    {
        Scene scene = EditorSceneManager.NewScene(NewSceneSetup.DefaultGameObjects, NewSceneMode.Single);

        // Configure camera for menu
        Camera mainCamera = Camera.main;
        mainCamera.clearFlags = CameraClearFlags.SolidColor;
        mainCamera.backgroundColor = new Color(0f, 0.063f, 0.188f); // Dark space blue #001030

        // Create EventSystem first
        CreateEventSystem();

        // Create Canvas with proper settings
        GameObject canvasObj = new GameObject("Canvas");
        Canvas canvas = canvasObj.AddComponent<Canvas>();
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;

        CanvasScaler scaler = canvasObj.AddComponent<CanvasScaler>();
        scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        scaler.referenceResolution = new Vector2(1920, 1080);
        scaler.screenMatchMode = CanvasScaler.ScreenMatchMode.MatchWidthOrHeight;
        scaler.matchWidthOrHeight = 0.5f;

        canvasObj.AddComponent<GraphicRaycaster>();

        // Background Panel
        GameObject background = CreatePanel(canvasObj.transform, "Background");
        background.GetComponent<Image>().color = new Color(0.05f, 0.05f, 0.1f, 1f);

        // Title Panel
        GameObject titlePanel = CreatePanel(canvasObj.transform, "TitlePanel");
        RectTransform titleRect = titlePanel.GetComponent<RectTransform>();
        titleRect.anchorMin = new Vector2(0.5f, 0.7f);
        titleRect.anchorMax = new Vector2(0.5f, 0.9f);
        titleRect.sizeDelta = new Vector2(800, 200);
        titlePanel.GetComponent<Image>().color = Color.clear;

        // Game Title
        GameObject titleText = CreateText(titlePanel.transform, "GameTitle", "SPACE COLONY DEFENDER", 72,
            new Vector2(0, 30), new Vector2(800, 100));
        titleText.GetComponent<Text>().fontStyle = FontStyle.Bold;

        // Version Text
        GameObject versionText = CreateText(titlePanel.transform, "VersionText", "v0.1 Prototype", 24,
            new Vector2(0, -40), new Vector2(400, 40));
        versionText.GetComponent<Text>().color = new Color(0.7f, 0.7f, 0.7f);

        // Main Menu Panel
        GameObject menuPanel = CreatePanel(canvasObj.transform, "MainMenuPanel");
        RectTransform menuRect = menuPanel.GetComponent<RectTransform>();
        menuRect.anchorMin = new Vector2(0.5f, 0.2f);
        menuRect.anchorMax = new Vector2(0.5f, 0.65f);
        menuRect.sizeDelta = new Vector2(400, 400);
        menuPanel.GetComponent<Image>().color = new Color(0, 0, 0, 0.5f);

        // Create buttons with proper spacing
        CreateMenuButton(menuPanel.transform, "SoloColonyButton", "Solo Colony", new Vector2(0, 100), "StartSoloColony");
        CreateMenuButton(menuPanel.transform, "JoinRaidButton", "Join Raid", new Vector2(0, 40), "ShowJoinRaidPanel");
        CreateMenuButton(menuPanel.transform, "HostRaidButton", "Host Raid", new Vector2(0, -20), "HostRaid");
        CreateMenuButton(menuPanel.transform, "SettingsButton", "Settings", new Vector2(0, -80), "ShowSettingsPanel");
        CreateMenuButton(menuPanel.transform, "QuitButton", "Quit", new Vector2(0, -140), "QuitGame");

        // Join Raid Panel (Initially inactive)
        GameObject joinRaidPanel = CreatePanel(canvasObj.transform, "JoinRaidPanel");
        RectTransform joinRect = joinRaidPanel.GetComponent<RectTransform>();
        joinRect.anchorMin = new Vector2(0.5f, 0.3f);
        joinRect.anchorMax = new Vector2(0.5f, 0.7f);
        joinRect.sizeDelta = new Vector2(500, 300);
        joinRaidPanel.SetActive(false);

        // IP Input Field
        GameObject ipLabel = CreateText(joinRaidPanel.transform, "IPLabel", "Server IP:", 24,
            new Vector2(0, 50), new Vector2(400, 40));

        GameObject ipInputField = new GameObject("IPInputField");
        ipInputField.transform.SetParent(joinRaidPanel.transform);
        RectTransform ipRect = ipInputField.AddComponent<RectTransform>();
        ipRect.anchoredPosition = new Vector2(0, 0);
        ipRect.sizeDelta = new Vector2(400, 40);
        InputField ipInput = ipInputField.AddComponent<InputField>();
        Image ipBg = ipInputField.AddComponent<Image>();
        ipBg.color = new Color(0.2f, 0.2f, 0.2f);

        GameObject ipPlaceholder = CreateText(ipInputField.transform, "Placeholder", "Enter IP Address", 18,
            Vector2.zero, new Vector2(400, 40));
        ipPlaceholder.GetComponent<Text>().color = new Color(0.5f, 0.5f, 0.5f);

        GameObject ipText = CreateText(ipInputField.transform, "Text", "", 18, Vector2.zero, new Vector2(400, 40));
        ipInput.textComponent = ipText.GetComponent<Text>();
        ipInput.placeholder = ipPlaceholder.GetComponent<Text>();

        // Connect and Back buttons
        CreateMenuButton(joinRaidPanel.transform, "ConnectButton", "Connect", new Vector2(-100, -80), "ConnectToHost");
        CreateMenuButton(joinRaidPanel.transform, "BackButton", "Back", new Vector2(100, -80), "HideJoinRaidPanel");

        // Settings Panel (Initially inactive)
        GameObject settingsPanel = CreatePanel(canvasObj.transform, "SettingsPanel");
        RectTransform settingsRect = settingsPanel.GetComponent<RectTransform>();
        settingsRect.anchorMin = new Vector2(0.5f, 0.25f);
        settingsRect.anchorMax = new Vector2(0.5f, 0.75f);
        settingsRect.sizeDelta = new Vector2(600, 400);
        settingsPanel.SetActive(false);

        // Volume Slider
        GameObject volumeLabel = CreateText(settingsPanel.transform, "VolumeLabel", "Master Volume", 24,
            new Vector2(0, 100), new Vector2(400, 40));

        Slider volumeSlider = CreateSlider(settingsPanel.transform, "VolumeSlider",
            new Vector2(0, 60), new Vector2(400, 40));
        volumeSlider.value = 0.8f;

        // Graphics Quality Dropdown
        GameObject qualityLabel = CreateText(settingsPanel.transform, "QualityLabel", "Graphics Quality", 24,
            new Vector2(0, 0), new Vector2(400, 40));

        GameObject dropdownObj = new GameObject("QualityDropdown");
        dropdownObj.transform.SetParent(settingsPanel.transform);
        RectTransform dropRect = dropdownObj.AddComponent<RectTransform>();
        dropRect.anchoredPosition = new Vector2(0, -40);
        dropRect.sizeDelta = new Vector2(400, 40);
        Dropdown dropdown = dropdownObj.AddComponent<Dropdown>();
        Image dropBg = dropdownObj.AddComponent<Image>();
        dropBg.color = new Color(0.2f, 0.2f, 0.2f);

        // Back button for settings
        CreateMenuButton(settingsPanel.transform, "BackButton", "Back", new Vector2(0, -120), "HideSettingsPanel");

        // Network Manager
        GameObject networkManagerObj = new GameObject("NetworkManager");
        // Add Transport first (required by NetworkManager)
        // KcpTransport transport = networkManagerObj.AddComponent<KcpTransport>();
        GameNetworkManager networkManager = networkManagerObj.AddComponent<GameNetworkManager>();
        NetworkManager mirrorNetManager = networkManagerObj.GetComponent<NetworkManager>();
        // mirrorNetManager.transport = transport;
        mirrorNetManager.networkAddress = "localhost";
        mirrorNetManager.maxConnections = 6;

        // Audio Source for background music
        GameObject audioObj = new GameObject("AudioSource");
        AudioSource audioSource = audioObj.AddComponent<AudioSource>();
        audioSource.playOnAwake = true;
        audioSource.loop = true;
        audioSource.volume = 0.5f;

        // UI Manager
        UIManager uiManager = canvasObj.AddComponent<UIManager>();
        uiManager.mainMenuPanel = menuPanel;
        uiManager.joinRaidPanel = joinRaidPanel;
        uiManager.settingsPanel = settingsPanel;
        uiManager.ipInputField = ipInput;

        // Save scene
        string scenePath = "Assets/_Project/Scenes/MainMenu.unity";
        CreateSceneDirectory();
        EditorSceneManager.SaveScene(scene, scenePath);
        Debug.Log($"MainMenu scene created at: {scenePath}");
    }

    [MenuItem("SpaceColony/Scenes/Generate Colony Scene")]
    public static void GenerateColonyScene()
    {
        Scene scene = EditorSceneManager.NewScene(NewSceneSetup.DefaultGameObjects, NewSceneMode.Single);

        // Directional Light (Sun)
        GameObject lightObj = GameObject.Find("Directional Light");
        if (lightObj != null)
        {
            Light sun = lightObj.GetComponent<Light>();
            sun.transform.rotation = Quaternion.Euler(50f, -30f, 0f);
            sun.intensity = 1.2f;
            sun.color = new Color(1f, 0.972f, 0.906f); // Warm white #FFF8E7
        }

        // Setup camera for isometric view
        Camera mainCamera = Camera.main;
        mainCamera.transform.position = new Vector3(0, 20, -10);
        mainCamera.transform.rotation = Quaternion.Euler(45, 0, 0);
        mainCamera.fieldOfView = 60;

        // Create EventSystem for UI
        CreateEventSystem();

        // Colony Manager container
        GameObject colonyManager = new GameObject("Colony Manager");
        BuildingSystem buildingSystem = colonyManager.AddComponent<BuildingSystem>();
        ResourceManager resourceManager = colonyManager.AddComponent<ResourceManager>();

        // Environment container
        GameObject environment = new GameObject("Environment");

        // Create terrain (100x100 flat plane)
        GameObject terrain = GameObject.CreatePrimitive(PrimitiveType.Plane);
        terrain.name = "Terrain";
        terrain.transform.parent = environment.transform;
        terrain.transform.position = Vector3.zero;
        terrain.transform.localScale = new Vector3(10, 1, 10); // Unity plane is 10x10 by default
        terrain.layer = LayerMask.NameToLayer("Ground");

        // Apply material if exists
        Material groundMat = AssetDatabase.LoadAssetAtPath<Material>("Assets/_Project/Materials/Ground_Mat.mat");
        if (groundMat != null)
        {
            terrain.GetComponent<Renderer>().material = groundMat;
        }

        // Grid Visual (optional overlay)
        GameObject gridVisual = new GameObject("Grid Visual");
        gridVisual.transform.parent = environment.transform;
        // Grid would be implemented with line renderer or shader

        // Create UI
        GameObject canvas = CreateCanvas();
        UIManager uiManager = canvas.AddComponent<UIManager>();

        // Colony HUD
        GameObject colonyHUD = CreatePanel(canvas.transform, "Colony HUD");
        colonyHUD.GetComponent<Image>().color = Color.clear;

        // Resource Panel (Top)
        GameObject resourcePanel = CreatePanel(colonyHUD.transform, "Resource Panel");
        RectTransform resRect = resourcePanel.GetComponent<RectTransform>();
        resRect.anchorMin = new Vector2(0, 1);
        resRect.anchorMax = new Vector2(1, 1);
        resRect.pivot = new Vector2(0.5f, 1);
        resRect.anchoredPosition = new Vector2(0, 0);
        resRect.sizeDelta = new Vector2(0, 60);
        resourcePanel.GetComponent<Image>().color = new Color(0, 0, 0, 0.8f);

        // Resource displays
        float resourceSpacing = 200;
        uiManager.metalText = CreateText(resourcePanel.transform, "MetalDisplay", "Metal: 100", 20,
            new Vector2(-resourceSpacing, 0), new Vector2(180, 60)).GetComponent<Text>();
        uiManager.energyText = CreateText(resourcePanel.transform, "EnergyDisplay", "Energy: 50", 20,
            new Vector2(0, 0), new Vector2(180, 60)).GetComponent<Text>();
        uiManager.foodText = CreateText(resourcePanel.transform, "FoodDisplay", "Food: 25", 20,
            new Vector2(resourceSpacing, 0), new Vector2(180, 60)).GetComponent<Text>();

        // Building Panel (Bottom)
        GameObject buildingPanel = CreatePanel(colonyHUD.transform, "Building Panel");
        RectTransform buildRect = buildingPanel.GetComponent<RectTransform>();
        buildRect.anchorMin = new Vector2(0, 0);
        buildRect.anchorMax = new Vector2(1, 0);
        buildRect.pivot = new Vector2(0.5f, 0);
        buildRect.anchoredPosition = new Vector2(0, 0);
        buildRect.sizeDelta = new Vector2(0, 100);
        buildingPanel.GetComponent<Image>().color = new Color(0, 0, 0, 0.8f);

        // Building buttons
        float buttonSpacing = 90;
        CreateBuildingButton(buildingPanel.transform, "GeneratorButton", "Generator [1]",
            new Vector2(-buttonSpacing, 50), 0);
        CreateBuildingButton(buildingPanel.transform, "BarracksButton", "Barracks [2]",
            new Vector2(0, 50), 1);
        CreateBuildingButton(buildingPanel.transform, "StorageButton", "Storage [3]",
            new Vector2(buttonSpacing, 50), 2);

        // Colonist Info Panel
        GameObject colonistPanel = CreatePanel(colonyHUD.transform, "Colonist Info Panel");
        RectTransform colRect = colonistPanel.GetComponent<RectTransform>();
        colRect.anchorMin = new Vector2(0, 0.5f);
        colRect.anchorMax = new Vector2(0, 0.5f);
        colRect.pivot = new Vector2(0, 0.5f);
        colRect.anchoredPosition = new Vector2(20, 0);
        colRect.sizeDelta = new Vector2(250, 200);
        colonistPanel.GetComponent<Image>().color = new Color(0, 0, 0, 0.6f);

        // Raid Prep Button
        GameObject raidButton = CreateButton(colonyHUD.transform, "RaidPrepButton", "Prepare for Raid",
            new Vector2(0, 80), new Vector2(200, 50));
        RectTransform raidRect = raidButton.GetComponent<RectTransform>();
        raidRect.anchorMin = new Vector2(1, 0);
        raidRect.anchorMax = new Vector2(1, 0);
        raidRect.pivot = new Vector2(1, 0);
        raidRect.anchoredPosition = new Vector2(-20, 120);

        // Building Ghost (for placement preview)
        GameObject buildingGhost = new GameObject("Building Ghost");
        buildingGhost.transform.SetParent(canvas.transform);
        buildingGhost.SetActive(false);

        // Colonist Spawn Points
        GameObject spawnPoints = new GameObject("Colonist Spawn Points");
        for (int i = 0; i < 3; i++)
        {
            GameObject spawn = new GameObject($"Spawn Point {i + 1}");
            spawn.transform.parent = spawnPoints.transform;
            spawn.transform.position = new Vector3(-5 + i * 5, 0.5f, -10);
        }

        // Post Process Volume (optional for URP)
        GameObject postProcess = new GameObject("Post Process Volume");
        postProcess.layer = LayerMask.NameToLayer("PostProcessing");

        // Assign UI references
        uiManager.colonyHUD = colonyHUD;
        uiManager.buildingPanel = buildingPanel;

        // Save scene
        string scenePath = "Assets/_Project/Scenes/ColonyScene.unity";
        CreateSceneDirectory();
        EditorSceneManager.SaveScene(scene, scenePath);
        Debug.Log($"ColonyScene created at: {scenePath}");
    }

    [MenuItem("SpaceColony/Scenes/Generate Raid Scene")]
    public static void GenerateRaidScene()
    {
        // Check if scene already exists
        if (File.Exists("Assets/_Project/Scenes/RaidScene.unity"))
        {
            if (!EditorUtility.DisplayDialog("Scene Generation Warning",
                "RaidScene.unity already exists. This will OVERWRITE it!\n\n" +
                "Are you sure you want to regenerate the Raid scene?",
                "Yes, Regenerate", "Cancel"))
            {
                Debug.Log("Raid scene generation cancelled by user.");
                return;
            }
        }

        Scene scene = EditorSceneManager.NewScene(NewSceneSetup.DefaultGameObjects, NewSceneMode.Single);

        // Configure lighting for combat atmosphere
        RenderSettings.ambientLight = new Color(0.2f, 0.2f, 0.3f);
        GameObject lightObj = GameObject.Find("Directional Light");
        if (lightObj != null)
        {
            Light dirLight = lightObj.GetComponent<Light>();
            dirLight.transform.rotation = Quaternion.Euler(30f, 0f, 0f);
            dirLight.intensity = 0.8f;
        }

        // Network Manager
        GameObject networkManagerObj = new GameObject("Network Manager");
        // Add Transport first (required by NetworkManager)
        // KcpTransport transport = networkManagerObj.AddComponent<KcpTransport>();
        GameNetworkManager networkManager = networkManagerObj.AddComponent<GameNetworkManager>();
        NetworkManager mirrorNetManager = networkManagerObj.GetComponent<NetworkManager>();
        // mirrorNetManager.transport = transport;

        // Raid Manager
        GameObject raidManagerObj = new GameObject("Raid Manager");
        NetworkIdentity raidNetIdentity = raidManagerObj.AddComponent<NetworkIdentity>();
        RaidManager raidManager = raidManagerObj.AddComponent<RaidManager>();

        // Wave Spawner (child of Raid Manager)
        GameObject waveSpawner = new GameObject("Wave Spawner");
        waveSpawner.transform.parent = raidManagerObj.transform;

        // Objective Manager
        GameObject objectiveManager = new GameObject("Objective Manager");
        objectiveManager.transform.parent = raidManagerObj.transform;

        // Loot Manager
        GameObject lootManager = new GameObject("Loot Manager");
        lootManager.transform.parent = raidManagerObj.transform;

        // Environment
        GameObject environment = new GameObject("Environment");

        // Combat Arena
        GameObject combatArena = new GameObject("Combat Arena");
        combatArena.transform.parent = environment.transform;

        // Ground (200x200 plane)
        GameObject ground = GameObject.CreatePrimitive(PrimitiveType.Plane);
        ground.name = "Ground";
        ground.transform.parent = combatArena.transform;
        ground.transform.localScale = new Vector3(20, 1, 20); // 200x200 units
        ground.layer = LayerMask.NameToLayer("Ground");

        // Boundaries (Invisible walls)
        CreateBoundaryWall(combatArena.transform, "North Wall", new Vector3(0, 5, 100), new Vector3(200, 10, 1));
        CreateBoundaryWall(combatArena.transform, "South Wall", new Vector3(0, 5, -100), new Vector3(200, 10, 1));
        CreateBoundaryWall(combatArena.transform, "East Wall", new Vector3(100, 5, 0), new Vector3(1, 10, 200));
        CreateBoundaryWall(combatArena.transform, "West Wall", new Vector3(-100, 5, 0), new Vector3(1, 10, 200));

        // Cover Objects
        GameObject coverObjects = new GameObject("Cover Objects");
        coverObjects.transform.parent = combatArena.transform;

        // Create some basic cover
        for (int i = 0; i < 10; i++)
        {
            GameObject cover = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cover.name = $"Cover {i + 1}";
            cover.transform.parent = coverObjects.transform;
            cover.transform.position = new Vector3(
                Random.Range(-50f, 50f),
                1f,
                Random.Range(-50f, 50f)
            );
            cover.transform.localScale = new Vector3(
                Random.Range(2f, 5f),
                Random.Range(1.5f, 3f),
                Random.Range(2f, 5f)
            );
            cover.layer = LayerMask.NameToLayer("Environment");
        }

        // Enemy Spawn Points
        GameObject enemySpawnPoints = new GameObject("Enemy Spawn Points");
        enemySpawnPoints.transform.parent = environment.transform;

        string[] spawnNames = { "North Spawner", "East Spawner", "South Spawner", "West Spawner" };
        Vector3[] spawnPositions = {
            new Vector3(0, 0, 50),
            new Vector3(50, 0, 0),
            new Vector3(0, 0, -50),
            new Vector3(-50, 0, 0)
        };

        raidManager.spawnPoints = new Transform[4];
        for (int i = 0; i < 4; i++)
        {
            GameObject spawn = new GameObject(spawnNames[i]);
            spawn.transform.parent = enemySpawnPoints.transform;
            spawn.transform.position = spawnPositions[i];
            raidManager.spawnPoints[i] = spawn.transform;

            // Add visual indicator
            GameObject indicator = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            indicator.name = "Spawn Indicator";
            indicator.transform.parent = spawn.transform;
            indicator.transform.localScale = Vector3.one * 2;
            Renderer rend = indicator.GetComponent<Renderer>();
            if (rend != null)
            {
                rend.material.color = Color.red;
            }
        }

        // Player Spawn Area
        GameObject playerSpawnArea = new GameObject("Player Spawn Area");
        playerSpawnArea.transform.parent = environment.transform;

        // Create 6 player spawn points in circle formation
        for (int i = 0; i < 6; i++)
        {
            GameObject spawn = new GameObject($"Spawn Point {i + 1}");
            spawn.transform.parent = playerSpawnArea.transform;
            float angle = i * 60f * Mathf.Deg2Rad;
            spawn.transform.position = new Vector3(
                Mathf.Sin(angle) * 5f,
                1f,
                Mathf.Cos(angle) * 5f
            );
            spawn.AddComponent<NetworkStartPosition>();
        }

        // Create UI
        GameObject canvas = CreateCanvas();
        UIManager uiManager = canvas.AddComponent<UIManager>();

        // Raid HUD
        GameObject raidHUD = CreatePanel(canvas.transform, "Raid HUD");
        raidHUD.GetComponent<Image>().color = Color.clear;

        // Timer Display (Top Center)
        uiManager.timerText = CreateText(raidHUD.transform, "Timer Display", "05:00", 48,
            Vector2.zero, new Vector2(200, 60)).GetComponent<Text>();
        RectTransform timerRect = uiManager.timerText.GetComponent<RectTransform>();
        timerRect.anchorMin = new Vector2(0.5f, 1);
        timerRect.anchorMax = new Vector2(0.5f, 1);
        timerRect.pivot = new Vector2(0.5f, 1);
        timerRect.anchoredPosition = new Vector2(0, -20);
        uiManager.timerText.fontStyle = FontStyle.Bold;

        // Objective Panel (Top Left)
        GameObject objectivePanel = CreatePanel(raidHUD.transform, "Objective Panel");
        RectTransform objRect = objectivePanel.GetComponent<RectTransform>();
        objRect.anchorMin = new Vector2(0, 1);
        objRect.anchorMax = new Vector2(0, 1);
        objRect.pivot = new Vector2(0, 1);
        objRect.anchoredPosition = new Vector2(20, -20);
        objRect.sizeDelta = new Vector2(300, 100);
        objectivePanel.GetComponent<Image>().color = new Color(0, 0, 0, 0.6f);

        CreateText(objectivePanel.transform, "ObjectiveText", "Survive the waves!", 18,
            Vector2.zero, new Vector2(300, 100));

        // Enemy Counter (Top Right)
        uiManager.enemiesText = CreateText(raidHUD.transform, "Enemy Counter", "Enemies: 0/0", 24,
            Vector2.zero, new Vector2(200, 40)).GetComponent<Text>();
        RectTransform enemyRect = uiManager.enemiesText.GetComponent<RectTransform>();
        enemyRect.anchorMin = new Vector2(1, 1);
        enemyRect.anchorMax = new Vector2(1, 1);
        enemyRect.pivot = new Vector2(1, 1);
        enemyRect.anchoredPosition = new Vector2(-20, -20);

        // Player Health Bar (Bottom Left)
        GameObject healthContainer = new GameObject("Health Container");
        healthContainer.transform.SetParent(raidHUD.transform);
        RectTransform healthContRect = healthContainer.AddComponent<RectTransform>();
        healthContRect.anchorMin = new Vector2(0, 0);
        healthContRect.anchorMax = new Vector2(0, 0);
        healthContRect.pivot = new Vector2(0, 0);
        healthContRect.anchoredPosition = new Vector2(20, 20);
        healthContRect.sizeDelta = new Vector2(300, 60);

        uiManager.healthBar = CreateSlider(healthContainer.transform, "Player Health Bar",
            new Vector2(150, 15), new Vector2(300, 30));
        uiManager.healthBar.fillRect.GetComponent<Image>().color = Color.red;

        uiManager.healthText = CreateText(healthContainer.transform, "Health Text", "100 / 100", 18,
            new Vector2(150, 15), new Vector2(300, 30)).GetComponent<Text>();

        // Ammo Display (Bottom Right)
        GameObject ammoDisplay = CreateText(raidHUD.transform, "Ammo Display", "Ammo: ∞", 24,
            Vector2.zero, new Vector2(200, 40));
        RectTransform ammoRect = ammoDisplay.GetComponent<RectTransform>();
        ammoRect.anchorMin = new Vector2(1, 0);
        ammoRect.anchorMax = new Vector2(1, 0);
        ammoRect.pivot = new Vector2(1, 0);
        ammoRect.anchoredPosition = new Vector2(-20, 20);

        // Team Status Panel (Left Side)
        GameObject teamPanel = CreatePanel(raidHUD.transform, "Team Status Panel");
        RectTransform teamRect = teamPanel.GetComponent<RectTransform>();
        teamRect.anchorMin = new Vector2(0, 0.5f);
        teamRect.anchorMax = new Vector2(0, 0.5f);
        teamRect.pivot = new Vector2(0, 0.5f);
        teamRect.anchoredPosition = new Vector2(20, 0);
        teamRect.sizeDelta = new Vector2(250, 300);
        teamPanel.GetComponent<Image>().color = new Color(0, 0, 0, 0.6f);

        CreateText(teamPanel.transform, "TeamTitle", "Team Status", 20,
            new Vector2(125, 130), new Vector2(250, 40));

        // Victory/Defeat Panel (Initially inactive)
        GameObject resultPanel = CreatePanel(raidHUD.transform, "Victory Defeat Panel");
        RectTransform resultRect = resultPanel.GetComponent<RectTransform>();
        resultRect.anchorMin = new Vector2(0.5f, 0.5f);
        resultRect.anchorMax = new Vector2(0.5f, 0.5f);
        resultRect.sizeDelta = new Vector2(600, 400);
        resultPanel.SetActive(false);

        GameObject resultText = CreateText(resultPanel.transform, "ResultText", "VICTORY!", 72,
            new Vector2(0, 50), new Vector2(600, 100));
        resultText.GetComponent<Text>().fontStyle = FontStyle.Bold;

        CreateButton(resultPanel.transform, "ContinueButton", "Return to Colony",
            new Vector2(0, -100), new Vector2(250, 60));

        // Create EventSystem for UI (before creating UI)
        CreateEventSystem();

        // Audio Manager
        GameObject audioManager = new GameObject("Audio Manager");
        audioManager.AddComponent<AudioManager>();

        // Post Process Volume
        GameObject postProcess = new GameObject("Post Process Volume");
        postProcess.layer = LayerMask.NameToLayer("PostProcessing");

        // Assign UI references
        uiManager.raidHUD = raidHUD;
        uiManager.victoryDefeatPanel = resultPanel;

        // Save scene
        string scenePath = "Assets/_Project/Scenes/RaidScene.unity";
        CreateSceneDirectory();
        EditorSceneManager.SaveScene(scene, scenePath);
        Debug.Log($"RaidScene created at: {scenePath}");
    }

    private static void CreateBoundaryWall(Transform parent, string name, Vector3 position, Vector3 scale)
    {
        GameObject wall = GameObject.CreatePrimitive(PrimitiveType.Cube);
        wall.name = name;
        wall.transform.parent = parent;
        wall.transform.position = position;
        wall.transform.localScale = scale;
        wall.layer = LayerMask.NameToLayer("Environment");

        // Make invisible
        Renderer rend = wall.GetComponent<Renderer>();
        if (rend != null)
        {
            rend.enabled = false;
        }
    }

    private static GameObject CreateMenuButton(Transform parent, string name, string text, Vector2 position, string methodName)
    {
        GameObject button = CreateButton(parent, name, text, position, new Vector2(250, 50));
        button.GetComponent<Button>().onClick.AddListener(() => {
            Debug.Log($"[Button] {name} clicked, attempting to call {methodName}");

            if (UIManager.Instance == null)
            {
                Debug.LogError($"[Button] UIManager.Instance is null!");
                return;
            }

            System.Reflection.MethodInfo method = typeof(UIManager).GetMethod(methodName);
            if (method != null)
            {
                Debug.Log($"[Button] Found method {methodName}, invoking...");
                method.Invoke(UIManager.Instance, null);
            }
            else
            {
                Debug.LogError($"[Button] Method '{methodName}' not found on UIManager!");
            }
        });
        return button;
    }

    private static GameObject CreateBuildingButton(Transform parent, string name, string text, Vector2 position, int buildingIndex)
    {
        GameObject button = CreateButton(parent, name, text, position, new Vector2(80, 80));
        button.GetComponent<Button>().onClick.AddListener(() => {
            BuildingSystem buildingSystem = GameObject.FindFirstObjectByType<BuildingSystem>();
            if (buildingSystem != null)
            {
                // TODO: Update to pass BuildingData instead of index
                // buildingSystem.StartPlacement(buildingData);
            }
        });
        return button;
    }

    private static void CreateSceneDirectory()
    {
        string scenesPath = "Assets/_Project/Scenes";
        if (!Directory.Exists(scenesPath))
        {
            Directory.CreateDirectory(scenesPath);
            AssetDatabase.Refresh();
        }
    }

    private static GameObject CreateCanvas()
    {
        GameObject canvas = new GameObject("Canvas");
        Canvas c = canvas.AddComponent<Canvas>();
        c.renderMode = RenderMode.ScreenSpaceOverlay;

        CanvasScaler scaler = canvas.AddComponent<CanvasScaler>();
        scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        scaler.referenceResolution = new Vector2(1920, 1080);

        canvas.AddComponent<GraphicRaycaster>();

        return canvas;
    }

    private static GameObject CreatePanel(Transform parent, string name)
    {
        GameObject panel = new GameObject(name);
        panel.transform.SetParent(parent);

        RectTransform rect = panel.AddComponent<RectTransform>();
        rect.anchorMin = Vector2.zero;
        rect.anchorMax = Vector2.one;
        rect.offsetMin = Vector2.zero;
        rect.offsetMax = Vector2.zero;

        Image img = panel.AddComponent<Image>();
        img.color = new Color(0, 0, 0, 0.8f);

        return panel;
    }

    private static GameObject CreateButton(Transform parent, string name, string text,
        Vector2 position, Vector2 size)
    {
        GameObject button = new GameObject(name);
        button.transform.SetParent(parent);

        RectTransform rect = button.AddComponent<RectTransform>();
        rect.anchoredPosition = position;
        rect.sizeDelta = size;

        Image img = button.AddComponent<Image>();
        img.color = new Color(0.2f, 0.3f, 0.4f, 1f);  // Match normal color

        // Add outline for better visibility
        Outline outline = button.AddComponent<Outline>();
        outline.effectColor = new Color(0.1f, 0.15f, 0.2f, 1f);
        outline.effectDistance = new Vector2(2, -2);

        Button btn = button.AddComponent<Button>();

        // Enhanced color transitions for better visual feedback
        ColorBlock colors = btn.colors;
        colors.normalColor = new Color(0.2f, 0.3f, 0.4f, 1f);       // Dark blue
        colors.highlightedColor = new Color(0.3f, 0.5f, 0.7f, 1f);  // Lighter blue (hover)
        colors.pressedColor = new Color(0.1f, 0.2f, 0.3f, 1f);      // Darker blue (click)
        colors.selectedColor = new Color(0.3f, 0.5f, 0.7f, 1f);     // Same as highlighted
        colors.disabledColor = new Color(0.15f, 0.15f, 0.15f, 0.5f);// Grayed out
        colors.colorMultiplier = 1f;
        colors.fadeDuration = 0.1f;  // Quick transition
        btn.colors = colors;

        // Set transition mode to color tint
        btn.transition = Selectable.Transition.ColorTint;
        btn.targetGraphic = img;

        GameObject textObj = CreateText(button.transform, "Text", text, 20, Vector2.zero, size);

        // Make text more visible
        Text textComponent = textObj.GetComponent<Text>();
        if (textComponent != null)
        {
            textComponent.fontStyle = FontStyle.Bold;
            // Add shadow for better readability
            Shadow shadow = textObj.AddComponent<Shadow>();
            shadow.effectColor = new Color(0, 0, 0, 0.8f);
            shadow.effectDistance = new Vector2(1, -1);
        }

        return button;
    }

    private static GameObject CreateText(Transform parent, string name, string text, int fontSize,
        Vector2 position, Vector2 size)
    {
        GameObject textObj = new GameObject(name);
        textObj.transform.SetParent(parent);

        RectTransform rect = textObj.AddComponent<RectTransform>();
        rect.anchoredPosition = position;
        rect.sizeDelta = size;

        Text txt = textObj.AddComponent<Text>();
        txt.text = text;
        txt.fontSize = fontSize;
        txt.alignment = TextAnchor.MiddleCenter;
        txt.color = Color.white;
        txt.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");

        return textObj;
    }

    private static Slider CreateSlider(Transform parent, string name, Vector2 position, Vector2 size)
    {
        GameObject sliderObj = new GameObject(name);
        sliderObj.transform.SetParent(parent);

        RectTransform rect = sliderObj.AddComponent<RectTransform>();
        rect.anchoredPosition = position;
        rect.sizeDelta = size;

        Slider slider = sliderObj.AddComponent<Slider>();

        // Background
        GameObject bg = new GameObject("Background");
        bg.transform.SetParent(sliderObj.transform);
        RectTransform bgRect = bg.AddComponent<RectTransform>();
        bgRect.anchorMin = Vector2.zero;
        bgRect.anchorMax = Vector2.one;
        bgRect.sizeDelta = Vector2.zero;
        bgRect.offsetMin = Vector2.zero;
        bgRect.offsetMax = Vector2.zero;
        Image bgImg = bg.AddComponent<Image>();
        bgImg.color = new Color(0.2f, 0.2f, 0.2f);

        // Fill area
        GameObject fillArea = new GameObject("Fill Area");
        fillArea.transform.SetParent(sliderObj.transform);
        RectTransform fillRect = fillArea.AddComponent<RectTransform>();
        fillRect.anchorMin = Vector2.zero;
        fillRect.anchorMax = Vector2.one;
        fillRect.sizeDelta = Vector2.zero;
        fillRect.offsetMin = Vector2.zero;
        fillRect.offsetMax = Vector2.zero;

        // Fill
        GameObject fill = new GameObject("Fill");
        fill.transform.SetParent(fillArea.transform);
        RectTransform fRect = fill.AddComponent<RectTransform>();
        fRect.anchorMin = Vector2.zero;
        fRect.anchorMax = new Vector2(0, 1);
        fRect.sizeDelta = Vector2.zero;
        fRect.offsetMin = Vector2.zero;
        fRect.offsetMax = Vector2.zero;
        Image fillImg = fill.AddComponent<Image>();
        fillImg.color = Color.green;

        slider.fillRect = fRect;
        slider.targetGraphic = fillImg;

        return slider;
    }

    private static GameObject CreateEventSystem()
    {
        GameObject eventSystem = new GameObject("EventSystem");
        eventSystem.AddComponent<EventSystem>();
        // eventSystem.AddComponent<InputSystemUIInputModule>(); // Requires Input System package
        return eventSystem;
    }

    private static void AddScenesToBuildSettings()
    {
        EditorBuildSettingsScene[] scenes = new EditorBuildSettingsScene[]
        {
            new EditorBuildSettingsScene("Assets/_Project/Scenes/MainMenu.unity", true),
            new EditorBuildSettingsScene("Assets/_Project/Scenes/ColonyScene.unity", true),
            new EditorBuildSettingsScene("Assets/_Project/Scenes/RaidScene.unity", true)
        };

        EditorBuildSettings.scenes = scenes;
        Debug.Log("Scenes added to build settings");
    }
}
#endif
