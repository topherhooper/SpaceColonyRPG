Based on the hackathon plan and development guides, here's a comprehensive scene development plan for programmatically creating the required scenes:

# Scene Development Plan for Space Colony RPG

## Scene Structure Overview

The project requires 3 main scenes:
1. **MainMenu** - Entry point with game start/join options
2. **Colony** - Single-player colony building and management
3. **Raid** - Multiplayer cooperative combat

## Scene 1: MainMenu Scene

### Scene Hierarchy Structure
```
MainMenu
├── Main Camera
├── EventSystem
├── Canvas (Screen Space - Overlay)
│   ├── Background (Full screen image/panel)
│   ├── Title Panel
│   │   ├── Game Title Text ("Space Colony Defender")
│   │   └── Version Text ("v0.1 Prototype")
│   ├── Main Menu Panel
│   │   ├── Solo Colony Button
│   │   ├── Join Raid Button
│   │   ├── Host Raid Button
│   │   ├── Settings Button
│   │   └── Quit Button
│   ├── Join Raid Panel (Initially inactive)
│   │   ├── IP Input Field
│   │   ├── Connect Button
│   │   └── Back Button
│   └── Settings Panel (Initially inactive)
│       ├── Volume Slider
│       ├── Graphics Quality Dropdown
│       └── Back Button
├── NetworkManager (GameObject)
│   └── GameNetworkManager (Script)
└── AudioSource (Background Music)
```

### Programmatic Setup Instructions

