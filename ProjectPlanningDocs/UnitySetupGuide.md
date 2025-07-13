# Unity Setup Guide - Space Colony RPG

## Required Unity Packages

1. **Mirror Networking** (Already imported based on file structure)
2. **TextMeshPro** (Import when Unity prompts)
3. **Post Processing** (Optional but recommended)
4. **NavMesh Components** (For enemy AI)

## Step-by-Step Scene Setup

### 1. Main Menu Scene

```
MainMenu
├── Main Camera
├── EventSystem
├── GameManagers
│   ├── GameStateManager
│   ├── ResourceManager
│   ├── ColonyUpgrades
│   └── AudioManager
└── Canvas
    └── MainMenuPanel
        ├── Title Text ("Space Colony RPG")
        ├── NewGameButton
        ├── ContinueButton (grayed out if no save)
        └── QuitButton
```

**Component Setup:**
- GameStateManager: Attach GameStateManager.cs
- ResourceManager: Attach ResourceManager.cs
- ColonyUpgrades: Attach ColonyUpgrades.cs
- AudioManager: Attach AudioManager.cs
- Add UIManager to Canvas, assign panel references

### 2. Colony Scene

```
ColonyScene
├── Main Camera (top-down view)
├── Directional Light
├── Environment
│   ├── Terrain/Ground (Layer: Ground)
│   └── Skybox
├── GameManagers
│   ├── BuildingSystem
│   └── GameNetworkManager
├── UI
│   └── Canvas
│       ├── ColonyHUD
│       │   ├── ResourcePanel
│       │   │   ├── MetalText
│       │   │   ├── EnergyText
│       │   │   └── FoodText
│       │   ├── BuildModeIndicator
│       │   └── RaidButton
│       └── BuildingPanel (hidden by default)
└── SpawnPoints
    ├── ColonistSpawn1
    ├── ColonistSpawn2
    └── ColonistSpawn3
```

**Component Setup:**
- Ground: Layer = "Ground", Add MeshCollider
- BuildingSystem: Attach BuildingSystem.cs, assign building prefabs
- Canvas: Add UIManager component, assign all UI references

### 3. Raid Scene

```
RaidScene
├── Main Camera
├── Directional Light (darker for atmosphere)
├── Environment
│   ├── RaidTerrain
│   └── CombatArena
├── GameManagers
│   ├── GameNetworkManager
│   └── RaidManager
├── NetworkStartPositions
│   ├── SpawnPoint1
│   └── SpawnPoint2
├── EnemySpawnPoints
│   ├── EnemySpawn1
│   ├── EnemySpawn2
│   └── EnemySpawn3
└── UI
    └── Canvas
        └── RaidHUD
            ├── TimerText
            ├── EnemiesText
            ├── HealthBar
            ├── XPBar
            └── GameOverPanel
```

## Prefab Creation Guide

### Player Prefab

1. Create empty GameObject "Player"
2. Add Components:
   - **NetworkIdentity** (check "Local Player Authority")
   - **NetworkTransform**
   - **CharacterController** (or Rigidbody + Collider)
   - **PlayerController** script
   - **CombatStats** script
   - **Weapon** script
   - **PlayerProgression** script

3. Child Objects:
   ```
   Player
   ├── Model (Capsule or imported model)
   └── FirePoint (empty, positioned at gun tip)
   ```

4. Settings:
   - Tag: "Player"
   - Layer: "Player"
   - CharacterController: Height = 2, Radius = 0.5

### Enemy Prefab

1. Create empty GameObject "Enemy"
2. Add Components:
   - **NetworkIdentity**
   - **NetworkTransform**
   - **NavMeshAgent**
   - **CapsuleCollider**
   - **SimpleEnemy** script
   - **CombatStats** script
   - **LootDrop** script

3. Settings:
   - Tag: "Enemy"
   - Layer: "Enemy"
   - NavMeshAgent: Speed = 3, Stopping Distance = 2

### Projectile Prefab

1. Create empty GameObject "Projectile"
2. Add Components:
   - **NetworkIdentity**
   - **NetworkTransform**
   - **Rigidbody** (Use Gravity = false)
   - **SphereCollider** (Is Trigger = true)
   - **Projectile** script
   - **TrailRenderer** (optional)

