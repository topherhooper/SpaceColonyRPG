# Unity Gotchas & Common Issues

## Transform & GameObject Issues

### 1. Destroyed Object Access
```csharp
// ❌ PROBLEM - Accessing destroyed object
GameObject enemy = GameObject.Find("Enemy");
Destroy(enemy);
enemy.transform.position = Vector3.zero; // NullReferenceException!

// ✅ SOLUTION - Always null check
if (enemy != null)
{
    enemy.transform.position = Vector3.zero;
}

// ✅ BETTER - Use a flag
public class Enemy : MonoBehaviour
{
    private bool isDestroyed = false;
    
    public void Die()
    {
        if (isDestroyed) return;
        isDestroyed = true;
        Destroy(gameObject);
    }
}
```

### 2. Transform.position in FixedUpdate
```csharp
// ❌ WRONG - Causes jitter
void FixedUpdate()
{
    transform.position += velocity * Time.fixedDeltaTime;
}

// ✅ CORRECT - Use Rigidbody for physics
void FixedUpdate()
{
    rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
}

// ✅ OR - Move transform in Update
void Update()
{
    transform.position += velocity * Time.deltaTime;
}
```

## Prefab & Instantiation Issues

### 3. Prefab Reference Lost
```csharp
// ❌ PROBLEM - Direct reference breaks in prefab
public class Spawner : MonoBehaviour
{
    public Transform spawnPoint; // Assigned in scene, lost in prefab
}

// ✅ SOLUTION 1 - Find at runtime
void Start()
{
    spawnPoint = GameObject.Find("SpawnPoint").transform;
}

// ✅ SOLUTION 2 - Use tags
void Start()
{
    spawnPoint = GameObject.FindWithTag("SpawnPoint").transform;
}

// ✅ SOLUTION 3 - Assign via inspector on prefab
[SerializeField] private Transform spawnPointPrefab;
```

### 4. Instantiate Position Issues
```csharp
// ❌ PROBLEM - Wrong parent space
GameObject obj = Instantiate(prefab, transform.position, Quaternion.identity);
obj.transform.parent = parentTransform; // Position changes!

// ✅ SOLUTION 1 - Set parent in Instantiate
GameObject obj = Instantiate(prefab, transform.position, Quaternion.identity, parentTransform);

// ✅ SOLUTION 2 - Use local position
GameObject obj = Instantiate(prefab);
obj.transform.SetParent(parentTransform);
obj.transform.localPosition = Vector3.zero;
```

## Component & GetComponent Issues

### 5. GetComponent Performance
```csharp
// ❌ BAD - Getting component every frame
void Update()
{
    GetComponent<Rigidbody>().velocity = newVelocity;
}

// ✅ GOOD - Cache the reference
private Rigidbody rb;

void Awake()
{
    rb = GetComponent<Rigidbody>();
}

void Update()
{
    rb.velocity = newVelocity;
}
```

### 6. Missing Component Checks
```csharp
// ❌ RISKY - Assumes component exists
void Start()
{
    GetComponent<AudioSource>().Play();
}

// ✅ SAFE - Check if component exists
void Start()
{
    AudioSource audio = GetComponent<AudioSource>();
    if (audio != null)
        audio.Play();
    else
        Debug.LogWarning("AudioSource missing on " + name);
}

// ✅ BETTER - Require component
[RequireComponent(typeof(AudioSource))]
public class SoundPlayer : MonoBehaviour
{
    private AudioSource audioSource;
    
    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
}
```

## Coroutine Pitfalls

### 7. Coroutine Doesn't Stop
```csharp
// ❌ PROBLEM - Coroutine continues after object destroyed
void Start()
{
    StartCoroutine(SpawnEnemies());
}

IEnumerator SpawnEnemies()
{
    while (true) // Runs forever!
    {
        Instantiate(enemyPrefab);
        yield return new WaitForSeconds(1f);
    }
}

// ✅ SOLUTION - Add exit condition
private bool isSpawning = true;

IEnumerator SpawnEnemies()
{
    while (isSpawning && gameObject != null)
    {
        Instantiate(enemyPrefab);
        yield return new WaitForSeconds(1f);
    }
}

void OnDestroy()
{
    isSpawning = false;
}
```

### 8. StartCoroutine on Disabled Object
```csharp
// ❌ PROBLEM - Coroutine won't run
gameObject.SetActive(false);
StartCoroutine(DelayedActivation()); // Won't execute!

// ✅ SOLUTION - Start coroutine before disabling
StartCoroutine(DelayedActivation());
// Or use a manager that stays active
GameManager.Instance.StartCoroutine(DelayedActivation());
```

## Input System Issues

### 9. Input in FixedUpdate
```csharp
// ❌ WRONG - Input can be missed
void FixedUpdate()
{
    if (Input.GetKeyDown(KeyCode.Space)) // Might not register
    {
        Jump();
    }
}

// ✅ CORRECT - Check input in Update, apply in FixedUpdate
private bool shouldJump;

void Update()
{
    if (Input.GetKeyDown(KeyCode.Space))
        shouldJump = true;
}

void FixedUpdate()
{
    if (shouldJump)
    {
        Jump();
        shouldJump = false;
    }
}
```

