# Day 0: Pre-Hackathon Developer Setup Guide

## Time Required: 4-6 hours

## Part 1: Installing Unity (Complete Beginner Guide)

### Step 1: Download Unity Hub
```bash
# Instructions for Claude Code:
# 1. Navigate to: https://unity.com/download
# 2. Click "Download Unity Hub"
# 3. Run the installer when download completes

Platform-specific:
- Windows: UnityHubSetup.exe
- Mac: UnityHubSetup.dmg
- Linux: UnityHub.AppImage (make executable with chmod +x)
```

### Step 2: Create Unity Account
```bash
1. Open Unity Hub after installation
2. Click "Sign in" in top-right
3. Select "Create a Unity ID"
4. Fill in:
   - Email address
   - Password (min 8 characters)
   - Username
   - Full name
5. Verify email address
```

### Step 3: Install Unity Editor
```bash
# In Unity Hub:
1. Click "Installs" tab (left sidebar)
2. Click "Install Editor" button (blue button, top-right)
3. Select "2022.3.XX LTS" (Long Term Support)
   - This is the most stable version
   - LTS = fewer bugs for hackathon

4. In modules selection, CHECK these boxes:
   □ Microsoft Visual Studio Community 2022 (for Windows)
   □ Visual Studio for Mac (for Mac users)
   □ Windows Build Support (IL2CPP)
   □ Mac Build Support (Mono)
   □ Documentation
   □ WebGL Build Support (optional but useful)

5. Click "Install" and wait (15-30 minutes depending on internet)
```

### Step 4: First Time Unity Setup
```bash
# Creating your first project to test:
1. In Unity Hub, click "Projects" tab
2. Click "New project" button
3. Select template: "3D (URP)" 
   - URP = Universal Render Pipeline (better performance)
4. Project Settings:
   - Project name: "TestProject"
   - Location: Create a "UnityProjects" folder on your drive
5. Click "Create project"
6. Unity will open (first time takes 5-10 minutes)
```

## Part 2: Complete Project Setup

### Creating the Hackathon Project
```bash
# Claude Code Instructions:
# Execute these commands in order after Unity installation

# 1. Create new project in Unity Hub
Project Template: 3D (URP)
Project Name: SpaceColonyRPG
Location: C:/UnityProjects/ (or your preferred location)
Unity Version: 2022.3.XX LTS

# 2. Wait for Unity to open, then create folder structure
```

### Folder Structure Creation Script
```csharp
// INSTRUCTIONS FOR CLAUDE CODE:
// 1. In Unity, go to Window > General > Console
// 2. Right-click in Project window > Create > C# Script
// 3. Name it "FolderSetup"
// 4. Double-click to open in Visual Studio
// 5. Replace ALL contents with this code:
// 6. Save and return to Unity
// 7. Drag script onto any GameObject in scene
// 8. Press Play button to create folders
// 9. Press Stop and delete the script

using UnityEngine;
using UnityEditor;
using System.IO;

public class FolderSetup : MonoBehaviour
{
    void Start()
    {
        CreateFolderStructure();
    }
    
    void CreateFolderStructure()
    {
        string[] folders = new string[]
        {
            "Assets/_Project",
            "Assets/_Project/Scripts",
            "Assets/_Project/Scripts/Colony",
            "Assets/_Project/Scripts/Combat",
            "Assets/_Project/Scripts/Networking",
            "Assets/_Project/Scripts/Player",
            "Assets/_Project/Scripts/UI",
            "Assets/_Project/Scripts/Utilities",
            "Assets/_Project/Prefabs",
            "Assets/_Project/Prefabs/Buildings",
            "Assets/_Project/Prefabs/Enemies",
            "Assets/_Project/Prefabs/Players",
            "Assets/_Project/Prefabs/Projectiles",
            "Assets/_Project/Prefabs/UI",
            "Assets/_Project/Prefabs/VFX",
            "Assets/_Project/Materials",
            "Assets/_Project/Textures",
            "Assets/_Project/Audio",
            "Assets/_Project/Audio/SFX",
            "Assets/_Project/Audio/Music",
            "Assets/_Project/Scenes",
            "Assets/ThirdParty"
        };
        
        foreach (string folder in folders)
        {
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
                Debug.Log($"Created folder: {folder}");
            }
        }
        
        AssetDatabase.Refresh();
        Debug.Log("Folder structure created successfully!");
    }
}
```

