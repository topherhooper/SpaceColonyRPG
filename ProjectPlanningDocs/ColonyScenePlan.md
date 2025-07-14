# Colony Scene Implementation Guide

## Overview
This guide provides step-by-step instructions for implementing the Colony Scene in SpaceColonyRPG. The colony is a single-player base management scene where players build structures, manage resources, and prepare for multiplayer raids.

## Implementation Status
**Last Updated: Day 7 of Development - All Code Implementation Complete**

### ✅ Completed Components:
1. **Core Systems**
   - RTSCameraController - RTS-style camera with WASD/arrow movement and zoom
   - GridSystem - Grid-based building placement with occupancy checking
   - ResourceManager - Tracks 5 resources (Metal, Energy, Credits, Colonists, Research)
   - BuildingData - ScriptableObject structure for building definitions
   - BuildingSystem - Handles placement preview and building management
   - Building - Individual building behavior with production loops
   - ColonyManager - Main controller coordinating all systems

2. **Colonist System**
   - ColonistManager - Spawns and manages colonist entities
   - Colonist - AI behavior with wandering and work animations
   - State-based AI system with idle, wandering, and working states

3. **UI System**
   - ColonyUIManager - Main UI controller
   - ResourceDisplay - Individual resource UI components
   - Building selection menu with category tabs
   - Real-time resource and power status display
   - Error message system

4. **Helper Tools**
   - ColonySceneSetup - Editor tool for quick scene creation
   - BuildingDataCreator - Creates default building data assets

### 🐛 Compilation Fixes Applied:
1. **Namespace Conflicts Resolved**
   - Fixed naming conflict between `BuildingData` ScriptableObject and nested class in ColonyManager
   - Renamed ColonyManager's nested class to `SavedBuildingData`
   - Added `using SpaceColonyRPG.Colony;` to all files requiring Colony namespace

2. **BuildingData Asset Creation**
   - Created 8 BuildingData ScriptableObject assets directly as YAML files
   - Assets include: CommandCenter, SolarPanel, MetalMine, HabitatPod, ResearchLab, DefenseTower, ShieldGenerator, MedicalBay
   - All assets properly configured with costs, requirements, and production values

3. **Meta File Issues**
   - Deleted corrupted BuildingData.cs.meta file
   - Let Unity regenerate proper meta files with correct GUIDs
   - Fixed script reference in all BuildingData assets

4. **API Updates**
   - Updated `AddResource()` calls to `ModifyResource()` in GameStateManager
   - Fixed SaveManager to use proper Building/Resource properties
   - Updated UIManager to access building properties through BuildingData
   - Fixed QuickSetupHelper to use ResourceType enum instead of strings

5. **Editor Script Fixes**
   - Added namespace imports to SceneGenerator and PrefabGenerator
   - Commented out outdated building property assignments
   - Updated to use BuildingData ScriptableObject pattern

### ✅ Current Build Status:
- **All scripts compile without errors** ✓
- **BuildingData assets created and ready** ✓
- **All namespace conflicts resolved** ✓
- **Meta files properly regenerated** ✓
- **ColonyUIManager replaced with fixed version** ✓
- **All environment scripts implemented** ✓
- **All editor tools created** ✓
- **Ready for Unity scene setup** ✓

### 📄 Related Documentation:
- **ColonySceneFixes.md** - Implementation guide (COMPLETED)
- **ColonySceneIntegration.md** - Step-by-step Unity integration guide:
  - Quick implementation steps with time estimates
  - Environment setup using new scripts
  - UI system configuration  
  - Building prefab creation
  - Testing checklists
  - Troubleshooting common issues

### 📝 Key Lessons Learned:
1. **Unity Meta Files**: Corrupted or incorrect meta files can cause "type not found" errors even when code is correct
2. **Namespace Conflicts**: Nested classes with same names as ScriptableObjects cause compilation issues
3. **Asset Creation Best Practices**: 
   - Always ensure directories exist before creating assets
   - Use proper Unity AssetDatabase API instead of creating YAML files
   - Add error handling and user feedback in editor scripts
4. **Build Script Value**: The WSL build script was invaluable for quickly identifying compilation errors
5. **Editor Script Requirements**: Always include proper using directives (UnityEngine, UnityEditor) in editor scripts

### 🔧 Immediate Next Steps in Unity:
1. **Scene Environment Setup** (5 minutes - See ColonySceneIntegration.md)
   - Run Tools > Colony > Create Alien Materials
   - Add ColonyEnvironmentSetup component to scene
   - Add SpaceSkyboxController component
   - Environment will auto-populate on play

2. **UI Setup** (10 minutes - See ColonySceneIntegration.md)
   - Run Tools > Colony > Setup UI Prefabs
   - Click "Setup Complete Colony UI" button
   - Wire up all references on ColonyUIManager
   - Test all button functionality

3. **Building Prefab Creation**
   - Create prefabs for each BuildingData asset
   - Use Simple Space assets as base models
   - Apply alien materials for consistent theme
   - Add Building component and colliders

4. **Final Integration**
   - Assign all prefabs to BuildingData assets
   - Configure BuildingSystem with placement materials
   - Set up manager cross-references
   - Run through testing checklist

### 🎯 Implementation Progress:
- **ColonyEnvironmentSetup.cs** ✓ - Auto-populates scene with alien decorations
- **AlienMaterialCreator.cs** ✓ - Editor tool to create alien-themed materials
- **SpaceSkyboxController.cs** ✓ - Manages alien atmosphere and effects
- **EnergyCrystalPrefab.cs** ✓ - Generates glowing crystal meshes
- **ColonyUIManager** ✓ - Replaced with comprehensive fixed version
- **UISetupHelper.cs** ✓ - Creates all required UI prefabs
- **ColonySceneIntegration.md** ✓ - Complete implementation guide

### 📁 File Locations:
- **Colony Scripts**: `Assets/_Project/Scripts/Colony/`
  - ColonyEnvironmentSetup.cs
  - SpaceSkyboxController.cs
  - EnergyCrystalPrefab.cs
  - ColonyUIManager.cs (replaced with fixed version)
- **Building Data**: `Assets/_Project/ScriptableObjects/Buildings/`
  - All 8 BuildingData assets ready
- **Editor Tools**: `Assets/_Project/Scripts/Editor/`
  - AlienMaterialCreator.cs
  - UISetupHelper.cs
  - BuildingDataCreator.cs

## Scene Setup (1 hour)

