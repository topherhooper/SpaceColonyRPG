#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEngine.UI;
using Mirror;

public class SceneGenerator : EditorWindow
{
    [MenuItem("SpaceColony/Generate All Scenes")]
    public static void GenerateAllScenes()
    {
        GenerateMainMenuScene();
        GenerateColonyScene();
        GenerateRaidScene();
        
        // Add scenes to build settings
        AddScenesToBuildSettings();
        
        Debug.Log("All scenes generated successfully!");
    }

    [MenuItem("SpaceColony/Scenes/Generate Main Menu")]
    public static void GenerateMainMenuScene()
    {
        Scene scene = EditorSceneManager.NewScene(NewSceneSetup.DefaultGameObjects, NewSceneMode.Single);
        
        // Create managers
        GameObject managers = new GameObject("GameManagers");
        managers.AddComponent<GameStateManager>();
        managers.AddComponent<ResourceManager>();
        managers.AddComponent<ColonyUpgrades>();
        managers.AddComponent<AudioManager>();
        
        // Create UI
        GameObject canvas = CreateCanvas();
        UIManager uiManager = canvas.AddComponent<UIManager>();
        
        // Create main menu panel
        GameObject menuPanel = CreatePanel(canvas.transform, "MainMenuPanel");
        
        // Title
        CreateText(menuPanel.transform, "Title", "SPACE COLONY RPG", 48, 
            new Vector2(0, 100), new Vector2(400, 60));
        
        // New Game Button
        GameObject newGameBtn = CreateButton(menuPanel.transform, "NewGameButton", "New Game",
            new Vector2(0, 0), new Vector2(200, 50));
        newGameBtn.GetComponent<Button>().onClick.AddListener(() => {
            if (UIManager.Instance) UIManager.Instance.OnStartNewGameClicked();
        });
        
        // Continue Button
        GameObject continueBtn = CreateButton(menuPanel.transform, "ContinueButton", "Continue",
            new Vector2(0, -60), new Vector2(200, 50));
        continueBtn.GetComponent<Button>().onClick.AddListener(() => {
            if (UIManager.Instance) UIManager.Instance.OnContinueGameClicked();
        });
        
        // Quit Button
        GameObject quitBtn = CreateButton(menuPanel.transform, "QuitButton", "Quit",
            new Vector2(0, -120), new Vector2(200, 50));
        quitBtn.GetComponent<Button>().onClick.AddListener(() => {
            Application.Quit();
        });
        
        // Assign references
        uiManager.mainMenuPanel = menuPanel;
        
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
        
        // Setup camera for top-down view
        Camera.main.transform.position = new Vector3(0, 10, -10);
        Camera.main.transform.rotation = Quaternion.Euler(45, 0, 0);
        
        // Create ground
        GameObject ground = GameObject.CreatePrimitive(PrimitiveType.Plane);
        ground.name = "Ground";
        ground.transform.localScale = new Vector3(10, 1, 10);
        ground.layer = LayerMask.NameToLayer("Ground");
        
        // Add material if exists
        Material groundMat = AssetDatabase.LoadAssetAtPath<Material>("Assets/_Project/Materials/Ground_Mat.mat");
        if (groundMat != null)
        {
            ground.GetComponent<Renderer>().material = groundMat;
        }
        
        // Create managers
        GameObject buildingSystemObj = new GameObject("BuildingSystem");
        BuildingSystem buildingSystem = buildingSystemObj.AddComponent<BuildingSystem>();
        
        // Create network manager
        GameObject networkManager = new GameObject("GameNetworkManager");
        GameNetworkManager netManager = networkManager.AddComponent<GameNetworkManager>();
        
        // Create UI
        GameObject canvas = CreateCanvas();
        UIManager uiManager = canvas.AddComponent<UIManager>();
        
        // Create Colony HUD
        GameObject colonyHUD = CreatePanel(canvas.transform, "ColonyHUD");
        colonyHUD.GetComponent<RectTransform>().anchorMin = Vector2.zero;
        colonyHUD.GetComponent<RectTransform>().anchorMax = Vector2.one;
        
        // Resource Panel
        GameObject resourcePanel = CreatePanel(colonyHUD.transform, "ResourcePanel");
        resourcePanel.GetComponent<RectTransform>().anchorMin = new Vector2(0, 1);
        resourcePanel.GetComponent<RectTransform>().anchorMax = new Vector2(0, 1);
        resourcePanel.GetComponent<RectTransform>().pivot = new Vector2(0, 1);
        resourcePanel.GetComponent<RectTransform>().anchoredPosition = new Vector2(20, -20);
        resourcePanel.GetComponent<RectTransform>().sizeDelta = new Vector2(300, 100);
        
        // Create resource texts
        uiManager.metalText = CreateText(resourcePanel.transform, "MetalText", "Metal: 100", 16,
            new Vector2(0, 0), new Vector2(300, 30)).GetComponent<Text>();
        uiManager.energyText = CreateText(resourcePanel.transform, "EnergyText", "Energy: 50", 16,
            new Vector2(0, -30), new Vector2(300, 30)).GetComponent<Text>();
        uiManager.foodText = CreateText(resourcePanel.transform, "FoodText", "Food: 25", 16,
            new Vector2(0, -60), new Vector2(300, 30)).GetComponent<Text>();
        
        // Raid Button
        GameObject raidBtn = CreateButton(colonyHUD.transform, "RaidButton", "Start Raid",
            new Vector2(0, -50), new Vector2(150, 40));
        raidBtn.GetComponent<RectTransform>().anchorMin = new Vector2(1, 1);
        raidBtn.GetComponent<RectTransform>().anchorMax = new Vector2(1, 1);
        raidBtn.GetComponent<RectTransform>().pivot = new Vector2(1, 1);
        raidBtn.GetComponent<RectTransform>().anchoredPosition = new Vector2(-20, -20);
        
        // Create spawn points
        GameObject spawnPoints = new GameObject("SpawnPoints");
        for (int i = 0; i < 3; i++)
        {
            GameObject spawn = new GameObject($"ColonistSpawn{i + 1}");
            spawn.transform.parent = spawnPoints.transform;
            spawn.transform.position = new Vector3(i * 3 - 3, 0, -5);
        }
        
        uiManager.colonyHUD = colonyHUD;
        
        // Save scene
        string scenePath = "Assets/_Project/Scenes/ColonyScene.unity";
        CreateSceneDirectory();
        EditorSceneManager.SaveScene(scene, scenePath);
        Debug.Log($"ColonyScene created at: {scenePath}");
    }

