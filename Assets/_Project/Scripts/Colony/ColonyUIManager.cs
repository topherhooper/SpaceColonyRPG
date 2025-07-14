using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;

namespace SpaceColonyRPG.Colony
{
    public class ColonyUIManager : MonoBehaviour
    {
        public static ColonyUIManager Instance { get; private set; }
        
        [Header("UI Panels")]
        public GameObject mainPanel;
        public GameObject buildingPanel;
        public GameObject raidPanel;
        
        [Header("Resource Display")]
        public Transform resourceContainer;
        public GameObject resourceDisplayPrefab;
        private Dictionary<ResourceType, ResourceDisplay> resourceDisplays;
        
        [Header("Building Menu")]
        public Transform buildingCategoryTabs;
        public Transform buildingButtonContainer;
        public GameObject categoryTabPrefab;
        public GameObject buildingButtonPrefab;
        
        [Header("Building Info")]
        public GameObject buildingInfoPanel;
        public Text buildingNameText;
        public Text buildingDescriptionText;
        public Text buildingCostText;
        public Button startPlacementButton;
        
        [Header("Messages")]
        public GameObject errorMessagePanel;
        public Text errorMessageText;
        public float errorMessageDuration = 2f;
        
        [Header("Colony Stats")]
        public Text colonyLevelText;
        public Text powerStatusText;
        public Slider powerBar;
        
        [Header("Main Buttons")]
        public Button openBuildMenuButton;
        public Button closeBuildMenuButton;
        public Button prepareRaidButton;
        
        private BuildingCategory currentCategory = BuildingCategory.Infrastructure;
        private Dictionary<BuildingCategory, List<BuildingData>> categorizedBuildings;
        
        void Awake()
        {
            // Singleton pattern with proper cleanup
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }
            Instance = this;
            
            resourceDisplays = new Dictionary<ResourceType, ResourceDisplay>();
            categorizedBuildings = new Dictionary<BuildingCategory, List<BuildingData>>();
        }
        
        void Start()
        {
            SetupUI();
            SetupButtonListeners();
            SetupResourceDisplay();
            SetupBuildingMenu();
            UpdateColonyStats();
            
            // Subscribe to events
            if (ResourceManager.Instance != null)
            {
                ResourceManager.OnResourceChanged += OnResourceChanged;
            }
        }
        
        void SetupUI()
        {
            // Ensure panels start in correct state
            SetPanelActive(buildingPanel, false);
            SetPanelActive(raidPanel, false);
            SetPanelActive(buildingInfoPanel, false);
            SetPanelActive(errorMessagePanel, false);
        }
        
        void SetPanelActive(GameObject panel, bool active)
        {
            if (panel != null) panel.SetActive(active);
        }
        
        void SetupButtonListeners()
        {
            // Main buttons
            SetupButton(openBuildMenuButton, OpenBuildingMenu);
            SetupButton(closeBuildMenuButton, CloseBuildingMenu);
            SetupButton(prepareRaidButton, PrepareForRaid);
            
            // Start placement button (without action yet)
            if (startPlacementButton != null)
            {
                startPlacementButton.onClick.RemoveAllListeners();
            }
        }
        
        void SetupButton(Button button, UnityEngine.Events.UnityAction action)
        {
            if (button != null)
            {
                button.onClick.RemoveAllListeners();
                button.onClick.AddListener(action);
            }
        }
        
        void SetupResourceDisplay()
        {
            if (!resourceContainer || !resourceDisplayPrefab || ResourceManager.Instance == null) 
            {
                Debug.LogWarning("Cannot setup resource display - missing references");
                return;
            }
            
            // Clear existing displays
            foreach (Transform child in resourceContainer)
            {
                Destroy(child.gameObject);
            }
            resourceDisplays.Clear();
            
            // Create displays for each resource
            foreach (var resource in ResourceManager.Instance.resources)
            {
                GameObject display = Instantiate(resourceDisplayPrefab, resourceContainer);
                ResourceDisplay rd = display.GetComponent<ResourceDisplay>();
                if (rd != null)
                {
                    rd.Setup(resource);
                    resourceDisplays[resource.type] = rd;
                }
                else
                {
                    Debug.LogWarning($"ResourceDisplay component missing on prefab for {resource.type}");
                }
            }
        }
        