### 1. Create Scene Structure
```
1. Create new scene: "ColonyScene"
2. Create GameObject hierarchy:
   
ColonyScene
├── _Managers (Empty GameObject)
│   ├── ColonyManager
│   ├── GridSystem
│   ├── BuildingSystem
│   ├── ResourceManager
│   ├── ColonistManager
│   └── ColonyUIManager
├── _Environment
│   ├── Terrain (100x100 plane)
│   ├── Lighting
│   │   ├── Directional Light (Sun)
│   │   └── Ambient Settings
│   └── Boundaries (invisible walls)
├── _Dynamic
│   ├── Buildings (Empty)
│   ├── Colonists (Empty)
│   └── Effects (Empty)
├── _Camera
│   └── Main Camera (RTS setup)
└── _UI
    └── Canvas
```

### 2. Terrain Setup
```csharp
// Use Simple Space terrain texture or create alien ground:
1. Create Plane (100x100 units)
2. Apply material with alien ground texture
3. Set layer to "Ground"
4. Add MeshCollider component
```

### 3. Lighting Configuration
```csharp
// Window > Rendering > Lighting
Environment Settings:
- Skybox: Simple Space skybox
- Ambient Color: Dark purple (#1a0033)
- Ambient Intensity: 0.8

Directional Light:
- Color: Pale blue (#b3d9ff)
- Intensity: 1.2
- Rotation: (35, -30, 0)
```

### 4. Camera Setup
```csharp
// RTSCameraController.cs
using UnityEngine;

public class RTSCameraController : MonoBehaviour
{
    [Header("Movement Settings")]
    public float moveSpeed = 20f;
    public float edgeScrollSpeed = 15f;
    public float edgeBorderThickness = 10f;
    
    [Header("Zoom Settings")]
    public float zoomSpeed = 500f;
    public float minHeight = 10f;
    public float maxHeight = 50f;
    
    [Header("Bounds")]
    public Vector2 mapBoundsMin = new Vector2(-45, -45);
    public Vector2 mapBoundsMax = new Vector2(45, 45);
    
    private Camera cam;
    private Vector3 targetPosition;
    
    void Start()
    {
        cam = GetComponent<Camera>();
        targetPosition = transform.position;
        
        // Set initial position
        transform.position = new Vector3(0, 30, -20);
        transform.rotation = Quaternion.Euler(45, 0, 0);
    }
    
    void Update()
    {
        HandleMovement();
        HandleZoom();
        ClampPosition();
    }
    
    void HandleMovement()
    {
        Vector3 moveDir = Vector3.zero;
        
        // Keyboard input
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            moveDir.z += 1;
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            moveDir.z -= 1;
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            moveDir.x -= 1;
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            moveDir.x += 1;
            
        // Edge scrolling
        Vector3 mousePos = Input.mousePosition;
        if (mousePos.x <= edgeBorderThickness)
            moveDir.x -= 1;
        if (mousePos.x >= Screen.width - edgeBorderThickness)
            moveDir.x += 1;
        if (mousePos.y <= edgeBorderThickness)
            moveDir.z -= 1;
        if (mousePos.y >= Screen.height - edgeBorderThickness)
            moveDir.z += 1;
            
        // Apply movement
        moveDir.Normalize();
        targetPosition += moveDir * moveSpeed * Time.deltaTime;
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * 10f);
    }
    
    void HandleZoom()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if (scroll != 0)
        {
            targetPosition.y -= scroll * zoomSpeed * Time.deltaTime;
            targetPosition.y = Mathf.Clamp(targetPosition.y, minHeight, maxHeight);
        }
    }
    
    void ClampPosition()
    {
        targetPosition.x = Mathf.Clamp(targetPosition.x, mapBoundsMin.x, mapBoundsMax.x);
        targetPosition.z = Mathf.Clamp(targetPosition.z, mapBoundsMin.y, mapBoundsMax.y);
    }
}
```

## Core Systems Implementation (3 hours)

### 1. Grid System
```csharp
// GridSystem.cs
using UnityEngine;

public class GridSystem : MonoBehaviour
{
    public static GridSystem Instance { get; private set; }
    
    [Header("Grid Configuration")]
    public int gridWidth = 50;
    public int gridHeight = 50;
    public float cellSize = 2f;
    
    [Header("Visuals")]
    public bool showGrid = true;
    public Color gridColor = new Color(1, 1, 1, 0.1f);
    public GameObject gridLinePrefab; // Simple quad stretched thin
    
    private GridCell[,] grid;
    private GameObject gridVisualContainer;
    
    public struct GridCell
    {
        public bool isOccupied;
        public GameObject occupyingBuilding;
        public Vector2Int position;
    }
    
    void Awake()
    {
        Instance = this;
        InitializeGrid();
        if (showGrid) CreateGridVisuals();
    }
    
    void InitializeGrid()
    {
        grid = new GridCell[gridWidth, gridHeight];
        
        for (int x = 0; x < gridWidth; x++)
        {
            for (int z = 0; z < gridHeight; z++)
            {
                grid[x, z] = new GridCell 
                { 
                    position = new Vector2Int(x, z),
                    isOccupied = false,
                    occupyingBuilding = null
                };
            }
        }
    }
    
    public Vector3 GridToWorldPosition(Vector2Int gridPos)
    {
        float x = (gridPos.x - gridWidth / 2f) * cellSize;
        float z = (gridPos.y - gridHeight / 2f) * cellSize;
        return new Vector3(x, 0, z);
    }
    
    public Vector2Int WorldToGridPosition(Vector3 worldPos)
    {
        int x = Mathf.RoundToInt(worldPos.x / cellSize + gridWidth / 2f);
        int z = Mathf.RoundToInt(worldPos.z / cellSize + gridHeight / 2f);
        return new Vector2Int(x, z);
    }
    
    public bool CanPlaceBuilding(Vector2Int gridPos, Vector2Int size)
    {
        // Check bounds
        if (gridPos.x < 0 || gridPos.y < 0 || 
            gridPos.x + size.x > gridWidth || 
            gridPos.y + size.y > gridHeight)
            return false;
            
        // Check occupancy
        for (int x = 0; x < size.x; x++)
        {
            for (int z = 0; z < size.y; z++)
            {
                if (grid[gridPos.x + x, gridPos.y + z].isOccupied)
                    return false;
            }
        }
        
        return true;
    }
    
    public void OccupyCells(Vector2Int gridPos, Vector2Int size, GameObject building)
    {
        for (int x = 0; x < size.x; x++)
        {
            for (int z = 0; z < size.y; z++)
            {
                grid[gridPos.x + x, gridPos.y + z].isOccupied = true;
                grid[gridPos.x + x, gridPos.y + z].occupyingBuilding = building;
            }
        }
    }
    
    public void FreeCells(Vector2Int gridPos, Vector2Int size)
    {
        for (int x = 0; x < size.x; x++)
        {
            for (int z = 0; z < size.y; z++)
            {
                grid[gridPos.x + x, gridPos.y + z].isOccupied = false;
                grid[gridPos.x + x, gridPos.y + z].occupyingBuilding = null;
            }
        }
    }
}
```

