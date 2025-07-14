# Unity Test Setup - Additional Steps Required

## Package Dependencies

The test suite requires the following Unity packages to be installed via Package Manager:

1. **Test Framework** (com.unity.test-framework)
   - Required for all unit tests
   - Usually included by default

2. **Code Coverage** (com.unity.testtools.codecoverage)
   - Optional but recommended for coverage reports
   - Install for test coverage metrics

3. **NSubstitute** 
   - Mocking framework for unit tests
   - Download from: https://nsubstitute.github.io/
   - Add DLL to project

## Assembly Definition Setup

The following assembly definitions have been created:
- `SpaceColonyRPG.Runtime.asmdef` - Main runtime code
- `SpaceColonyRPG.Editor.asmdef` - Editor scripts
- `EditModeTests.asmdef` - Edit mode tests
- `PlayModeTests.asmdef` - Play mode tests

## Manual Unity Setup

1. **Import Test Framework**
   - Window > Package Manager
   - Search for "Test Framework"
   - Install latest version

2. **Configure Test Runner**
   - Window > General > Test Runner
   - Click "Create EditMode Test Assembly Folder" if prompted
   - Click "Create PlayMode Test Assembly Folder" if prompted

3. **Fix Compilation Errors**
   - Some optional dependencies may need to be installed:
     - Input System package (for new input system)
     - Universal Render Pipeline (for URP features)
   - Or keep them commented out if not using those features

## Running Tests

Once setup is complete:

1. **In Unity Editor**
   - Window > General > Test Runner
   - Select EditMode or PlayMode tab
   - Click "Run All"

2. **Via Menu**
   - Tools > Code Quality > Run All Tests

3. **Via Git Hook**
   - The pre-push hook will automatically run tests
   - Located at: .git/hooks/pre-push

## Test Coverage

To enable code coverage:
1. Install Code Coverage package
2. Enable code coverage in Test Runner settings
3. Run: Tools > Code Quality > Generate Test Coverage Report

## Troubleshooting

If you see "The type or namespace name 'X' could not be found":
1. Ensure all assembly definitions are properly configured
2. Check that Mirror package is installed
3. Verify namespace matches in your scripts
4. Restart Unity Editor if needed

## Current Test Status

✅ Created:
- ResourceManager tests (17 tests)
- GridSystem tests (12 tests)  
- BuildingSystem tests (8 tests)
- Colonist tests (8 tests)
- Integration tests (4 tests)

Total: 49 unit tests ready to run once Unity packages are configured.