        void SetupBuildingMenu()
        {
            if (!BuildingSystem.Instance || BuildingSystem.Instance.availableBuildings == null) 
            {
                Debug.LogWarning("BuildingSystem not ready");
                return;
            }
            
            categorizedBuildings.Clear();
            
            // Categorize buildings
            foreach (var building in BuildingSystem.Instance.availableBuildings)
            {
                if (building == null) continue;
                
                if (!categorizedBuildings.ContainsKey(building.category))
                {
                    categorizedBuildings[building.category] = new List<BuildingData>();
                }
                categorizedBuildings[building.category].Add(building);
            }
            
            // Create category tabs
            CreateCategoryTabs();
            
            // Show first category
            if (categorizedBuildings.Count > 0)
            {
                ShowBuildingCategory(categorizedBuildings.Keys.First());
            }
        }
        
        void CreateCategoryTabs()
        {
            if (!buildingCategoryTabs || !categoryTabPrefab) 
            {
                Debug.LogWarning("Cannot create category tabs - missing references");
                return;
            }
            
            // Clear existing tabs
            foreach (Transform child in buildingCategoryTabs)
            {
                Destroy(child.gameObject);
            }
            
            // Create tab for each category
            foreach (var category in categorizedBuildings.Keys)
            {
                GameObject tab = Instantiate(categoryTabPrefab, buildingCategoryTabs);
                
                // Setup tab text
                Text tabText = tab.GetComponentInChildren<Text>();
                if (tabText != null) 
                {
                    tabText.text = GetCategoryDisplayName(category);
                }
                
                // Setup tab button
                Button tabButton = tab.GetComponent<Button>();
                if (tabButton != null)
                {
                    BuildingCategory cat = category; // Capture for closure
                    tabButton.onClick.RemoveAllListeners();
                    tabButton.onClick.AddListener(() => ShowBuildingCategory(cat));
                }
            }
        }
        
        string GetCategoryDisplayName(BuildingCategory category)
        {
            switch (category)
            {
                case BuildingCategory.Infrastructure: return "Power & Housing";
                case BuildingCategory.Production: return "Production";
                case BuildingCategory.Military: return "Military";
                case BuildingCategory.Research: return "Research";
                case BuildingCategory.Defense: return "Defense";
                default: return category.ToString();
            }
        }
        
        public void ShowBuildingCategory(BuildingCategory category)
        {
            currentCategory = category;
            
            if (!buildingButtonContainer) 
            {
                Debug.LogWarning("Building button container not set");
                return;
            }
            
            // Clear existing buttons
            foreach (Transform child in buildingButtonContainer)
            {
                Destroy(child.gameObject);
            }
            
            // Create buttons for buildings in category
            if (categorizedBuildings.ContainsKey(category))
            {
                foreach (var building in categorizedBuildings[category])
                {
                    if (building != null)
                    {
                        CreateBuildingButton(building);
                    }
                }
            }
            
            // Update tab highlighting
            UpdateCategoryTabHighlight(category);
        }
        
        void UpdateCategoryTabHighlight(BuildingCategory selectedCategory)
        {
            if (!buildingCategoryTabs) return;
            
            int index = 0;
            foreach (var category in categorizedBuildings.Keys)
            {
                if (index < buildingCategoryTabs.childCount)
                {
                    Transform tab = buildingCategoryTabs.GetChild(index);
                    Image tabImage = tab.GetComponent<Image>();
                    if (tabImage != null)
                    {
                        tabImage.color = (category == selectedCategory) ? 
                            new Color(0.3f, 0.8f, 1f, 1f) : 
                            new Color(0.5f, 0.5f, 0.5f, 0.8f);
                    }
                }
                index++;
            }
        }
        
