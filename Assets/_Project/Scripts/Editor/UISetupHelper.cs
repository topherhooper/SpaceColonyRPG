using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;
using SpaceColonyRPG.Colony;

namespace SpaceColonyRPG.Editor
{
    public class UISetupHelper : EditorWindow
    {
        [MenuItem("Tools/Colony/Setup UI Prefabs")]
        public static void ShowWindow()
        {
            GetWindow<UISetupHelper>("UI Setup Helper");
        }

        void OnGUI()
        {
            GUILayout.Label("UI Prefab Setup", EditorStyles.boldLabel);

            EditorGUILayout.Space();

            if (GUILayout.Button("Create Resource Display Prefab", GUILayout.Height(30)))
            {
                CreateResourceDisplayPrefab();
            }

            if (GUILayout.Button("Create Building Button Prefab", GUILayout.Height(30)))
            {
                CreateBuildingButtonPrefab();
            }

            if (GUILayout.Button("Create Category Tab Prefab", GUILayout.Height(30)))
            {
                CreateCategoryTabPrefab();
            }

            EditorGUILayout.Space();
            EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);
            EditorGUILayout.Space();

            if (GUILayout.Button("Setup Complete Colony UI", GUILayout.Height(40)))
            {
                SetupCompleteUI();
            }

            EditorGUILayout.Space();

            EditorGUILayout.HelpBox(
                "This will create UI prefabs in Assets/_Project/Prefabs/UI/\n\n" +
                "Individual buttons create specific prefabs.\n" +
                "Complete UI setup creates a full Canvas hierarchy.",
                MessageType.Info);
        }

        void CreateResourceDisplayPrefab()
        {
            string path = "Assets/_Project/Prefabs/UI/";
            EnsureDirectoryExists(path);

            GameObject prefab = new GameObject("ResourceDisplay");
            RectTransform rect = prefab.AddComponent<RectTransform>();
            rect.sizeDelta = new Vector2(100, 60);

            // Background
            Image bg = prefab.AddComponent<Image>();
            bg.color = new Color(0.2f, 0.2f, 0.2f, 0.8f);

            // Icon
            GameObject icon = CreateChildUI(prefab, "Icon", new Vector2(-30, 0), new Vector2(30, 30));
            icon.AddComponent<Image>();

            // Name text
            GameObject nameObj = CreateChildUI(prefab, "Name", new Vector2(10, 10), new Vector2(60, 20));
            Text nameText = nameObj.AddComponent<Text>();
            nameText.text = "Resource";
            nameText.alignment = TextAnchor.MiddleCenter;
            nameText.fontSize = 14;
            nameText.font = Resources.GetBuiltinResource<Font>("Arial.ttf");

            // Amount text
            GameObject amountObj = CreateChildUI(prefab, "Amount", new Vector2(10, -10), new Vector2(60, 20));
            Text amountText = amountObj.AddComponent<Text>();
            amountText.text = "0/100";
            amountText.alignment = TextAnchor.MiddleCenter;
            amountText.fontSize = 16;
            amountText.fontStyle = FontStyle.Bold;
            amountText.font = Resources.GetBuiltinResource<Font>("Arial.ttf");

            // Add component references
            ResourceDisplay rd = prefab.AddComponent<ResourceDisplay>();
            rd.iconImage = icon.GetComponent<Image>();
            rd.nameText = nameText;
            rd.amountText = amountText;
            rd.backgroundImage = bg;

            // Save prefab
            string prefabPath = path + "ResourceDisplay.prefab";
            SavePrefab(prefab, prefabPath);
        }

        void CreateBuildingButtonPrefab()
        {
            string path = "Assets/_Project/Prefabs/UI/";
            EnsureDirectoryExists(path);

            GameObject prefab = new GameObject("BuildingButton");
            RectTransform rect = prefab.AddComponent<RectTransform>();
            rect.sizeDelta = new Vector2(200, 60);

            // Button component
            Button btn = prefab.AddComponent<Button>();
            Image btnImg = prefab.AddComponent<Image>();
            btnImg.color = new Color(0.3f, 0.3f, 0.3f, 0.9f);
            btn.targetGraphic = btnImg;

            // Setup button colors
            ColorBlock colors = btn.colors;
            colors.normalColor = Color.white;
            colors.highlightedColor = new Color(0.8f, 0.8f, 0.8f);
            colors.pressedColor = new Color(0.6f, 0.6f, 0.6f);
            colors.disabledColor = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            btn.colors = colors;

            // Icon
            GameObject icon = CreateChildUI(prefab, "Icon", new Vector2(-70, 0), new Vector2(40, 40));
            Image iconImg = icon.AddComponent<Image>();
            iconImg.color = Color.white;

            // Name
            GameObject nameObj = CreateChildUI(prefab, "Name", new Vector2(20, 10), new Vector2(120, 25));
            Text nameText = nameObj.AddComponent<Text>();
            nameText.text = "Building Name";
            nameText.alignment = TextAnchor.MiddleLeft;
            nameText.fontSize = 16;
            nameText.font = Resources.GetBuiltinResource<Font>("Arial.ttf");

            // Cost
            GameObject costObj = CreateChildUI(prefab, "Cost", new Vector2(20, -10), new Vector2(120, 20));
            Text costText = costObj.AddComponent<Text>();
            costText.text = "M:50 E:10";
            costText.alignment = TextAnchor.MiddleLeft;
            costText.fontSize = 12;
            costText.color = new Color(0.8f, 0.8f, 0.8f);
            costText.font = Resources.GetBuiltinResource<Font>("Arial.ttf");

            // Save prefab
            string prefabPath = path + "BuildingButton.prefab";
            SavePrefab(prefab, prefabPath);
        }