    [MenuItem("SpaceColony/Scenes/Generate Raid Scene")]
    public static void GenerateRaidScene()
    {
        Scene scene = EditorSceneManager.NewScene(NewSceneSetup.DefaultGameObjects, NewSceneMode.Single);
        
        // Darker lighting for combat
        RenderSettings.ambientLight = new Color(0.2f, 0.2f, 0.3f);
        
        // Create arena ground
        GameObject ground = GameObject.CreatePrimitive(PrimitiveType.Plane);
        ground.name = "CombatArena";
        ground.transform.localScale = new Vector3(15, 1, 15);
        
        // Create managers
        GameObject networkManager = new GameObject("GameNetworkManager");
        GameNetworkManager netManager = networkManager.AddComponent<GameNetworkManager>();
        
        GameObject raidManagerObj = new GameObject("RaidManager");
        RaidManager raidManager = raidManagerObj.AddComponent<RaidManager>();
        
        // Create spawn points
        GameObject playerSpawns = new GameObject("NetworkStartPositions");
        for (int i = 0; i < 2; i++)
        {
            GameObject spawn = new GameObject($"SpawnPoint{i + 1}");
            spawn.transform.parent = playerSpawns.transform;
            spawn.transform.position = new Vector3(i * 4 - 2, 0, -5);
            spawn.AddComponent<NetworkStartPosition>();
        }
        
        // Create enemy spawn points
        GameObject enemySpawns = new GameObject("EnemySpawnPoints");
        raidManager.spawnPoints = new Transform[4];
        for (int i = 0; i < 4; i++)
        {
            GameObject spawn = new GameObject($"EnemySpawn{i + 1}");
            spawn.transform.parent = enemySpawns.transform;
            float angle = i * 90f * Mathf.Deg2Rad;
            spawn.transform.position = new Vector3(Mathf.Sin(angle) * 20f, 0, Mathf.Cos(angle) * 20f);
            raidManager.spawnPoints[i] = spawn.transform;
        }
        
        // Create UI
        GameObject canvas = CreateCanvas();
        UIManager uiManager = canvas.AddComponent<UIManager>();
        
        // Create Raid HUD
        GameObject raidHUD = CreatePanel(canvas.transform, "RaidHUD");
        raidHUD.GetComponent<RectTransform>().anchorMin = Vector2.zero;
        raidHUD.GetComponent<RectTransform>().anchorMax = Vector2.one;
        
        // Timer and enemies at top
        uiManager.timerText = CreateText(raidHUD.transform, "TimerText", "Time: 5:00", 24,
            new Vector2(0, -30), new Vector2(200, 40)).GetComponent<Text>();
        uiManager.timerText.GetComponent<RectTransform>().anchorMin = new Vector2(0.5f, 1);
        uiManager.timerText.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 1);
        