### Installing Visual Studio Code (Alternative to Visual Studio)
```bash
# For lightweight coding option:
1. Download from: https://code.visualstudio.com/
2. Install with default options
3. Install C# extension:
   - Open VS Code
   - Click Extensions icon (left sidebar)
   - Search "C# Dev Kit"
   - Click Install on Microsoft's official extension
4. In Unity: Edit > Preferences > External Tools
   - External Script Editor: Browse to VS Code
```

### Git Setup for Version Control
```bash
# Step 1: Install Git
- Windows: https://git-scm.com/download/win
- Mac: Install via Terminal: brew install git
- Linux: sudo apt-get install git

# Step 2: Install GitHub Desktop (easier for beginners)
Download from: https://desktop.github.com/

# Step 3: Create .gitignore file
1. In your project root folder (where Assets folder is)
2. Create new file named ".gitignore" (note the dot)
3. Copy this content:
```

### Unity .gitignore Template
```bash
# This file tells Git what NOT to track
# INSTRUCTIONS: Save as .gitignore in project root

# Unity folders to ignore
[Ll]ibrary/
[Tt]emp/
[Oo]bj/
[Bb]uild/
[Bb]uilds/
[Ll]ogs/
[Uu]ser[Ss]ettings/

# MemoryCaptures can get excessive
[Mm]emoryCaptures/

# Asset meta data should only be ignored if using Asset Server
!/[Aa]ssets/**/*.meta

# Recordings can get excessive
[Rr]ecordings/

# Uncomment this line if you wish to ignore the asset store tools plugin
# /[Aa]ssets/AssetStoreTools*

# Autogenerated Jetbrains Rider plugin
[Aa]ssets/Plugins/Editor/JetBrains*

# Visual Studio cache directory
.vs/

# Gradle cache directory
.gradle/

# Autogenerated VS/MD/Consulo solution and project files
ExportedObj/
.consulo/
*.csproj
*.unityproj
*.sln
*.suo
*.tmp
*.user
*.userprefs
*.pidb
*.booproj
*.svd
*.pdb
*.mdb
*.opendb
*.VC.db

# Unity3D generated meta files
*.pidb.meta
*.pdb.meta
*.mdb.meta

# Unity3D generated file on crash reports
sysinfo.txt

# Builds
*.apk
*.aab
*.unitypackage
*.app

# Crashlytics generated file
crashlytics-build.properties

# Packed Addressables
/[Aa]ssets/[Aa]ddressable[Aa]ssets[Dd]ata/*/*.bin*

# Temporary auto-generated Android Assets
/[Aa]ssets/[Ss]treamingAssets/aa.meta
/[Aa]ssets/[Ss]treamingAssets/aa/*

# MacOS
.DS_Store
```

## Part 3: Installing Essential Assets

### How to Use Unity Asset Store
```bash
# BEGINNER INSTRUCTIONS:
1. In Unity, go to: Window > Asset Store (or Ctrl+9)
2. Sign in with your Unity account
3. Search for asset name
4. Click on asset
5. Click "Add to My Assets"
6. Click "Open in Unity"
7. In Package Manager: Click "Download" then "Import"
8. In import window: Click "Import" (keep all files checked)
```

### Essential Free Assets

#### 1. **Mirror Networking** (FREE)
```bash
# CLAUDE CODE INSTRUCTIONS:
# Step-by-step Mirror installation:

1. Open Unity
2. Go to: Window > Package Manager
3. Click '+' button (top-left)
4. Select "Add package from git URL"
5. Paste: https://github.com/Mirror-Networking/Mirror.git
6. Click 'Add'
7. Wait for import to complete

# Alternative method (Asset Store):
1. Window > Asset Store
2. Search: "Mirror Networking"
3. Click "Add to My Assets"
4. Go to Package Manager
5. Top dropdown: Change to "My Assets"
6. Find Mirror, click Download, then Import
```

