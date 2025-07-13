#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.Build.Reporting;
using UnityEngine;
using System.IO;
using System.Linq;
using System.Collections.Generic;

public class BuildScript
{
    private static string[] SCENES = new string[]
    {
        "Assets/_Project/Scenes/MainMenu.unity",
        "Assets/_Project/Scenes/ColonyScene.unity",
        "Assets/_Project/Scenes/RaidScene.unity"
    };

    [MenuItem("Build/Build All Platforms")]
    public static void BuildAll()
    {
        BuildWindows();
        BuildMac();
        BuildLinux();
    }

    [MenuItem("Build/Build Windows")]
    public static void BuildWindows()
    {
        Build(BuildTarget.StandaloneWindows64, "Builds/Windows/SpaceColonyRPG.exe");
    }

    [MenuItem("Build/Build Mac")]
    public static void BuildMac()
    {
        Build(BuildTarget.StandaloneOSX, "Builds/Mac/SpaceColonyRPG.app");
    }

    [MenuItem("Build/Build Linux")]
    public static void BuildLinux()
    {
        Build(BuildTarget.StandaloneLinux64, "Builds/Linux/SpaceColonyRPG");
    }

    private static void Build(BuildTarget target, string outputPath)
    {
        Debug.Log($"Starting build for {target}...");

        // Pre-build setup
        if (!PreBuildSetup())
        {
            Debug.LogError("Pre-build setup failed!");
            return;
        }

        // Ensure output directory exists
        string directory = Path.GetDirectoryName(outputPath);
        if (!Directory.Exists(directory))
        {
            Directory.CreateDirectory(directory);
        }

        // Configure build options
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions
        {
            scenes = GetScenePaths(),
            locationPathName = outputPath,
            target = target,
            options = BuildOptions.None
        };

        // Configure player settings
        ConfigurePlayerSettings();

        // Execute build
        BuildReport report = BuildPipeline.BuildPlayer(buildPlayerOptions);
        BuildSummary summary = report.summary;

        if (summary.result == BuildResult.Succeeded)
        {
            Debug.Log($"Build succeeded: {summary.totalSize / 1024 / 1024} MB");
            Debug.Log($"Build saved to: {outputPath}");
            
            // Post-build actions
            PostBuildActions(outputPath, target);
        }
        else
        {
            Debug.LogError($"Build failed with {summary.totalErrors} errors");
        }
    }

    private static bool PreBuildSetup()
    {
        Debug.Log("Running pre-build setup...");

        // Ensure scenes exist
        if (!EnsureScenesExist())
        {
            Debug.Log("Creating missing scenes...");
            CreateMissingScenes();
        }

        // Ensure essential prefabs exist
        if (!EnsurePrefabsExist())
        {
            Debug.Log("Creating missing prefabs...");
            CreateEssentialPrefabs();
        }

        // Validate scripts compile
        if (EditorUtility.scriptCompilationFailed)
        {
            Debug.LogError("Script compilation errors detected!");
            return false;
        }

        return true;
    }

    private static void ConfigurePlayerSettings()
    {
        PlayerSettings.companyName = "7DayHackathon";
        PlayerSettings.productName = "Space Colony RPG";
        PlayerSettings.defaultScreenWidth = 1920;
        PlayerSettings.defaultScreenHeight = 1080;
        PlayerSettings.fullScreenMode = UnityEngine.FullScreenMode.Windowed;
        
        // Graphics settings
        PlayerSettings.SetGraphicsAPIs(BuildTarget.StandaloneWindows64, new[] { UnityEngine.Rendering.GraphicsDeviceType.Direct3D11 });
        
        // Quality settings
        QualitySettings.SetQualityLevel(2); // Medium quality
    }

    private static string[] GetScenePaths()
    {
        List<string> validScenes = new List<string>();
        
        foreach (string scene in SCENES)
        {
            if (File.Exists(scene))
            {
                validScenes.Add(scene);
            }
            else
            {
                Debug.LogWarning($"Scene not found: {scene}");
            }
        }

        if (validScenes.Count == 0)
        {
            Debug.LogError("No valid scenes found!");
            // Return at least one scene to prevent build error
            validScenes.Add("Assets/_Project/Scenes/MainMenu.unity");
        }

        return validScenes.ToArray();
    }

    private static bool EnsureScenesExist()
    {
        foreach (string scenePath in SCENES)
        {
            if (!File.Exists(scenePath))
            {
                return false;
            }
        }
        return true;
    }

    private static void CreateMissingScenes()
    {
        string scenesPath = "Assets/_Project/Scenes";
        if (!Directory.Exists(scenesPath))
        {
            Directory.CreateDirectory(scenesPath);
            AssetDatabase.Refresh();
        }

        // This would need to be implemented with scene creation logic
        Debug.LogWarning("Scene creation not implemented - please create scenes manually or use SceneGenerator");
    }

    private static bool EnsurePrefabsExist()
    {
        string[] requiredPrefabs = new string[]
        {
            "Assets/_Project/Prefabs/Players/Player.prefab",
            "Assets/_Project/Prefabs/Enemies/Enemy.prefab",
            "Assets/_Project/Prefabs/Projectiles/Projectile.prefab"
        };

        foreach (string prefab in requiredPrefabs)
        {
            if (!File.Exists(prefab))
            {
                return false;
            }
        }
        return true;
    }

    private static void CreateEssentialPrefabs()
    {
        // This would need prefab creation logic
        Debug.LogWarning("Prefab creation not implemented - please create prefabs manually or use PrefabGenerator");
    }

    private static void PostBuildActions(string buildPath, BuildTarget target)
    {
        string buildDir = Path.GetDirectoryName(buildPath);
        
        // Copy README
        string readmePath = Path.Combine(buildDir, "README.txt");
        File.WriteAllText(readmePath, GetReadmeContent());
        
        // Copy controls guide
        string controlsPath = Path.Combine(buildDir, "Controls.txt");
        File.WriteAllText(controlsPath, GetControlsContent());
        
        Debug.Log($"Post-build actions completed for {target}");
    }

    private static string GetReadmeContent()
    {
        return @"SPACE COLONY RPG - 7 Day Hackathon Build
=========================================

Thank you for testing our game!

QUICK START:
1. Run SpaceColonyRPG.exe
2. Click 'New Game' to start
3. Build your colony with 'B' key
4. Click 'Start Raid' when ready
5. Survive the alien attack!

MULTIPLAYER:
- Host: Click 'Host Raid' 
- Join: Enter host's IP and click 'Join Raid'

KNOWN ISSUES:
- Some visual effects may be missing
- Balance is still being tuned
- Save/Load may have issues

Report bugs to: [your email/discord]

Have fun!
";
    }

    private static string GetControlsContent()
    {
        return @"CONTROLS
========

COLONY MODE:
- WASD: Move camera
- B: Toggle build mode
- 1-5: Select building type
- Tab: Building menu
- Left Click: Place building
- Right Click: Cancel

RAID MODE:
- WASD: Move player
- Mouse: Aim
- Left Click: Shoot
- Tab: Scoreboard
- Esc: Pause

TIPS:
- Build generators first for energy
- Place buildings efficiently
- Work together in raids
- Collect loot for resources
";
    }

    // Command line entry points
    public static void BuildWindowsCLI()
    {
        BuildWindows();
        EditorApplication.Exit(0);
    }

    public static void BuildMacCLI()
    {
        BuildMac();
        EditorApplication.Exit(0);
    }

    public static void BuildLinuxCLI()
    {
        BuildLinux();
        EditorApplication.Exit(0);
    }
}
#endif