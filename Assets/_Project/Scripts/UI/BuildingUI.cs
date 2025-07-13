using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class BuildingUI : MonoBehaviour
{
    [Header("UI References")]
    public GameObject buildingButtonPrefab;
    public Transform buttonContainer;
    public BuildingSystem buildingSystem;
    public GameObject buildingPanel;
    public Text selectedBuildingText;
    
    [System.Serializable]
    public class BuildingInfo
    {
        public string name;
        public Sprite icon;
        public GameObject prefab;
        public int metalCost;
        public int energyCost;
        public KeyCode hotkey;
        public string description;
    }
    
    [Header("Building Types")]
    public BuildingInfo[] availableBuildings = new BuildingInfo[]
    {
        new BuildingInfo 
        { 
            name = "Generator", 
            metalCost = 50, 
            energyCost = 0, 
            hotkey = KeyCode.Alpha1,
            description = "Produces energy over time"
        },
        new BuildingInfo 
        { 
            name = "Barracks", 
            metalCost = 75, 
            energyCost = 25, 
            hotkey = KeyCode.Alpha2,
            description = "Spawns colonists"
        },
        new BuildingInfo 
        { 
            name = "Storage", 
            metalCost = 40, 
            energyCost = 10, 
            hotkey = KeyCode.Alpha3,
            description = "Increases resource capacity"
        },
        new BuildingInfo 
        { 
            name = "Mine", 
            metalCost = 60, 
            energyCost = 20, 
            hotkey = KeyCode.Alpha4,
            description = "Produces metal over time"
        },
        new BuildingInfo 
        { 
            name = "Farm", 
            metalCost = 30, 
            energyCost = 15, 
            hotkey = KeyCode.Alpha5,
            description = "Produces food over time"
        }
    };
    
    private List<GameObject> buildingButtons = new List<GameObject>();
    
    void Start()
    {
        CreateBuildingButtons();
        UpdateBuildingButtons();
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            ToggleBuildingPanel();
        }
        
        for (int i = 0; i < Mathf.Min(availableBuildings.Length, 9); i++)
        {
            if (Input.GetKeyDown(availableBuildings[i].hotkey))
            {
                TrySelectBuilding(i);
            }
        }
        
        if (buildingSystem != null && buildingSystem.IsInBuildMode())
        {
            UpdateSelectedBuildingText();
        }
    }
    
    void CreateBuildingButtons()
    {
        if (buildingButtonPrefab == null || buttonContainer == null) return;
        
        for (int i = 0; i < availableBuildings.Length; i++)
        {
            BuildingInfo info = availableBuildings[i];
            GameObject button = Instantiate(buildingButtonPrefab, buttonContainer);
            buildingButtons.Add(button);
            
            Text nameText = button.transform.Find("NameText")?.GetComponent<Text>();
            if (nameText != null)
            {
                nameText.text = $"{info.name} [{info.hotkey.ToString().Replace("Alpha", "")}]";
            }
            
            Text costText = button.transform.Find("CostText")?.GetComponent<Text>();
            if (costText != null)
            {
                string cost = "";
                if (info.metalCost > 0) cost += $"M:{info.metalCost} ";
                if (info.energyCost > 0) cost += $"E:{info.energyCost}";
                costText.text = cost;
            }
            
            Text descText = button.transform.Find("DescText")?.GetComponent<Text>();
            if (descText != null)
            {
                descText.text = info.description;
            }
            
            Image iconImage = button.transform.Find("Icon")?.GetComponent<Image>();
            if (iconImage != null && info.icon != null)
            {
                iconImage.sprite = info.icon;
            }
            
            Button btn = button.GetComponent<Button>();
            int index = i;
            btn.onClick.AddListener(() => TrySelectBuilding(index));
        }
    }
    
    void UpdateBuildingButtons()
    {
        for (int i = 0; i < buildingButtons.Count && i < availableBuildings.Length; i++)
        {
            BuildingInfo info = availableBuildings[i];
            Button btn = buildingButtons[i].GetComponent<Button>();
            
            bool canAfford = ResourceManager.Instance.CanAfford("Metal", info.metalCost) &&
                           ResourceManager.Instance.CanAfford("Energy", info.energyCost);
            
            btn.interactable = canAfford;
            
            Image costBG = buildingButtons[i].transform.Find("CostBG")?.GetComponent<Image>();
            if (costBG != null)
            {
                costBG.color = canAfford ? Color.green : Color.red;
            }
        }
    }
    
    void TrySelectBuilding(int index)
    {
        if (index < 0 || index >= availableBuildings.Length) return;
        
        BuildingInfo info = availableBuildings[index];
        
        if (ResourceManager.Instance.CanAfford("Metal", info.metalCost) &&
            ResourceManager.Instance.CanAfford("Energy", info.energyCost))
        {
            if (buildingSystem != null && info.prefab != null)
            {
                buildingSystem.buildingPrefabs[index] = info.prefab;
                buildingSystem.StartPlacement(index);
            }
        }
        else
        {
            ShowInsufficientResourcesPopup(info);
        }
    }
    
    void ShowInsufficientResourcesPopup(BuildingInfo info)
    {
        string message = "Insufficient resources!\n";
        
        int currentMetal = ResourceManager.Instance.GetResource("Metal");
        int currentEnergy = ResourceManager.Instance.GetResource("Energy");
        
        if (currentMetal < info.metalCost)
        {
            message += $"Need {info.metalCost - currentMetal} more Metal\n";
        }
        
        if (currentEnergy < info.energyCost)
        {
            message += $"Need {info.energyCost - currentEnergy} more Energy\n";
        }
        
        Debug.Log(message);
        
        if (AudioManager.Instance != null && AudioManager.Instance.errorBuzzSound != null)
        {
            AudioManager.Instance.PlaySFX(AudioManager.Instance.errorBuzzSound);
        }
    }
    
    void ToggleBuildingPanel()
    {
        if (buildingPanel != null)
        {
            buildingPanel.SetActive(!buildingPanel.activeSelf);
            
            if (buildingPanel.activeSelf)
            {
                UpdateBuildingButtons();
            }
        }
    }
    
    void UpdateSelectedBuildingText()
    {
        if (selectedBuildingText != null && buildingSystem != null)
        {
            int index = buildingSystem.selectedBuildingIndex;
            if (index >= 0 && index < availableBuildings.Length)
            {
                BuildingInfo info = availableBuildings[index];
                selectedBuildingText.text = $"Placing: {info.name}";
                selectedBuildingText.gameObject.SetActive(true);
            }
        }
    }
    
    public void OnBuildModeToggle()
    {
        if (buildingSystem != null)
        {
            buildingSystem.ToggleBuildMode();
        }
    }
}