### 2. Resource Manager
```csharp
// ResourceManager.cs
using UnityEngine;
using System;
using System.Collections.Generic;

public class ResourceManager : MonoBehaviour
{
    public static ResourceManager Instance { get; private set; }
    
    [Header("Resource Configuration")]
    public List<Resource> resources = new List<Resource>();
    
    [Header("Starting Resources")]
    public int startingMetal = 100;
    public int startingEnergy = 0;
    public int startingCredits = 0;
    public int startingColonists = 2;
    
    // Events
    public static event Action<ResourceType, int> OnResourceChanged;
    
    [Serializable]
    public class Resource
    {
        public ResourceType type;
        public string displayName;
        public Sprite icon;
        public int currentAmount;
        public int maxCapacity;
        public Color displayColor = Color.white;
    }
    
    void Awake()
    {
        Instance = this;
        InitializeResources();
    }
    
    void InitializeResources()
    {
        // Create resource entries
        resources = new List<Resource>
        {
            new Resource 
            { 
                type = ResourceType.Metal, 
                displayName = "Metal",
                currentAmount = startingMetal,
                maxCapacity = 500,
                displayColor = new Color(0.7f, 0.7f, 0.8f)
            },
            new Resource 
            { 
                type = ResourceType.Energy, 
                displayName = "Energy",
                currentAmount = startingEnergy,
                maxCapacity = int.MaxValue, // Energy is flow-based
                displayColor = new Color(0.3f, 0.8f, 1f)
            },
            new Resource 
            { 
                type = ResourceType.Credits, 
                displayName = "Credits",
                currentAmount = startingCredits,
                maxCapacity = int.MaxValue,
                displayColor = new Color(1f, 0.9f, 0.3f)
            },
            new Resource 
            { 
                type = ResourceType.Colonists, 
                displayName = "Colonists",
                currentAmount = startingColonists,
                maxCapacity = 2, // Starts with housing for 2
                displayColor = new Color(0.3f, 1f, 0.3f)
            },
            new Resource 
            { 
                type = ResourceType.Research, 
                displayName = "Research",
                currentAmount = 0,
                maxCapacity = int.MaxValue,
                displayColor = new Color(0.8f, 0.3f, 1f)
            }
        };
    }
    
    public bool CanAfford(ResourceType type, int amount)
    {
        var resource = GetResource(type);
        return resource != null && resource.currentAmount >= amount;
    }
    
    public bool CanAfford(Dictionary<ResourceType, int> costs)
    {
        foreach (var cost in costs)
        {
            if (!CanAfford(cost.Key, cost.Value))
                return false;
        }
        return true;
    }
    
    public void SpendResources(Dictionary<ResourceType, int> costs)
    {
        foreach (var cost in costs)
        {
            ModifyResource(cost.Key, -cost.Value);
        }
    }
    
    public void ModifyResource(ResourceType type, int amount)
    {
        var resource = GetResource(type);
        if (resource != null)
        {
            int oldAmount = resource.currentAmount;
            resource.currentAmount = Mathf.Clamp(
                resource.currentAmount + amount, 
                0, 
                resource.maxCapacity
            );
            
            if (oldAmount != resource.currentAmount)
            {
                OnResourceChanged?.Invoke(type, resource.currentAmount);
            }
        }
    }
    
    public Resource GetResource(ResourceType type)
    {
        return resources.Find(r => r.type == type);
    }
    
    public int GetResourceAmount(ResourceType type)
    {
        var resource = GetResource(type);
        return resource?.currentAmount ?? 0;
    }
    
    public void IncreaseCapacity(ResourceType type, int amount)
    {
        var resource = GetResource(type);
        if (resource != null)
        {
            resource.maxCapacity += amount;
        }
    }
}

public enum ResourceType
{
    Metal,
    Energy,
    Credits,
    Colonists,
    Research
}
```

### 3. Building Data Structure
```csharp
// BuildingData.cs (ScriptableObject)
using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "BuildingData", menuName = "Colony/Building Data")]
public class BuildingData : ScriptableObject
{
    [Header("Basic Info")]
    public string buildingName;
    public string description;
    public GameObject prefab;
    public Sprite icon;
    public BuildingCategory category;
    
    [Header("Grid")]
    public Vector2Int gridSize = Vector2Int.one;
    
    [Header("Costs")]
    public int metalCost;
    public int energyCost;
    public int creditsCost;
    public int researchCost;
    
    [Header("Requirements")]
    public int requiredColonyLevel = 1;
    public BuildingData[] prerequisiteBuildings;
    
    [Header("Production")]
    public ResourceProduction[] resourceProduction;
    public int energyConsumption; // Energy used per minute
    public int colonistsRequired; // Workers needed
    
    [Header("Effects")]
    public int housingCapacity; // For Habitat Pod
    public float raidDamageBonus; // For Armory
    public float raidShieldBonus; // For Shield Generator
    public float raidHealthRegenBonus; // For Medical Bay
    
    [Header("Visuals")]
    public Color buildingTintColor = Color.white;
    public GameObject constructionEffectPrefab;
    public GameObject productionEffectPrefab;
    
    [System.Serializable]
    public class ResourceProduction
    {
        public ResourceType resourceType;
        public int amountPerMinute;
    }
    
    public Dictionary<ResourceType, int> GetCosts()
    {
        var costs = new Dictionary<ResourceType, int>();
        
        if (metalCost > 0) costs[ResourceType.Metal] = metalCost;
        if (energyCost > 0) costs[ResourceType.Energy] = energyCost;
        if (creditsCost > 0) costs[ResourceType.Credits] = creditsCost;
        if (researchCost > 0) costs[ResourceType.Research] = researchCost;
        
        return costs;
    }
}

public enum BuildingCategory
{
    Infrastructure,
    Production,
    Military,
    Research,
    Defense
}
```

