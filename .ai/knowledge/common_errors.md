# Common Unity/Mirror Errors & Solutions

## Mirror Networking Errors

### "Trying to send command for object without authority"
**Cause**: Client attempting to execute Command on object they don't own
```csharp
// ❌ WRONG
void Update()
{
    if (Input.GetKeyDown(KeyCode.Space))
        CmdFire(); // Error if not local player!
}

// ✅ SOLUTION
void Update()
{
    if (!isLocalPlayer) return;
    
    if (Input.GetKeyDown(KeyCode.Space))
        CmdFire(); // Only local player can call
}
```

### "Spawn scene object not found for X"
**Cause**: Trying to spawn object that isn't registered
```csharp
// ✅ SOLUTION 1: Add to NetworkManager
// In Inspector: NetworkManager > Spawnable Prefabs > Add prefab

// ✅ SOLUTION 2: Register at runtime
void Start()
{
    NetworkClient.RegisterPrefab(myPrefab);
}
```

### "SyncVar hook not firing"
**Cause**: Hook method signature incorrect
```csharp
// ❌ WRONG signatures
void OnHealthChanged(int newValue) { }
void OnHealthChanged() { }
void HealthChanged(int old, int new) { }

// ✅ CORRECT signature
[SyncVar(hook = nameof(OnHealthChanged))]
int health;

void OnHealthChanged(int oldValue, int newValue)
{
    // Must have exactly these parameter names and types
}
```

### "NetworkBehaviour.netId is zero"
**Cause**: Accessing netId before spawn
```csharp
// ❌ WRONG
void Awake()
{
    Debug.Log(netId); // Always 0!
}

// ✅ CORRECT
public override void OnStartClient()
{
    Debug.Log(netId); // Valid ID
}
```

## Unity Component Errors

### "NullReferenceException: Object reference not set to an instance"
**Most common Unity error!**
```csharp
// Common causes and fixes:

// 1. Unassigned reference in Inspector
[SerializeField] private GameObject target; // Forgot to assign!
// FIX: Check Inspector, assign reference

// 2. Finding object that doesn't exist
GameObject player = GameObject.Find("Players"); // Typo! Should be "Player"
// FIX: Check exact GameObject name

// 3. Component doesn't exist
GetComponent<Rigidbody>().velocity = Vector3.zero; // No Rigidbody!
// FIX: Add null check or RequireComponent

// 4. Destroyed object access
Destroy(enemy);
enemy.transform.position = Vector3.zero; // enemy is destroyed!
// FIX: Check if (enemy != null)
```

### "The variable X of Y has not been assigned"
**Cause**: SerializeField not assigned in Inspector
```csharp
public class Player : MonoBehaviour
{
    [SerializeField] private Transform spawnPoint; // Warning in console
    
    void Start()
    {
        transform.position = spawnPoint.position; // NullReferenceException
    }
}

// ✅ SOLUTIONS:
// 1. Assign in Inspector
// 2. Find at runtime: spawnPoint = GameObject.Find("SpawnPoint").transform;
// 3. Make optional: if (spawnPoint != null)
```

### "Can't add script behaviour. The script needs to derive from MonoBehaviour"
**Cause**: Class name doesn't match filename
```csharp
// Filename: PlayerController.cs
public class Player : MonoBehaviour // WRONG! Must be PlayerController
{
}

// ✅ CORRECT
public class PlayerController : MonoBehaviour
{
}
```

## Physics Errors

### "Actor::setLinearVelocity: Actor must be (non-kinematic) dynamic!"
**Cause**: Trying to set velocity on kinematic Rigidbody
```csharp
// ❌ WRONG
rigidbody.isKinematic = true;
rigidbody.velocity = Vector3.forward; // Error!

// ✅ SOLUTION 1: Use MovePosition for kinematic
rigidbody.MovePosition(transform.position + Vector3.forward * Time.deltaTime);

// ✅ SOLUTION 2: Make it non-kinematic
rigidbody.isKinematic = false;
rigidbody.velocity = Vector3.forward;
```