#### 2. **Polygon Sci-Fi Space Pack** (FREE)
```
Publisher: Synty Studios
Contains: Low-poly space-themed models perfect for colonies
- Buildings, props, materials
- Sci-fi environment pieces
```

#### 3. **Free Low Poly Space Kit** (FREE)
```
Publisher: Nerd Castle
Contains: Additional space assets
- Asteroids, planets, space stations
- Good for raid environments
```

#### 4. **Simple Low Poly Nature Pack** (FREE)
```
Publisher: NeutronCat
Contains: Trees, rocks for colony terrain
Note: Recolor to alien palette
```

### Cheap But Valuable Assets ($5-20 range)

#### 1. **Feel - Game Feel Engine** (~$10 on sale)
```
Why: Instant game juice (screenshake, hit pause, etc.)
Alternative FREE: Write basic screenshake yourself
```

#### 2. **DOTween Pro** (~$15 on sale)
```
Why: Smooth UI animations, movement
Alternative FREE: DOTween Free version (sufficient)
```

### Free Tools & Resources

#### Audio Assets
```bash
1. Freesound.org
   - Search: "laser", "explosion", "sci-fi"
   - Account required (free)

2. OpenGameArt.org  
   - Filter: Sci-fi sounds
   - CC0 licensed audio

3. Zapsplat.com
   - Free with account
   - Great sci-fi SFX library

4. YouTube Audio Library
   - Royalty-free music
   - Good for background tracks
```

#### Fonts
```bash
1. Google Fonts:
   - Orbitron (sci-fi style)
   - Exo 2 (clean, futuristic)
   - Share Tech Mono (terminal style)

2. DaFont.com:
   - Search "sci-fi" category
   - Check license for each
```

### Quick Asset Lists

#### Minimum Required SFX (Find Free)
```markdown
- weapon_laser_shoot.wav
- enemy_hit.wav  
- enemy_death.wav
- building_place.wav
- resource_pickup.wav
- level_up.wav
- button_click.wav
- error_buzz.wav
```

#### Basic Particle Effects (Make with Unity)
```markdown
- Muzzle flash (yellow burst)
- Hit impact (spark burst)
- Enemy death (dissolve)
- Level up (ring expand)
- Building complete (shine)
```

### Project Configuration

#### 1. **Setting Up Layers** (What are Layers?)
```bash
# Layers help Unity know what objects can interact
# Like having different "channels" for different object types

INSTRUCTIONS:
1. Top menu: Edit > Project Settings
2. Left panel: Click "Tags and Layers"
3. Under "Layers", you'll see Layer 0-7 are built-in
4. Click on Layer 8, type: Ground
5. Click on Layer 9, type: Building
6. Click on Layer 10, type: Enemy
7. Click on Layer 11, type: Player
8. Click on Layer 12, type: Projectile
9. Close Project Settings

# Why we need these:
- Ground: For placement detection
- Building: So buildings don't shoot each other
- Enemy: For targeting system
- Player: For enemy AI detection
- Projectile: So bullets only hit enemies/players
```

#### 2. **Setting Up Tags** (What are Tags?)
```bash
# Tags are labels to identify GameObjects quickly

INSTRUCTIONS:
1. Still in Project Settings > Tags and Layers
2. Under "Tags", click the + button
3. Add these tags one by one:
   - Player
   - Enemy
   - Building
   - Colonist
   - Resource
   - Projectile
```

#### 3. **Input System Setup**
```bash
# This tells Unity what keys/buttons do what

INSTRUCTIONS:
1. Edit > Project Settings
2. Left panel: Click "Input Manager"
3. You'll see "Axes" with items like "Horizontal"
4. These are already set up for WASD/Arrow keys!
5. Verify these exist:
   - Horizontal (A/D, Left/Right arrows)
   - Vertical (W/S, Up/Down arrows)
   - Fire1 (Left mouse button)
   - Fire2 (Right mouse button)
   - Jump (Spacebar)
   - Cancel (Escape key)

# No changes needed - Unity has good defaults!
```

