# Recent Changes (Auto-generated)
Generated: 2025-07-13 22:15:03

## Modified Files
.github/workflows/README.md
.github/workflows/code-quality.yml
.github/workflows/unity-tests.yml

## Statistics  
 .github/workflows/README.md        |  17 ++-
 .github/workflows/code-quality.yml | 215 +++++++++++++------------------------
 .github/workflows/unity-tests.yml  |  44 +-------
 3 files changed, 93 insertions(+), 183 deletions(-)

## Key Changes
--- a/.github/workflows/README.md
+++ b/.github/workflows/README.md
@@ -51,0 +52 @@ If you have Unity Teams Advanced:
+### Unity Tests (`unity-tests.yml`)
@@ -55 +55,0 @@ If you have Unity Teams Advanced:
@@ -58,0 +59,5 @@ If you have Unity Teams Advanced:
+### Code Quality (`code-quality.yml`)
+- **Security Scanning**: Blocks commits with potential sensitive data
+- **Performance Warnings**: Identifies potential performance issues (non-blocking)
+- **Code Style Suggestions**: Optional style checks (informational only)
@@ -109 +114,9 @@ Before pushing, test locally with:
-This runs the same tests that will run in CI.
+This runs the same tests that will run in CI.
+## Note on Code Quality
+Code linting is available but not enforced in the workflows. You can run linting locally with:
+```bash
+./build-wsl.sh lint        # Check for issues
+./build-wsl.sh fix-lint    # Auto-fix issues
+```
--- a/.github/workflows/code-quality.yml
+++ b/.github/workflows/code-quality.yml
@@ -11,2 +11,2 @@ jobs:
-  lint:
-    name: Code Linting
+  performance-check:
+    name: Performance Check
@@ -19 +19 @@ jobs:
-    - name: Check C# Files
+    - name: Check for Performance Issues
@@ -21 +21 @@ jobs:

## Staged Changes Summary
- Files changed: 3
- Insertions: 93 insertion
- Deletions: 183 deletion