        void CreateCategoryTabPrefab()
        {
            string path = "Assets/_Project/Prefabs/UI/";
            EnsureDirectoryExists(path);

            GameObject prefab = new GameObject("CategoryTab");
            RectTransform rect = prefab.AddComponent<RectTransform>();
            rect.sizeDelta = new Vector2(120, 40);

            // Button
            Button btn = prefab.AddComponent<Button>();
            Image img = prefab.AddComponent<Image>();
            img.color = new Color(0.5f, 0.5f, 0.5f, 0.8f);
            btn.targetGraphic = img;

            // Text
            GameObject textObj = CreateChildUI(prefab, "Text", Vector2.zero, new Vector2(110, 30));
            Text text = textObj.AddComponent<Text>();
            text.text = "Category";
            text.alignment = TextAnchor.MiddleCenter;
            text.fontSize = 14;
            text.font = Resources.GetBuiltinResource<Font>("Arial.ttf");

            // Save prefab
            string prefabPath = path + "CategoryTab.prefab";
            SavePrefab(prefab, prefabPath);
        }

        void SetupCompleteUI()
        {
            // Create canvas if it doesn't exist
            GameObject canvasObj = GameObject.Find("Canvas");
            if (!canvasObj)
            {
                canvasObj = new GameObject("Canvas");
                Canvas canvas = canvasObj.AddComponent<Canvas>();
                canvas.renderMode = RenderMode.ScreenSpaceOverlay;
                canvasObj.AddComponent<CanvasScaler>();
                canvasObj.AddComponent<GraphicRaycaster>();

                // Event System
                if (!GameObject.Find("EventSystem"))
                {
                    GameObject eventSystem = new GameObject("EventSystem");
                    eventSystem.AddComponent<UnityEngine.EventSystems.EventSystem>();
                    eventSystem.AddComponent<UnityEngine.EventSystems.StandaloneInputModule>();
                }
            }

            // Create UI hierarchy
            CreateMainPanel(canvasObj);
            CreateBuildingPanel(canvasObj);
            CreateErrorPanel(canvasObj);

            Debug.Log("Complete UI setup finished!");
            EditorUtility.DisplayDialog("Success",
                "UI hierarchy created!\n\n" +
                "Next steps:\n" +
                "1. Assign prefabs to ColonyUIManager slots\n" +
                "2. Configure button references\n" +
                "3. Test in play mode",
                "OK");
        }

        void CreateMainPanel(GameObject canvas)
        {
            GameObject mainPanel = CreateUIPanel(canvas, "MainPanel",
                new Vector2(0, 1), new Vector2(0, 1),
                new Vector2(0, -50), new Vector2(800, 100));

            // Resource bar
            GameObject resourceBar = CreateUIPanel(mainPanel, "ResourceBar",
                new Vector2(0, 0.5f), new Vector2(0, 0.5f),
                new Vector2(10, 0), new Vector2(600, 60));

            // Layout group for resources
            HorizontalLayoutGroup hlg = resourceBar.AddComponent<HorizontalLayoutGroup>();
            hlg.spacing = 10;
            hlg.padding = new RectOffset(10, 10, 10, 10);
            hlg.childAlignment = TextAnchor.MiddleLeft;

            // Build menu button
            GameObject buildBtn = CreateUIButton(mainPanel, "OpenBuildMenuButton",
                new Vector2(1, 0.5f), new Vector2(1, 0.5f),
                new Vector2(-100, 20), new Vector2(180, 40), "Build Menu");

            // Raid button
            GameObject raidBtn = CreateUIButton(mainPanel, "PrepareRaidButton",
                new Vector2(1, 0.5f), new Vector2(1, 0.5f),
                new Vector2(-100, -20), new Vector2(180, 40), "Prepare Raid");
        }

        void CreateBuildingPanel(GameObject canvas)
        {
            GameObject buildPanel = CreateUIPanel(canvas, "BuildingPanel",
                new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f),
                Vector2.zero, new Vector2(800, 600));

            // Background
            Image bg = buildPanel.GetComponent<Image>();
            if (!bg) bg = buildPanel.AddComponent<Image>();
            bg.color = new Color(0.1f, 0.1f, 0.1f, 0.95f);