#### 4. **Build Settings**
```bash
# Preparing for multiplayer testing

INSTRUCTIONS:
1. File > Build Settings
2. Platform should be "PC, Mac & Linux Standalone"
3. Click "Player Settings" button
4. In Inspector panel, set:
   - Company Name: Your name or team
   - Product Name: Space Colony Defender
   - Default Icon: Leave default for now
5. Close Build Settings
```

### Creating Your First Script (Beginner Tutorial)
```bash
# What is a script? It's code that controls GameObject behavior

INSTRUCTIONS:
1. In Project window, navigate to: _Project/Scripts/Utilities
2. Right-click in empty space
3. Create > C# Script
4. Name it: "HelloUnity" (press Enter)
5. Double-click the script (Visual Studio/VS Code opens)
6. You'll see some starter code - that's normal!

# Understanding the default script:
- "using" lines: Import Unity features
- "public class": Your script's name
- "Start()": Runs once when game starts
- "Update()": Runs every frame (60 times/second)
```

### Time-Saving Prefab Templates

#### What is a Prefab?
```bash
# Prefab = Reusable GameObject template
# Like a blueprint you can spawn multiple times

HOW TO CREATE A PREFAB:
1. Create GameObject in scene (Hierarchy window)
2. Set it up with components
3. Drag from Hierarchy to Project window
4. It turns blue = It's now a prefab!
5. Delete from scene - you can spawn it later
```

#### 1. **Basic Enemy Template**
```bash
INSTRUCTIONS TO CREATE:
1. In Hierarchy: Right-click > 3D Object > Capsule
2. Rename to "Enemy"
3. In Inspector, click "Add Component"
4. Add these components:
   - Rigidbody (for physics)
   - Capsule Collider (already there)
   - Nav Mesh Agent (for AI movement)
5. Create materials (see next section first)
6. Drag Enemy_Mat to the Capsule
7. Drag to: _Project/Prefabs/Enemies folder
```

#### 2. **Building Template**
```
GameObject Structure:
Building
├── Model (Cube scaled)
├── Collider (Box)
├── Construction Site
│   └── Progress Bar Canvas
└── Scripts
    ├── Building
    └── BuildingUI
```

#### 3. **Projectile Template**
```
GameObject Structure:
Projectile
├── Model (Cylinder scaled)
├── Trail Renderer
├── Collider (trigger)
├── Rigidbody
└── Scripts
    └── Projectile
```

### Quick Material Setup

#### How to Create Materials (Complete Beginner Guide)
```bash
# Materials = What makes objects look different (color, shine, etc.)

INSTRUCTIONS FOR EACH MATERIAL:
1. In Project window: _Project/Materials folder
2. Right-click > Create > Material
3. Name it (see below)
4. Select the new material
5. In Inspector, change settings as listed
```

Create these basic materials:
```markdown
1. **Player_Mat**
   INSTRUCTIONS:
   - In Inspector, find "Surface Options"
   - Click color box next to "Base Map"
   - Set to bright blue: R=0, G=128, B=255
   - Find "Metallic Map" slider: Set to 0.8
   - Find "Smoothness" slider: Set to 0.8
   
2. **Enemy_Mat**
   INSTRUCTIONS:
   - Base Map color: Red (R=255, G=0, B=0)
   - Scroll down to "Emission"
   - Check "Emission" checkbox
   - Emission color: Dark red (R=128, G=0, B=0)

3. **Building_Mat**
   INSTRUCTIONS:
   - Base Map color: Gray (R=128, G=128, B=128)
   - Metallic: 0.5
   - Smoothness: 0.3

4. **Building_Ghost_Valid**
   INSTRUCTIONS:
   - Top of Inspector: "Surface Type" → Transparent
   - Base Map color: Green (R=0, G=255, B=0)
   - Alpha (A) slider in color: Set to 128

5. **Building_Ghost_Invalid**
   INSTRUCTIONS:
   - Surface Type → Transparent
   - Base Map color: Red (R=255, G=0, B=0)
   - Alpha (A): 128
```

### Testing Tools Setup

