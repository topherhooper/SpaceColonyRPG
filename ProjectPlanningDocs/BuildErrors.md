# Build Error Solutions

## Common Build Errors and Fixes

### 1. Shader Errors (URP/Built-in Mismatch)
**Error**: "Shader error in 'Universal Render Pipeline/Lit'"
**Solution**: 
```csharp
// In CreateMaterial method, use fallback shader
Material mat = new Material(Shader.Find("Universal Render Pipeline/Lit"));
if (mat.shader == null)
{
    mat = new Material(Shader.Find("Standard")); // Fallback to built-in
}
```

### 2. Missing Prefab References
**Error**: "The referenced script on this Behaviour is missing"
**Solution**:
- Ensure all scripts compile before generating prefabs
- Run setup after fixing compilation errors

### 3. Scene Not in Build Settings
**Error**: "Scene 'MainMenu' couldn't be loaded because it has not been added to the build settings"
**Solution**:
- SceneGenerator.cs automatically adds scenes
- Or manually add in File > Build Settings

### 4. NetworkIdentity Missing
**Error**: "NetworkBehaviour scripts require a NetworkIdentity"
**Solution**:
- PrefabGenerator adds NetworkIdentity automatically
- For manual prefabs, add NetworkIdentity component first

### 5. NavMesh Not Found
**Error**: "NavMeshAgent could not find NavMesh"
**Solution**:
```csharp
// Add to scene generation
UnityEditor.AI.NavMeshBuilder.BuildNavMesh();
```

### 6. Layer Not Found
**Error**: "Layer 'Ground' is not defined"
**Solution**:
- Run QuickSetupHelper.SetupLayersAndTags()
- Or use build.bat setup

### 7. Missing Assembly References
**Error**: "The type or namespace name 'Mirror' could not be found"
**Solution**:
1. Import Mirror package first
2. Ensure .asmdef files reference Mirror

### 8. Build Platform Module Missing
**Error**: "No valid Unity Editor install found"
**Solution**:
1. Install build support modules in Unity Hub
2. Update UNITY_PATH in build scripts

## Pre-Build Validation Checklist

```csharp
public static bool ValidateBeforeBuild()
{
    bool valid = true;
    
    // Check Mirror installed
    if (Shader.Find("Universal Render Pipeline/Lit") == null)
    {
        Debug.LogError("URP not installed!");
        valid = false;
    }
    
    // Check scenes exist
    foreach (string scene in SCENES)
    {
        if (!File.Exists(scene))
        {
            Debug.LogError($"Scene missing: {scene}");
            valid = false;
        }
    }
    
    // Check critical prefabs
    if (!File.Exists("Assets/_Project/Prefabs/Players/Player.prefab"))
    {
        Debug.LogError("Player prefab missing!");
        valid = false;
    }
    
    return valid;
}
```

## Build Script Troubleshooting

### Windows: Unity Path Not Found
Edit build.bat:
```batch
set UNITY_PATH="C:\Program Files\Unity\Hub\Editor\[YOUR_VERSION]\Editor\Unity.exe"
```

### Mac/Linux: Permission Denied
```bash
chmod +x build.sh
```

### Build Hangs
- Check for infinite loops in static constructors
- Disable auto-refresh in Unity preferences
- Clear Library folder and rebuild

## Post-Build Issues

### Game Won't Start
- Check _Data folder is included
- Verify all DLLs are present
- Run with -logfile output.log

### Multiplayer Connection Failed
- Ensure port 7777 is open
- Check firewall settings
- Verify Mirror transport settings

### Missing Textures/Materials
- Ensure materials use correct shaders
- Check texture import settings
- Verify build includes all assets