### "Collisions ignored between X and Y"
**Common causes**:
1. Missing Rigidbody on at least one object
2. Both objects have kinematic Rigidbodies
3. Layer collision matrix disabled
4. One object is a trigger (use OnTriggerEnter)

```csharp
// ✅ Debug collision setup
void OnCollisionEnter(Collision col) 
{
    Debug.Log("Collision with " + col.gameObject.name);
}

void OnTriggerEnter(Collider other)
{
    Debug.Log("Trigger with " + other.gameObject.name);
}
```

## Build Errors

### "Shader error: Shader is not supported on this GPU"
**Cause**: Using editor-only shaders
```csharp
// ✅ SOLUTION: Check shader compatibility
// Edit > Project Settings > Graphics
// Add used shaders to "Always Included Shaders"
```

### "Scene 'X' couldn't be loaded because it has not been added to build settings"
```csharp
// ✅ SOLUTION: Add scenes to build
// File > Build Settings > Add Open Scenes
// Or drag scenes into the list

// Check in code:
if (Application.CanStreamedLevelBeLoaded(sceneName))
{
    SceneManager.LoadScene(sceneName);
}
```

## Performance Warnings

### "SendMessage cannot be called during Awake, CheckConsistency, or OnValidate"
**Cause**: Using SendMessage incorrectly
```csharp
// ❌ AVOID SendMessage entirely - it's slow!
SendMessage("TakeDamage", 10);

// ✅ Use direct method calls
GetComponent<Health>().TakeDamage(10);

// ✅ Or interfaces
if (TryGetComponent<IDamageable>(out var damageable))
{
    damageable.TakeDamage(10);
}
```

### "Texture has out of range width/height"
**Cause**: Texture too large
```
Max texture sizes:
- Mobile: 2048x2048 or 4096x4096
- Desktop: 8192x8192 or 16384x16384

✅ SOLUTION: Resize textures in image editor
```

## Animation Errors

### "Animator.GotoState: State could not be found"
**Cause**: State name typo or doesn't exist
```csharp
// ❌ String literals prone to typos
animator.Play("Runing"); // Typo!

// ✅ Use constants or hash
private static readonly int RunState = Animator.StringToHash("Running");
animator.Play(RunState);
```

## UI Errors

### "Canvas element contains invalid UI elements"
**Common causes**:
1. UI element not under Canvas
2. Using 3D objects in UI
3. Missing required components

```csharp
// ✅ UI GameObject hierarchy:
Canvas
└── Panel
    └── Button
        └── Text
```

### "Graphic requires a Canvas"
**Cause**: UI element not child of Canvas
```csharp
// ✅ Create UI properly
GameObject canvas = new GameObject("Canvas");
canvas.AddComponent<Canvas>();
canvas.AddComponent<CanvasScaler>();
canvas.AddComponent<GraphicRaycaster>();

GameObject text = new GameObject("Text");
text.transform.SetParent(canvas.transform);
text.AddComponent<Text>();
```

## Quick Error Diagnosis

### Check These First:
1. **Is the GameObject active?** `gameObject.activeSelf`
2. **Is the component enabled?** `component.enabled`
3. **Is it destroyed?** `obj == null`
4. **Is the reference assigned?** Check Inspector
5. **Is the name spelled correctly?** Check GameObject name
6. **Is it the right type?** Check GetComponent type
7. **Is it on the right layer?** Check Layer dropdown
8. **Is it in the scene?** Check Hierarchy

### Debug Helper Script
```csharp
public static class DebugHelper
{
    [Conditional("DEBUG")]
    public static void CheckComponent<T>(GameObject obj) where T : Component
    {
        if (obj == null)
        {
            Debug.LogError("GameObject is null!");
            return;
        }
        
        if (!obj.GetComponent<T>())
        {
            Debug.LogError($"{obj.name} missing {typeof(T).Name}");
        }
    }
    
    [Conditional("DEBUG")]
    public static void CheckReference(Object obj, string name)
    {
        if (obj == null)
        {
            Debug.LogError($"{name} is not assigned!");
        }
    }
}

// Usage:
void Start()
{
    DebugHelper.CheckComponent<Rigidbody>(gameObject);
    DebugHelper.CheckReference(targetPrefab, "Target Prefab");
}
```