### 4. Building System
```csharp
// BuildingSystem.cs
using UnityEngine;
using System.Collections.Generic;

public class BuildingSystem : MonoBehaviour
{
    public static BuildingSystem Instance { get; private set; }
    
    [Header("Configuration")]
    public LayerMask placementCheckMask;
    public Material validPlacementMaterial;
    public Material invalidPlacementMaterial;
    
    [Header("Building Data")]
    public List<BuildingData> availableBuildings;
    
    [Header("Effects")]
    public GameObject placementEffectPrefab;
    public GameObject constructionCompletePrefab;
    
    // Placement state
    private GameObject currentPreview;
    private BuildingData selectedBuilding;
    private bool isPlacing = false;
    private bool canPlace = false;
    
    // Placed buildings
    private List<Building> placedBuildings = new List<Building>();
    
    void Awake()
    {
        Instance = this;
    }
    
    void Update()
    {
        if (isPlacing)
        {
            UpdatePlacementPreview();
            HandlePlacementInput();
        }
    }
    
    public void StartPlacement(BuildingData buildingData)
    {
        // Check if can afford
        if (!ResourceManager.Instance.CanAfford(buildingData.GetCosts()))
        {
            ColonyUIManager.Instance.ShowError("Insufficient resources!");
            return;
        }
        
        // Check requirements
        if (!CheckBuildingRequirements(buildingData))
        {
            ColonyUIManager.Instance.ShowError("Requirements not met!");
            return;
        }
        
        // Start placement
        selectedBuilding = buildingData;
        currentPreview = Instantiate(buildingData.prefab);
        
        // Setup preview
        SetupPreviewMaterials(currentPreview);
        
        // Disable components during preview
        var building = currentPreview.GetComponent<Building>();
        if (building) building.enabled = false;
        
        isPlacing = true;
    }
    
    void UpdatePlacementPreview()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        
        if (Physics.Raycast(ray, out hit, 100f, placementCheckMask))
        {
            // Get grid position
            Vector2Int gridPos = GridSystem.Instance.WorldToGridPosition(hit.point);
            Vector3 worldPos = GridSystem.Instance.GridToWorldPosition(gridPos);
            
            // Update preview position
            currentPreview.transform.position = worldPos;
            
            // Check if can place
            canPlace = GridSystem.Instance.CanPlaceBuilding(gridPos, selectedBuilding.gridSize);
            
            // Update preview material
            UpdatePreviewMaterial(canPlace);
        }
    }
    
    void HandlePlacementInput()
    {
        if (Input.GetMouseButtonDown(0) && canPlace)
        {
            PlaceBuilding();
        }
        else if (Input.GetMouseButtonDown(1) || Input.GetKeyDown(KeyCode.Escape))
        {
            CancelPlacement();
        }
    }
    
    void PlaceBuilding()
    {
        // Get final position
        Vector2Int gridPos = GridSystem.Instance.WorldToGridPosition(currentPreview.transform.position);
        Vector3 worldPos = GridSystem.Instance.GridToWorldPosition(gridPos);
        
        // Spend resources
        ResourceManager.Instance.SpendResources(selectedBuilding.GetCosts());
        
        // Destroy preview
        Destroy(currentPreview);
        
        // Create actual building
        GameObject buildingObj = Instantiate(selectedBuilding.prefab, worldPos, Quaternion.identity);
        buildingObj.transform.SetParent(GameObject.Find("_Dynamic/Buildings").transform);
        
        // Setup building component
        Building building = buildingObj.GetComponent<Building>();
        if (!building) building = buildingObj.AddComponent<Building>();
        
        building.Initialize(selectedBuilding, gridPos);
        placedBuildings.Add(building);
        
        // Update grid
        GridSystem.Instance.OccupyCells(gridPos, selectedBuilding.gridSize, buildingObj);
        
        // Effects
        if (constructionCompletePrefab)
        {
            Instantiate(constructionCompletePrefab, worldPos, Quaternion.identity);
        }
        
        // Audio
        AudioManager.Instance?.PlaySFX(AudioManager.Instance.buildingPlaceSound);
        
        // End placement
        isPlacing = false;
        selectedBuilding = null;
        
        // Update UI
        ColonyUIManager.Instance.RefreshBuildingButtons();
    }
    
    void CancelPlacement()
    {
        if (currentPreview)
        {
            Destroy(currentPreview);
        }
        
        isPlacing = false;
        selectedBuilding = null;
    }
    
    void SetupPreviewMaterials(GameObject preview)
    {
        Renderer[] renderers = preview.GetComponentsInChildren<Renderer>();
        foreach (var renderer in renderers)
        {
            Material[] mats = new Material[renderer.materials.Length];
            for (int i = 0; i < mats.Length; i++)
            {
                mats[i] = validPlacementMaterial;
            }
            renderer.materials = mats;
        }
    }
    
    void UpdatePreviewMaterial(bool valid)
    {
        Material mat = valid ? validPlacementMaterial : invalidPlacementMaterial;
        Renderer[] renderers = currentPreview.GetComponentsInChildren<Renderer>();
        
        foreach (var renderer in renderers)
        {
            Material[] mats = renderer.materials;
            for (int i = 0; i < mats.Length; i++)
            {
                mats[i] = mat;
            }
            renderer.materials = mats;
        }
    }
    
    bool CheckBuildingRequirements(BuildingData data)
    {
        // Check colony level
        if (ColonyManager.Instance.colonyLevel < data.requiredColonyLevel)
            return false;
            
        // Check prerequisites
        foreach (var prereq in data.prerequisiteBuildings)
        {
            if (!HasBuilding(prereq))
                return false;
        }
        
        return true;
    }
    
    bool HasBuilding(BuildingData buildingType)
    {
        return placedBuildings.Exists(b => b.buildingData == buildingType);
    }
    
    public List<Building> GetBuildingsOfType(BuildingData type)
    {
        return placedBuildings.FindAll(b => b.buildingData == type);
    }
    
    public int GetTotalEnergyProduction()
    {
        int total = 0;
        foreach (var building in placedBuildings)
        {
            if (building.isActive)
            {
                foreach (var prod in building.buildingData.resourceProduction)
                {
                    if (prod.resourceType == ResourceType.Energy)
                        total += prod.amountPerMinute;
                }
            }
        }
        return total;
    }
    
    public int GetTotalEnergyConsumption()
    {
        int total = 0;
        foreach (var building in placedBuildings)
        {
            if (building.isActive)
            {
                total += building.buildingData.energyConsumption;
            }
        }
        return total;
    }
}
```