#### 1. **ParrelSync** (Test Multiplayer Locally)
```bash
# WHAT IT DOES: Lets you run 2 copies of your game on 1 computer
# BEGINNER-FRIENDLY INSTALLATION:

1. In Unity, go to: Window > Package Manager
2. Click '+' button > "Add package from git URL"
3. Paste: https://github.com/VeriorPies/ParrelSync.git
4. Click 'Add' and wait

HOW TO USE:
1. In Unity menu bar: ParrelSync > Clones Manager
2. Click "Create new clone"
3. Click "Open in New Editor" on the clone
4. Now you have 2 Unity editors!
5. Build and run in both to test multiplayer
```

#### 2. **Quick Testing Without ParrelSync**
```bash
# SIMPLER METHOD FOR BEGINNERS:

1. In Unity: File > Build Settings
2. Click "Build"
3. Create folder "Builds" on Desktop
4. Name it "TestBuild"
5. After build completes:
   - Run the .exe file (that's Player 1)
   - Click Play in Unity Editor (that's Player 2)
   - In Player 1: Host game
   - In Player 2: Join localhost
```

### Pre-Hackathon Code Templates

#### How to Use These Templates
```bash
# CLAUDE CODE INSTRUCTIONS:
# 1. Create new C# Script in appropriate folder
# 2. Open in VS Code/Visual Studio
# 3. DELETE all default code
# 4. PASTE template code
# 5. SAVE file (Ctrl+S)
# 6. Return to Unity

# IMPORTANT: Script filename MUST match class name!
# Example: "ManagerTemplate.cs" contains "public class ManagerTemplate"
```

#### 1. **Singleton Template** (One Instance Only)
```csharp
// WHAT IT DOES: Ensures only one copy exists in game
// USE FOR: Managers (GameManager, AudioManager, etc.)
// SAVE AS: ManagerTemplate.cs (rename as needed)

using UnityEngine;

public class ManagerTemplate : MonoBehaviour
{
    // Static reference to the single instance
    public static ManagerTemplate Instance { get; private set; }
    
    void Awake()
    {
        // If no instance exists, this becomes the instance
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Survive scene changes
        }
        else
        {
            // Destroy duplicates
            Destroy(gameObject);
        }
    }
    
    // Add your manager-specific code here
    public void DoSomething()
    {
        Debug.Log("Manager is working!");
    }
}

// HOW TO USE IN OTHER SCRIPTS:
// ManagerTemplate.Instance.DoSomething();
```

#### 2. **Object Pool Template**
```csharp
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool<T> where T : MonoBehaviour
{
    private Queue<T> pool = new Queue<T>();
    private T prefab;
    private Transform parent;
    
    public ObjectPool(T prefab, int initialSize, Transform parent = null)
    {
        this.prefab = prefab;
        this.parent = parent;
        
        for (int i = 0; i < initialSize; i++)
        {
            var obj = GameObject.Instantiate(prefab, parent);
            obj.gameObject.SetActive(false);
            pool.Enqueue(obj);
        }
    }
    
    public T Get()
    {
        if (pool.Count > 0)
        {
            var obj = pool.Dequeue();
            obj.gameObject.SetActive(true);
            return obj;
        }
        else
        {
            var obj = GameObject.Instantiate(prefab, parent);
            return obj;
        }
    }
    
    public void Return(T obj)
    {
        obj.gameObject.SetActive(false);
        pool.Enqueue(obj);
    }
}
```

#### 3. **Timer Utility**
```csharp
using System;
using UnityEngine;

[Serializable]
public class Timer
{
    public float Duration { get; private set; }
    public float TimeRemaining { get; private set; }
    public bool IsRunning { get; private set; }
    public bool IsFinished => TimeRemaining <= 0 && IsRunning;
    
    public Timer(float duration)
    {
        Duration = duration;
    }
    
    public void Start()
    {
        TimeRemaining = Duration;
        IsRunning = true;
    }
    
    public void Update(float deltaTime)
    {
        if (IsRunning && TimeRemaining > 0)
        {
            TimeRemaining -= deltaTime;
        }
    }
    
    public void Stop()
    {
        IsRunning = false;
    }
    
    public void Reset()
    {
        TimeRemaining = Duration;
        IsRunning = false;
    }
}
```

