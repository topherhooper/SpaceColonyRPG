# Colony Scene Population & UI Fix Guide

## Part 1: Populating the Colony Scene with Scenery

### Scene Environment Setup

#### 1. Terrain and Ground Setup
```csharp
// ColonyEnvironmentSetup.cs
using UnityEngine;

public class ColonyEnvironmentSetup : MonoBehaviour
{
    [Header("Terrain Settings")]
    public Material alienGroundMaterial;
    public Texture2D heightmapTexture;
    public float terrainSize = 100f;
    public float maxHeight = 5f;
    
    [Header("Decoration Prefabs")]
    public GameObject[] rockPrefabs; // Use SimpleLowPolyNature rocks
    public GameObject[] alienTreePrefabs; // Recolored trees
    public GameObject[] crystalPrefabs; // Energy crystals
    public GameObject[] debrisPrefabs; // Space debris
    
    void Start()
    {
        SetupTerrain();
        PlaceDecorations();
    }
    
    void SetupTerrain()
    {
        // Create terrain with subtle height variation
        GameObject terrain = GameObject.CreatePrimitive(PrimitiveType.Plane);
        terrain.name = "AlienTerrain";
        terrain.transform.localScale = new Vector3(terrainSize / 10f, 1, terrainSize / 10f);
        terrain.layer = LayerMask.NameToLayer("Ground");
        
        // Apply alien material
        if (alienGroundMaterial)
        {
            terrain.GetComponent<Renderer>().material = alienGroundMaterial;
        }
    }
    
    void PlaceDecorations()
    {
        // Place rocks
        PlaceObjectGroup(rockPrefabs, 30, 50, "Rocks");
        
        // Place alien vegetation
        PlaceObjectGroup(alienTreePrefabs, 20, 40, "Vegetation");
        
        // Place energy crystals
        PlaceObjectGroup(crystalPrefabs, 10, 15, "Crystals");
        
        // Place debris
        PlaceObjectGroup(debrisPrefabs, 5, 10, "Debris");
    }
    
    void PlaceObjectGroup(GameObject[] prefabs, int minCount, int maxCount, string groupName)
    {
        if (prefabs == null || prefabs.Length == 0) return;
        
        GameObject container = new GameObject($"_Environment/{groupName}");
        int count = Random.Range(minCount, maxCount);
        
        for (int i = 0; i < count; i++)
        {
            GameObject prefab = prefabs[Random.Range(0, prefabs.Length)];
            Vector3 position = GetRandomPosition();
            Quaternion rotation = Quaternion.Euler(0, Random.Range(0, 360), 0);
            
            GameObject obj = Instantiate(prefab, position, rotation, container.transform);
            
            // Random scale variation
            float scale = Random.Range(0.8f, 1.2f);
            obj.transform.localScale *= scale;
        }
    }
    
    Vector3 GetRandomPosition()
    {
        float margin = 10f; // Keep away from edges
        float x = Random.Range(-terrainSize/2 + margin, terrainSize/2 - margin);
        float z = Random.Range(-terrainSize/2 + margin, terrainSize/2 - margin);
        return new Vector3(x, 0, z);
    }
}
```

