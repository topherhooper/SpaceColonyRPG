# Space Colony RPG Testing Strategy

## Current Testing Approach

### 1. Compilation Testing (WSL Command Line)

#### Quick Compile Check
```bash
# Run from project root in WSL
./compile-check.sh

# Or directly:
/mnt/c/Program\ Files/Unity/Hub/Editor/6000.1.11f1/Editor/Unity.exe -batchmode -quit -projectPath . -executeMethod UnityEditor.AssetDatabase.Refresh -logFile /dev/stdout | grep -i "error"
```

#### Benefits:
- No need to open Unity Editor
- Instant feedback on compilation errors
- Can be run in CI/CD pipeline
- Shows errors directly in terminal

### 2. Manual Testing Checklist (Day 7)
As outlined in the 7-day hackathon plan:

#### Bug Fixing Checklist
- [ ] Test full game loop 5 times
- [ ] Fix any null reference exceptions
- [ ] Ensure multiplayer sync works properly
- [ ] Balance enemy health/damage
- [ ] Verify save/load works correctly
- [ ] Test all UI buttons function
- [ ] Check resource costs make sense
- [ ] Verify colonist AI doesn't get stuck

#### Core Systems Testing
1. **Networking (Day 1)**
   - [ ] Host/Join functionality
   - [ ] Player spawning
   - [ ] Movement synchronization
   
2. **Combat (Day 2)**
   - [ ] Weapon firing
   - [ ] Projectile sync
   - [ ] Damage dealing
   - [ ] Death/respawn cycle
   
3. **Colony Systems (Day 3)**
   - [ ] Building placement on grid
   - [ ] Resource spending
   - [ ] Colonist work assignment
   - [ ] Production cycles
   
4. **Progression (Day 4)**
   - [ ] Loot drops from enemies
   - [ ] XP gain and leveling
   - [ ] Colony upgrades purchasing
   - [ ] Stat bonuses application
   
5. **Game Flow (Day 5)**
   - [ ] Scene transitions
   - [ ] Raid start/end conditions
   - [ ] Save/load persistence
   - [ ] Victory/defeat screens

### 3. Performance Testing
- Implemented `ProjectilePool` for object pooling optimization
- Monitor frame rate during raids with multiple enemies
- Check network traffic during multiplayer sessions

### 4. Multiplayer Testing
Using **ParrelSync** for local testing:
1. Clone the project in Unity
2. Run host in main editor
3. Run client in cloned editor
4. Test all networked features

Alternative: Build and run multiple instances

## Recommended Unit Tests (Post-Hackathon)

### Unity Test Framework Setup
```csharp
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class ResourceManagerTests
{
    [Test]
    public void CanAfford_WithSufficientResources_ReturnsTrue()
    {
        // Arrange
        var resourceManager = new GameObject().AddComponent<ResourceManager>();
        resourceManager.AddResource("Metal", 100);
        
        // Act
        bool canAfford = resourceManager.CanAfford("Metal", 50);
        
        // Assert
        Assert.IsTrue(canAfford);
    }
}
```

### Play Mode Tests
```csharp
public class CombatTests
{
    [UnityTest]
    public IEnumerator TakeDamage_ReducesHealth()
    {
        // Arrange
        var go = new GameObject();
        var combatStats = go.AddComponent<CombatStats>();
        combatStats.health = 100;
        
        // Act
        combatStats.TakeDamage(20);
        yield return null;
        
        // Assert
        Assert.AreEqual(80, combatStats.health);
    }
}
```

## Integration Testing Plan

1. **Colony → Raid Flow**
   - Start in colony
   - Build 3 buildings
   - Purchase upgrades
   - Start raid
   - Complete raid
   - Return to colony
   - Verify resources and upgrades persist

2. **Multiplayer Combat**
   - 2 players join raid
   - Both shoot enemies
   - Verify damage sync
   - One player dies
   - Verify respawn
   - Complete raid together

3. **Save/Load Cycle**
   - Build colony
   - Save game
   - Quit to menu
   - Load game
   - Verify all buildings/resources restored

## Known Issues to Test
1. Enemy AI pathfinding on complex terrain
2. Building placement validation edge cases
3. Network disconnection handling
4. Resource UI updates when spending quickly
5. Projectile collision at high speeds

## Testing Tools
- Unity Profiler for performance
- Unity Test Framework for unit tests
- ParrelSync for multiplayer testing
- Debug.Log statements for state verification
- Visual Studio debugger for breakpoints

## WSL Development Workflow

### 1. Add Unity Alias (One-time setup)
```bash
# Add to ~/.bashrc
echo "alias unity='/mnt/c/Program\ Files/Unity/Hub/Editor/6000.1.11f1/Editor/Unity.exe'" >> ~/.bashrc
source ~/.bashrc
```

### 2. Development Cycle
```bash
# 1. Make code changes in VS Code
code .

# 2. Quick compile check
./compile-check.sh

# 3. If errors, check details
unity -batchmode -quit -projectPath . -executeMethod UnityEditor.AssetDatabase.Refresh -logFile /dev/stdout 2>&1 | less

# 4. Build when ready
./build-wsl.sh build

# 5. Check build log for errors
grep -i "error\|exception" build_windows.log
```

### 3. Common WSL Commands
```bash
# Full project setup (scenes, prefabs, materials)
./build-wsl.sh setup

# Quick validation test
./build-wsl.sh test

# Clean build artifacts
./build-wsl.sh clean

# Watch for file changes and auto-compile
while true; do 
    inotifywait -r -e modify Assets/_Project/Scripts/
    ./compile-check.sh
done
```

### 4. Error Detection Patterns
```bash
# Find specific error types
unity -batchmode -quit -projectPath . -executeMethod UnityEditor.AssetDatabase.Refresh -logFile /dev/stdout 2>&1 | grep -E "(CS[0-9]{4}|missing|null reference|Mirror|Network)"

# Count errors by type
unity -batchmode -quit -projectPath . -buildWindows64Player test.exe -logFile - | grep -oE "CS[0-9]{4}" | sort | uniq -c
```

## Next Steps
1. Implement automated unit tests for core systems
2. Create integration test scenes
3. Add debug UI for spawning enemies/resources
4. Implement replay system for bug reproduction
5. Add analytics for tracking common issues