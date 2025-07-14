# Recent Changes (Auto-generated)
Generated: 2025-07-13 22:57:44

## Modified Files
.github/workflows/code-quality.yml
.github/workflows/unity-tests-debug.yml
.github/workflows/unity-tests.yml

## Statistics  
 .github/workflows/code-quality.yml      |   2 +-
 .github/workflows/unity-tests-debug.yml | 100 ++++++++++++++++++++++++++++++++
 .github/workflows/unity-tests.yml       |  15 +++--
 3 files changed, 108 insertions(+), 9 deletions(-)

## Key Changes
--- a/.github/workflows/code-quality.yml
+++ b/.github/workflows/code-quality.yml
@@ -147 +147 @@ jobs:
-      uses: actions/upload-artifact@v3
+      uses: actions/upload-artifact@v4
--- /dev/null
+++ b/.github/workflows/unity-tests-debug.yml
@@ -0,0 +1,100 @@
+name: Unity Tests Debug
+on:
+  workflow_dispatch:
+jobs:
+  debug-info:
+    name: Debug Unity Setup
+    runs-on: ubuntu-latest
+    
+    steps:
+    - name: Checkout repository
+      uses: actions/checkout@v4
+      with:
+        lfs: true
+        
+    - name: Check Unity License
+      run: |
+        echo "=== Checking Unity License Setup ==="
+        if [ -z "${{ secrets.UNITY_LICENSE }}" ]; then
+          echo "❌ UNITY_LICENSE secret is not set"
+        else
+          echo "✅ UNITY_LICENSE secret is set (length: ${#UNITY_LICENSE})"
+        fi

## Staged Changes Summary
- Files changed: 3
- Insertions: 108 insertion
- Deletions: 9 deletion