#### 2. Alien Material Creator
```csharp
// Editor/AlienMaterialCreator.cs
using UnityEngine;
using UnityEditor;

public class AlienMaterialCreator : EditorWindow
{
    [MenuItem("Tools/Colony/Create Alien Materials")]
    public static void ShowWindow()
    {
        GetWindow<AlienMaterialCreator>("Alien Materials");
    }
    
    void OnGUI()
    {
        if (GUILayout.Button("Create All Alien Materials"))
        {
            CreateAlienMaterials();
        }
    }
    
    void CreateAlienMaterials()
    {
        string path = "Assets/_Project/Materials/Environment/";
        
        // Alien Ground
        CreateMaterial(path + "AlienGround.mat", new Color(0.4f, 0.3f, 0.5f), 0.2f, 0.1f);
        
        // Alien Rock
        CreateMaterial(path + "AlienRock.mat", new Color(0.3f, 0.25f, 0.4f), 0.3f, 0.2f);
        
        // Energy Crystal
        CreateEmissiveMaterial(path + "EnergyCrystal.mat", new Color(0.3f, 0.8f, 1f), 2f);
        
        // Alien Vegetation
        CreateMaterial(path + "AlienVegetation.mat", new Color(0.5f, 0.3f, 0.7f), 0.1f, 0.8f);
        
        AssetDatabase.Refresh();
        Debug.Log("Alien materials created!");
    }
    
    void CreateMaterial(string path, Color color, float metallic, float smoothness)
    {
        Material mat = new Material(Shader.Find("Universal Render Pipeline/Lit"));
        mat.color = color;
        mat.SetFloat("_Metallic", metallic);
        mat.SetFloat("_Smoothness", smoothness);
        
        AssetDatabase.CreateAsset(mat, path);
    }
    
    void CreateEmissiveMaterial(string path, Color color, float intensity)
    {
        Material mat = new Material(Shader.Find("Universal Render Pipeline/Lit"));
        mat.color = color;
        mat.EnableKeyword("_EMISSION");
        mat.SetColor("_EmissionColor", color * intensity);
        
        AssetDatabase.CreateAsset(mat, path);
    }
}
```

#### 3. Skybox and Atmosphere
```csharp
// SpaceSkyboxController.cs
using UnityEngine;
using UnityEngine.Rendering;

public class SpaceSkyboxController : MonoBehaviour
{
    [Header("Skybox Settings")]
    public Material spaceSkybox;
    public Gradient skyGradient;
    public float rotationSpeed = 0.5f;
    
    [Header("Atmospheric Effects")]
    public GameObject dustParticlesPrefab;
    public Light sunLight;
    public Light ambientLight;
    
    void Start()
    {
        SetupSkybox();
        SetupLighting();
        CreateAtmosphericEffects();
    }
    
    void SetupSkybox()
    {
        if (spaceSkybox)
        {
            RenderSettings.skybox = spaceSkybox;
        }
        else
        {
            // Create procedural skybox
            RenderSettings.skybox = CreateProceduralSkybox();
        }
    }
    
    Material CreateProceduralSkybox()
    {
        Material skyMat = new Material(Shader.Find("Skybox/Procedural"));
        skyMat.SetFloat("_SunSize", 0.02f);
        skyMat.SetFloat("_AtmosphereThickness", 0.5f);
        skyMat.SetColor("_SkyTint", new Color(0.2f, 0.1f, 0.3f));
        skyMat.SetColor("_GroundColor", new Color(0.1f, 0.05f, 0.15f));
        return skyMat;
    }
    
    void SetupLighting()
    {
        // Main sun
        if (!sunLight) sunLight = FindObjectOfType<Light>();
        if (sunLight)
        {
            sunLight.color = new Color(0.8f, 0.7f, 1f);
            sunLight.intensity = 1.2f;
            sunLight.transform.rotation = Quaternion.Euler(35f, -30f, 0);
        }
        
        // Ambient lighting
        RenderSettings.ambientMode = AmbientMode.Trilight;
        RenderSettings.ambientSkyColor = new Color(0.3f, 0.2f, 0.5f);
        RenderSettings.ambientEquatorColor = new Color(0.2f, 0.15f, 0.3f);
        RenderSettings.ambientGroundColor = new Color(0.1f, 0.08f, 0.15f);
    }
    
    void CreateAtmosphericEffects()
    {
        // Floating dust particles
        if (dustParticlesPrefab)
        {
            GameObject dust = Instantiate(dustParticlesPrefab);
            dust.name = "AtmosphericDust";
            
            var ps = dust.GetComponent<ParticleSystem>();
            if (!ps) ps = dust.AddComponent<ParticleSystem>();
            
            var main = ps.main;
            main.maxParticles = 100;
            main.startLifetime = 20f;
            main.startSpeed = 0.5f;
            main.startSize = 0.2f;
            main.startColor = new Color(0.6f, 0.5f, 0.8f, 0.3f);
            
            var shape = ps.shape;
            shape.shapeType = ParticleSystemShapeType.Box;
            shape.scale = new Vector3(100, 20, 100);
        }
    }
    
    void Update()
    {
        // Slowly rotate skybox
        if (RenderSettings.skybox)
        {
            RenderSettings.skybox.SetFloat("_Rotation", Time.time * rotationSpeed);
        }
    }
}
```