### 5. Building Component
```csharp
// Building.cs
using UnityEngine;
using System.Collections;

public class Building : MonoBehaviour
{
    [Header("Data")]
    public BuildingData buildingData;
    public Vector2Int gridPosition;
    
    [Header("State")]
    public bool isActive = true;
    public bool hasEnoughPower = true;
    public bool hasEnoughWorkers = true;
    
    [Header("Visual")]
    public GameObject[] activationEffects;
    public GameObject noPowerIndicator;
    public Transform effectSpawnPoint;
    
    private float productionTimer = 0f;
    private float productionInterval = 60f; // 1 minute
    
    public void Initialize(BuildingData data, Vector2Int gridPos)
    {
        buildingData = data;
        gridPosition = gridPos;
        
        // Start production
        StartCoroutine(ProductionLoop());
        
        // Apply visual settings
        ApplyVisualSettings();
        
        // Update colony stats
        UpdateColonyStats(true);
    }
    
    void ApplyVisualSettings()
    {
        // Apply tint color
        if (buildingData.buildingTintColor != Color.white)
        {
            Renderer[] renderers = GetComponentsInChildren<Renderer>();
            foreach (var renderer in renderers)
            {
                renderer.material.color = buildingData.buildingTintColor;
            }
        }
        
        // Enable activation effects
        SetActivationEffects(true);
    }
    
    IEnumerator ProductionLoop()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            
            if (isActive && hasEnoughPower && hasEnoughWorkers)
            {
                productionTimer += 1f;
                
                if (productionTimer >= productionInterval)
                {
                    ProduceResources();
                    productionTimer = 0f;
                }
            }
        }
    }
    
    void ProduceResources()
    {
        foreach (var production in buildingData.resourceProduction)
        {
            ResourceManager.Instance.ModifyResource(
                production.resourceType, 
                production.amountPerMinute
            );
            
            // Visual feedback
            if (buildingData.productionEffectPrefab && effectSpawnPoint)
            {
                var effect = Instantiate(
                    buildingData.productionEffectPrefab, 
                    effectSpawnPoint.position, 
                    Quaternion.identity
                );
                Destroy(effect, 2f);
            }
        }
    }
    
    public void UpdatePowerStatus(bool hasPower)
    {
        hasEnoughPower = hasPower;
        
        if (noPowerIndicator)
            noPowerIndicator.SetActive(!hasPower);
            
        SetActivationEffects(hasPower && hasEnoughWorkers);
    }
    
    void SetActivationEffects(bool active)
    {
        foreach (var effect in activationEffects)
        {
            if (effect) effect.SetActive(active);
        }
    }
    
    void UpdateColonyStats(bool adding)
    {
        int multiplier = adding ? 1 : -1;
        
        // Housing capacity
        if (buildingData.housingCapacity > 0)
        {
            ResourceManager.Instance.IncreaseCapacity(
                ResourceType.Colonists, 
                buildingData.housingCapacity * multiplier
            );
        }
        
        // Raid bonuses are handled by RaidManager when loading raid scene
    }
    
    void OnDestroy()
    {
        UpdateColonyStats(false);
    }
}
```

## Colonist System (2 hours)

### 1. Colonist Manager
```csharp
// ColonistManager.cs
using UnityEngine;
using System.Collections.Generic;

public class ColonistManager : MonoBehaviour
{
    public static ColonistManager Instance { get; private set; }
    
    [Header("Configuration")]
    public GameObject colonistPrefab; // Use Bean character
    public Transform colonistContainer;
    public int startingColonists = 2;
    
    [Header("Spawn Settings")]
    public Vector3 spawnAreaCenter = Vector3.zero;
    public float spawnAreaRadius = 10f;
    
    private List<Colonist> colonists = new List<Colonist>();
    private List<Transform> wanderPoints = new List<Transform>();
    
    void Awake()
    {
        Instance = this;
    }
    
    void Start()
    {
        // Generate wander points
        GenerateWanderPoints();
        
        // Spawn initial colonists
        for (int i = 0; i < startingColonists; i++)
        {
            SpawnColonist();
        }
        
        // Subscribe to resource changes
        ResourceManager.OnResourceChanged += OnResourceChanged;
    }
    
    void GenerateWanderPoints()
    {
        // Create points around colony for colonists to wander between
        int pointCount = 20;
        for (int i = 0; i < pointCount; i++)
        {
            GameObject point = new GameObject($"WanderPoint_{i}");
            point.transform.parent = transform;
            
            // Random position within bounds
            float angle = Random.Range(0f, 360f) * Mathf.Deg2Rad;
            float distance = Random.Range(5f, 40f);
            Vector3 pos = new Vector3(
                Mathf.Sin(angle) * distance,
                0,
                Mathf.Cos(angle) * distance
            );
            
            point.transform.position = pos;
            wanderPoints.Add(point.transform);
        }
    }
    
    public void SpawnColonist()
    {
        // Check housing capacity
        var colonistResource = ResourceManager.Instance.GetResource(ResourceType.Colonists);
        if (colonistResource.currentAmount >= colonistResource.maxCapacity)
        {
            Debug.Log("No housing available for new colonist!");
            return;
        }
        
        // Spawn colonist
        Vector3 spawnPos = spawnAreaCenter + Random.insideUnitSphere * spawnAreaRadius;
        spawnPos.y = 0;
        
        GameObject colonistObj = Instantiate(colonistPrefab, spawnPos, Quaternion.identity);
        colonistObj.transform.SetParent(colonistContainer);
        
        // Setup colonist
        Colonist colonist = colonistObj.GetComponent<Colonist>();
        if (!colonist) colonist = colonistObj.AddComponent<Colonist>();
        
        colonist.Initialize($"Colonist_{colonists.Count + 1}", wanderPoints);
        colonists.Add(colonist);
        
        // Update resource count
        ResourceManager.Instance.ModifyResource(ResourceType.Colonists, 1);
    }
    
    void OnResourceChanged(ResourceType type, int newAmount)
    {
        if (type == ResourceType.Colonists)
        {
            // Handle colonist count changes if needed
        }
    }
    
    public List<Colonist> GetIdleColonists()
    {
        return colonists.FindAll(c => c.currentState == ColonistState.Idle);
    }
    
    void OnDestroy()
    {
        ResourceManager.OnResourceChanged -= OnResourceChanged;
    }
}
```

