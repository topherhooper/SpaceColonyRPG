# Code Review Checklist

## Every Script
- [ ] **Null checks** on public references
- [ ] **Namespace** used (SpaceColony.[Feature])
- [ ] **XML documentation** on public methods
- [ ] **Regions** used for organization
- [ ] **Naming conventions** followed
- [ ] **No magic numbers** - use constants
- [ ] **Debug logs** include context `[ClassName]`
- [ ] **Try-catch** for external operations

## Networked Scripts
- [ ] Inherits from **NetworkBehaviour**
- [ ] **[SyncVar]** for shared state
- [ ] **Authority checks** (isServer/isLocalPlayer/hasAuthority)
- [ ] **Commands validated** on server
- [ ] **No floating point** in [SyncVar] (use int/fixed)
- [ ] **Proper cleanup** (NetworkServer.UnSpawn)
- [ ] **Network prefab** has NetworkIdentity
- [ ] **Spawn list** includes prefab

## Performance
- [ ] **Update() usage** minimized
- [ ] **GetComponent** cached in Awake/Start
- [ ] **Events** used instead of constant checking
- [ ] **Object pooling** for frequent spawns
- [ ] **Coroutines** use yield return null wisely
- [ ] **LINQ** avoided in hot paths
- [ ] **String concatenation** avoided in loops
- [ ] **GameObject.Find** never in Update

## Memory Management
- [ ] **Lists cleared** instead of recreated
- [ ] **StringBuilder** used for string building
- [ ] **Events unsubscribed** in OnDestroy
- [ ] **Static references** cleared properly
- [ ] **Materials** use sharedMaterial when possible
- [ ] **Textures** are power of 2
- [ ] **Audio clips** compressed appropriately

## Unity Specific
- [ ] **Prefab overrides** minimized
- [ ] **Layer** set correctly
- [ ] **Tag** used appropriately
- [ ] **Collider** type matches usage
- [ ] **Rigidbody** settings optimized
- [ ] **Canvas** separated by update frequency
- [ ] **UI Raycast Target** disabled when not needed

## Input Handling
- [ ] Input checked in **Update** not FixedUpdate
- [ ] **isLocalPlayer** check before input
- [ ] **EventSystem** check for UI input blocking
- [ ] **Input buffering** for better feel
- [ ] **Rebindable keys** considered

## Error Handling
- [ ] **Graceful failures** (no crashes)
- [ ] **Meaningful error messages**
- [ ] **Fallback behavior** for failures
- [ ] **Network disconnection** handled
- [ ] **Missing references** handled

## Testing
- [ ] **Single player** functionality verified
- [ ] **Multiplayer** sync verified
- [ ] **Edge cases** tested
- [ ] **Performance** acceptable (30+ FPS)
- [ ] **Build** tested (not just editor)

## Security (Multiplayer)
- [ ] **Never trust client** input
- [ ] **Validate ranges** on server
- [ ] **Rate limiting** for commands
- [ ] **Sanitize** player inputs
- [ ] **Authority** properly assigned

## Documentation
- [ ] **Purpose** clear from class name/comments
- [ ] **Complex logic** explained
- [ ] **TODOs** include context
- [ ] **Known issues** documented
- [ ] **Usage examples** for utilities

## Quick Review Commands
```
// For reviewing a specific file:
"Review [filename] using review_checklist.md"

// For reviewing a feature:
"Review all scripts in Scripts/[Feature]/ folder"

// For performance review:
"Check Scripts/[Feature]/ for performance issues"

// For network review:
"Verify networking in [filename] follows Mirror patterns"
```

## Common Issues Found in Reviews

### Issue 1: Missing Null Checks
```csharp
// ❌ BAD
transform.position = target.position;

// ✅ GOOD
if (target != null)
    transform.position = target.position;
```

### Issue 2: Update Every Frame
```csharp
// ❌ BAD
void Update()
{
    healthText.text = health.ToString();
}

// ✅ GOOD
void OnHealthChanged(int oldVal, int newVal)
{
    healthText.text = newVal.ToString();
}
```

### Issue 3: No Authority Check
```csharp
// ❌ BAD
void Update()
{
    if (Input.GetKeyDown(KeyCode.Space))
        CmdFire();
}

// ✅ GOOD
void Update()
{
    if (!isLocalPlayer) return;
    if (Input.GetKeyDown(KeyCode.Space))
        CmdFire();
}
```