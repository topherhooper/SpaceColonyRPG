# Build Automation Plan - Space Colony RPG

## Overview
Implement command-line build automation for Unity to compile the project without opening the Unity Editor. This will enable CI/CD pipelines and faster iteration.

## Requirements

### 1. Unity Command Line Interface
- Unity must be installed with build support modules
- Need to know Unity installation path
- Build support for target platforms (Windows, Mac, Linux)

### 2. Build Scripts
- C# script that Unity can execute in batch mode
- Configuration for different build targets
- Scene management and build settings

### 3. Build Pipeline Components

#### A. Unity Build Script (`BuildScript.cs`)
```csharp
using UnityEditor;
using UnityEngine;
using System.Linq;
using System.IO;

public class BuildScript
{
    static string[] GetScenes()
    {
        // Get all scenes in build settings or find them
        return new string[] {
            "Assets/_Project/Scenes/MainMenu.unity",
            "Assets/_Project/Scenes/ColonyScene.unity",
            "Assets/_Project/Scenes/RaidScene.unity"
        };
    }

    [MenuItem("Build/Build Windows")]
    public static void BuildWindows()
    {
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = GetScenes();
        buildPlayerOptions.locationPathName = "Builds/Windows/SpaceColonyRPG.exe";
        buildPlayerOptions.target = BuildTarget.StandaloneWindows64;
        buildPlayerOptions.options = BuildOptions.None;

        BuildPipeline.BuildPlayer(buildPlayerOptions);
    }
}
```

#### B. Batch/Shell Scripts
- Windows: `build.bat`
- Mac/Linux: `build.sh`

#### C. Build Configuration
- Player settings configuration
- Quality settings
- Graphics settings

## Implementation Steps

### Phase 1: Create Build Infrastructure
1. Create `Assets/_Project/Scripts/Editor/BuildScript.cs`
2. Create build scripts in project root
3. Create `BuildConfig` folder for settings

### Phase 2: Scene Setup Automation
1. Script to create missing scenes
2. Auto-configure scene settings
3. Validate scene requirements

### Phase 3: Prefab Generation
1. Script to create prefabs from code
2. Component auto-wiring
3. Material assignment

### Phase 4: Build Pipeline
1. Pre-build validation
2. Build execution
3. Post-build packaging

## Build Commands

### Windows Build
```batch
Unity.exe -batchmode -quit -projectPath "." -executeMethod BuildScript.BuildWindows -logFile build.log
```

### Mac Build
```bash
/Applications/Unity/Unity.app/Contents/MacOS/Unity -batchmode -quit -projectPath "." -executeMethod BuildScript.BuildMac -logFile build.log
```

### Linux Build
```bash
Unity -batchmode -quit -projectPath "." -executeMethod BuildScript.BuildLinux -logFile build.log
```

## Expected Issues & Solutions

### 1. Missing Scenes
- **Issue**: Scenes don't exist yet
- **Solution**: Create scene generation script

### 2. Missing Prefabs
- **Issue**: Prefabs need manual creation
- **Solution**: Procedural prefab generation

### 3. Material/Shader Issues
- **Issue**: Materials not assigned
- **Solution**: Automatic material creation and assignment

### 4. Mirror Networking Setup
- **Issue**: NetworkManager needs configuration
- **Solution**: Scriptable object for network settings

### 5. Build Errors
- **Issue**: Compilation errors in build
- **Solution**: Pre-build validation script

## Success Criteria

1. ✅ Can build from command line without opening Unity
2. ✅ All scenes included in build
3. ✅ Executable runs without errors
4. ✅ Multiplayer connectivity works
5. ✅ Resources load correctly

## Benefits

1. **CI/CD Integration**: Can build on servers
2. **Faster Iteration**: No need to open Unity
3. **Consistent Builds**: Same settings every time
4. **Automation**: Part of larger pipeline
5. **Testing**: Can run automated tests

## Next Steps

1. Implement BuildScript.cs
2. Create scene generation utilities
3. Create prefab generation utilities
4. Test command line builds
5. Document any platform-specific issues