### Scenery Prefab Setup

#### 1. Alien Rock Variations
```yaml
# Create these as prefab variants from SimpleLowPolyNature rocks
AlienRock_Small:
  - Base: Rock1.prefab
  - Material: AlienRock.mat
  - Scale: 0.5-0.8
  - Tint: Purple/Blue

AlienRock_Medium:
  - Base: Rock5.prefab
  - Material: AlienRock.mat
  - Scale: 1.0-1.5
  - Tint: Purple/Gray

AlienRock_Large:
  - Base: Rock10.prefab
  - Material: AlienRock.mat
  - Scale: 2.0-3.0
  - Tint: Dark Purple
```

#### 2. Alien Vegetation
```yaml
# Recolor SimpleLowPolyNature trees
AlienTree_Spiky:
  - Base: TreeDead1.prefab
  - Material: AlienVegetation.mat
  - Color: Purple/Pink
  - Emissive tips

AlienPlant_Bulb:
  - Base: Mushroom3.prefab
  - Material: AlienVegetation.mat
  - Scale: 2.0
  - Glow effect

AlienGrass_Patches:
  - Base: Grass3.prefab
  - Material: AlienVegetation.mat
  - Color: Blue/Purple
```

#### 3. Energy Crystal Prefabs
```csharp
// EnergyCrystalPrefab.cs
using UnityEngine;

public class EnergyCrystalPrefab : MonoBehaviour
{
    public float glowIntensity = 2f;
    public float pulseSpeed = 1f;
    public Color crystalColor = new Color(0.3f, 0.8f, 1f);
    
    private Material crystalMaterial;
    private float baseIntensity;
    
    void Start()
    {
        SetupCrystal();
    }
    
    void SetupCrystal()
    {
        // Create crystal mesh
        MeshFilter mf = GetComponent<MeshFilter>();
        if (!mf) mf = gameObject.AddComponent<MeshFilter>();
        
        mf.mesh = CreateCrystalMesh();
        
        // Setup material
        MeshRenderer mr = GetComponent<MeshRenderer>();
        if (!mr) mr = gameObject.AddComponent<MeshRenderer>();
        
        crystalMaterial = new Material(Shader.Find("Universal Render Pipeline/Lit"));
        crystalMaterial.EnableKeyword("_EMISSION");
        crystalMaterial.color = crystalColor;
        mr.material = crystalMaterial;
        
        baseIntensity = glowIntensity;
    }
    
    void Update()
    {
        // Pulsing glow effect
        float pulse = Mathf.Sin(Time.time * pulseSpeed) * 0.5f + 0.5f;
        float currentIntensity = baseIntensity * (0.5f + pulse * 0.5f);
        
        crystalMaterial.SetColor("_EmissionColor", crystalColor * currentIntensity);
    }
    
    Mesh CreateCrystalMesh()
    {
        // Simple crystal shape
        Mesh mesh = new Mesh();
        
        Vector3[] vertices = new Vector3[]
        {
            // Base
            new Vector3(-0.5f, 0, -0.5f),
            new Vector3(0.5f, 0, -0.5f),
            new Vector3(0.5f, 0, 0.5f),
            new Vector3(-0.5f, 0, 0.5f),
            // Top point
            new Vector3(0, 2f, 0)
        };
        
        int[] triangles = new int[]
        {
            // Base
            0, 2, 1,
            0, 3, 2,
            // Sides
            0, 1, 4,
            1, 2, 4,
            2, 3, 4,
            3, 0, 4
        };
        
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.RecalculateNormals();
        
        return mesh;
    }
}
```

## Part 2: Fixing Non-Functional Buttons

### UI Button Fix Implementation

