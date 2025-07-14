using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using SpaceColonyRPG.Colony;

namespace SpaceColonyRPG.Editor
{
    public class ColonySceneSetup : EditorWindow
    {
        [MenuItem("Tools/Colony/Setup Colony Scene")]
        static void Init()
        {
            ColonySceneSetup window = (ColonySceneSetup)EditorWindow.GetWindow(typeof(ColonySceneSetup));
            window.titleContent = new GUIContent("Colony Scene Setup");
            window.Show();
        }

        void OnGUI()
        {
            GUILayout.Label("Colony Scene Setup", EditorStyles.boldLabel);

            if (GUILayout.Button("Create Complete Colony Scene"))
            {
                CreateColonyScene();
            }

            GUILayout.Space(10);

            GUILayout.Label("Individual Components:", EditorStyles.boldLabel);

            if (GUILayout.Button("Create Managers"))
            {
                CreateManagers();
            }

            if (GUILayout.Button("Create Environment"))
            {
                CreateEnvironment();
            }

            if (GUILayout.Button("Create UI"))
            {
                CreateUI();
            }
        }

        void CreateColonyScene()
        {
            CreateManagers();
            CreateEnvironment();
            CreateUI();

            Debug.Log("Colony Scene setup complete!");
        }

        void CreateManagers()
        {
            // Create Managers parent
            GameObject managers = new GameObject("_Managers");

            // Colony Manager
            GameObject colonyManager = new GameObject("ColonyManager");
            colonyManager.transform.SetParent(managers.transform);
            var cm = colonyManager.AddComponent<ColonyManager>();

            // Grid System
            GameObject gridSystem = new GameObject("GridSystem");
            gridSystem.transform.SetParent(managers.transform);
            var gs = gridSystem.AddComponent<GridSystem>();
            cm.gridSystem = gs;

            // Building System
            GameObject buildingSystem = new GameObject("BuildingSystem");
            buildingSystem.transform.SetParent(managers.transform);
            var bs = buildingSystem.AddComponent<BuildingSystem>();
            cm.buildingSystem = bs;

            // Resource Manager
            GameObject resourceManager = new GameObject("ResourceManager");
            resourceManager.transform.SetParent(managers.transform);
            var rm = resourceManager.AddComponent<ResourceManager>();
            cm.resourceManager = rm;

            // Colonist Manager
            GameObject colonistManager = new GameObject("ColonistManager");
            colonistManager.transform.SetParent(managers.transform);
            var clm = colonistManager.AddComponent<ColonistManager>();
            cm.colonistManager = clm;

            // Create colonist container
            GameObject colonistContainer = new GameObject("Colonists");
            colonistContainer.transform.SetParent(GameObject.Find("_Dynamic") ? GameObject.Find("_Dynamic").transform : managers.transform);
            clm.colonistContainer = colonistContainer.transform;
        }

        void CreateEnvironment()
        {
            // Create Environment parent
            GameObject environment = new GameObject("_Environment");

            // Create Terrain
            GameObject terrain = GameObject.CreatePrimitive(PrimitiveType.Plane);
            terrain.name = "Terrain";
            terrain.transform.SetParent(environment.transform);
            terrain.transform.localScale = new Vector3(10, 1, 10); // 100x100 units
            terrain.layer = LayerMask.NameToLayer("Default");

            // Create Directional Light
            GameObject lightParent = new GameObject("Lighting");
            lightParent.transform.SetParent(environment.transform);

            GameObject sunLight = new GameObject("Sun");
            sunLight.transform.SetParent(lightParent.transform);
            Light light = sunLight.AddComponent<Light>();
            light.type = LightType.Directional;
            light.color = new Color(0.7f, 0.85f, 1f); // Pale blue
            light.intensity = 1.2f;
            sunLight.transform.rotation = Quaternion.Euler(35, -30, 0);

            // Create Dynamic parent
            GameObject dynamic = new GameObject("_Dynamic");
            GameObject buildings = new GameObject("Buildings");
            buildings.transform.SetParent(dynamic.transform);
            GameObject colonists = new GameObject("Colonists");
            colonists.transform.SetParent(dynamic.transform);
            GameObject effects = new GameObject("Effects");
            effects.transform.SetParent(dynamic.transform);

            // Create Camera
            GameObject cameraParent = new GameObject("_Camera");
            GameObject mainCamera = new GameObject("Main Camera");
            mainCamera.transform.SetParent(cameraParent.transform);
            Camera cam = mainCamera.AddComponent<Camera>();
            mainCamera.AddComponent<AudioListener>();
            RTSCameraController rtsController = mainCamera.AddComponent<RTSCameraController>();
            mainCamera.transform.position = new Vector3(0, 30, -20);
            mainCamera.transform.rotation = Quaternion.Euler(45, 0, 0);
            mainCamera.tag = "MainCamera";
        }

        void CreateUI()
        {
            // Create UI parent
            GameObject uiParent = new GameObject("_UI");

            // Create Canvas
            GameObject canvasObj = new GameObject("Canvas");
            canvasObj.transform.SetParent(uiParent.transform);
            Canvas canvas = canvasObj.AddComponent<Canvas>();
            canvas.renderMode = RenderMode.ScreenSpaceOverlay;
            canvasObj.AddComponent<CanvasScaler>();
            canvasObj.AddComponent<GraphicRaycaster>();

            // Create EventSystem
            GameObject eventSystem = new GameObject("EventSystem");
            eventSystem.transform.SetParent(uiParent.transform);
            eventSystem.AddComponent<UnityEngine.EventSystems.EventSystem>();
            eventSystem.AddComponent<UnityEngine.EventSystems.StandaloneInputModule>();

            // Add Colony UI Manager
            ColonyUIManager uiManager = canvasObj.AddComponent<ColonyUIManager>();

            // Create basic UI structure
            CreateResourcePanel(canvasObj.transform, uiManager);
            CreateBuildingPanel(canvasObj.transform, uiManager);
            CreateStatusPanel(canvasObj.transform, uiManager);

            // Link UI Manager to Colony Manager
            ColonyManager colonyManager = FindObjectOfType<ColonyManager>();
            if (colonyManager)
            {
                colonyManager.uiManager = uiManager;
            }
        }