### Environment & Lighting Quick Setup

#### 1. **Understanding Unity Lighting**
```bash
# Unity starts with default lighting - let's improve it!

COMPLETE BEGINNER INSTRUCTIONS:
1. In Hierarchy, find "Directional Light"
2. Select it
3. In Inspector, under "Light":
   - Color: Click and set to pale yellow
   - Intensity: 0.8
   
# For space atmosphere:
1. Window > Rendering > Lighting
2. Click "New Lighting Settings" if prompted
3. In "Environment" section:
   - Skybox Material: Click circle, select "None"
   - Ambient Mode: Color
   - Ambient Color: Click and set to dark blue (R=0, G=16, B=48)
```

#### 2. **Post-Processing Quick Setup** (Make it Pretty!)
```bash
# Post-processing = Instagram filters for your game

BEGINNER INSTRUCTIONS:
1. Window > Package Manager
2. Top-left dropdown: "Unity Registry"
3. Search: "Post Processing"
4. Click "Install"

SETTING IT UP:
1. In Hierarchy: Right-click > Volume > Global Volume
2. Select the new "Global Volume"
3. In Inspector: "Profile" > New
4. Click "Add Override" > Post-processing > Bloom
5. Check all boxes and adjust:
   - Intensity: 0.5 (subtle glow)
   - Threshold: 1.0
6. Add Override > Vignette
   - Intensity: 0.3 (darken edges)
7. Add Override > Color Adjustments
   - Contrast: 10 (more punchy colors)
```

### Quick Reference Sheets

#### Useful Hotkeys
```
Unity:
- Ctrl+Shift+F: Focus on selected object
- Ctrl+D: Duplicate
- Ctrl+P: Play/Stop
- F2: Rename
- Ctrl+Z: Undo (lifesaver!)

VS Code:
- Ctrl+.: Quick fix
- F12: Go to definition
- Ctrl+Shift+F: Find in all files
- Alt+↑/↓: Move line up/down
```

#### Common Pitfalls to Avoid
```
1. Not setting up .gitignore properly
2. Forgetting to add [SerializeField] for inspector variables
3. Not testing multiplayer early
4. Hardcoding values instead of using variables
5. Forgetting to assign references in prefabs
```

### Final Pre-Hackathon Checklist

```markdown
BEGINNER CHECKLIST - Check each box when complete:

INSTALLATIONS:
□ Unity Hub installed and account created
□ Unity 2022.3 LTS installed with modules
□ Visual Studio or VS Code installed
□ Git installed
□ GitHub Desktop installed (optional but helpful)

PROJECT SETUP:
□ Created "SpaceColonyRPG" project
□ Folder structure created (run the script!)
□ Layers added (Ground, Building, Enemy, Player, Projectile)
□ Tags added (Player, Enemy, Building, etc.)
□ .gitignore file created in project root

ASSETS READY:
□ Mirror Networking imported
□ Free space assets bookmarked/downloaded
□ Materials created (Player, Enemy, Building, Ghost)
□ Saved template scripts for quick use

TESTING READY:
□ ParrelSync installed OR Build folder created
□ Tested creating a build
□ Post-processing package installed

FINAL TESTS:
□ Created a cube, added Rigidbody, pressed Play (it falls!)
□ Created a material, applied to cube (it's colorful!)
□ Opened and closed Visual Studio/VS Code from Unity

PERSONAL PREP:
□ Coffee/snacks/energy drinks stocked
□ Comfortable chair and desk setup
□ Alarm set for hackathon start time
□ Backup plan written down (in case features fail)
□ Motivational playlist ready on Spotify/YouTube
```

### Quick Reference for Common Unity Shortcuts
```bash
MUST-KNOW SHORTCUTS:
- Ctrl+S: SAVE (do this often!)
- Ctrl+P: Play/Stop game
- Ctrl+Z: Undo (lifesaver!)
- Ctrl+D: Duplicate selected object
- F: Focus camera on selected object
- Alt+Left Click: Rotate camera
- Middle Mouse: Pan camera
- Scroll Wheel: Zoom in/out

IN VISUAL STUDIO/VS CODE:
- Ctrl+S: Save file
- Ctrl+.: Quick fix errors
- F12: Go to definition
- Ctrl+F: Find text
- Ctrl+H: Find and replace
```