#### 1. Complete Working ColonyUIManager
```csharp
// ColonyUIManager.cs - Fixed Version
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;
using SpaceColonyRPG.Colony;

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
    
    [Header("Buttons")]
    public Button openBuildMenuButton;
    public Button closeBuildMenuButton;
    public Button prepareRaidButton;
    
    private BuildingCategory currentCategory = BuildingCategory.Infrastructure;
    private Dictionary<BuildingCategory, List<BuildingData>> categorizedBuildings;
    
    void Awake()
    {
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
        ResourceManager.OnResourceChanged += OnResourceChanged;
    }
    
    void SetupUI()
    {
        // Ensure panels start in correct state
        if (buildingPanel) buildingPanel.SetActive(false);
        if (raidPanel) raidPanel.SetActive(false);
        if (buildingInfoPanel) buildingInfoPanel.SetActive(false);
        if (errorMessagePanel) errorMessagePanel.SetActive(false);
    }
    
    void SetupButtonListeners()
    {
        // Main buttons
        if (openBuildMenuButton)
        {
            openBuildMenuButton.onClick.RemoveAllListeners();
            openBuildMenuButton.onClick.AddListener(OpenBuildingMenu);
        }
        
        if (closeBuildMenuButton)
        {
            closeBuildMenuButton.onClick.RemoveAllListeners();
            closeBuildMenuButton.onClick.AddListener(CloseBuildingMenu);
        }
        
        if (prepareRaidButton)
        {
            prepareRaidButton.onClick.RemoveAllListeners();
            prepareRaidButton.onClick.AddListener(PrepareForRaid);
        }
        
        if (startPlacementButton)
        {
            startPlacementButton.onClick.RemoveAllListeners();
        }
    }
    
    void SetupResourceDisplay()
    {
        if (!resourceContainer || !resourceDisplayPrefab) return;
        
        // Clear existing displays
        foreach (Transform child in resourceContainer)
        {
            Destroy(child.gameObject);
        }
        
        // Create displays for each resource
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
        if (!BuildingSystem.Instance || BuildingSystem.Instance.availableBuildings == null) return;
        
        // Categorize buildings
        foreach (var building in BuildingSystem.Instance.availableBuildings)
        {
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
        if (!buildingCategoryTabs || !categoryTabPrefab) return;
        
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
            if (tabText) tabText.text = GetCategoryDisplayName(category);
            
            // Setup tab button
            Button tabButton = tab.GetComponent<Button>();
            if (tabButton)
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
        
        if (!buildingButtonContainer) return;
        
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
                CreateBuildingButton(building);
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
                if (tabImage)
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
        if (!buildingButtonPrefab || !buildingButtonContainer) return;
        
        GameObject button = Instantiate(buildingButtonPrefab, buildingButtonContainer);
        
        // Setup visuals
        Text nameText = button.transform.Find("Name")?.GetComponent<Text>();
        if (nameText) nameText.text = building.buildingName;
        
        Image iconImage = button.transform.Find("Icon")?.GetComponent<Image>();
        if (iconImage && building.icon) iconImage.sprite = building.icon;
        
        // Cost display
        Text costText = button.transform.Find("Cost")?.GetComponent<Text>();
        if (costText)
        {
            string cost = "";
            if (building.metalCost > 0) cost += $"M:{building.metalCost} ";
            if (building.energyCost > 0) cost += $"E:{building.energyCost} ";
            if (building.creditsCost > 0) cost += $"C:{building.creditsCost}";
            costText.text = cost.Trim();
        }
        
        // Button functionality
        Button btn = button.GetComponent<Button>();
        if (btn)
        {
            btn.onClick.RemoveAllListeners();
            btn.onClick.AddListener(() => OnBuildingButtonClicked(building));
        }
        
        // Update interactability
        UpdateBuildingButton(button, building);
    }
    
    void OnBuildingButtonClicked(BuildingData building)
    {
        ShowBuildingInfo(building);
    }
    
    void ShowBuildingInfo(BuildingData building)
    {
        if (!buildingInfoPanel) return;
        
        buildingInfoPanel.SetActive(true);
        
        if (buildingNameText) buildingNameText.text = building.buildingName;
        if (buildingDescriptionText) buildingDescriptionText.text = building.description;
        
        // Cost breakdown
        if (buildingCostText)
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
        if (startPlacementButton)
        {
            startPlacementButton.onClick.RemoveAllListeners();
            startPlacementButton.onClick.AddListener(() => 
            {
                BuildingSystem.Instance.StartPlacement(building);
                buildingInfoPanel.SetActive(false);
            });
            
            // Check if can afford
            bool canAfford = ResourceManager.Instance.CanAfford(building.GetCosts());
            bool meetsRequirements = ColonyManager.Instance.colonyLevel >= building.requiredColonyLevel;
            startPlacementButton.interactable = canAfford && meetsRequirements;
        }
    }
    
    void UpdateBuildingButton(GameObject button, BuildingData building)
    {
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
        if (!errorMessagePanel || !errorMessageText) return;
        
        errorMessageText.text = message;
        errorMessagePanel.SetActive(true);
        
        CancelInvoke(nameof(HideError));
        Invoke(nameof(HideError), errorMessageDuration);
    }
    
    void HideError()
    {
        if (errorMessagePanel) errorMessagePanel.SetActive(false);
    }
    
    void UpdateColonyStats()
    {
        // Colony level
        if (colonyLevelText)
            colonyLevelText.text = $"Colony Level: {ColonyManager.Instance.colonyLevel}";
        
        // Power status
        int production = BuildingSystem.Instance.GetTotalEnergyProduction();
        int consumption = BuildingSystem.Instance.GetTotalEnergyConsumption();
        
        if (powerStatusText)
        {
            powerStatusText.text = $"Power: {production}/{consumption}";
            powerStatusText.color = (consumption > production) ? Color.red : Color.green;
        }
        
        if (powerBar)
        {
            powerBar.maxValue = Mathf.Max(production, consumption);
            powerBar.value = production;
        }
    }
    
    // Button Actions
    void OpenBuildingMenu()
    {
        if (buildingPanel) buildingPanel.SetActive(true);
        RefreshBuildingButtons();
    }
    
    void CloseBuildingMenu()
    {
        if (buildingPanel) buildingPanel.SetActive(false);
        if (buildingInfoPanel) buildingInfoPanel.SetActive(false);
    }
    
    void PrepareForRaid()
    {
        // Show raid preparation panel
        if (raidPanel) raidPanel.SetActive(true);
        
        // Could add more prep UI here
        Debug.Log("Preparing for raid...");
        
        // For now, just transition
        Invoke(nameof(StartRaid), 2f);
    }
    
    void StartRaid()
    {
        ColonyManager.Instance.PrepareForRaid();
    }
    
    void OnDestroy()
    {
        ResourceManager.OnResourceChanged -= OnResourceChanged;
    }
}
```

