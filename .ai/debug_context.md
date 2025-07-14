# Current Debug Focus

## Active Issue: None Currently
- **File**: N/A
- **Symptom**: N/A
- **Hypothesis**: N/A
- **Priority**: N/A

## Debug Template (Copy for new issues)
```
## Issue: [Brief description]
- **File**: [Path to problematic file]
- **Line**: [Approximate line number]
- **Symptom**: [What's happening]
- **Expected**: [What should happen]
- **Hypothesis**: [Your theory]
- **Priority**: [Critical/High/Medium/Low]

## Steps to Reproduce
1. [Step 1]
2. [Step 2]
3. [Observe issue]

## Debug Steps Taken
- [ ] Checked console for errors
- [ ] Verified object references
- [ ] Checked network authority
- [ ] Added debug logs
- [ ] Tested in build

## Relevant Code
```csharp
// Paste relevant code snippet
```

## Solution
[Document the fix when found]
```

## Common Debug Procedures

### For Networking Issues
1. Check NetworkIdentity on prefab
2. Verify prefab in NetworkManager spawn list
3. Add debug logs with [Server]/[Client] tags
4. Check authority with isLocalPlayer/isServer
5. Verify Command/RPC signatures

### For Physics Issues
1. Check Rigidbody settings
2. Verify layer collision matrix
3. Check collider types (trigger vs solid)
4. Debug.DrawRay for raycasts
5. Time.timeScale isn't 0

### For Performance Issues
1. Check Profiler (Window > Analysis > Profiler)
2. Look for spike frames
3. Check draw calls (Game view Stats)
4. Monitor GC allocations
5. Check Update() call counts

## Debug Helper Methods
```csharp
// Add to any script for quick debugging

#if UNITY_EDITOR || DEVELOPMENT_BUILD
void OnGUI()
{
    GUILayout.BeginArea(new Rect(10, 10, 300, 500));
    GUILayout.Label($"FPS: {1f/Time.deltaTime:F1}");
    GUILayout.Label($"Network: {(isServer ? "Server" : "Client")}");
    GUILayout.Label($"Authority: {hasAuthority}");
    GUILayout.Label($"NetID: {netId}");
    // Add more debug info as needed
    GUILayout.EndArea();
}
#endif
```