### Common Beginner Mistakes to Avoid
```bash
SAVE YOUR SANITY - AVOID THESE:

1. FORGETTING TO SAVE SCENES
   - Unity doesn't auto-save scenes!
   - Ctrl+S after EVERY change
   - Lost work = lost time

2. SCRIPT NAME MISMATCH
   - Script filename MUST match class name
   - "PlayerController.cs" = "public class PlayerController"
   - Mismatch = Unity can't find your script

3. NOT ASSIGNING REFERENCES
   - Dragged script onto GameObject?
   - Did you assign required objects in Inspector?
   - "None (GameObject)" = it won't work!

4. FORGETTING COLLIDERS
   - No collider = objects pass through each other
   - No trigger = OnTriggerEnter won't work
   - Check "Is Trigger" for pickups

5. WRONG PHYSICS SETTINGS
   - Rigidbody needed for moving objects
   - Freeze rotation to prevent spinning
   - Gravity off for projectiles

6. BUILD ERRORS
   - Test builds EARLY and OFTEN
   - Don't wait until day 7!
   - Missing scenes in Build Settings = black screen
```

### Emergency "Nothing Works!" Fixes
```bash
IF UNITY CRASHES OR ACTS WEIRD:
1. Save everything
2. Close Unity
3. Delete "Library" folder in project
4. Reopen Unity (it rebuilds Library)
5. Wait for reimport (5-10 minutes)

IF SCRIPTS WON'T COMPILE:
1. Check Console window for red errors
2. Double-click error to go to problem line
3. Common fixes:
   - Missing semicolon ;
   - Missing bracket { or }
   - Typo in variable name
   - Using = instead of ==

IF MULTIPLAYER WON'T CONNECT:
1. Both players on same network?
2. Firewall blocking Unity?
3. Using "localhost" or "127.0.0.1"?
4. Host first, then join
5. Check Mirror NetworkManager settings

IF OBJECTS ARE INVISIBLE:
1. Check Layer isn't hidden
2. Camera Culling Mask includes layer
3. Object has Mesh Renderer
4. Material assigned to renderer
5. Scale isn't 0,0,0
```

### Resource Links Quick Reference
```bash
ESSENTIAL BOOKMARKS:
Unity Learn (Free Tutorials): https://learn.unity.com
Mirror Docs: https://mirror-networking.com/docs
Unity Forums: https://forum.unity.com
Brackeys YouTube (Archived but gold): https://www.youtube.com/c/Brackeys
Game Programming Patterns: https://gameprogrammingpatterns.com

QUICK HELP:
Unity Scripting Reference: https://docs.unity3d.com/ScriptReference/
"How to" + your problem in Google usually works!

FREE ASSETS:
OpenGameArt: https://opengameart.org
Freesound: https://freesound.org
Mixamo (Free Animations): https://www.mixamo.com
Unity Asset Store Free: https://assetstore.unity.com/free
```

### Day 1 Quick Start Guide
```bash
WITH ALL THIS PREPARED, ON DAY 1:

HOUR 1:
1. Open SpaceColonyRPG project
2. Create scene: "TestMultiplayer"
3. Add Mirror NetworkManager
4. Create player prefab with movement
5. Test host/join locally

HOUR 2:
1. Add shooting to player
2. Sync projectiles over network
3. Test with 2 players
4. Celebrate - you have networked combat!

By end of Day 1, you'll be 4-6 hours ahead
of starting from scratch!
```

### Final Words of Encouragement
```bash
REMEMBER:
- Every expert was once a beginner
- Google is your friend
- Stack Overflow has your answer
- Taking breaks prevents bugs
- Simple and working > Complex and broken
- Have FUN - it's a hackathon!

YOU'VE GOT THIS! 
Your preparation will pay off!
```

**Total Prep Time: 4-6 hours**
**Time Saved During Hackathon: 8-12 hours**
**Result: More time for features and polish!**