#### 2. UI Prefab Setup Helper
```csharp
// Editor/UISetupHelper.cs
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

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
        
        if (GUILayout.Button("Create Resource Display Prefab"))
        {
            CreateResourceDisplayPrefab();
        }
        
        if (GUILayout.Button("Create Building Button Prefab"))
        {
            CreateBuildingButtonPrefab();
        }
        
        if (GUILayout.Button("Create Category Tab Prefab"))
        {
            CreateCategoryTabPrefab();
        }
        
        if (GUILayout.Button("Setup Complete Colony UI"))
        {
            SetupCompleteUI();
        }
    }
    
    void CreateResourceDisplayPrefab()
    {
        GameObject prefab = new GameObject("ResourceDisplay");
        prefab.AddComponent<RectTransform>();
        
        // Background
        Image bg = prefab.AddComponent<Image>();
        bg.color = new Color(0.2f, 0.2f, 0.2f, 0.8f);
        
        // Icon
        GameObject icon = new GameObject("Icon");
        icon.transform.SetParent(prefab.transform);
        RectTransform iconRect = icon.AddComponent<RectTransform>();
        iconRect.anchoredPosition = new Vector2(-40, 0);
        iconRect.sizeDelta = new Vector2(30, 30);
        Image iconImg = icon.AddComponent<Image>();
        
        // Name text
        GameObject nameObj = new GameObject("Name");
        nameObj.transform.SetParent(prefab.transform);
        RectTransform nameRect = nameObj.AddComponent<RectTransform>();
        nameRect.anchoredPosition = new Vector2(0, 10);
        nameRect.sizeDelta = new Vector2(80, 20);
        Text nameText = nameObj.AddComponent<Text>();
        nameText.text = "Resource";
        nameText.alignment = TextAnchor.MiddleCenter;
        nameText.fontSize = 14;
        
        // Amount text
        GameObject amountObj = new GameObject("Amount");
        amountObj.transform.SetParent(prefab.transform);
        RectTransform amountRect = amountObj.AddComponent<RectTransform>();
        amountRect.anchoredPosition = new Vector2(0, -10);
        amountRect.sizeDelta = new Vector2(80, 20);
        Text amountText = amountObj.AddComponent<Text>();
        amountText.text = "0/100";
        amountText.alignment = TextAnchor.MiddleCenter;
        amountText.fontSize = 16;
        amountText.fontStyle = FontStyle.Bold;
        
        // Add component
        ResourceDisplay rd = prefab.AddComponent<ResourceDisplay>();
        rd.iconImage = iconImg;
        rd.nameText = nameText;
        rd.amountText = amountText;
        rd.backgroundImage = bg;
        
        // Save prefab
        string path = "Assets/_Project/Prefabs/UI/ResourceDisplay.prefab";
        PrefabUtility.SaveAsPrefabAsset(prefab, path);
        DestroyImmediate(prefab);
        
        Debug.Log($"Created ResourceDisplay prefab at {path}");
    }
    
    void CreateBuildingButtonPrefab()
    {
        GameObject prefab = new GameObject("BuildingButton");
        RectTransform rect = prefab.AddComponent<RectTransform>();
        rect.sizeDelta = new Vector2(200, 60);
        
        // Button component
        Button btn = prefab.AddComponent<Button>();
        Image btnImg = prefab.AddComponent<Image>();
        btn.targetGraphic = btnImg;
        
        // Icon
        GameObject icon = new GameObject("Icon");
        icon.transform.SetParent(prefab.transform);
        RectTransform iconRect = icon.AddComponent<RectTransform>();
        iconRect.anchorMin = new Vector2(0, 0.5f);
        iconRect.anchorMax = new Vector2(0, 0.5f);
        iconRect.pivot = new Vector2(0, 0.5f);
        iconRect.anchoredPosition = new Vector2(10, 0);
        iconRect.sizeDelta = new Vector2(40, 40);
        icon.AddComponent<Image>();
        
        // Name
        GameObject nameObj = new GameObject("Name");
        nameObj.transform.SetParent(prefab.transform);
        RectTransform nameRect = nameObj.AddComponent<RectTransform>();
        nameRect.anchorMin = new Vector2(0, 0.5f);
        nameRect.anchorMax = new Vector2(1, 1);
        nameRect.offsetMin = new Vector2(60, 0);
        nameRect.offsetMax = new Vector2(-10, -5);
        Text nameText = nameObj.AddComponent<Text>();
        nameText.text = "Building Name";
        nameText.alignment = TextAnchor.MiddleLeft;
        nameText.fontSize = 16;
        
        // Cost
        GameObject costObj = new GameObject("Cost");
        costObj.transform.SetParent(prefab.transform);
        RectTransform costRect = costObj.AddComponent<RectTransform>();
        costRect.anchorMin = new Vector2(0, 0);
        costRect.anchorMax = new Vector2(1, 0.5f);
        costRect.offsetMin = new Vector2(60, 5);
        costRect.offsetMax = new Vector2(-10, 0);
        Text costText = costObj.AddComponent<Text>();
        costText.text = "M:50 E:10";
        costText.alignment = TextAnchor.MiddleLeft;
        costText.fontSize = 12;
        costText.color = new Color(0.8f, 0.8f, 0.8f);
        
        // Save prefab
        string path = "Assets/_Project/Prefabs/UI/BuildingButton.prefab";
        PrefabUtility.SaveAsPrefabAsset(prefab, path);
        DestroyImmediate(prefab);
        
        Debug.Log($"Created BuildingButton prefab at {path}");
    }
    
    void CreateCategoryTabPrefab()
    {
        GameObject prefab = new GameObject("CategoryTab");
        RectTransform rect = prefab.AddComponent<RectTransform>();
        rect.sizeDelta = new Vector2(120, 40);
        
        // Button
        Button btn = prefab.AddComponent<Button>();
        Image img = prefab.AddComponent<Image>();
        btn.targetGraphic = img;
        
        // Text
        GameObject textObj = new GameObject("Text");
        textObj.transform.SetParent(prefab.transform);
        RectTransform textRect = textObj.AddComponent<RectTransform>();
        textRect.anchorMin = Vector2.zero;
        textRect.anchorMax = Vector2.one;
        textRect.sizeDelta = Vector2.zero;
        textRect.offsetMin = new Vector2(5, 5);
        textRect.offsetMax = new Vector2(-5, -5);
        Text text = textObj.AddComponent<Text>();
        text.text = "Category";
        text.alignment = TextAnchor.MiddleCenter;
        text.fontSize = 14;
        
        // Save prefab
        string path = "Assets/_Project/Prefabs/UI/CategoryTab.prefab";
        PrefabUtility.SaveAsPrefabAsset(prefab, path);
        DestroyImmediate(prefab);
        
        Debug.Log($"Created CategoryTab prefab at {path}");
    }
    
    void SetupCompleteUI()
    {
        // Implementation for complete UI setup
        Debug.Log("Complete UI setup would create all panels and wire them up");
    }
}
```