        void CreateResourcePanel(Transform parent, ColonyUIManager uiManager)
        {
            GameObject panel = new GameObject("ResourcePanel");
            panel.transform.SetParent(parent);
            RectTransform rect = panel.AddComponent<RectTransform>();
            rect.anchorMin = new Vector2(0, 1);
            rect.anchorMax = new Vector2(1, 1);
            rect.pivot = new Vector2(0.5f, 1);
            rect.anchoredPosition = new Vector2(0, -10);
            rect.sizeDelta = new Vector2(0, 60);

            Image bg = panel.AddComponent<Image>();
            bg.color = new Color(0, 0, 0, 0.8f);

            HorizontalLayoutGroup layout = panel.AddComponent<HorizontalLayoutGroup>();
            layout.padding = new RectOffset(10, 10, 5, 5);
            layout.spacing = 20;

            uiManager.resourceContainer = panel.transform;
        }

        void CreateBuildingPanel(Transform parent, ColonyUIManager uiManager)
        {
            GameObject panel = new GameObject("BuildingPanel");
            panel.transform.SetParent(parent);
            RectTransform rect = panel.AddComponent<RectTransform>();
            rect.anchorMin = new Vector2(0, 0);
            rect.anchorMax = new Vector2(0, 1);
            rect.pivot = new Vector2(0, 0.5f);
            rect.anchoredPosition = new Vector2(10, 0);
            rect.sizeDelta = new Vector2(200, -100);

            Image bg = panel.AddComponent<Image>();
            bg.color = new Color(0, 0, 0, 0.8f);

            VerticalLayoutGroup layout = panel.AddComponent<VerticalLayoutGroup>();
            layout.padding = new RectOffset(5, 5, 5, 5);
            layout.spacing = 5;

            // Category tabs
            GameObject tabs = new GameObject("CategoryTabs");
            tabs.transform.SetParent(panel.transform);
            RectTransform tabRect = tabs.AddComponent<RectTransform>();
            tabRect.sizeDelta = new Vector2(190, 40);
            HorizontalLayoutGroup tabLayout = tabs.AddComponent<HorizontalLayoutGroup>();
            tabLayout.spacing = 2;

            uiManager.buildingCategoryTabs = tabs.transform;

            // Building buttons container
            GameObject buttons = new GameObject("BuildingButtons");
            buttons.transform.SetParent(panel.transform);
            RectTransform buttonRect = buttons.AddComponent<RectTransform>();
            VerticalLayoutGroup buttonLayout = buttons.AddComponent<VerticalLayoutGroup>();
            buttonLayout.spacing = 2;

            uiManager.buildingButtonContainer = buttons.transform;
        }

        void CreateStatusPanel(Transform parent, ColonyUIManager uiManager)
        {
            GameObject panel = new GameObject("StatusPanel");
            panel.transform.SetParent(parent);
            RectTransform rect = panel.AddComponent<RectTransform>();
            rect.anchorMin = new Vector2(1, 1);
            rect.anchorMax = new Vector2(1, 1);
            rect.pivot = new Vector2(1, 1);
            rect.anchoredPosition = new Vector2(-10, -10);
            rect.sizeDelta = new Vector2(200, 100);

            Image bg = panel.AddComponent<Image>();
            bg.color = new Color(0, 0, 0, 0.8f);

            VerticalLayoutGroup layout = panel.AddComponent<VerticalLayoutGroup>();
            layout.padding = new RectOffset(10, 10, 10, 10);
            layout.spacing = 5;

            // Colony Level
            GameObject levelObj = new GameObject("ColonyLevel");
            levelObj.transform.SetParent(panel.transform);
            Text levelText = levelObj.AddComponent<Text>();
            levelText.text = "Colony Level: 1";
            levelText.color = Color.white;
            levelText.fontSize = 16;
            levelText.alignment = TextAnchor.MiddleLeft;
            uiManager.colonyLevelText = levelText;

            // Power Status
            GameObject powerObj = new GameObject("PowerStatus");
            powerObj.transform.SetParent(panel.transform);
            Text powerText = powerObj.AddComponent<Text>();
            powerText.text = "Power: 0/0";
            powerText.color = Color.green;
            powerText.fontSize = 14;
            powerText.alignment = TextAnchor.MiddleLeft;
            uiManager.powerStatusText = powerText;

            // Error message
            GameObject errorObj = new GameObject("ErrorMessage");
            errorObj.transform.SetParent(parent);
            RectTransform errorRect = errorObj.AddComponent<RectTransform>();
            errorRect.anchorMin = new Vector2(0.5f, 0.8f);
            errorRect.anchorMax = new Vector2(0.5f, 0.8f);
            errorRect.pivot = new Vector2(0.5f, 0.5f);
            errorRect.sizeDelta = new Vector2(400, 50);

            Image errorBg = errorObj.AddComponent<Image>();
            errorBg.color = new Color(0.8f, 0.2f, 0.2f, 0.9f);

            Text errorText = errorObj.AddComponent<Text>();
            errorText.text = "Error Message";
            errorText.color = Color.white;
            errorText.fontSize = 18;
            errorText.alignment = TextAnchor.MiddleCenter;
            uiManager.errorMessageText = errorText;

            errorObj.SetActive(false);
        }
    }
}
