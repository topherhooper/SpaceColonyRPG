# Colony Scene Integration Guide

## Quick Implementation Steps

### Step 1: Environment Setup (5 minutes)

1. **Create Alien Materials**
   - Go to `Tools > Colony > Create Alien Materials`
   - This creates 5 materials in `Assets/_Project/Materials/Environment/`
   - Materials: AlienGround, AlienRock, EnergyCrystal, AlienVegetation, AlienMetal

2. **Add Environment Controller**
   ```
   GameObject > Create Empty > Name it "EnvironmentController"
   Add Component > ColonyEnvironmentSetup
   ```
   
3. **Configure Environment Prefabs**
   - Rock Prefabs: Drag any rock models from SimpleLowPolyNature
   - Tree Prefabs: Drag dead trees or mushrooms for alien look
   - Crystal Prefabs: Leave empty (will auto-generate) or create using EnergyCrystalPrefab
   - Apply alien materials to prefabs

4. **Add Skybox Controller**
   ```
   GameObject > Create Empty > Name it "SkyboxController"
   Add Component > SpaceSkyboxController
   ```

5. **Test Environment**
   - Enter Play Mode - environment should auto-populate
   - Or right-click ColonyEnvironmentSetup > "Populate Environment"

### Step 2: Fix UI System (10 minutes)

1. **Create UI Prefabs**
   - Go to `Tools > Colony > Setup UI Prefabs`
   - Click each button to create:
     - ResourceDisplay.prefab
     - BuildingButton.prefab  
     - CategoryTab.prefab

2. **Create UI Hierarchy**
   - Click "Setup Complete Colony UI" button
   - This creates the Canvas and all panels

3. **UI Manager Update Complete**
   - ColonyUIManager has been replaced with the fixed version
   - The improved version includes proper null checking and button functionality
   - No further action needed - just assign references in Unity

4. **Wire Up References**
   On ColonyUIManager, assign:
   ```
   UI Panels:
   - Main Panel: Canvas/MainPanel
   - Building Panel: Canvas/BuildingPanel
   - Building Info Panel: Create or find existing
   - Error Message Panel: Canvas/ErrorMessagePanel
   
   Resource Display:
   - Container: MainPanel/ResourceBar
   - Prefab: ResourceDisplay.prefab
   
   Building Menu:
   - Category Tabs: BuildingPanel/CategoryTabs
   - Button Container: BuildingPanel/BuildingGrid
   - Tab Prefab: CategoryTab.prefab
   - Button Prefab: BuildingButton.prefab
   
   Main Buttons:
   - Open Build Menu: MainPanel/OpenBuildMenuButton
   - Close Build Menu: BuildingPanel/CloseButton
   - Prepare Raid: MainPanel/PrepareRaidButton
   ```

### Step 3: Building Prefabs (15 minutes)

1. **Create Building Prefabs**
   For each BuildingData asset in `ScriptableObjects/Buildings/`:
   ```
   - Create Empty GameObject
   - Add visual model (cube, cylinder, etc)
   - Apply alien materials
   - Add Building component
   - Add BoxCollider
   - Save as Prefab in Assets/_Project/Prefabs/Buildings/
   ```

2. **Example Building Setup**
   ```
   CommandCenter:
   - Model: Large cube (3x3x3)
   - Material: AlienMetal
   - Add antenna/dish on top
   
   SolarPanel:
   - Model: Flat plane with frame
   - Material: EnergyCrystal (for glow)
   - Tilt at angle
   
   MetalMine:
   - Model: Cylinder with drill
   - Material: AlienRock
   - Add particle effect
   ```

3. **Assign Prefabs to Data**
   - Select each BuildingData asset
   - Drag corresponding prefab to "Prefab" field

### Step 4: System Configuration (5 minutes)

1. **BuildingSystem Setup**
   ```
   Find BuildingSystem GameObject
   - Available Buildings: Drag all 8 BuildingData assets
   - Valid Placement Material: Create green transparent
   - Invalid Placement Material: Create red transparent
   - Placement Check Mask: Ground
   ```

2. **Create Placement Materials**
   ```
   Right-click in Project > Create > Material
   Name: BuildingPlacementValid
   - Shader: Universal Render Pipeline/Lit
   - Surface Type: Transparent
   - Base Map Color: Green, Alpha 0.5
   
   Duplicate and rename: BuildingPlacementInvalid
   - Base Map Color: Red, Alpha 0.5
   ```

3. **Colony Manager Links**
   Ensure all manager references are connected:
   - Grid System
   - Building System
   - Resource Manager
   - Colonist Manager
   - UI Manager (use Fixed version)

### Step 5: Testing Checklist

#### Environment
- [ ] Alien terrain visible with purple tint
- [ ] Rocks scattered around scene
- [ ] Alien vegetation placed
- [ ] Energy crystals glowing
- [ ] Skybox has alien atmosphere
- [ ] Dust particles floating

#### UI Functionality  
- [ ] Build Menu button opens panel
- [ ] Category tabs switch content
- [ ] Building buttons show info on click
- [ ] Start Placement begins preview
- [ ] Resources display updates
- [ ] Power bar shows production/consumption

#### Building System
- [ ] Preview snaps to grid
- [ ] Preview changes color (red/green)
- [ ] Can place with left click
- [ ] Can cancel with right click/ESC
- [ ] Resources deduct on placement
- [ ] Buildings appear in world

## Troubleshooting

### Common Issues

1. **"NullReferenceException" in UI**
   - Check all UI references are assigned
   - Ensure prefabs exist in project
   - Verify Canvas hierarchy matches expected structure

2. **Buildings not placing**
   - Check Ground layer on terrain
   - Verify placement materials assigned
   - Ensure BuildingData has prefab assigned

3. **Environment not populating**
   - Check prefab arrays have items
   - Verify materials were created
   - Try manual "Populate Environment" context menu

4. **UI Buttons not responding**
   - Check EventSystem exists in scene
   - Verify button references assigned
   - Check Canvas has GraphicRaycaster

### Quick Fixes

**Reset Everything:**
```
1. Delete Canvas
2. Tools > Colony > Setup UI Prefabs
3. Click "Setup Complete Colony UI"
4. Reassign all references
```

**Force Refresh:**
```
1. Right-click ColonyEnvironmentSetup > Populate Environment
2. Right-click SpaceSkyboxController > Apply Atmosphere Settings
3. Enter/Exit Play Mode
```

## Next Steps

Once basic setup is working:

1. **Customize Buildings**
   - Add unique models for each type
   - Create construction effects
   - Add production particles

2. **Enhance Environment**
   - Add more prop variety
   - Create biomes/regions
   - Add ambient sounds

3. **Polish UI**
   - Custom UI sprites
   - Animation on buttons
   - Better visual feedback

4. **Integrate Systems**
   - Connect to save system
   - Link raid bonuses
   - Add colony progression

## Script Locations

- **Environment:** `Assets/_Project/Scripts/Colony/`
  - ColonyEnvironmentSetup.cs
  - SpaceSkyboxController.cs
  - EnergyCrystalPrefab.cs

- **UI:** `Assets/_Project/Scripts/Colony/`
  - ColonyUIManager.cs (replaced with fixed version)

- **Editor Tools:** `Assets/_Project/Scripts/Editor/`
  - AlienMaterialCreator.cs
  - UISetupHelper.cs
  - BuildingDataCreator.cs

Remember to test frequently and save your scene!