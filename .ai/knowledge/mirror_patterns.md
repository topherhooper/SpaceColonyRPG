# Mirror Networking Patterns & Best Practices

## Essential Patterns

### 1. Spawning Objects Over Network
```csharp
// ❌ WRONG - Only visible to spawning client
GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

// ✅ CORRECT - Visible to all clients
[Command]
void CmdFire()
{
    GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    NetworkServer.Spawn(bullet);
    
    // Optional: Give authority to shooting player
    NetworkServer.Spawn(bullet, connectionToClient);
}
```

### 2. Authority Checking Pattern
```csharp
void Update()
{
    // ✅ CORRECT - Only process input for local player
    if (!isLocalPlayer) return;
    
    if (Input.GetKeyDown(KeyCode.Space))
    {
        CmdDoAction();
    }
}

void OnCollisionEnter(Collision collision)
{
    // ✅ CORRECT - Only server processes gameplay logic
    if (!isServer) return;
    
    // Process collision damage, physics, etc.
}
```

### 3. SyncVar with Hooks
```csharp
public class Player : NetworkBehaviour
{
    [SyncVar(hook = nameof(OnHealthChanged))]
    private int health = 100;
    
    // Hook signature must match exactly
    void OnHealthChanged(int oldHealth, int newHealth)
    {
        // Update UI for all clients
        healthBar.SetHealth(newHealth);
        
        // Client-side effects
        if (newHealth < oldHealth)
        {
            ShowDamageEffect();
        }
    }
    
    [Command]
    void CmdTakeDamage(int amount)
    {
        // Server validates and applies damage
        health = Mathf.Max(0, health - amount);
    }
}
```

### 4. Efficient RPC Usage
```csharp
// ❌ BAD - Sending every frame
void Update()
{
    if (isLocalPlayer)
        CmdUpdatePosition(transform.position);
}

// ✅ GOOD - Use NetworkTransform component instead
// Or batch updates:
float lastSendTime;
void Update()
{
    if (isLocalPlayer && Time.time - lastSendTime > 0.1f)
    {
        CmdUpdateState(transform.position, health, ammo);
        lastSendTime = Time.time;
    }
}
```

### 5. Object Pooling with Mirror
```csharp
public class ProjectilePool : MonoBehaviour
{
    [SerializeField] private GameObject projectilePrefab;
    private Queue<GameObject> pool = new Queue<GameObject>();
    
    void Start()
    {
        // Pre-warm pool
        for (int i = 0; i < 50; i++)
        {
            GameObject obj = Instantiate(projectilePrefab);
            obj.SetActive(false);
            pool.Enqueue(obj);
        }
    }
    
    [Server]
    public void SpawnProjectile(Vector3 position, Quaternion rotation)
    {
        GameObject projectile = pool.Count > 0 ? pool.Dequeue() : Instantiate(projectilePrefab);
        projectile.transform.position = position;
        projectile.transform.rotation = rotation;
        projectile.SetActive(true);
        
        NetworkServer.Spawn(projectile);
        
        // Return to pool after 3 seconds
        StartCoroutine(ReturnToPool(projectile, 3f));
    }
    
    IEnumerator ReturnToPool(GameObject obj, float delay)
    {
        yield return new WaitForSeconds(delay);
        NetworkServer.UnSpawn(obj);
        obj.SetActive(false);
        pool.Enqueue(obj);
    }
}
```

### 6. Custom Network Messages
```csharp
// Define message
public struct DamageMessage : NetworkMessage
{
    public uint netId;
    public int damage;
    public Vector3 hitPoint;
}

// Send from server
[ServerCallback]
void SendDamageInfo(NetworkIdentity target, int damage, Vector3 hitPoint)
{
    DamageMessage msg = new DamageMessage
    {
        netId = target.netId,
        damage = damage,
        hitPoint = hitPoint
    };
    
    NetworkServer.SendToAll(msg);
}

// Receive on client
void Start()
{
    NetworkClient.RegisterHandler<DamageMessage>(OnDamageReceived);
}

void OnDamageReceived(DamageMessage msg)
{
    if (NetworkClient.spawned.TryGetValue(msg.netId, out NetworkIdentity identity))
    {
        ShowDamageNumber(identity.transform, msg.damage, msg.hitPoint);
    }
}
```