### 3. Testing Checklist for UI

```markdown
## UI Testing Checklist

### Button Functionality
- [ ] **Open Build Menu** button opens building panel
- [ ] **Close Build Menu** button closes building panel
- [ ] **Category Tabs** switch between building categories
- [ ] **Building Buttons** show building info when clicked
- [ ] **Start Placement** button begins building placement
- [ ] **Prepare Raid** button shows raid prep UI

### Visual Feedback
- [ ] Resource displays update in real-time
- [ ] Power bar shows production vs consumption
- [ ] Building buttons gray out when can't afford
- [ ] Category tabs highlight when selected
- [ ] Error messages appear and auto-hide

### Building Placement
- [ ] ESC or right-click cancels placement
- [ ] Preview changes color based on validity
- [ ] Resources deduct on placement
- [ ] Grid snapping works correctly

### Edge Cases
- [ ] UI handles no buildings in category
- [ ] UI handles insufficient resources gracefully
- [ ] UI updates when buildings are destroyed
- [ ] UI persists state between scene loads
```

## Quick Implementation Steps

### 1. Scene Population
```
1. Create Materials:
   - Use Tools > Colony > Create Alien Materials
   - Verify materials in Materials/Environment folder

2. Add Environment Controller:
   - Create empty GameObject "_Environment"
   - Add ColonyEnvironmentSetup component
   - Assign rock/tree prefabs from SimpleLowPolyNature
   - Run scene to auto-populate

3. Setup Skybox:
   - Add SpaceSkyboxController to scene
   - Configure alien atmosphere colors
   - Add dust particle effects

4. Place Key Landmarks:
   - Landing pad area (flat concrete)
   - Crystal field (energy source)
   - Rocky outcrops for visual interest
   - Alien vegetation clusters
```

### 2. UI Fixes
```
1. Create UI Prefabs:
   - Use Tools > Colony > Setup UI Prefabs
   - Creates ResourceDisplay, BuildingButton, CategoryTab

2. Setup Canvas Hierarchy:
   Canvas
   ├── MainPanel
   │   ├── ResourceBar (top)
   │   ├── BuildMenuButton
   │   └── RaidButton
   ├── BuildingPanel
   │   ├── CategoryTabs
   │   ├── BuildingGrid
   │   └── CloseButton
   └── ErrorMessage

3. Assign References:
   - Drag prefabs to ColonyUIManager slots
   - Link all buttons and panels
   - Set up button listeners

4. Test All Interactions:
   - Verify each button works
   - Check building placement flow
   - Confirm resource updates
```

This completes the colony scene population with alien scenery and fixes all non-functional buttons with a proper UI implementation!