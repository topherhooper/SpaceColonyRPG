# Unity Test Suite for Space Colony RPG

## Overview
This test suite provides comprehensive unit testing for the Space Colony RPG project, following Unity's Test Framework best practices.

## Test Structure

```
Tests/
├── EditMode/          # Tests that run in Edit Mode (faster, no physics)
│   ├── Colony/        # Colony system tests
│   ├── Combat/        # Combat system tests
│   ├── Player/        # Player progression tests
│   └── Utilities/     # Utility class tests
└── PlayMode/          # Tests that run in Play Mode (physics, networking)
    ├── Networking/    # Network functionality tests
    └── Integration/   # System integration tests
```

## Running Tests

### In Unity Editor
1. Open Test Runner: `Window > General > Test Runner`
2. Select "EditMode" or "PlayMode" tab
3. Click "Run All" or run individual tests

### Via Menu
- `Tools > Code Quality > Run All Tests` - Runs both Edit and Play mode tests

### Command Line
```bash
# Run all tests
Unity -batchmode -projectPath . -runTests -testPlatform All

# Run only Edit Mode tests
Unity -batchmode -projectPath . -runTests -testPlatform EditMode

# Run only Play Mode tests
Unity -batchmode -projectPath . -runTests -testPlatform PlayMode
```

## Writing Tests

### Basic Test Structure
```csharp
using NUnit.Framework;
using UnityEngine;

[TestFixture]
public class MySystemTests
{
    private MySystem system;
    
    [SetUp]
    public void Setup()
    {
        // Initialize test objects
    }
    
    [TearDown]
    public void TearDown()
    {
        // Clean up test objects
    }
    
    [Test]
    public void MethodName_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var input = 5;
        
        // Act
        var result = system.Calculate(input);
        
        // Assert
        Assert.AreEqual(10, result);
    }
}
```

### Testing Unity Components
```csharp
[Test]
public void Component_Test()
{
    // Create GameObject with component
    var gameObject = new GameObject();
    var component = gameObject.AddComponent<MyComponent>();
    
    // Test component
    component.DoSomething();
    
    // Clean up
    Object.DestroyImmediate(gameObject);
}
```

## Code Quality Tools

### Code Linter
- `Tools > Code Quality > Code Linter` - Check for code style issues
- Auto-fixes trailing whitespace, tabs, and basic formatting

### Format On Save
- Automatically formats C# files when saved
- Removes trailing whitespace
- Ensures files end with newline

### Pre-Push Hook
The git pre-push hook automatically:
1. Runs code linting checks
2. Checks for performance issues (GameObject.Find, etc.)
3. Runs all unit tests
4. Blocks push if any checks fail

## Code Style Guidelines

### Naming Conventions
- **Classes/Interfaces**: PascalCase (e.g., `PlayerController`, `IWeapon`)
- **Methods/Properties**: PascalCase (e.g., `TakeDamage()`, `Health`)
- **Fields**: camelCase (e.g., `private int health`)
- **Constants**: UPPER_CASE (e.g., `MAX_HEALTH`)

### Unity Specific
- Prefer `[SerializeField] private` over `public` fields
- Use `// PERF:` comments for intentional expensive operations
- Always clean up GameObjects in tests with `Object.DestroyImmediate()`

## Test Coverage

### Viewing Coverage
1. Install Code Coverage package: `com.unity.testtools.codecoverage`
2. Run `Tools > Code Quality > Generate Test Coverage Report`
3. View HTML report in `TestResults/CoverageReport`

### Coverage Goals
- Core Systems: 80%+ coverage
- Utilities: 90%+ coverage
- UI/Networking: 60%+ coverage

## Troubleshooting

### Tests Not Found
- Check assembly definition references
- Ensure test methods have `[Test]` attribute
- Verify namespace matches assembly definition

### Play Mode Tests Fail
- May need active scene with required components
- Check for missing prefab references
- Ensure NetworkManager exists for network tests

### Git Hook Not Working
- Check file permissions: `chmod +x .git/hooks/pre-push`
- Update Unity path in hook script
- For WSL users: Tests must be run manually in Windows

## Best Practices

1. **Test Isolation**: Each test should be independent
2. **AAA Pattern**: Arrange, Act, Assert
3. **Descriptive Names**: `MethodName_StateUnderTest_ExpectedBehavior`
4. **Fast Tests**: Keep tests under 100ms each
5. **Clean Up**: Always destroy created GameObjects
6. **Mock Dependencies**: Use interfaces for easier mocking

## Continuous Integration

For CI/CD pipelines, see `.github/workflows/tests.yml` for:
- Automated testing on push/PR
- Code quality checks
- Coverage reporting

## Additional Resources

- [Unity Test Framework Documentation](https://docs.unity3d.com/Packages/com.unity.test-framework@latest)
- [NUnit Documentation](https://docs.nunit.org/)
- [Unity Code Coverage](https://docs.unity3d.com/Packages/com.unity.testtools.codecoverage@latest)