### 7. Scene Management
```csharp
public class GameNetworkManager : NetworkManager
{
    public override void OnServerAddPlayer(NetworkConnection conn)
    {
        base.OnServerAddPlayer(conn);
        
        // Customize player spawn
        GameObject player = conn.identity.gameObject;
        player.transform.position = GetSpawnPosition();
        
        // Initialize player
        player.GetComponent<PlayerStats>().SetPlayerName($"Player {numPlayers}");
    }
    
    public override void OnServerDisconnect(NetworkConnection conn)
    {
        // Clean up player data
        if (conn.identity != null)
        {
            PlayerStats stats = conn.identity.GetComponent<PlayerStats>();
            SavePlayerProgress(stats);
        }
        
        base.OnServerDisconnect(conn);
    }
}
```

## Common Mirror Gotchas

### 1. SyncVar Limitations
```csharp
// ❌ WON'T SYNC - Complex types
[SyncVar] List<Item> inventory;
[SyncVar] Dictionary<int, string> data;

// ✅ WILL SYNC - Primitives and Unity types
[SyncVar] int score;
[SyncVar] float health;
[SyncVar] Vector3 spawnPoint;
[SyncVar] Quaternion rotation;
[SyncVar] Color teamColor;

// ✅ For collections, use SyncList/SyncDictionary
public SyncList<int> inventoryIds = new SyncList<int>();
public SyncDictionary<int, string> playerNames = new SyncDictionary<int, string>();
```

### 2. Command Validation
```csharp
[Command]
void CmdMoveToPosition(Vector3 position)
{
    // ❌ BAD - Trust client blindly
    transform.position = position;
    
    // ✅ GOOD - Validate on server
    if (Vector3.Distance(transform.position, position) > maxMoveDistance)
    {
        Debug.LogWarning($"Player {netId} attempted invalid move");
        return;
    }
    
    if (Physics.Linecast(transform.position, position, obstacleLayer))
    {
        Debug.LogWarning($"Player {netId} attempted to move through wall");
        return;
    }
    
    transform.position = position;
}
```

### 3. NetworkBehaviour Lifecycle
```csharp
public class PlayerController : NetworkBehaviour
{
    // Called on server when object spawned
    public override void OnStartServer() => Debug.Log("Server started this object");
    
    // Called on clients when object spawned
    public override void OnStartClient() => Debug.Log("Client started this object");
    
    // Called on client that owns this object
    public override void OnStartLocalPlayer()
    {
        Debug.Log("This is MY player!");
        Camera.main.GetComponent<CameraFollow>().target = transform;
    }
    
    // Called when gaining authority
    public override void OnStartAuthority() => Debug.Log("I now control this");
    
    // Called when losing authority
    public override void OnStopAuthority() => Debug.Log("I lost control");
}
```

### 4. Proper Cleanup
```csharp
public class Enemy : NetworkBehaviour
{
    [Server]
    public void Die()
    {
        // Spawn death effects for all clients
        RpcShowDeathEffect();
        
        // Give rewards
        GiveRewards();
        
        // Clean up after effect
        StartCoroutine(DelayedCleanup());
    }
    
    IEnumerator DelayedCleanup()
    {
        yield return new WaitForSeconds(2f);
        
        // Proper network cleanup
        NetworkServer.UnSpawn(gameObject);
        
        // Return to pool or destroy
        if (objectPool != null)
            objectPool.Return(gameObject);
        else
            Destroy(gameObject);
    }
}
```

## Performance Optimizations

### 1. Conditional Compilation
```csharp
[ServerCallback]  // Method only runs on server, stripped from client builds
void UpdateAI() { }

[ClientCallback]  // Method only runs on clients, stripped from server builds
void UpdateVisuals() { }
```

### 2. Interest Management
```csharp
// In NetworkManager
public override void OnServerConnect(NetworkConnection conn)
{
    // Set player's visible range
    conn.identity.GetComponent<NetworkIdentity>().visRange = 30f;
}
```

### 3. Selective Updates
```csharp
public class OptimizedSync : NetworkBehaviour
{
    [SyncVar(hook = nameof(OnStateChanged))]
    private byte compressedState;
    
    // Pack multiple bools into single byte
    public bool isMoving => (compressedState & 1) != 0;
    public bool isShooting => (compressedState & 2) != 0;
    public bool isDead => (compressedState & 4) != 0;
    
    [Server]
    void UpdateState(bool moving, bool shooting, bool dead)
    {
        byte newState = 0;
        if (moving) newState |= 1;
        if (shooting) newState |= 2;
        if (dead) newState |= 4;
        
        compressedState = newState;
    }
}
```