        void CreateBuildingButton(BuildingData building)
        {
            if (!buildingButtonPrefab || !buildingButtonContainer) 
            {
                Debug.LogWarning("Cannot create building button - missing references");
                return;
            }
            
            GameObject button = Instantiate(buildingButtonPrefab, buildingButtonContainer);
            
            // Setup visuals
            SetupButtonText(button, "Name", building.buildingName);
            SetupButtonIcon(button, "Icon", building.icon);
            SetupButtonCost(button, "Cost", building);
            
            // Button functionality
            Button btn = button.GetComponent<Button>();
            if (btn != null)
            {
                btn.onClick.RemoveAllListeners();
                btn.onClick.AddListener(() => OnBuildingButtonClicked(building));
            }
            
            // Update interactability
            UpdateBuildingButton(button, building);
        }
        
        void SetupButtonText(GameObject button, string childName, string text)
        {
            Transform child = button.transform.Find(childName);
            if (child != null)
            {
                Text textComp = child.GetComponent<Text>();
                if (textComp != null) textComp.text = text;
            }
        }
        
        void SetupButtonIcon(GameObject button, string childName, Sprite icon)
        {
            Transform child = button.transform.Find(childName);
            if (child != null && icon != null)
            {
                Image iconImage = child.GetComponent<Image>();
                if (iconImage != null) iconImage.sprite = icon;
            }
        }
        
        void SetupButtonCost(GameObject button, string childName, BuildingData building)
        {
            Transform child = button.transform.Find(childName);
            if (child != null)
            {
                Text costText = child.GetComponent<Text>();
                if (costText != null)
                {
                    string cost = "";
                    if (building.metalCost > 0) cost += $"M:{building.metalCost} ";
                    if (building.energyCost > 0) cost += $"E:{building.energyCost} ";
                    if (building.creditsCost > 0) cost += $"C:{building.creditsCost}";
                    costText.text = cost.Trim();
                }
            }
        }
        
        void OnBuildingButtonClicked(BuildingData building)
        {
            ShowBuildingInfo(building);
        }
        
        void ShowBuildingInfo(BuildingData building)
        {
            if (!buildingInfoPanel) 
            {
                Debug.LogWarning("Building info panel not set");
                return;
            }
            
            buildingInfoPanel.SetActive(true);
            
            // Set building info
            if (buildingNameText != null) buildingNameText.text = building.buildingName;
            if (buildingDescriptionText != null) buildingDescriptionText.text = building.description;
            
            // Cost breakdown
            if (buildingCostText != null)
            {
                string costInfo = "Cost:\n";
                if (building.metalCost > 0) costInfo += $"Metal: {building.metalCost}\n";
                if (building.energyCost > 0) costInfo += $"Energy: {building.energyCost}\n";
                if (building.creditsCost > 0) costInfo += $"Credits: {building.creditsCost}\n";
                if (building.researchCost > 0) costInfo += $"Research: {building.researchCost}\n";
                
                if (building.requiredColonyLevel > 1)
                    costInfo += $"\nRequires Colony Level {building.requiredColonyLevel}";
                    
                buildingCostText.text = costInfo;
            }
            
            // Setup placement button
            if (startPlacementButton != null)
            {
                startPlacementButton.onClick.RemoveAllListeners();
                startPlacementButton.onClick.AddListener(() => 
                {
                    if (BuildingSystem.Instance != null)
                    {
                        BuildingSystem.Instance.StartPlacement(building);
                        buildingInfoPanel.SetActive(false);
                    }
                });
                
                // Check if can afford
                bool canAfford = ResourceManager.Instance != null && 
                                ResourceManager.Instance.CanAfford(building.GetCosts());
                bool meetsRequirements = ColonyManager.Instance != null && 
                                       ColonyManager.Instance.colonyLevel >= building.requiredColonyLevel;
                startPlacementButton.interactable = canAfford && meetsRequirements;
            }
        }
        
