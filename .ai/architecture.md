# Space Colony RPG - Architecture

## High-Level Architecture

```
┌─────────────────────────────────────────────────────────┐
│                     Client (Player)                       │
├─────────────────────────────────────────────────────────┤
│  Input System → Player Controller → Commands to Server   │
│  UI Manager ← Game State ← SyncVars from Server         │
└─────────────────────────────────────────────────────────┘
                            ↕ Mirror
┌─────────────────────────────────────────────────────────┐
│                    Server (Host/Dedicated)                │
├─────────────────────────────────────────────────────────┤
│  Game Manager → Validate Commands → Update Game State    │
│  AI Systems → Enemy/Colonist Logic → Broadcast Changes   │
└─────────────────────────────────────────────────────────┘
```

## Core Systems Design

### 1. Network Architecture
- **Pattern**: Client-Server with Host mode
- **Authority**: Server validates all gameplay actions
- **State Sync**: SyncVars for simple data, RPCs for events
- **Scenes**: Single persistent scene (no scene switching)

### 2. Game State Management
```
GameNetworkManager (Singleton)
├── PlayerManager (tracks connected players)
├── BuildingManager (colony structures)
├── ResourceManager (shared resources)
├── WaveManager (enemy spawning)
└── ColonistManager (AI units)
```

### 3. Player Systems
```
Player GameObject
├── NetworkIdentity (Mirror component)
├── NetworkTransform (position sync)
├── PlayerController (movement/input)
├── PlayerCombat (shooting/abilities)
├── PlayerStats (health/score)
└── PlayerUI (local HUD)
```

### 4. Building System
```
BuildingSystem
├── PlacementValidator (grid/collision checks)
├── BuildingCatalog (available buildings)
├── ConstructionManager (build progress)
└── NetworkedBuilding (sync to clients)
```

### 5. Combat System
```
Combat Flow:
1. Player Input → CmdFire()
2. Server Validates → Spawn Projectile
3. Projectile Hits → Apply Damage
4. Broadcast Result → RpcTakeDamage()
```

## Folder Structure

```
Assets/_Project/
├── Scripts/
│   ├── Core/               # Singletons, Managers
│   │   ├── GameNetworkManager.cs
│   │   ├── Singleton.cs
│   │   └── GameState.cs
│   ├── Player/            # Player-specific
│   │   ├── PlayerController.cs
│   │   ├── PlayerCombat.cs
│   │   └── PlayerStats.cs
│   ├── Colony/            # Building/Resource systems
│   │   ├── BuildingSystem.cs
│   │   ├── Building.cs
│   │   ├── ResourceManager.cs
│   │   └── Colonist.cs
│   ├── Combat/            # Weapons/Damage
│   │   ├── Weapon.cs
│   │   ├── Projectile.cs
│   │   └── DamageHandler.cs
│   ├── Enemies/           # AI Opponents
│   │   ├── Enemy.cs
│   │   ├── EnemySpawner.cs
│   │   └── WaveManager.cs
│   ├── UI/                # Interface
│   │   ├── UIManager.cs
│   │   ├── BuildMenu.cs
│   │   └── HUD.cs
│   └── Utilities/         # Helpers
│       ├── ObjectPool.cs
│       └── Extensions.cs
├── Prefabs/
│   ├── Core/              # Manager prefabs
│   ├── Players/           # Player variations
│   ├── Buildings/         # Colony structures
│   ├── Enemies/           # Enemy types
│   ├── Projectiles/       # Bullets/missiles
│   └── UI/                # UI elements
```

## Component Patterns

### Networked GameObject Pattern
```csharp
GameObject Structure:
├── NetworkIdentity (required)
├── NetworkTransform (if moving)
├── [Feature]Controller : NetworkBehaviour
├── [Feature]View : MonoBehaviour (visuals only)
├── Collider (for interaction)
└── Rigidbody (if physics-based)
```

### Manager Pattern
```csharp
public class [Feature]Manager : Singleton<[Feature]Manager>
{
    // Server-only logic
    [Server]
    void ServerMethod() { }
    
    // Client-only logic
    [Client]
    void ClientMethod() { }
    
    // Shared logic
    void SharedMethod() { }
}
```

## Data Flow Examples

### Building Placement
1. **Client**: Selects building type, previews placement
2. **Client**: Clicks to place → `CmdPlaceBuilding(type, position)`
3. **Server**: Validates placement and resources
4. **Server**: Spawns building → `NetworkServer.Spawn()`
5. **Server**: Deducts resources → Updates SyncVars
6. **All Clients**: See building appear and resources update

### Combat Damage
1. **Client**: Fires weapon → `CmdFire(origin, direction)`
2. **Server**: Spawns projectile with velocity
3. **Server**: Physics detects hit → Calculates damage
4. **Server**: Updates health → `SyncVar` changes
5. **All Clients**: See health bar update via hook

## Performance Considerations

### Object Pooling Required For:
- Projectiles (high spawn rate)
- Hit effects (particles)
- Damage numbers (UI elements)
- Sound effects (audio sources)

### Update Loop Optimization:
- Enemies use manager pattern (single Update)
- UI updates on SyncVar hooks only
- Physics on FixedUpdate (50Hz)
- Visual effects on client only

## Network Optimization

### SyncVar Usage:
- Health, Resources, Score (integers)
- States (enums as integers)
- Positions (via NetworkTransform)

### Avoid Syncing:
- Visual effects
- Audio
- UI states
- Particle systems

### Message Batching:
- Group related updates
- Use dirty bit masking
- Limit update rates per object type