            // Title
            GameObject title = CreateUIText(buildPanel, "Title",
                new Vector2(0.5f, 1), new Vector2(0.5f, 1),
                new Vector2(0, -30), new Vector2(300, 40), "Building Menu");
            Text titleText = title.GetComponent<Text>();
            titleText.fontSize = 24;
            titleText.fontStyle = FontStyle.Bold;

            // Category tabs
            GameObject tabs = CreateUIPanel(buildPanel, "CategoryTabs",
                new Vector2(0.5f, 1), new Vector2(0.5f, 1),
                new Vector2(0, -80), new Vector2(700, 50));
            HorizontalLayoutGroup tabLayout = tabs.AddComponent<HorizontalLayoutGroup>();
            tabLayout.spacing = 5;
            tabLayout.childAlignment = TextAnchor.MiddleCenter;

            // Building grid
            GameObject grid = CreateUIPanel(buildPanel, "BuildingGrid",
                new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f),
                new Vector2(0, -20), new Vector2(700, 400));
            GridLayoutGroup gridLayout = grid.AddComponent<GridLayoutGroup>();
            gridLayout.cellSize = new Vector2(200, 60);
            gridLayout.spacing = new Vector2(10, 10);
            gridLayout.padding = new RectOffset(10, 10, 10, 10);

            // Close button
            GameObject closeBtn = CreateUIButton(buildPanel, "CloseButton",
                new Vector2(1, 1), new Vector2(1, 1),
                new Vector2(-30, -30), new Vector2(50, 50), "X");
        }

        void CreateErrorPanel(GameObject canvas)
        {
            GameObject errorPanel = CreateUIPanel(canvas, "ErrorMessagePanel",
                new Vector2(0.5f, 1), new Vector2(0.5f, 1),
                new Vector2(0, -100), new Vector2(400, 80));

            Image bg = errorPanel.GetComponent<Image>();
            if (!bg) bg = errorPanel.AddComponent<Image>();
            bg.color = new Color(0.8f, 0.2f, 0.2f, 0.9f);

            GameObject errorText = CreateUIText(errorPanel, "ErrorText",
                new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f),
                Vector2.zero, new Vector2(380, 60), "Error Message");
            Text text = errorText.GetComponent<Text>();
            text.fontSize = 16;
            text.alignment = TextAnchor.MiddleCenter;

            // Start hidden
            errorPanel.SetActive(false);
        }

        // Helper methods
        GameObject CreateChildUI(GameObject parent, string name, Vector2 position, Vector2 size)
        {
            GameObject child = new GameObject(name);
            child.transform.SetParent(parent.transform);
            RectTransform rect = child.AddComponent<RectTransform>();
            rect.anchoredPosition = position;
            rect.sizeDelta = size;
            rect.anchorMin = new Vector2(0.5f, 0.5f);
            rect.anchorMax = new Vector2(0.5f, 0.5f);
            rect.pivot = new Vector2(0.5f, 0.5f);
            return child;
        }

        GameObject CreateUIPanel(GameObject parent, string name, Vector2 anchorMin, Vector2 anchorMax,
                               Vector2 position, Vector2 size)
        {
            GameObject panel = new GameObject(name);
            panel.transform.SetParent(parent.transform);
            RectTransform rect = panel.AddComponent<RectTransform>();
            rect.anchorMin = anchorMin;
            rect.anchorMax = anchorMax;
            rect.anchoredPosition = position;
            rect.sizeDelta = size;
            return panel;
        }

        GameObject CreateUIButton(GameObject parent, string name, Vector2 anchorMin, Vector2 anchorMax,
                                Vector2 position, Vector2 size, string text)
        {
            GameObject buttonObj = CreateUIPanel(parent, name, anchorMin, anchorMax, position, size);
            Button btn = buttonObj.AddComponent<Button>();
            Image img = buttonObj.AddComponent<Image>();
            img.color = new Color(0.2f, 0.5f, 0.8f);
            btn.targetGraphic = img;

            GameObject textObj = CreateUIText(buttonObj, "Text",
                new Vector2(0, 0), new Vector2(1, 1),
                Vector2.zero, Vector2.zero, text);

            return buttonObj;
        }

        GameObject CreateUIText(GameObject parent, string name, Vector2 anchorMin, Vector2 anchorMax,
                               Vector2 position, Vector2 size, string text)
        {
            GameObject textObj = CreateUIPanel(parent, name, anchorMin, anchorMax, position, size);
            Text textComp = textObj.AddComponent<Text>();
            textComp.text = text;
            textComp.alignment = TextAnchor.MiddleCenter;
            textComp.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
            textComp.color = Color.white;
            return textObj;
        }

        void EnsureDirectoryExists(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                AssetDatabase.Refresh();
            }
        }

        void SavePrefab(GameObject obj, string path)
        {
            // Delete existing if it exists
            if (File.Exists(path))
            {
                AssetDatabase.DeleteAsset(path);
            }

            PrefabUtility.SaveAsPrefabAsset(obj, path);
            DestroyImmediate(obj);

            Debug.Log($"Created prefab: {path}");
        }
    }
}