        void UpdateBuildingButton(GameObject button, BuildingData building)
        {
            Button btn = button.GetComponent<Button>();
            if (btn == null) return;
            
            bool canAfford = ResourceManager.Instance != null && 
                           ResourceManager.Instance.CanAfford(building.GetCosts());
            bool meetsRequirements = ColonyManager.Instance != null && 
                                   ColonyManager.Instance.colonyLevel >= building.requiredColonyLevel;
            
            btn.interactable = canAfford && meetsRequirements;
            
            // Visual feedback
            Image buttonImage = button.GetComponent<Image>();
            if (buttonImage != null)
            {
                if (!meetsRequirements)
                {
                    buttonImage.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                }
                else if (!canAfford)
                {
                    buttonImage.color = new Color(1f, 0.5f, 0.5f, 0.8f);
                }
                else
                {
                    buttonImage.color = Color.white;
                }
            }
        }
        
        public void RefreshBuildingButtons()
        {
            ShowBuildingCategory(currentCategory);
        }
        
        void OnResourceChanged(ResourceType type, int amount)
        {
            // Update resource display
            if (resourceDisplays.ContainsKey(type))
            {
                resourceDisplays[type].UpdateDisplay(amount);
            }
            
            // Refresh building buttons
            RefreshBuildingButtons();
            
            // Update power status
            UpdateColonyStats();
        }
        
        public void ShowError(string message)
        {
            if (!errorMessagePanel || !errorMessageText) 
            {
                Debug.LogWarning($"Cannot show error: {message}");
                return;
            }
            
            errorMessageText.text = message;
            errorMessagePanel.SetActive(true);
            
            CancelInvoke(nameof(HideError));
            Invoke(nameof(HideError), errorMessageDuration);
        }
        
        void HideError()
        {
            SetPanelActive(errorMessagePanel, false);
        }
        
        public void UpdateColonyStats()
        {
            // Colony level
            if (colonyLevelText != null && ColonyManager.Instance != null)
            {
                colonyLevelText.text = $"Colony Level: {ColonyManager.Instance.colonyLevel}";
            }
            
            // Power status
            if (BuildingSystem.Instance != null)
            {
                int production = BuildingSystem.Instance.GetTotalEnergyProduction();
                int consumption = BuildingSystem.Instance.GetTotalEnergyConsumption();
                
                if (powerStatusText != null)
                {
                    powerStatusText.text = $"Power: {production}/{consumption}";
                    powerStatusText.color = (consumption > production) ? Color.red : Color.green;
                }
                
                if (powerBar != null)
                {
                    powerBar.maxValue = Mathf.Max(production, consumption, 1);
                    powerBar.value = production;
                }
            }
        }
        
        // Button Actions
        void OpenBuildingMenu()
        {
            SetPanelActive(buildingPanel, true);
            RefreshBuildingButtons();
            Debug.Log("Building menu opened");
        }
        
        void CloseBuildingMenu()
        {
            SetPanelActive(buildingPanel, false);
            SetPanelActive(buildingInfoPanel, false);
            Debug.Log("Building menu closed");
        }
        
        void PrepareForRaid()
        {
            // Show raid preparation panel
            SetPanelActive(raidPanel, true);
            
            Debug.Log("Preparing for raid...");
            
            // For now, just transition after delay
            Invoke(nameof(StartRaid), 2f);
        }
        
        void StartRaid()
        {
            if (ColonyManager.Instance != null)
            {
                ColonyManager.Instance.PrepareForRaid();
            }
            else
            {
                Debug.LogError("ColonyManager.Instance is null - cannot start raid");
            }
        }
        
        void OnDestroy()
        {
            if (ResourceManager.Instance != null)
            {
                ResourceManager.OnResourceChanged -= OnResourceChanged;
            }
        }
    }
}