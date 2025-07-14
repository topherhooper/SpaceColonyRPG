# Recent Changes (Auto-generated)
Generated: 2025-07-13 23:03:03

## Modified Files
.github/workflows/README.md
.github/workflows/code-quality.yml
.github/workflows/unity-tests-debug.yml
.github/workflows/unity-tests.yml

## Statistics  
 .github/workflows/README.md             | 122 --------------
 .github/workflows/code-quality.yml      | 152 -----------------
 .github/workflows/unity-tests-debug.yml | 100 -----------
 .github/workflows/unity-tests.yml       | 287 ++++++++++++++++++--------------
 4 files changed, 159 insertions(+), 502 deletions(-)

## Key Changes
--- a/.github/workflows/README.md
+++ /dev/null
@@ -1,122 +0,0 @@
-# GitHub Actions Unity Setup
-This workflow runs Unity tests automatically on push and pull requests.
-## Prerequisites
-You need to set up the following secrets in your GitHub repository:
-1. **UNITY_LICENSE**: Your Unity license file content
-2. **UNITY_EMAIL**: Unity account email
-3. **UNITY_PASSWORD**: Unity account password
-## Getting Your Unity License
-### Option 1: Manual Activation (Recommended)
-1. Generate a license request file:
-   ```bash
-   Unity -batchmode -createManualActivationFile -quit
-   ```
-   This creates `Unity_v6000.x.alf` file
-2. Upload the .alf file to: https://license.unity3d.com/manual
-3. Download the .ulf license file
-4. Set the contents of the .ulf file as the `UNITY_LICENSE` secret
-### Option 2: Using Unity License Server
-If you have Unity Teams Advanced:
-1. Set `UNITY_SERIAL` instead of `UNITY_LICENSE`
-2. The workflow will automatically activate
-## Setting GitHub Secrets
-1. Go to your repository on GitHub
-2. Navigate to Settings → Secrets and variables → Actions
-3. Click "New repository secret"
-4. Add each secret:
-   - Name: `UNITY_LICENSE`

## Staged Changes Summary
- Files changed: 4
- Insertions: 159 insertion
- Deletions: 502 deletion