3. Settings:
   - Layer: "Projectile"
   - Rigidbody: Mass = 0.1, Drag = 0

### Building Prefabs (Generator Example)

1. Create empty GameObject "Generator"
2. Add Components:
   - **Building** script
   - **BoxCollider**

3. Child Objects:
   ```
   Generator
   ├── Model (Cube scaled to 2x3x2)
   ├── ConstructionSite
   │   └── ConstructionModel (semi-transparent)
   └── WorkPosition (empty GameObject)
   ```

4. Building Script Settings:
   - Building Name: "Generator"
   - Metal Cost: 50
   - Energy Cost: 0
   - Is Producer: true
   - Produced Resource: "Energy"
   - Production Amount: 5

### Colonist Prefab

1. Create empty GameObject "Colonist"
2. Add Components:
   - **NavMeshAgent**
   - **CapsuleCollider**
   - **Colonist** script

3. Settings:
   - Tag: "Colonist"
   - NavMeshAgent: Speed = 3

### LootPickup Prefab

1. Create empty GameObject "LootPickup"
2. Add Components:
   - **NetworkIdentity**
   - **SphereCollider** (Is Trigger = true, Radius = 2)
   - **LootPickup** script
   - **Rigidbody** (for drop physics)

3. Visual:
   - Add a rotating cube or sphere as child
   - Add particle effect for sparkle

## Layer Setup (Edit > Project Settings > Tags and Layers)

```
Layers:
8: Ground
9: Building
10: Enemy
11: Player
12: Projectile
```

## Physics Collision Matrix (Edit > Project Settings > Physics)

Disable collisions between:
- Projectile ↔ Projectile
- Building ↔ Building
- Player ↔ Player

## Build Settings Setup

1. File > Build Settings
2. Add Scenes in order:
   - MainMenu
   - ColonyScene
   - RaidScene

3. Player Settings:
   - Product Name: "Space Colony RPG"
   - Company Name: Your name
   - Default Icon: (optional)

## Mirror Network Manager Setup

1. In ColonyScene and RaidScene, add GameNetworkManager prefab
2. Inspector settings:
   - Network Address: localhost
   - Player Prefab: Drag Player prefab
   - Auto Create Player: true
   - Player Spawn Method: Round Robin
   - Registered Spawnable Prefabs: Add Enemy, Projectile, LootPickup

## Testing Setup

### Quick Test Buttons (Editor Only)

Create TestSceneSetup buttons:
1. "Spawn Test Enemy" - Spawns enemy at camera position
2. "Add Resources" - Adds 1000 of each resource
3. "Level Up" - Adds XP to player
4. "Toggle God Mode" - Makes player invincible

### Debug Display

Add debug text to show:
- Current FPS
- Network latency
- Active enemy count
- Resource generation rate

## Common Issues & Solutions

1. **"NetworkBehaviour not found"**
   - Ensure Mirror is imported
   - Check script has `using Mirror;`

2. **Buildings won't place**
   - Check ground has "Ground" layer
   - Ensure BuildingSystem has prefabs assigned

3. **Enemies don't move**
   - Bake NavMesh (Window > AI > Navigation)
   - Ensure enemy has NavMeshAgent

4. **Projectiles pass through enemies**
   - Check collision matrix
   - Ensure IsTrigger is true on projectile
   - Verify enemy has collider

5. **UI not updating**
   - Check UIManager references
   - Ensure UIManager.Instance exists
   - Verify Canvas has UIManager component

## Performance Settings

1. **Quality Settings** (Edit > Project Settings > Quality)
   - Set to "Medium" for testing
   - Disable shadows on projectiles

2. **Player Settings**
   - Enable "Incremental GC"
   - Set scripting backend to IL2CPP for builds

3. **Mirror Settings**
   - Send Rate: 30 Hz
   - Max Connections: 4

## Final Checklist Before Testing

- [ ] All prefabs created and saved
- [ ] Scenes added to Build Settings
- [ ] Layers and Tags configured
- [ ] NavMesh baked in both scenes
- [ ] UI references assigned
- [ ] Network prefabs registered
- [ ] Audio clips assigned to AudioManager
- [ ] Materials created (use placeholders if needed)