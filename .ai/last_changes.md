# Recent Changes (Auto-generated)
Generated: 2025-07-13 20:56:39

## Modified Files
.github/workflows/README.md
.github/workflows/code-quality.yml
.github/workflows/unity-tests.yml
build-wsl.sh

## Statistics  
 .github/workflows/README.md        | 109 +++++++++++++++++++
 .github/workflows/code-quality.yml | 215 +++++++++++++++++++++++++++++++++++++
 .github/workflows/unity-tests.yml  | 188 ++++++++++++++++++++++++++++++++
 build-wsl.sh                       | 148 ++++++++++++++++++++++++-
 4 files changed, 659 insertions(+), 1 deletion(-)

## Key Changes
--- /dev/null
+++ b/.github/workflows/README.md
@@ -0,0 +1,109 @@
+# GitHub Actions Unity Setup
+This workflow runs Unity tests automatically on push and pull requests.
+## Prerequisites
+You need to set up the following secrets in your GitHub repository:
+1. **UNITY_LICENSE**: Your Unity license file content
+2. **UNITY_EMAIL**: Unity account email
+3. **UNITY_PASSWORD**: Unity account password
+## Getting Your Unity License
+### Option 1: Manual Activation (Recommended)
+1. Generate a license request file:
+   ```bash
+   Unity -batchmode -createManualActivationFile -quit
+   ```
+   This creates `Unity_v6000.x.alf` file
+2. Upload the .alf file to: https://license.unity3d.com/manual
+3. Download the .ulf license file
+4. Set the contents of the .ulf file as the `UNITY_LICENSE` secret
+### Option 2: Using Unity License Server
+If you have Unity Teams Advanced:
+1. Set `UNITY_SERIAL` instead of `UNITY_LICENSE`
+2. The workflow will automatically activate
+## Setting GitHub Secrets
+1. Go to your repository on GitHub
+2. Navigate to Settings → Secrets and variables → Actions
+3. Click "New repository secret"
+4. Add each secret:
+   - Name: `UNITY_LICENSE`

## Staged Changes Summary
- Files changed: 4
- Insertions: 659 insertion
- Deletions: 1 deletion