1. **Camera Configuration**
   - Position: (0, 0, -10)
   - Clear Flags: Solid Color
   - Background Color: Dark space blue (#001030)

2. **UI Canvas Setup**
   - Render Mode: Screen Space - Overlay
   - UI Scale Mode: Scale With Screen Size
   - Reference Resolution: 1920x1080

3. **Button Positioning** (Anchored to center)
   - Solo Colony: (0, 50)
   - Join Raid: (0, -10)
   - Host Raid: (0, -70)
   - Settings: (0, -130)
   - Quit: (0, -190)

4. **Network Manager Configuration**
   - Add NetworkManager component
   - Set Network Info > Network Address: "localhost"
   - Set Max Connections: 6

## Scene 2: Colony Scene

### Scene Hierarchy Structure
```
Colony
├── Directional Light (Sun)
├── Main Camera
├── Colony Manager
│   ├── BuildingSystem
│   ├── ColonistManager
│   ├── ResourceManager
│   └── SaveManager
├── Environment
│   ├── Terrain (100x100 flat plane)
│   ├── Grid Visual (Optional grid overlay)
│   └── Skybox Volume
├── UI Canvas
│   ├── Colony HUD
│   │   ├── Resource Panel (Top)
│   │   │   ├── Metal Display
│   │   │   ├── Energy Display
│   │   │   └── Food Display
│   │   ├── Building Panel (Bottom)
│   │   │   ├── Generator Button [1]
│   │   │   ├── Barracks Button [2]
│   │   │   └── Storage Button [3]
│   │   ├── Colonist Info Panel
│   │   └── Raid Prep Button
│   └── Building Ghost (Initially inactive)
├── Colonist Spawn Points
│   ├── Spawn Point 1
│   ├── Spawn Point 2
│   └── Spawn Point 3
└── Post Process Volume
```

### Programmatic Setup Instructions

1. **Terrain Creation**
   - Create flat terrain or plane (100x100 units)
   - Position at (0, 0, 0)
   - Add grid material with 2x2 unit squares
   - Layer: "Ground" (Layer 8)

2. **Camera Setup**
   - Position: (0, 20, -10)
   - Rotation: (45, 0, 0) for isometric view
   - Projection: Perspective
   - Field of View: 60

3. **Lighting Configuration**
   - Directional Light rotation: (50, -30, 0)
   - Intensity: 1.2
   - Color: Warm white (#FFF8E7)

4. **UI Layout**
   - Resource Panel: Anchor Top, Height 60px
   - Building Panel: Anchor Bottom, Height 100px
   - Each building button: 80x80 pixels with 10px spacing

5. **Colony Manager Setup**
   - Create empty GameObject "Colony Manager"
   - Add all manager scripts as components
   - Set up singleton references

## Scene 3: Raid Scene

### Scene Hierarchy Structure
```
Raid
├── Directional Light
├── Network Manager
├── Raid Manager
│   ├── Wave Spawner
│   ├── Objective Manager
│   └── Loot Manager
├── Environment
│   ├── Combat Arena
│   │   ├── Ground (200x200 plane)
│   │   ├── Boundaries (Invisible walls)
│   │   └── Cover Objects (Scattered rocks/debris)
│   ├── Enemy Spawn Points
│   │   ├── North Spawner
│   │   ├── East Spawner
│   │   ├── South Spawner
│   │   └── West Spawner
│   └── Player Spawn Area
│       ├── Spawn Point 1
│       ├── Spawn Point 2
│       ├── Spawn Point 3
│       ├── Spawn Point 4
│       ├── Spawn Point 5
│       └── Spawn Point 6
├── UI Canvas
│   ├── Raid HUD
│   │   ├── Timer Display (Top Center)
│   │   ├── Objective Panel (Top Left)
│   │   ├── Enemy Counter (Top Right)
│   │   ├── Player Health Bar (Bottom Left)
│   │   ├── Ammo Display (Bottom Right)
│   │   └── Team Status Panel (Left Side)
│   └── Victory/Defeat Panel (Initially inactive)
├── Audio Manager
└── Post Process Volume
```

### Programmatic Setup Instructions

1. **Arena Setup**
   - Ground plane: 200x200 units
   - Boundary walls: 4 invisible box colliders at edges
   - Height: 10 units, positioned at arena perimeter

2. **Spawn Point Configuration**
   - Player spawns: Circle formation, radius 5 units from center
   - Enemy spawns: 50 units from center at cardinal directions
   - All spawn points at Y = 1 (above ground)

3. **Lighting for Combat**
   - Directional Light rotation: (30, 0, 0)
   - Intensity: 0.8 (darker for atmosphere)
   - Add point lights at key locations for visibility

4. **Network Setup**
   - NetworkManager configured for client-server
   - Spawn player prefab at random spawn point
   - Register enemy prefabs for network spawning

5. **UI Configuration**
   - Timer: Large text, top center, "MM:SS" format
   - Enemy counter: "Enemies: X/Y" format
   - Health bar: 300x30 pixels, red fill
   - Team panel: Vertical list showing connected players

## Common Elements Across Scenes

### Prefab Requirements
Create these prefabs to be used across scenes:

1. **Player Prefab**
   - NetworkIdentity component
   - NetworkTransform component
   - PlayerController script
   - CombatStats script
   - Capsule collider
   - Basic mesh/model

2. **Enemy Prefab**
   - NetworkIdentity (server only)
   - SimpleEnemy script
   - CombatStats script
   - NavMeshAgent
   - Capsule collider

3. **Building Prefabs** (3 types)
   - Building script
   - Box collider
   - Construction visual states
   - Resource cost data

4. **Colonist Prefab**
   - Colonist script
   - NavMeshAgent
   - Capsule collider
   - State indicator

### Scene Transition Logic

1. **MainMenu → Colony**
   - Save selected game mode
   - Load Colony scene
   - Initialize resource values
   - Spawn initial colonists

2. **Colony → Raid**
   - Save colony state to PlayerPrefs/file
   - Store player stats and upgrades
   - Load Raid scene
   - Apply colony bonuses to player

3. **Raid → Colony**
   - Calculate raid rewards
   - Store loot gained
   - Load Colony scene
   - Apply rewards and update resources

## Performance Considerations

1. **LOD Setup**
   - Set up LOD groups for complex models
   - Reduce polygon count at distance
   - Disable shadows for distant objects

2. **Occlusion Culling**
   - Bake occlusion data for Colony scene
   - Use frustum culling for Raid scene

3. **Lighting Optimization**
   - Bake lighting for Colony scene
   - Use real-time lighting for Raid scene
   - Limit real-time shadows to important objects

## Testing Configurations

1. **Single Player Testing**
   - MainMenu: Start with "Solo Colony" flow
   - Colony: Spawn with debug resources (1000 each)
   - Raid: Auto-host and spawn test enemies

2. **Multiplayer Testing**
   - Use ParrelSync for local testing
   - Configure one instance as host
   - Configure second instance as client
   - Test scene transitions maintain connection

---

# IMPLEMENTATION NOTES (Updated 2025-07-13)

## Current Status (Updated 2025-07-13 - Latest)

### ✅ What's Working:
1. **Scene Generation**
   - All 3 scenes (MainMenu, ColonyScene, RaidScene) generate correctly
   - Scenes are properly added to build settings
   - Scene files exist at correct paths

2. **Visual Elements**
   - Buttons look great with enhanced visual feedback:
     - Dark blue normal state (0.2, 0.3, 0.4)
     - Light blue hover state (0.3, 0.5, 0.7)
     - Darker blue pressed state (0.1, 0.2, 0.3)
     - Outline and shadow effects working
   - UI layout is correct
   - EventSystem updated to use InputSystemUIInputModule

3. **Compilation**
   - No compilation errors
   - All scripts compile successfully
   - Mirror networking components properly configured

### ❌ What's NOT Working:
1. **Button Functionality**
   - "Solo Colony" button does nothing when clicked
   - Debug logs from button clicks are not appearing in console
   - No error messages when clicking buttons

2. **Scene Loading**
   - SceneManager.LoadScene("ColonyScene") appears to not execute
   - No scene transition occurs

### 🔍 Debugging Attempts:
1. Added extensive logging to:
   - UIManager.StartSoloColony() 
   - GameNetworkManager.StartSoloColony()
   - Button click handlers in SceneGenerator
   
2. Verified:
   - ColonyScene exists in build settings (index 1)
   - GameNetworkManager has Instance singleton
   - UIManager has Instance singleton
   - NetworkManager has KcpTransport component

3. Button connection uses reflection:
   ```csharp
   System.Reflection.MethodInfo method = typeof(UIManager).GetMethod(methodName);
   method.Invoke(UIManager.Instance, null);
   ```

### 🐛 Possible Issues:
1. **Button OnClick Not Firing**
   - The onClick listeners might not be properly serialized when scene is saved
   - Reflection-based method invocation might be failing silently

2. **Unity Editor vs Runtime**
   - Button clicks might work differently in editor vs play mode
   - Scene loading might be blocked in editor

3. **Event System Issue**
   - InputSystemUIInputModule might not be properly configured
   - Mouse clicks might not be registering

### 📋 Next Steps to Try:
1. **Direct Button Assignment**
   - Instead of reflection, try direct method assignment
   - Create a MenuController script that directly references methods

2. **Manual Testing**
   - Open MainMenu scene
   - Check button onClick events in Inspector
   - Manually assign UIManager methods to buttons

3. **Alternative Approach**
   - Create a simple test button that just logs "Hello"
   - Verify basic button functionality works

### 🔧 Code Snippets for Manual Fix:

#### Option 1: Manual Inspector Assignment
1. Open MainMenu scene
2. Select Canvas > MainMenuPanel > SoloColonyButton
3. In Button component, under OnClick():
   - Drag Canvas GameObject to object field
   - Select UIManager > StartSoloColony from dropdown

#### Option 2: Create MenuController.cs
```csharp
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    [Header("Buttons")]
    public Button soloColonyButton;
    public Button joinRaidButton;
    public Button hostRaidButton;
    public Button settingsButton;
    public Button quitButton;
    
    void Start()
    {
        // Direct assignment without reflection
        soloColonyButton?.onClick.AddListener(() => {
            Debug.Log("Solo Colony clicked!");
            UIManager.Instance?.StartSoloColony();
        });
        
        joinRaidButton?.onClick.AddListener(() => {
            UIManager.Instance?.ShowJoinRaidPanel();
        });
        
        hostRaidButton?.onClick.AddListener(() => {
            UIManager.Instance?.HostRaid();
        });
        
        settingsButton?.onClick.AddListener(() => {
            UIManager.Instance?.ShowSettingsPanel();
        });
        
        quitButton?.onClick.AddListener(() => {
            UIManager.Instance?.QuitGame();
        });
    }
}
```

#### Option 3: Modify SceneGenerator to Not Use Reflection
Replace the CreateMenuButton method to use UnityEvent.AddListener with captured variables instead of reflection.

---

## What Was Actually Implemented

### Key Files Created/Modified

1. **Scene Generation Scripts**
   - `Assets/_Project/Scripts/Editor/SceneGenerator.cs` - Complete scene generation with full UI hierarchy
   - `Assets/_Project/Scripts/Editor/MaterialGenerator.cs` - Basic material creation for prefabs
   - `Assets/_Project/Scripts/Editor/SetupAutomation.cs` - One-click complete project setup

2. **Updated Networking**
   - `Assets/_Project/Scripts/Networking/GameNetworkManager.cs` - Full Mirror networking implementation
   - Added NetworkPlayer class for player tracking
   - Fixed Mirror API changes (NetworkTransformReliable/Unreliable)

3. **UI System Updates**
   - `Assets/_Project/Scripts/UI/UIManager.cs` - Added missing panels and navigation methods
   - Added menu methods: StartSoloColony(), HostRaid(), JoinRaid(), etc.
   - Fixed all UI references for scene generation

4. **Manager Updates**
   - `Assets/_Project/Scripts/Combat/RaidManager.cs` - Added singleton Instance
   - Fixed compilation errors with proper method signatures

### Key Changes from Original Plan

1. **ColonistManager removed** - Doesn't exist as separate component, functionality is in ColonyManager
2. **SaveManager removed from scene** - It's a static class, not a component
3. **NetworkTransform changes** - Mirror now uses NetworkTransformReliable/NetworkTransformUnreliable
4. **BuildingSystem API** - Uses StartPlacement() instead of SelectBuilding()

### How to Run and Test

#### 1. Quick Setup (WSL Command Line)
```bash
# Navigate to project
cd /mnt/c/Users/hoope/Projects/UnityProjects/SpaceColonyRPG

# Check compilation
./compile-check.sh

# Run complete setup (creates all scenes, prefabs, materials)
./build-wsl.sh setup

# Build executable
./build-wsl.sh build
```

#### 2. Manual Setup (In Unity Editor)
1. Open Unity Hub and load the project
2. From menu bar: **SpaceColony > Run Complete Setup**
   - This creates all directories, materials, scenes, and prefabs
3. Open MainMenu scene from `Assets/_Project/Scenes/`
4. Assign prefabs to GameNetworkManager:
   - Player Prefab
   - Enemy Prefab
   - Building Prefabs (3)
   - Colonist Prefab
   - Loot Pickup Prefab

#### 3. Testing Scenes

**MainMenu Scene Testing:**
- Press Play
- Test "Solo Colony" button → Should load ColonyScene
- Test "Host Raid" → Should start Mirror host
- Test "Join Raid" → Should show IP input panel
- Test "Settings" → Should show settings panel

**Colony Scene Testing:**
- Resources should display at top (Metal: 100, Energy: 50, Food: 25)
- Building buttons at bottom should trigger BuildingSystem.StartPlacement()
- "Prepare for Raid" button should be visible

**Raid Scene Testing:**
- Timer should show "05:00"
- Health bar should be visible at bottom left
- Enemy counter at top right
- 6 player spawn points in circle formation
- 4 enemy spawn points at cardinal directions

### Current Build Status

✅ **All compilation errors fixed**
- Fixed Mirror API changes
- Added missing singleton instances
- Created all missing components
- Proper method signatures throughout

✅ **Build System Working**
- WSL build scripts configured for Unity 6000.1.11f1
- Compilation check script for quick validation
- Windows build output to `Builds/Windows/SpaceColonyRPG.exe`

### Known Issues and Solutions

1. **Unity Instance Running**
   - Error: "Another Unity instance is running"
   - Solution: Close Unity Editor before running command-line builds

2. **Material References**
   - Materials may not auto-assign to prefabs
   - Solution: Run MaterialGenerator then reassign in prefabs

3. **Network Prefab Assignment**
   - NetworkManager needs manual prefab assignment
   - Solution: After setup, drag prefabs to NetworkManager slots

### Next Steps for Testing

1. **Verify Scene Generation**
   ```bash
   # Run setup to generate all scenes
   ./build-wsl.sh setup
   ```

2. **Test Each Scene**
   - Open each scene in Unity
   - Verify hierarchy matches plan
   - Test UI interactions
   - Check manager components

3. **Network Testing**
   - Build project
   - Run two instances
   - Test host/join functionality
   - Verify scene transitions

4. **Prefab Testing**
   - Verify all prefabs have correct components
   - Test spawning in play mode
   - Check network synchronization

This implementation provides a complete, programmatically generated scene structure that matches the original plan with necessary adjustments for the actual codebase constraints.