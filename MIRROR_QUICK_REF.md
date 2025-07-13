# Mirror Networking Quick Reference

## Common Patterns

### Networked Variable
```csharp
[SyncVar]
public int health = 100;

[SyncVar(hook = nameof(OnHealthChanged))]
public int score = 0;

void OnHealthChanged(int oldValue, int newValue) 
{
    // Called on all clients when value changes
    UpdateHealthBar(newValue);
}
```

### Commands (Client to Server)
```csharp
[Command]
void CmdFire(Vector3 position) 
{
    // Runs ONLY on server
    // Called by client, executed on server
    SpawnProjectile(position);
}

// Usage (from client):
if (isLocalPlayer)
{
    CmdFire(transform.position);
}
```

### ClientRpc (Server to All Clients)
```csharp
[ClientRpc]
void RpcTakeDamage(int damage)
{
    // Runs on ALL clients
    // Called by server, executed on all clients
    ShowDamageEffect(damage);
}

// Usage (from server):
if (isServer)
{
    RpcTakeDamage(10);
}
```

### TargetRpc (Server to Specific Client)
```csharp
[TargetRpc]
void TargetShowMessage(NetworkConnection conn, string message)
{
    // Runs on ONE specific client
    UIManager.Instance.ShowNotification(message);
}

// Usage (from server):
TargetShowMessage(connectionToClient, "You gained 50 XP!");
```

### Authority Checks
```csharp
if (isLocalPlayer) { }      // Is this MY player?
if (hasAuthority) { }       // Do I control this object?
if (isServer) { }           // Am I the server/host?
if (isClient) { }           // Am I a client?
if (isServerOnly) { }       // Am I ONLY server (not host)?
if (isClientOnly) { }       // Am I ONLY client (not host)?
```

### NetworkBehaviour Lifecycle
```csharp
public override void OnStartServer() { }      // Server started this object
public override void OnStartClient() { }      // Client started this object
public override void OnStartLocalPlayer() { } // This is MY player object
public override void OnStartAuthority() { }   // I gained control
public override void OnStopAuthority() { }    // I lost control
```

### Spawning Objects
```csharp
// Server-side spawning
if (isServer)
{
    GameObject obj = Instantiate(prefab, position, rotation);
    NetworkServer.Spawn(obj);
    
    // With client authority
    NetworkServer.Spawn(obj, connectionToClient);
}
```

### Network Transform Settings
```csharp
// NetworkTransform component settings for different use cases:

// Player (client authoritative)
- Client Authority: ✓
- Sync Position: ✓
- Sync Rotation: ✓ (if needed)
- Sync Scale: ✗

// Enemy (server authoritative)  
- Client Authority: ✗
- Sync Position: ✓
- Sync Rotation: ✓
- Sync Scale: ✗

// Projectile (server authoritative)
- Client Authority: ✗
- Sync Position: ✓
- Sync Rotation: ✓
- Send Rate: 30 (higher for fast objects)
```

### Common Gotchas
```csharp
// ❌ WRONG - Runs on all clients
void Update()
{
    transform.position += movement;
}

// ✅ CORRECT - Only local player moves
void Update()
{
    if (!isLocalPlayer) return;
    transform.position += movement;
}

// ❌ WRONG - Client tries to spawn
GameObject bullet = Instantiate(bulletPrefab);

// ✅ CORRECT - Server spawns via Command
[Command]
void CmdFireBullet()
{
    GameObject bullet = Instantiate(bulletPrefab);
    NetworkServer.Spawn(bullet);
}
```

### SyncVar Best Practices
```csharp
public class Player : NetworkBehaviour
{
    // ✅ GOOD - Primitive types
    [SyncVar] int health;
    [SyncVar] float speed;
    [SyncVar] bool isDead;
    
    // ✅ GOOD - With hooks
    [SyncVar(hook = nameof(OnNameChanged))]
    string playerName;
    
    // ❌ BAD - Don't sync complex types directly
    [SyncVar] List<Item> inventory; // Won't work!
    
    // ✅ GOOD - Use SyncList instead
    public SyncList<int> inventoryIds = new SyncList<int>();
}
```

### Quick Multiplayer Setup
```csharp
// 1. NetworkManager in scene
// 2. Set Network Address: localhost
// 3. Assign Player Prefab
// 4. Player prefab needs:
//    - NetworkIdentity
//    - NetworkTransform
//    - Your PlayerController : NetworkBehaviour

// 5. Host: NetworkManager.singleton.StartHost()
// 6. Join: NetworkManager.singleton.StartClient()