### 2. Colonist Behavior
```csharp
// Colonist.cs
using UnityEngine;
using UnityEngine.AI;
using System.Collections.Generic;

public enum ColonistState
{
    Idle,
    Wandering,
    WorkingAnimation
}

public class Colonist : MonoBehaviour
{
    [Header("Identity")]
    public string colonistName;
    
    [Header("Movement")]
    public float moveSpeed = 3f;
    public float rotationSpeed = 120f;
    
    [Header("State")]
    public ColonistState currentState = ColonistState.Idle;
    
    private NavMeshAgent agent;
    private Animator animator;
    private List<Transform> wanderPoints;
    private Transform currentTarget;
    private float stateTimer = 0f;
    
    public void Initialize(string name, List<Transform> wander)
    {
        colonistName = name;
        wanderPoints = wander;
        
        // Setup components
        agent = GetComponent<NavMeshAgent>();
        if (!agent) agent = gameObject.AddComponent<NavMeshAgent>();
        
        agent.speed = moveSpeed;
        agent.angularSpeed = rotationSpeed;
        agent.stoppingDistance = 0.5f;
        
        animator = GetComponent<Animator>();
        
        // Start behavior
        ChangeState(ColonistState.Idle);
    }
    
    void Update()
    {
        stateTimer += Time.deltaTime;
        
        switch (currentState)
        {
            case ColonistState.Idle:
                UpdateIdle();
                break;
            case ColonistState.Wandering:
                UpdateWandering();
                break;
            case ColonistState.WorkingAnimation:
                UpdateWorking();
                break;
        }
        
        // Update animator
        if (animator)
        {
            animator.SetFloat("Speed", agent.velocity.magnitude);
        }
    }
    
    void UpdateIdle()
    {
        // Wait 2-5 seconds then wander
        if (stateTimer > Random.Range(2f, 5f))
        {
            ChangeState(ColonistState.Wandering);
        }
    }
    
    void UpdateWandering()
    {
        // Check if reached destination
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
        {
            // Chance to "work" at this location
            if (Random.value < 0.3f && IsNearBuilding())
            {
                ChangeState(ColonistState.WorkingAnimation);
            }
            else
            {
                ChangeState(ColonistState.Idle);
            }
        }
    }
    
    void UpdateWorking()
    {
        // Play work animation for 3-6 seconds
        if (stateTimer > Random.Range(3f, 6f))
        {
            ChangeState(ColonistState.Idle);
        }
    }
    
    void ChangeState(ColonistState newState)
    {
        currentState = newState;
        stateTimer = 0f;
        
        switch (newState)
        {
            case ColonistState.Idle:
                agent.isStopped = true;
                if (animator) animator.SetBool("Working", false);
                break;
                
            case ColonistState.Wandering:
                agent.isStopped = false;
                SelectRandomDestination();
                if (animator) animator.SetBool("Working", false);
                break;
                
            case ColonistState.WorkingAnimation:
                agent.isStopped = true;
                if (animator) animator.SetBool("Working", true);
                break;
        }
    }
    
    void SelectRandomDestination()
    {
        if (wanderPoints.Count == 0) return;
        
        // Pick random wander point
        Transform target = wanderPoints[Random.Range(0, wanderPoints.Count)];
        
        // Or sometimes go to a building
        if (Random.value < 0.4f)
        {
            Building[] buildings = FindObjectsOfType<Building>();
            if (buildings.Length > 0)
            {
                Building randomBuilding = buildings[Random.Range(0, buildings.Length)];
                target = randomBuilding.transform;
            }
        }
        
        currentTarget = target;
        agent.SetDestination(target.position);
    }
    
    bool IsNearBuilding()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, 3f);
        foreach (var col in colliders)
        {
            if (col.GetComponent<Building>())
                return true;
        }
        return false;
    }
}
```

## UI Implementation (2 hours)

### 1. Colony UI Manager
```csharp
// ColonyUIManager.cs
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

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
        foreach (var resource in ResourceManager.Instance.resources)
        {
            GameObject display = Instantiate(resourceDisplayPrefab, resourceContainer);
            ResourceDisplay rd = display.GetComponent<ResourceDisplay>();
            rd.Setup(resource);
            resourceDisplays[resource.type] = rd;
        }
    }
    
    void SetupBuildingMenu()
    {
        // Get unique categories
        var categories = new HashSet<BuildingCategory>();
        foreach (var building in BuildingSystem.Instance.availableBuildings)
        {
            categories.Add(building.category);
        }
        
        // Create category tabs
        foreach (var category in categories)
        {
            GameObject tab = Instantiate(categoryTabPrefab, buildingCategoryTabs);
            tab.GetComponentInChildren<Text>().text = category.ToString();
            
            Button button = tab.GetComponent<Button>();
            BuildingCategory cat = category; // Capture for closure
            button.onClick.AddListener(() => ShowBuildingCategory(cat));
        }
        
        // Show first category
        if (categories.Count > 0)
        {
            ShowBuildingCategory(BuildingCategory.Infrastructure);
        }
    }
    
    void ShowBuildingCategory(BuildingCategory category)
    {
        // Clear existing buttons
        foreach (Transform child in buildingButtonContainer)
        {
            Destroy(child.gameObject);
        }
        
        // Create buttons for buildings in category
        foreach (var building in BuildingSystem.Instance.availableBuildings)
        {
            if (building.category == category)
            {
                CreateBuildingButton(building);
            }
        }
    }
    
    void CreateBuildingButton(BuildingData building)
    {
        GameObject button = Instantiate(buildingButtonPrefab, buildingButtonContainer);
        
        // Setup visuals
        button.GetComponentInChildren<Text>().text = building.buildingName;
        Image icon = button.transform.Find("Icon").GetComponent<Image>();
        if (icon && building.icon) icon.sprite = building.icon;
        
        // Cost display
        Text costText = button.transform.Find("Cost").GetComponent<Text>();
        costText.text = $"M:{building.metalCost} E:{building.energyCost}";
        
        // Button functionality
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(() => OnBuildingButtonClicked(building));
        
        // Update interactability
        UpdateBuildingButton(button, building);
    }
    
    void OnBuildingButtonClicked(BuildingData building)
    {
        // Show info
        ShowBuildingInfo(building);
        
        // Start placement
        BuildingSystem.Instance.StartPlacement(building);
    }
    
    void ShowBuildingInfo(BuildingData building)
    {
        buildingInfoPanel.SetActive(true);
        buildingNameText.text = building.buildingName;
        buildingDescriptionText.text = building.description;
    }
    
    public void RefreshBuildingButtons()
    {
        // Refresh current category
        // Implementation depends on tracking current category
    }
    
    void UpdateBuildingButton(GameObject button, BuildingData building)
    {
        Button btn = button.GetComponent<Button>();
        bool canAfford = ResourceManager.Instance.CanAfford(building.GetCosts());
        bool meetsRequirements = ColonyManager.Instance.colonyLevel >= building.requiredColonyLevel;
        
        btn.interactable = canAfford && meetsRequirements;
        
        // Visual feedback
        if (!meetsRequirements)
        {
            button.GetComponent<Image>().color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
        }
        else if (!canAfford)
        {
            button.GetComponent<Image>().color = new Color(1f, 0.5f, 0.5f, 0.8f);
        }
    }
    
    void OnResourceChanged(ResourceType type, int amount)
    {
        if (resourceDisplays.ContainsKey(type))
        {
            resourceDisplays[type].UpdateDisplay(amount);
        }
        
        // Refresh building buttons
        RefreshBuildingButtons();
    }
    
    public void ShowError(string message)
    {
        errorMessageText.text = message;
        errorMessageText.gameObject.SetActive(true);
        CancelInvoke(nameof(HideError));
        Invoke(nameof(HideError), errorMessageDuration);
    }
    
    void HideError()
    {
        errorMessageText.gameObject.SetActive(false);
    }
    
    void UpdateColonyStats()
    {
        // Colony level
        colonyLevelText.text = $"Colony Level: {ColonyManager.Instance.colonyLevel}";
        
        // Power status
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
    
    void OnDestroy()
    {
        ResourceManager.OnResourceChanged -= OnResourceChanged;
    }
}
```

