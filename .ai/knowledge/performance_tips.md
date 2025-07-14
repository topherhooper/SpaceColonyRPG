# Unity Performance Optimization Tips

## CPU Optimization

### 1. Update Loop Optimization
```csharp
// ❌ BAD - 100 enemies each with Update()
public class Enemy : MonoBehaviour
{
    void Update()
    {
        // AI logic, movement, etc.
    }
}

// ✅ GOOD - Single manager updates all
public class EnemyManager : MonoBehaviour
{
    private List<Enemy> activeEnemies = new List<Enemy>();
    
    void Update()
    {
        for (int i = 0; i < activeEnemies.Count; i++)
        {
            activeEnemies[i].UpdateEnemy();
        }
    }
}

// ✅ BETTER - Update only what's needed
void Update()
{
    // Update only enemies in view
    for (int i = 0; i < activeEnemies.Count; i++)
    {
        if (IsInCameraView(activeEnemies[i].transform))
        {
            activeEnemies[i].UpdateEnemy();
        }
    }
}
```

### 2. Object Pooling Pattern
```csharp
public class ObjectPool<T> where T : Component
{
    private Queue<T> pool = new Queue<T>();
    private T prefab;
    private Transform parent;
    
    public ObjectPool(T prefab, int initialSize, Transform parent = null)
    {
        this.prefab = prefab;
        this.parent = parent;
        
        // Pre-warm pool
        for (int i = 0; i < initialSize; i++)
        {
            T obj = GameObject.Instantiate(prefab, parent);
            obj.gameObject.SetActive(false);
            pool.Enqueue(obj);
        }
    }
    
    public T Get()
    {
        T obj = pool.Count > 0 ? pool.Dequeue() : GameObject.Instantiate(prefab, parent);
        obj.gameObject.SetActive(true);
        return obj;
    }
    
    public void Return(T obj)
    {
        obj.gameObject.SetActive(false);
        pool.Enqueue(obj);
    }
}

// Usage
private ObjectPool<Projectile> projectilePool;

void Start()
{
    projectilePool = new ObjectPool<Projectile>(projectilePrefab, 50);
}

void Fire()
{
    Projectile proj = projectilePool.Get();
    proj.Initialize(firePoint.position, firePoint.forward);
}
```

### 3. Caching Common Operations
```csharp
// ❌ BAD - Repeated expensive calls
void Update()
{
    if (Vector3.Distance(transform.position, target.position) < 10f)
    {
        // Attack logic
    }
}

// ✅ GOOD - Cache squared distance
private Transform target;
private float attackRangeSqr = 100f; // 10 * 10

void Update()
{
    Vector3 dirToTarget = target.position - transform.position;
    if (dirToTarget.sqrMagnitude < attackRangeSqr)
    {
        // Attack logic
    }
}

// ✅ String caching
private static readonly string ANIM_SPEED = "Speed"; // Cache animation parameter
animator.SetFloat(ANIM_SPEED, speed); // No string allocation
```

### 4. Batch Operations
```csharp
// ❌ BAD - Individual operations
foreach (Enemy enemy in enemies)
{
    enemy.TakeDamage(10);
    enemy.ShowDamageEffect();
    enemy.UpdateHealthBar();
}

// ✅ GOOD - Batched operations
public void DamageAllEnemiesInRadius(Vector3 center, float radius, int damage)
{
    // Get all at once
    Collider[] colliders = Physics.OverlapSphere(center, radius, enemyLayer);
    
    // Process in batch
    for (int i = 0; i < colliders.Length; i++)
    {
        if (colliders[i].TryGetComponent<Enemy>(out Enemy enemy))
        {
            enemy.TakeDamage(damage);
        }
    }
    
    // Single VFX for all
    ShowAreaDamageEffect(center, radius);
}
```

## Memory Optimization

### 5. Avoid Garbage Generation
```csharp
// ❌ BAD - Creates garbage
void Update()
{
    string status = "Health: " + health + " Ammo: " + ammo; // New string every frame
    List<Enemy> nearbyEnemies = new List<Enemy>(); // New list every frame
}

// ✅ GOOD - Reuse objects
private StringBuilder statusBuilder = new StringBuilder();
private List<Enemy> nearbyEnemies = new List<Enemy>();

void Update()
{
    statusBuilder.Clear();
    statusBuilder.Append("Health: ").Append(health).Append(" Ammo: ").Append(ammo);
    
    nearbyEnemies.Clear();
    // Reuse the same list
}
```

### 6. Struct vs Class
```csharp
// ✅ Use struct for small data containers
public struct DamageInfo
{
    public int damage;
    public Vector3 point;
    public DamageType type;
}

// ❌ Avoid class for simple data
public class DamageInfo
{
    public int damage;      // 4 bytes
    public Vector3 point;   // 12 bytes
    public DamageType type; // 4 bytes
    // Class overhead: 24+ bytes
}
```

## Physics Optimization

### 7. Layer-Based Collision Matrix
```csharp
// Configure in: Edit > Project Settings > Physics > Layer Collision Matrix
// Disable unnecessary collision pairs:
// - UI doesn't collide with anything
// - Projectiles don't collide with each other
// - Effects layer doesn't collide

// In code:
private int enemyLayer = LayerMask.GetMask("Enemy");
private int obstacleLayer = LayerMask.GetMask("Obstacle");
private int combinedMask = enemyLayer | obstacleLayer;

// Use specific layer masks
Collider[] hits = Physics.OverlapSphere(position, radius, combinedMask);
```

