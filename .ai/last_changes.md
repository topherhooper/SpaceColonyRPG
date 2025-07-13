# Recent Changes (Auto-generated)
Generated: 2025-07-13 15:12:09

## Modified Files
.claude/settings.local.json
.gitignore
Assets/_Project/Materials/Building_Mat.mat
Assets/_Project/Materials/Colonist_Mat.mat
Assets/_Project/Materials/Colonist_Mat.mat.meta
Assets/_Project/Materials/Enemy_Mat.mat
Assets/_Project/Materials/Ground_Mat.mat
Assets/_Project/Materials/Loot_Mat.mat
Assets/_Project/Materials/Loot_Mat.mat.meta
Assets/_Project/Materials/Player_Mat.mat
Assets/_Project/Materials/Projectile_Mat.mat
Assets/_Project/Materials/Projectile_Mat.mat.meta
Assets/_Project/Prefabs/Buildings/Barracks.prefab
Assets/_Project/Prefabs/Buildings/Barracks.prefab.meta
Assets/_Project/Prefabs/Buildings/Farm.prefab
Assets/_Project/Prefabs/Buildings/Farm.prefab.meta
Assets/_Project/Prefabs/Buildings/Generator.prefab
Assets/_Project/Prefabs/Buildings/Generator.prefab.meta
Assets/_Project/Prefabs/Buildings/Mine.prefab
Assets/_Project/Prefabs/Buildings/Mine.prefab.meta
Assets/_Project/Prefabs/Buildings/Storage.prefab
Assets/_Project/Prefabs/Buildings/Storage.prefab.meta
Assets/_Project/Prefabs/Colonist.prefab
Assets/_Project/Prefabs/Colonist.prefab.meta
Assets/_Project/Prefabs/Enemies/Enemy.prefab
Assets/_Project/Prefabs/Enemies/Enemy.prefab.meta
Assets/_Project/Prefabs/LootPickup.prefab
Assets/_Project/Prefabs/LootPickup.prefab.meta
Assets/_Project/Prefabs/Players/Player.prefab
Assets/_Project/Prefabs/Projectiles/Projectile.prefab
Assets/_Project/Prefabs/Projectiles/Projectile.prefab.meta
Assets/_Project/Scenes/ColonyScene.unity
Assets/_Project/Scenes/MainMenu.unity
Assets/_Project/Scenes/RaidScene.unity
Assets/_Project/Scripts/Combat/RaidManager.cs
Assets/_Project/Scripts/Editor.meta
Assets/_Project/Scripts/Editor/BuildScript.cs.meta
Assets/_Project/Scripts/Editor/MaterialGenerator.cs
Assets/_Project/Scripts/Editor/MaterialGenerator.cs.meta
Assets/_Project/Scripts/Editor/PrefabGenerator.cs
Assets/_Project/Scripts/Editor/PrefabGenerator.cs.meta
Assets/_Project/Scripts/Editor/SceneGenerator.cs
Assets/_Project/Scripts/Editor/SceneGenerator.cs.meta
Assets/_Project/Scripts/Editor/SetupAutomation.cs
Assets/_Project/Scripts/Editor/SetupAutomation.cs.meta
Assets/_Project/Scripts/Managers.meta
Assets/_Project/Scripts/Networking/GameNetworkManager.cs
Assets/_Project/Scripts/UI/UIManager.cs
ProjectPlanningDocs/SceneCodingPlan.md
ProjectSettings/DynamicsManager.asset
ProjectSettings/EditorBuildSettings.asset
ProjectSettings/TagManager.asset
build-wsl.sh
build.bat
build.sh
compile-check.sh