### 2. Resource Display Component
```csharp
// ResourceDisplay.cs
using UnityEngine;
using UnityEngine.UI;

public class ResourceDisplay : MonoBehaviour
{
    public Image iconImage;
    public Text nameText;
    public Text amountText;
    public Image backgroundImage;
    
    private ResourceManager.Resource resource;
    
    public void Setup(ResourceManager.Resource res)
    {
        resource = res;
        
        nameText.text = res.displayName;
        if (res.icon) iconImage.sprite = res.icon;
        backgroundImage.color = res.displayColor * 0.3f;
        
        UpdateDisplay(res.currentAmount);
    }
    
    public void UpdateDisplay(int amount)
    {
        if (resource.maxCapacity == int.MaxValue)
        {
            amountText.text = amount.ToString();
        }
        else
        {
            amountText.text = $"{amount}/{resource.maxCapacity}";
        }
        
        // Color feedback when at capacity
        if (amount >= resource.maxCapacity)
        {
            amountText.color = Color.yellow;
        }
        else
        {
            amountText.color = Color.white;
        }
    }
}
```

## Colony Manager (Main Controller)
```csharp
// ColonyManager.cs
using UnityEngine;
using System.Collections;

public class ColonyManager : MonoBehaviour
{
    public static ColonyManager Instance { get; private set; }
    
    [Header("Colony Stats")]
    public int colonyLevel = 1;
    public float colonyInfluence = 0f;
    
    [Header("Systems")]
    public GridSystem gridSystem;
    public BuildingSystem buildingSystem;
    public ResourceManager resourceManager;
    public ColonistManager colonistManager;
    public ColonyUIManager uiManager;
    
    [Header("Configuration")]
    public float resourceUpdateInterval = 1f;
    public float powerCheckInterval = 5f;
    
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }
    
    void Start()
    {
        // Initialize systems in order
        StartCoroutine(InitializeSystems());
        
        // Start update loops
        StartCoroutine(ResourceUpdateLoop());
        StartCoroutine(PowerCheckLoop());
    }
    
    IEnumerator InitializeSystems()
    {
        // Small delays to ensure proper initialization order
        yield return new WaitForSeconds(0.1f);
        
        // Load any saved colony data
        LoadColonyData();
        
        Debug.Log("Colony Manager initialized!");
    }
    
    IEnumerator ResourceUpdateLoop()
    {
        while (true)
        {
            yield return new WaitForSeconds(resourceUpdateInterval);
            
            // This is handled by individual buildings now
            // But we can add global effects here
        }
    }
    
    IEnumerator PowerCheckLoop()
    {
        while (true)
        {
            yield return new WaitForSeconds(powerCheckInterval);
            
            CheckPowerStatus();
        }
    }
    
    void CheckPowerStatus()
    {
        int production = buildingSystem.GetTotalEnergyProduction();
        int consumption = buildingSystem.GetTotalEnergyConsumption();
        
        bool hasPower = production >= consumption;
        
        // Update all buildings
        foreach (var building in FindObjectsOfType<Building>())
        {
            building.UpdatePowerStatus(hasPower);
        }
        
        // Update UI
        uiManager.UpdateColonyStats();
    }
    
    public void IncreaseColonyLevel()
    {
        colonyLevel++;
        colonyInfluence += 100f;
        
        // Unlock new buildings
        uiManager.RefreshBuildingButtons();
        
        // Celebration effect
        Debug.Log($"Colony reached level {colonyLevel}!");
    }
    
    public ColonySaveData CreateSaveData()
    {
        var saveData = new ColonySaveData();
        
        // Save colony stats
        saveData.colonyLevel = colonyLevel;
        saveData.colonyInfluence = colonyInfluence;
        
        // Save resources
        foreach (var resource in resourceManager.resources)
        {
            saveData.resources.Add(new ColonySaveData.ResourceData
            {
                type = resource.type,
                amount = resource.currentAmount,
                capacity = resource.maxCapacity
            });
        }
        
        // Save buildings
        foreach (var building in FindObjectsOfType<Building>())
        {
            saveData.buildings.Add(new ColonySaveData.BuildingData
            {
                buildingType = building.buildingData.name,
                gridPosition = building.gridPosition,
                isActive = building.isActive
            });
        }
        
        // Save colonist count
        saveData.colonistCount = colonistManager.colonists.Count;
        
        return saveData;
    }
    
    void LoadColonyData()
    {
        // For hackathon, just use PlayerPrefs
        if (PlayerPrefs.HasKey("ColonyLevel"))
        {
            colonyLevel = PlayerPrefs.GetInt("ColonyLevel");
            
            // Load resources
            resourceManager.GetResource(ResourceType.Metal).currentAmount = 
                PlayerPrefs.GetInt("Metal", 100);
            resourceManager.GetResource(ResourceType.Credits).currentAmount = 
                PlayerPrefs.GetInt("Credits", 0);
        }
    }
    
    public void SaveColonyData()
    {
        PlayerPrefs.SetInt("ColonyLevel", colonyLevel);
        PlayerPrefs.SetInt("Metal", resourceManager.GetResourceAmount(ResourceType.Metal));
        PlayerPrefs.SetInt("Credits", resourceManager.GetResourceAmount(ResourceType.Credits));
        PlayerPrefs.Save();
    }
    
    public float CalculateRaidBonus(RaidBonusType type)
    {
        float bonus = 0f;
        
        foreach (var building in FindObjectsOfType<Building>())
        {
            switch (type)
            {
                case RaidBonusType.Damage:
                    bonus += building.buildingData.raidDamageBonus;
                    break;
                case RaidBonusType.Shield:
                    bonus += building.buildingData.raidShieldBonus;
                    break;
                case RaidBonusType.HealthRegen:
                    bonus += building.buildingData.raidHealthRegenBonus;
                    break;
            }
        }
        
        return bonus;
    }
}

public enum RaidBonusType
{
    Damage,
    Shield,
    HealthRegen
}

[System.Serializable]
public class ColonySaveData
{
    public int colonyLevel;
    public float colonyInfluence;
    public List<ResourceData> resources = new List<ResourceData>();
    public List<BuildingData> buildings = new List<BuildingData>();
    public int colonistCount;
    
    [System.Serializable]
    public class ResourceData
    {
        public ResourceType type;
        public int amount;
        public int capacity;
    }
    
    [System.Serializable]
    public class BuildingData
    {
        public string buildingType;
        public Vector2Int gridPosition;
        public bool isActive;
    }
}
```

