# GitHub Actions Unity Setup

This workflow runs Unity tests automatically on push and pull requests.

## Prerequisites

You need to set up the following secrets in your GitHub repository:

1. **UNITY_LICENSE**: Your Unity license file content
2. **UNITY_EMAIL**: Unity account email
3. **UNITY_PASSWORD**: Unity account password

## Getting Your Unity License

### Option 1: Manual Activation (Recommended)

1. Generate a license request file:
   ```bash
   Unity -batchmode -createManualActivationFile -quit
   ```
   This creates `Unity_v6000.x.alf` file

2. Upload the .alf file to: https://license.unity3d.com/manual

3. Download the .ulf license file

4. Set the contents of the .ulf file as the `UNITY_LICENSE` secret

### Option 2: Using Unity License Server

If you have Unity Teams Advanced:
1. Set `UNITY_SERIAL` instead of `UNITY_LICENSE`
2. The workflow will automatically activate

## Setting GitHub Secrets

1. Go to your repository on GitHub
2. Navigate to Settings → Secrets and variables → Actions
3. Click "New repository secret"
4. Add each secret:
   - Name: `UNITY_LICENSE`
   - Value: (paste entire .ulf file content)
   
   - Name: `UNITY_EMAIL`
   - Value: your-unity-email@example.com
   
   - Name: `UNITY_PASSWORD`
   - Value: your-unity-password

## Workflow Features

### Unity Tests (`unity-tests.yml`)
- **Automatic Testing**: Runs both EditMode and PlayMode tests
- **Code Coverage**: Generates coverage reports with badges
- **Build Validation**: Ensures the project builds successfully
- **Caching**: Speeds up subsequent runs by caching Unity Library
- **Artifacts**: Stores test results and builds for 7 days

### Code Quality (`code-quality.yml`)
- **Security Scanning**: Blocks commits with potential sensitive data
- **Performance Warnings**: Identifies potential performance issues (non-blocking)
- **Code Style Suggestions**: Optional style checks (informational only)

## Customization

### Running on Different Unity Versions

Edit the `matrix.unity-version` in the workflow:
```yaml
strategy:
  matrix:
    unity-version: ['6000.1.11f1', '2022.3.10f1']
```

### Building for Different Platforms

Add platforms to the build matrix:
```yaml
strategy:
  matrix:
    targetPlatform: [StandaloneWindows64, StandaloneLinux64, StandaloneOSX]
```

### Triggering Manually

The workflow includes `workflow_dispatch` which allows manual triggering from the Actions tab.

## Troubleshooting

### License Activation Failed

- Ensure your Unity license is valid and not expired
- Check if the Unity version in the workflow matches your license
- Try regenerating the license file

### Tests Not Found

- Ensure test assemblies are properly configured
- Check that Mirror and other dependencies are included in the project

### Build Failures

- Check the build logs in the GitHub Actions run
- Ensure all required packages are committed to the repository
- Verify .meta files are included

## Local Testing

Before pushing, test locally with:
```bash
./build-wsl.sh tests
```

This runs the same tests that will run in CI.

## Note on Code Quality

Code linting is available but not enforced in the workflows. You can run linting locally with:
```bash
./build-wsl.sh lint        # Check for issues
./build-wsl.sh fix-lint    # Auto-fix issues
```