        uiManager.enemiesText = CreateText(raidHUD.transform, "EnemiesText", "Enemies: 0", 20,
            new Vector2(0, -70), new Vector2(200, 30)).GetComponent<Text>();
        uiManager.enemiesText.GetComponent<RectTransform>().anchorMin = new Vector2(0.5f, 1);
        uiManager.enemiesText.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 1);
        
        // Health bar at bottom
        GameObject healthContainer = new GameObject("HealthContainer");
        healthContainer.transform.SetParent(raidHUD.transform);
        RectTransform healthRect = healthContainer.AddComponent<RectTransform>();
        healthRect.anchorMin = new Vector2(0.5f, 0);
        healthRect.anchorMax = new Vector2(0.5f, 0);
        healthRect.anchoredPosition = new Vector2(0, 50);
        healthRect.sizeDelta = new Vector2(300, 30);
        
        uiManager.healthBar = CreateSlider(healthContainer.transform, "HealthBar",
            Vector2.zero, new Vector2(300, 30));
        uiManager.healthText = CreateText(healthContainer.transform, "HealthText", "100/100", 16,
            Vector2.zero, new Vector2(300, 30)).GetComponent<Text>();
        
        uiManager.raidHUD = raidHUD;
        
        // Save scene
        string scenePath = "Assets/_Project/Scenes/RaidScene.unity";
        CreateSceneDirectory();
        EditorSceneManager.SaveScene(scene, scenePath);
        Debug.Log($"RaidScene created at: {scenePath}");
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
        canvas.AddComponent<CanvasScaler>();
        canvas.AddComponent<GraphicRaycaster>();
        
        // Create EventSystem if missing
        if (GameObject.FindObjectOfType<UnityEngine.EventSystems.EventSystem>() == null)
        {
            GameObject eventSystem = new GameObject("EventSystem");
            eventSystem.AddComponent<UnityEngine.EventSystems.EventSystem>();
            eventSystem.AddComponent<UnityEngine.EventSystems.StandaloneInputModule>();
        }
        
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
        img.color = Color.white;
        
        Button btn = button.AddComponent<Button>();
        
        GameObject textObj = CreateText(button.transform, "Text", text, 16, Vector2.zero, size);
        
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
        txt.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
        
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