## Integration Points

### 1. Transition to Raid Scene
```csharp
// In ColonyManager or separate TransitionManager
public void PrepareForRaid()
{
    // Save colony state
    SaveColonyData();
    
    // Calculate and store raid bonuses
    PlayerPrefs.SetFloat("RaidDamageBonus", CalculateRaidBonus(RaidBonusType.Damage));
    PlayerPrefs.SetFloat("RaidShieldBonus", CalculateRaidBonus(RaidBonusType.Shield));
    PlayerPrefs.SetFloat("RaidHealthRegenBonus", CalculateRaidBonus(RaidBonusType.HealthRegen));
    
    // Transition to raid
    GameStateManager.Instance.StartRaid();
}
```

### 2. Return from Raid
```csharp
public void ReturnFromRaid(int creditsEarned)
{
    // Add raid rewards
    resourceManager.ModifyResource(ResourceType.Credits, creditsEarned);
    
    // Check for colony level up
    if (resourceManager.GetResourceAmount(ResourceType.Credits) >= colonyLevel * 100)
    {
        IncreaseColonyLevel();
    }
}
```

## Testing Checklist

1. **Grid System**
   - [ ] Buildings snap to grid correctly
   - [ ] Can't place buildings on occupied cells
   - [ ] Grid bounds work properly

2. **Building System**
   - [ ] All building types place correctly
   - [ ] Resource costs deducted properly
   - [ ] Power system shuts down buildings
   - [ ] Visual effects work

3. **Resource System**
   - [ ] Resources generate at correct rates
   - [ ] UI updates in real-time
   - [ ] Capacity limits work

4. **Colonist System**
   - [ ] Colonists spawn and wander
   - [ ] Animation states work
   - [ ] Don't get stuck

5. **UI System**
   - [ ] All buttons functional
   - [ ] Resource display updates
   - [ ] Error messages show
   - [ ] Building info displays

6. **Save/Load**
   - [ ] Resources persist between scenes
   - [ ] Raid bonuses calculate correctly

## Performance Considerations

1. **Object Pooling**: Implement for effects and colonists if > 20
2. **LOD System**: Reduce detail for distant buildings
3. **Update Intervals**: Stagger system updates to avoid frame drops
4. **UI Optimization**: Only update changed elements

## Next Steps

### Immediate Actions Required:
1. **In Unity Editor:**
   - Use `Tools > Colony > Setup Colony Scene` to create the scene
   - Use `Tools > Colony > Create Default Buildings` to generate building data assets
   
2. **Create Building Prefabs:**
   - Use Simple Space assets for visual models
   - Add Building component to each prefab
   - Set up effect spawn points and visual indicators
   
3. **Create Materials:**
   - Valid placement material (green transparent)
   - Invalid placement material (red transparent)
   
4. **Configure Scene:**
   - Apply Simple Space skybox
   - Set up alien terrain material
   - Configure lighting for sci-fi atmosphere
   
5. **Testing:**
   - Verify building placement works
   - Check resource production/consumption
   - Test power system shutdown
   - Confirm UI updates properly

### Quick Start Guide:
```
1. ✅ COMPLETED: BuildingData assets created successfully via Tools menu
   - CommandCenter, SolarPanel, MetalMine, HabitatPod
   - ResearchLab, DefenseTower, ShieldGenerator, MedicalBay
   - All assets properly configured with costs, production, and requirements

2. Next Step - Create Building Prefabs:
   For each BuildingData asset:
   a. Create empty GameObject
   b. Add visual model from Simple Space assets
   c. Add Building component
   d. Add BoxCollider for placement detection
   e. Create effect spawn points (optional)
   f. Save as prefab in Assets/_Project/Prefabs/Buildings/
   g. Assign prefab reference to BuildingData asset

3. Create Placement Materials:
   a. Create new material: "BuildingPlacementValid"
      - Shader: Universal Render Pipeline/Lit
      - Surface Type: Transparent
      - Base Color: Green with 50% alpha
   b. Create new material: "BuildingPlacementInvalid"
      - Same settings but Red color
   
4. Setup Colony Scene:
   - Use Tools > Colony > Setup Colony Scene
   - Or manually create scene hierarchy (see Scene Setup section)
   - Ensure terrain has "Ground" layer

5. Configure BuildingSystem:
   - Add BuildingSystem component to _Managers/BuildingSystem
   - Drag all 8 BuildingData assets to availableBuildings array
   - Assign placement materials
   - Set placementCheckMask to "Ground" layer

6. Configure Other Systems:
   - ColonyManager: Link all manager references
   - ResourceManager: Verify starting resource values
   - GridSystem: Set grid size (50x50 recommended)
   - ColonistManager: Assign colonist prefab (Bean character)

7. Test Checklist:
   - [ ] Building menu displays all categories
   - [ ] Buildings snap to grid when placing
   - [ ] Preview changes color (green/red) based on validity
   - [ ] Resources deduct on placement
   - [ ] Power system affects building operation
   - [ ] Colonists spawn and wander
   - [ ] UI updates in real-time
```

### ⚠️ Important Implementation Notes:
- BuildingDataCreator now includes directory creation and error handling
- All BuildingData assets use the updated script with proper namespace
- Defense category (value 4) exists in enum for military buildings
- Remember to assign prefabs to BuildingData assets after creating them

### Integration Notes:
- **BuildingUI.cs** requires adapter to work with new BuildingSystem API
- **UIManager.cs** resource display needs migration to ResourceType enum
- Colony systems use `SpaceColonyRPG.Colony` namespace
- Legacy UI systems may need compatibility layer

## Development Notes

### Key Features Implemented:
- **Grid-based building system** with visual preview
- **Resource economy** with 5 resource types
- **Power management** - buildings shut down without sufficient energy
- **Colonist AI** that wanders and "works" at buildings
- **Building prerequisites** and colony level requirements
- **Raid bonuses** from buildings (damage, shield, health regen)
- **Save/Load** using PlayerPrefs for hackathon

### Architecture Highlights:
- **Singleton pattern** for manager classes
- **Event-driven** resource updates
- **ScriptableObject** based building definitions
- **Coroutine-based** production loops
- **State machine** for colonist AI

### Performance Optimizations:
- Grid-based placement reduces physics checks
- Staggered update intervals for different systems
- UI only updates on resource changes
- Simple colonist AI with minimal pathfinding

This implementation provides a solid foundation that can be expanded post-hackathon with more complex systems like detailed colonist needs, supply chains, or colony events.