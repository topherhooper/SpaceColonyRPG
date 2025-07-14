using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

namespace SpaceColonyRPG.Colony
{
    public class ColonyUIManager : MonoBehaviour
    {
        public static ColonyUIManager Instance { get; private set; }
        
        [Header("Resource Display")]
        public Transform resourceContainer;
        public GameObject resourceDisplayPrefab;
        private Dictionary<ResourceType, ResourceDisplay> resourceDisplays;
        
        [Header("Building Menu")]
        public Transform buildingCategoryTabs;
        public Transform buildingButtonContainer;
        public GameObject categoryTabPrefab;
        public GameObject buildingButtonPrefab;
        
        [Header("Panels")]
        public GameObject buildingInfoPanel;
        public Text buildingNameText;
        public Text buildingDescriptionText;
        
        [Header("Messages")]
        public Text errorMessageText;
        public float errorMessageDuration = 2f;
        
        [Header("Colony Stats")]
        public Text colonyLevelText;
        public Text powerStatusText;
        
        private BuildingCategory currentCategory = BuildingCategory.Infrastructure;
        
        void Awake()
        {
            Instance = this;
            resourceDisplays = new Dictionary<ResourceType, ResourceDisplay>();
        }
        
        void Start()
        {
            SetupResourceDisplay();
            SetupBuildingMenu();
            UpdateColonyStats();
            
            // Subscribe to events
            ResourceManager.OnResourceChanged += OnResourceChanged;
        }
        
        void SetupResourceDisplay()
        {
            if (!ResourceManager.Instance || !resourceContainer || !resourceDisplayPrefab) return;
            
            foreach (var resource in ResourceManager.Instance.resources)
            {
                GameObject display = Instantiate(resourceDisplayPrefab, resourceContainer);
                ResourceDisplay rd = display.GetComponent<ResourceDisplay>();
                if (rd)
                {
                    rd.Setup(resource);
                    resourceDisplays[resource.type] = rd;
                }
            }
        }
        
        void SetupBuildingMenu()
        {
            if (!BuildingSystem.Instance || !categoryTabPrefab || !buildingCategoryTabs) return;
            
            // Get unique categories
            var categories = new HashSet<BuildingCategory>();
            foreach (var building in BuildingSystem.Instance.availableBuildings)
            {
                if (building) categories.Add(building.category);
            }
            
            // Create category tabs
            foreach (var category in categories)
            {
                GameObject tab = Instantiate(categoryTabPrefab, buildingCategoryTabs);
                Text tabText = tab.GetComponentInChildren<Text>();
                if (tabText) tabText.text = category.ToString();
                
                Button button = tab.GetComponent<Button>();
                if (button)
                {
                    BuildingCategory cat = category; // Capture for closure
                    button.onClick.AddListener(() => ShowBuildingCategory(cat));
                }
            }
            
            // Show first category
            if (categories.Count > 0)
            {
                ShowBuildingCategory(BuildingCategory.Infrastructure);
            }
        }
        
        void ShowBuildingCategory(BuildingCategory category)
        {
            currentCategory = category;
            
            // Clear existing buttons
            if (buildingButtonContainer)
            {
                foreach (Transform child in buildingButtonContainer)
                {
                    Destroy(child.gameObject);
                }
            }
            
            // Create buttons for buildings in category
            if (BuildingSystem.Instance)
            {
                foreach (var building in BuildingSystem.Instance.availableBuildings)
                {
                    if (building && building.category == category)
                    {
                        CreateBuildingButton(building);
                    }
                }
            }
        }
        
        void CreateBuildingButton(BuildingData building)
        {
            if (!buildingButtonPrefab || !buildingButtonContainer) return;
            
            GameObject button = Instantiate(buildingButtonPrefab, buildingButtonContainer);
            
            // Setup visuals
            Text nameText = button.GetComponentInChildren<Text>();
            if (nameText) nameText.text = building.buildingName;
            
            Image icon = button.transform.Find("Icon")?.GetComponent<Image>();
            if (icon && building.icon) icon.sprite = building.icon;
            
            // Cost display
            Text costText = button.transform.Find("Cost")?.GetComponent<Text>();
            if (costText) costText.text = $"M:{building.metalCost} E:{building.energyCost}";
            
            // Button functionality
            Button btn = button.GetComponent<Button>();
            if (btn)
            {
                btn.onClick.AddListener(() => OnBuildingButtonClicked(building));
            }
            
            // Update interactability
            UpdateBuildingButton(button, building);
        }
        
        void OnBuildingButtonClicked(BuildingData building)
        {
            // Show info
            ShowBuildingInfo(building);
            
            // Start placement
            if (BuildingSystem.Instance)
            {
                BuildingSystem.Instance.StartPlacement(building);
            }
        }
        
        void ShowBuildingInfo(BuildingData building)
        {
            if (buildingInfoPanel) buildingInfoPanel.SetActive(true);
            if (buildingNameText) buildingNameText.text = building.buildingName;
            if (buildingDescriptionText) buildingDescriptionText.text = building.description;
        }
        
        public void RefreshBuildingButtons()
        {
            // Refresh current category
            ShowBuildingCategory(currentCategory);
        }
        
        void UpdateBuildingButton(GameObject button, BuildingData building)
        {
            if (!button || !building || !ResourceManager.Instance || !ColonyManager.Instance) return;
            
            Button btn = button.GetComponent<Button>();
            if (!btn) return;
            
            bool canAfford = ResourceManager.Instance.CanAfford(building.GetCosts());
            bool meetsRequirements = ColonyManager.Instance.colonyLevel >= building.requiredColonyLevel;
            
            btn.interactable = canAfford && meetsRequirements;
            
            // Visual feedback
            Image buttonImage = button.GetComponent<Image>();
            if (buttonImage)
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
        
        void OnResourceChanged(ResourceType type, int amount)
        {
            if (resourceDisplays != null && resourceDisplays.ContainsKey(type))
            {
                resourceDisplays[type].UpdateDisplay(amount);
            }
            
            // Refresh building buttons
            RefreshBuildingButtons();
        }
        
        public void ShowError(string message)
        {
            if (errorMessageText)
            {
                errorMessageText.text = message;
                errorMessageText.gameObject.SetActive(true);
                CancelInvoke(nameof(HideError));
                Invoke(nameof(HideError), errorMessageDuration);
            }
        }
        
        void HideError()
        {
            if (errorMessageText)
            {
                errorMessageText.gameObject.SetActive(false);
            }
        }
        
        public void UpdateColonyStats()
        {
            // Colony level
            if (colonyLevelText && ColonyManager.Instance)
            {
                colonyLevelText.text = $"Colony Level: {ColonyManager.Instance.colonyLevel}";
            }
            
            // Power status
            if (powerStatusText && BuildingSystem.Instance)
            {
                int production = BuildingSystem.Instance.GetTotalEnergyProduction();
                int consumption = BuildingSystem.Instance.GetTotalEnergyConsumption();
                powerStatusText.text = $"Power: {production}/{consumption}";
                
                if (consumption > production)
                {
                    powerStatusText.color = Color.red;
                }
                else
                {
                    powerStatusText.color = Color.green;
                }
            }
        }
        
        void OnDestroy()
        {
            ResourceManager.OnResourceChanged -= OnResourceChanged;
        }
    }
}