## Physics Issues

### 10. Modifying Transform with Rigidbody
```csharp
// ❌ PROBLEM - Breaks physics
void Update()
{
    if (GetComponent<Rigidbody>() != null)
        transform.position += movement; // Physics glitches!
}

// ✅ SOLUTION - Use Rigidbody methods
void FixedUpdate()
{
    rb.MovePosition(rb.position + movement);
}
```

### 11. Collision Detection Missing
```csharp
// Common reasons collisions don't work:
// 1. No Rigidbody on either object
// 2. Both Rigidbodies are kinematic
// 3. No collider on one object
// 4. Colliders are triggers (use OnTriggerEnter)
// 5. Layer collision matrix disabled

// ✅ Debugging collision issues
void OnCollisionEnter(Collision collision)
{
    Debug.Log($"Collided with {collision.gameObject.name}");
}

void OnTriggerEnter(Collider other)
{
    Debug.Log($"Triggered by {other.gameObject.name}");
}
```

## UI Issues

### 12. World Space UI Not Visible
```csharp
// ❌ PROBLEM - UI in wrong render mode
// Canvas set to Screen Space but positioned in world

// ✅ SOLUTION - Check Canvas settings
// For world UI: Render Mode = World Space
// For HUD: Render Mode = Screen Space - Overlay
```

### 13. UI Raycast Blocking
```csharp
// ❌ PROBLEM - UI blocks game input
void Update()
{
    if (Input.GetMouseButtonDown(0))
    {
        // Click goes to UI instead of game!
    }
}

// ✅ SOLUTION - Check if over UI
using UnityEngine.EventSystems;

void Update()
{
    if (Input.GetMouseButtonDown(0))
    {
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            // Safe to process game input
        }
    }
}
```

## Build Issues

### 14. Resources Not Loading in Build
```csharp
// ❌ PROBLEM - Direct asset reference
public GameObject prefab; // Assigned in inspector, null in build

// ✅ SOLUTION 1 - Use Resources folder
GameObject prefab = Resources.Load<GameObject>("Prefabs/Enemy");

// ✅ SOLUTION 2 - Use Addressables
// ✅ SOLUTION 3 - Ensure referenced in scene
```

### 15. Platform-Specific Code
```csharp
// ✅ Handle platform differences
#if UNITY_EDITOR
    Debug.Log("Running in editor");
#elif UNITY_STANDALONE_WIN
    Debug.Log("Windows build");
#elif UNITY_STANDALONE_OSX
    Debug.Log("Mac build");
#endif

// ✅ Input handling
#if UNITY_STANDALONE || UNITY_EDITOR
    if (Input.GetMouseButtonDown(0))
#elif UNITY_IOS || UNITY_ANDROID
    if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
#endif
```

## Performance Gotchas

### 16. Find Operations
```csharp
// ❌ TERRIBLE - Multiple finds per frame
void Update()
{
    GameObject player = GameObject.Find("Player");
    GameObject enemy = GameObject.FindWithTag("Enemy");
}

// ✅ GOOD - Cache references
private GameObject player;
private GameObject[] enemies;

void Start()
{
    player = GameObject.Find("Player");
    enemies = GameObject.FindGameObjectsWithTag("Enemy");
}
```

### 17. Instantiate/Destroy Spam
```csharp
// ❌ BAD - Constant allocation
void Update()
{
    GameObject bullet = Instantiate(bulletPrefab);
    Destroy(bullet, 2f);
}

// ✅ GOOD - Use object pooling
// See ObjectPool implementation in templates
```

## Script Execution Order Issues

### 18. Awake/Start Race Conditions
```csharp
// ❌ PROBLEM - Dependency not ready
public class Player : MonoBehaviour
{
    void Start()
    {
        GameManager.Instance.RegisterPlayer(this); // GameManager might not exist yet!
    }
}

// ✅ SOLUTION 1 - Use Awake for references
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    
    void Awake()
    {
        Instance = this;
    }
}

// ✅ SOLUTION 2 - Set Script Execution Order
// Edit > Project Settings > Script Execution Order
// GameManager: -100 (runs first)
// Player: 0 (default)
```

## Material & Shader Issues

### 19. Material Instance Leak
```csharp
// ❌ PROBLEM - Creates new material instance
GetComponent<Renderer>().material.color = Color.red; // Memory leak!

// ✅ SOLUTION 1 - Use sharedMaterial (affects all)
GetComponent<Renderer>().sharedMaterial.color = Color.red;

// ✅ SOLUTION 2 - Use MaterialPropertyBlock
private MaterialPropertyBlock propBlock;

void Start()
{
    propBlock = new MaterialPropertyBlock();
}

void ChangeColor(Color color)
{
    Renderer renderer = GetComponent<Renderer>();
    renderer.GetPropertyBlock(propBlock);
    propBlock.SetColor("_Color", color);
    renderer.SetPropertyBlock(propBlock);
}
```