### 8. Rigidbody Optimization
```csharp
// ✅ Configure Rigidbody properly
void SetupRigidbody(Rigidbody rb)
{
    // For moving platforms
    rb.isKinematic = true;
    
    // For projectiles
    rb.interpolation = RigidbodyInterpolation.None;
    rb.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
    
    // For player
    rb.interpolation = RigidbodyInterpolation.Interpolate;
    rb.freezeRotation = true; // Prevent unwanted rotation
}

// ✅ Disable when not needed
void OnBecameInvisible()
{
    rb.detectCollisions = false;
}

void OnBecameVisible()
{
    rb.detectCollisions = true;
}
```

## Rendering Optimization

### 9. LOD (Level of Detail)
```csharp
// Simple distance-based LOD
public class SimpleLOD : MonoBehaviour
{
    [SerializeField] private Renderer[] highDetail;
    [SerializeField] private Renderer[] lowDetail;
    [SerializeField] private float lodDistance = 50f;
    
    private Transform cameraTransform;
    private float lodDistanceSqr;
    
    void Start()
    {
        cameraTransform = Camera.main.transform;
        lodDistanceSqr = lodDistance * lodDistance;
    }
    
    void Update()
    {
        float distSqr = (transform.position - cameraTransform.position).sqrMagnitude;
        bool useHighDetail = distSqr < lodDistanceSqr;
        
        SetRenderersActive(highDetail, useHighDetail);
        SetRenderersActive(lowDetail, !useHighDetail);
    }
    
    void SetRenderersActive(Renderer[] renderers, bool active)
    {
        for (int i = 0; i < renderers.Length; i++)
            renderers[i].enabled = active;
    }
}
```

### 10. Batching Optimization
```csharp
// ✅ Enable GPU Instancing
// In Material Inspector: Check "Enable GPU Instancing"

// ✅ Use MaterialPropertyBlock for variations
private MaterialPropertyBlock propBlock;
private Renderer renderer;

void Start()
{
    propBlock = new MaterialPropertyBlock();
    renderer = GetComponent<Renderer>();
}

public void SetColor(Color color)
{
    renderer.GetPropertyBlock(propBlock);
    propBlock.SetColor("_Color", color);
    renderer.SetPropertyBlock(propBlock);
}
```

## UI Optimization

### 11. Canvas Optimization
```csharp
// ✅ Separate canvases by update frequency
// Canvas 1: Static UI (health bars, score) - Rarely updates
// Canvas 2: Dynamic UI (damage numbers) - Frequent updates
// Canvas 3: Screen effects - Constant updates

// ✅ Disable raycast when not needed
public class OptimizedButton : MonoBehaviour
{
    private CanvasGroup canvasGroup;
    
    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }
    
    public void SetInteractable(bool interactable)
    {
        canvasGroup.interactable = interactable;
        canvasGroup.blocksRaycasts = interactable;
    }
}
```

### 12. Text Optimization
```csharp
// ❌ BAD - Updates text every frame
void Update()
{
    scoreText.text = "Score: " + score;
}

// ✅ GOOD - Update only on change
private int lastScore = -1;

void Update()
{
    if (score != lastScore)
    {
        lastScore = score;
        scoreText.text = "Score: " + score;
    }
}
```

## Network Optimization (Mirror)

### 13. Reduce Network Traffic
```csharp
// ✅ Compress data
[SyncVar]
private byte health; // 0-255 instead of int

// ✅ Pack multiple bools
[SyncVar]
private byte flags; // 8 bools in 1 byte

public bool IsMoving => (flags & 1) != 0;
public bool IsShooting => (flags & 2) != 0;
public bool IsDead => (flags & 4) != 0;

// ✅ Conditional sync
public class NetworkedEnemy : NetworkBehaviour
{
    private Vector3 lastSyncedPos;
    
    void Update()
    {
        if (isServer && Vector3.Distance(transform.position, lastSyncedPos) > 0.1f)
        {
            lastSyncedPos = transform.position;
            RpcUpdatePosition(lastSyncedPos);
        }
    }
}
```

## Profiling & Measurement

### 14. Custom Profiler Markers
```csharp
using Unity.Profiling;

public class CombatSystem : MonoBehaviour
{
    private static readonly ProfilerMarker s_ProcessDamagePerfMarker = 
        new ProfilerMarker("CombatSystem.ProcessDamage");
    
    void ProcessDamage(List<DamageInfo> damages)
    {
        using (s_ProcessDamagePerfMarker.Auto())
        {
            // Your damage processing code
            foreach (var damage in damages)
            {
                // Process...
            }
        }
    }
}
```

### 15. Performance Targets
```csharp
// Mobile: 30 FPS minimum
// - Max 50 draw calls
// - Max 100k vertices
// - Max 50 SetPass calls

// Desktop: 60 FPS target
// - Max 500 draw calls
// - Max 1M vertices
// - Max 200 SetPass calls

// Quick performance check
void OnGUI()
{
    #if UNITY_EDITOR || DEVELOPMENT_BUILD
    GUI.Label(new Rect(10, 10, 200, 20), $"FPS: {1f / Time.deltaTime:F1}");
    #endif
}
```

## Quick Optimization Checklist
- [ ] Object pooling for projectiles/effects
- [ ] Manager pattern for multiple objects
- [ ] Cached references (no GetComponent in loops)
- [ ] Layer collision matrix configured
- [ ] LOD groups on detailed models
- [ ] GPU instancing enabled on materials
- [ ] UI separated by update frequency
- [ ] Network messages compressed
- [ ] Profiler shows no red flags
- [ ] Build tested on target hardware