# Coding Conventions & Standards

## Naming Conventions

### Scripts
- **Classes**: PascalCase - `PlayerController`, `BuildingSystem`
- **Interfaces**: IPascalCase - `IDamageable`, `IInteractable`
- **Methods**: PascalCase - `TakeDamage()`, `SpawnEnemy()`
- **Variables**: camelCase - `currentHealth`, `moveSpeed`
- **Constants**: UPPER_SNAKE - `MAX_PLAYERS`, `DEFAULT_HEALTH`
- **Private fields**: _camelCase - `_instance`, `_isInitialized`

### Unity Specific
- **Prefabs**: Feature_Type - `Player_Marine`, `Building_Turret`
- **Materials**: Mat_Name - `Mat_Player`, `Mat_Enemy_Red`
- **UI Elements**: UI_Feature - `UI_HealthBar`, `UI_BuildMenu`

### Network Specific
- **Networked Classes**: Include context - `NetworkedEnemy` not just `Enemy`
- **Commands**: Cmd prefix - `CmdFire()`, `CmdPlaceBuilding()`
- **ClientRpc**: Rpc prefix - `RpcShowEffect()`, `RpcUpdateScore()`
- **TargetRpc**: Target prefix - `TargetShowMessage()`
- **SyncVars**: Descriptive - `syncedHealth` not just `health`

## Code Organization

### File Structure Template
```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;  // If networked

namespace SpaceColony.[Feature]
{
    /// <summary>
    /// Brief description of what this class does
    /// </summary>
    public class ClassName : NetworkBehaviour  // or MonoBehaviour
    {
        #region Constants
        private const int MAX_VALUE = 100;
        #endregion

        #region Private Fields
        [Header("References")]
        [SerializeField] private GameObject _prefab;
        
        [Header("Settings")]
        [SerializeField] private float _moveSpeed = 5f;
        
        private bool _isInitialized;
        #endregion

        #region Public Properties
        public float MoveSpeed => _moveSpeed;
        public bool IsReady { get; private set; }
        #endregion

        #region Network Variables
        [SyncVar(hook = nameof(OnHealthChanged))]
        private int _syncedHealth = 100;
        #endregion

        #region Unity Lifecycle
        private void Awake() { }
        private void Start() { }
        private void Update() { }
        #endregion

        #region Public Methods
        public void Initialize() { }
        #endregion

        #region Private Methods
        private void HandleInput() { }
        #endregion

        #region Network Methods
        [Command]
        private void CmdDoAction() { }

        [ClientRpc]
        private void RpcShowEffect() { }
        #endregion

        #region Callbacks & Hooks
        private void OnHealthChanged(int oldValue, int newValue) { }
        #endregion
    }
}
```

## Best Practices

### General Unity
1. **Cache References**: Cache GetComponent calls in Awake/Start
2. **Null Checks**: Always check references before use
3. **Object Pooling**: Use for frequently spawned objects
4. **Coroutines**: Prefer async/await for new code
5. **Updates**: Minimize Update() usage, use events when possible

### Networking (Mirror)
1. **Authority**: Always check authority before accepting input
2. **Validation**: Validate all Commands on server
3. **State**: Keep game state on server, visuals on client
4. **Sync Rate**: Adjust NetworkTransform send rate by object type
5. **Debugging**: Use `[Server]` and `[Client]` attributes

### Performance
1. **Instantiate**: Avoid in Update loops
2. **Find**: Never use Find() in Update
3. **SendMessage**: Avoid, use direct references
4. **Strings**: Cache string literals
5. **UI**: Update only when values change

## Comment Standards

### XML Documentation
```csharp
/// <summary>
/// Handles player movement and input
/// </summary>
/// <param name="direction">Normalized movement direction</param>
/// <returns>True if movement was successful</returns>
public bool Move(Vector3 direction) { }
```

### Inline Comments
```csharp
// TODO: Implement damage reduction based on armor
// FIXME: Projectiles sometimes pass through thin walls
// HACK: Temporary fix for networking issue
// NOTE: This must run after BuildingManager initializes
```

### AI Context Comments
```csharp
// AI-CONTEXT: Handles local preview only, not networked
// AI-TODO: Add network sync after local testing
// AI-DEPENDS: Requires GridSystem to be initialized
// AI-TEST: Press 'B' to enter build mode
```

## Error Handling

### Logging Standards
```csharp
// Use contextual logging
Debug.Log($"[PlayerController] Moving to {position}", this);
Debug.LogWarning($"[BuildingSystem] Invalid placement at {position}");
Debug.LogError($"[NetworkManager] Failed to connect: {error}");

// Network-specific logging
if (isServer) Debug.Log("[Server] Processing command");
if (isClient) Debug.Log("[Client] Received update");
```

### Validation Pattern
```csharp
public bool TryPlaceBuilding(BuildingType type, Vector3 position)
{
    if (!ValidatePosition(position))
    {
        Debug.LogWarning($"Invalid position: {position}");
        return false;
    }
    
    if (!HasResources(type))
    {
        Debug.LogWarning($"Insufficient resources for {type}");
        return false;
    }
    
    // Place building
    return true;
}
```

## Git Commit Messages

### Format
```
[Feature] Brief description

- Detailed point 1
- Detailed point 2

Fixes #123
```

### Examples
```
[Combat] Add projectile pooling system

- Implement ObjectPool<T> generic class
- Convert projectile spawning to use pool
- Add pool warming on scene start

Improves performance with many projectiles
```

### Commit Types
- `[Feature]` - New functionality
- `[Fix]` - Bug fixes  
- `[Refactor]` - Code improvement
- `[UI]` - Interface changes
- `[Network]` - Multiplayer related
- `[Performance]` - Optimizations
- `[Docs]` - Documentation only

## Testing Patterns

### Debug Menu Items
```csharp
#if UNITY_EDITOR
[MenuItem("SpaceColony/Debug/Spawn 100 Enemies")]
private static void SpawnManyEnemies() { }
#endif
```

### Test Helpers
```csharp
[Conditional("UNITY_EDITOR")]
private void DebugDrawPlacement()
{
    // Only compiles in editor
}
```

## Code Review Checklist

Before committing, ensure:
- [ ] No compiler warnings
- [ ] Null reference checks added
- [ ] Network authority validated
- [ ] Performance considerations met
- [ ] Comments added for complex logic
- [ ] Follows naming conventions
- [ ] Region blocks organized
- [ ] Debug logs use proper format