## Statistics  
 .claude/settings.local.json                        |    9 +
 .gitignore                                         |    4 +-
 Assets/_Project/Materials/Building_Mat.mat         |   30 +-
 Assets/_Project/Materials/Colonist_Mat.mat         |  137 +
 Assets/_Project/Materials/Colonist_Mat.mat.meta    |    8 +
 Assets/_Project/Materials/Enemy_Mat.mat            |   32 +-
 Assets/_Project/Materials/Ground_Mat.mat           |   32 +-
 Assets/_Project/Materials/Loot_Mat.mat             |  137 +
 Assets/_Project/Materials/Loot_Mat.mat.meta        |    8 +
 Assets/_Project/Materials/Player_Mat.mat           |   34 +-
 Assets/_Project/Materials/Projectile_Mat.mat       |  137 +
 Assets/_Project/Materials/Projectile_Mat.mat.meta  |    8 +
 Assets/_Project/Prefabs/Buildings/Barracks.prefab  |  364 ++
 .../Prefabs/Buildings/Barracks.prefab.meta         |    7 +
 Assets/_Project/Prefabs/Buildings/Farm.prefab      |  364 ++
 Assets/_Project/Prefabs/Buildings/Farm.prefab.meta |    7 +
 Assets/_Project/Prefabs/Buildings/Generator.prefab |  364 ++
 .../Prefabs/Buildings/Generator.prefab.meta        |    7 +
 Assets/_Project/Prefabs/Buildings/Mine.prefab      |  364 ++
 Assets/_Project/Prefabs/Buildings/Mine.prefab.meta |    7 +
 Assets/_Project/Prefabs/Buildings/Storage.prefab   |  364 ++
 .../_Project/Prefabs/Buildings/Storage.prefab.meta |    7 +
 Assets/_Project/Prefabs/Colonist.prefab            |  151 +
 Assets/_Project/Prefabs/Colonist.prefab.meta       |    7 +
 Assets/_Project/Prefabs/Enemies/Enemy.prefab       |  260 +
 Assets/_Project/Prefabs/Enemies/Enemy.prefab.meta  |    7 +
 Assets/_Project/Prefabs/LootPickup.prefab          |  267 +
 Assets/_Project/Prefabs/LootPickup.prefab.meta     |    7 +
 Assets/_Project/Prefabs/Players/Player.prefab      |  532 +-
 .../_Project/Prefabs/Projectiles/Projectile.prefab |  330 ++
 .../Prefabs/Projectiles/Projectile.prefab.meta     |    7 +
 Assets/_Project/Scenes/ColonyScene.unity           | 2458 +++++----
 Assets/_Project/Scenes/MainMenu.unity              | 4154 ++++++++++++---
 Assets/_Project/Scenes/RaidScene.unity             | 5344 +++++++++++++++++++-
 Assets/_Project/Scripts/Combat/RaidManager.cs      |   16 +-
 Assets/_Project/Scripts/Editor.meta                |    8 +
 Assets/_Project/Scripts/Editor/BuildScript.cs.meta |    2 +
 .../_Project/Scripts/Editor/MaterialGenerator.cs   |   45 +
 .../Scripts/Editor/MaterialGenerator.cs.meta       |    2 +
 Assets/_Project/Scripts/Editor/PrefabGenerator.cs  |   16 +-
 .../Scripts/Editor/PrefabGenerator.cs.meta         |    2 +
 Assets/_Project/Scripts/Editor/SceneGenerator.cs   |  737 ++-
 .../_Project/Scripts/Editor/SceneGenerator.cs.meta |    2 +
 Assets/_Project/Scripts/Editor/SetupAutomation.cs  |  285 +-
 .../Scripts/Editor/SetupAutomation.cs.meta         |    2 +
 Assets/_Project/Scripts/Managers.meta              |    8 +
 .../Scripts/Networking/GameNetworkManager.cs       |  217 +-
 Assets/_Project/Scripts/UI/UIManager.cs            |   55 +
 ProjectPlanningDocs/SceneCodingPlan.md             |  418 ++
 ProjectSettings/DynamicsManager.asset              |   19 +-
 ProjectSettings/EditorBuildSettings.asset          |    6 +-
 ProjectSettings/TagManager.asset                   |    7 +-
 build-wsl.sh                                       |  323 +-
 build.bat                                          |  108 -
 build.sh                                           |  126 -
 compile-check.sh                                   |    2 +-
 56 files changed, 15293 insertions(+), 3068 deletions(-)

## Key Changes
--- /dev/null
+++ b/.claude/settings.local.json
@@ -0,0 +1,9 @@
+{
+  "permissions": {
+    "allow": [
+      "Bash(mkdir:*)",
+      "Bash(chmod:*)"
+    ],
+    "deny": []
+  }
+}
--- a/.gitignore
+++ b/.gitignore
@@ -81 +81,3 @@ crashlytics-build.properties
-.vsconfig
+.vsconfig
+build_windows.log
+setup.log
--- a/Assets/_Project/Materials/Building_Mat.mat
+++ b/Assets/_Project/Materials/Building_Mat.mat
@@ -3,13 +2,0 @@
---- !u!114 &-7485561398667753769
-MonoBehaviour:
-  m_ObjectHideFlags: 11
-  m_CorrespondingSourceObject: {fileID: 0}
-  m_PrefabInstance: {fileID: 0}
-  m_PrefabAsset: {fileID: 0}
-  m_GameObject: {fileID: 0}
-  m_Enabled: 1

## Staged Changes Summary
- Files changed: 56
- Insertions: 15293 insertion
- Deletions: 3068 deletion
