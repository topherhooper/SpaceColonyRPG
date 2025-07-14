# Recent Changes (Auto-generated)
Generated: 2025-07-13 21:01:43

## Modified Files
Assets/Tests.meta
Assets/Tests/EditMode.meta
Assets/Tests/EditMode/Colony.meta
Assets/Tests/EditMode/Combat.meta
Assets/Tests/EditMode/EditModeTests.asmdef.meta
Assets/Tests/EditMode/Player.meta
Assets/Tests/EditMode/Utilities.meta
Assets/Tests/PlayMode.meta
Assets/Tests/PlayMode/Integration.meta
Assets/Tests/PlayMode/Networking.meta
Assets/Tests/PlayMode/PlayModeTests.asmdef.meta
Assets/Tests/README.md.meta
Assets/Tests/SETUP_REQUIRED.md.meta
Assets/_Project/Scripts/Editor/PrefabGenerator.cs
Assets/_Project/Scripts/Editor/SceneGenerator.cs
Assets/_Project/Scripts/Editor/SpaceColonyRPG.Editor.asmdef.meta
Assets/_Project/Scripts/Editor/TestRunner.cs
Assets/_Project/Scripts/SpaceColonyRPG.Runtime.asmdef.meta
TestResults/editmode-log.txt
TestResults/playmode-log.txt
build-wsl.sh

## Statistics  
 Assets/Tests.meta                                  |   8 +-
 Assets/Tests/EditMode.meta                         |   8 +-
 Assets/Tests/EditMode/Colony.meta                  |   8 +-
 Assets/Tests/EditMode/Combat.meta                  |   8 +-
 Assets/Tests/EditMode/EditModeTests.asmdef.meta    |   7 +-
 Assets/Tests/EditMode/Player.meta                  |   8 +-
 Assets/Tests/EditMode/Utilities.meta               |   8 +-
 Assets/Tests/PlayMode.meta                         |   8 +-
 Assets/Tests/PlayMode/Integration.meta             |   8 +-
 Assets/Tests/PlayMode/Networking.meta              |   8 +-
 Assets/Tests/PlayMode/PlayModeTests.asmdef.meta    |   7 +-
 Assets/Tests/README.md.meta                        |   7 +-
 Assets/Tests/SETUP_REQUIRED.md.meta                |   7 +
 Assets/_Project/Scripts/Editor/PrefabGenerator.cs  |  14 +-
 Assets/_Project/Scripts/Editor/SceneGenerator.cs   |   8 +-
 .../Editor/SpaceColonyRPG.Editor.asmdef.meta       |   7 +-
 Assets/_Project/Scripts/Editor/TestRunner.cs       |   1 +
 .../Scripts/SpaceColonyRPG.Runtime.asmdef.meta     |   7 +-
 TestResults/editmode-log.txt                       | 795 +++++++++++++++++++++
 TestResults/playmode-log.txt                       | 437 +++++++++++
 build-wsl.sh                                       |  70 +-
 21 files changed, 1413 insertions(+), 26 deletions(-)

## Key Changes
--- a/Assets/Tests.meta
+++ b/Assets/Tests.meta
@@ -2 +2,7 @@ fileFormatVersion: 2
-guid: 0a4a76b14d236974280ce2d59ad60a57
+guid: 0a4a76b14d236974280ce2d59ad60a57
+folderAsset: yes
+DefaultImporter:
+  externalObjects: {}
+  userData: 
+  assetBundleName: 
+  assetBundleVariant: 
--- a/Assets/Tests/EditMode.meta
+++ b/Assets/Tests/EditMode.meta
@@ -2 +2,7 @@ fileFormatVersion: 2
-guid: 7acd170351e20a84fb965e5d430e9074
+guid: 7acd170351e20a84fb965e5d430e9074
+folderAsset: yes
+DefaultImporter:
+  externalObjects: {}
+  userData: 
+  assetBundleName: 
+  assetBundleVariant: 
--- a/Assets/Tests/EditMode/Colony.meta
+++ b/Assets/Tests/EditMode/Colony.meta
@@ -2 +2,7 @@ fileFormatVersion: 2
-guid: 5a91295c6b058fd48b6bf49356960a29
+guid: 5a91295c6b058fd48b6bf49356960a29
+folderAsset: yes
+DefaultImporter:
+  externalObjects: {}

## Staged Changes Summary
- Files changed: 21
- Insertions: 1413 insertion
- Deletions: 26 deletion
