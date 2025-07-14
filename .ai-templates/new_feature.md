# New Feature: [FEATURE NAME]

## Requirements
- **User Story**: As a player, I want to [action] so that [benefit]
- **Multiplayer**: Does this need networking? [Yes/No]
- **Dependencies**: What systems does this need?
  - [ ] System 1
  - [ ] System 2

## Technical Design
- **Architecture Pattern**: [Singleton/Manager/Component]
- **Network Authority**: [Server/Client/Shared]
- **Data Storage**: [SyncVars/SyncList/Custom]

## Implementation Plan
1. [ ] Create base scripts
   - [ ] [Feature]Manager.cs
   - [ ] [Feature]Controller.cs
   - [ ] [Feature]Data.cs
2. [ ] Add networking if needed
   - [ ] SyncVars for state
   - [ ] Commands for actions
   - [ ] RPCs for feedback
3. [ ] Create prefabs
   - [ ] [Feature]_Prefab
   - [ ] UI elements
4. [ ] Test locally
   - [ ] Basic functionality
   - [ ] Edge cases
5. [ ] Test multiplayer
   - [ ] 2 player test
   - [ ] Lag simulation
6. [ ] Polish and optimize
   - [ ] Visual feedback
   - [ ] Performance check

## Files to Create
```
Scripts/[Feature]/
├── [Feature]Manager.cs      # Singleton manager
├── [Feature]Controller.cs   # Per-instance logic
├── [Feature]Data.cs        # Data structures
└── [Feature]UI.cs          # UI handling

Prefabs/[Feature]/
├── [Feature]_Basic         # Basic prefab
└── [Feature]_UI           # UI elements
```

## API Design
```csharp
public class [Feature]Manager : Singleton<[Feature]Manager>
{
    // Core API
    public void Initialize();
    public void Create[Feature](Vector3 position);
    public void Remove[Feature](int id);
    public [Feature] Get[Feature](int id);
    public List<[Feature]> GetAll[Feature]s();
}

public class [Feature]Controller : NetworkBehaviour
{
    // Component API
    public void Activate();
    public void Deactivate();
    public void UpdateState(int newState);
}
```

## Test Scenarios
### Scenario 1: Basic Functionality
1. Create [feature]
2. Verify it appears
3. Interact with it
4. **Expected**: [describe expected behavior]
5. **Actual**: [to be filled during testing]

### Scenario 2: Multiplayer Sync
1. Player 1 creates [feature]
2. Player 2 observes
3. **Expected**: Both see same state
4. **Actual**: [to be filled during testing]

### Scenario 3: Edge Cases
1. Create multiple quickly
2. Delete while in use
3. Network disconnect during action
4. **Expected**: Graceful handling
5. **Actual**: [to be filled during testing]

## Performance Considerations
- [ ] Object pooling needed? [Yes/No]
- [ ] Update frequency: [Every frame/Periodic/Event-based]
- [ ] Network messages per second: [estimate]
- [ ] Memory footprint: [estimate]

## UI Requirements
- [ ] HUD element
- [ ] Menu interface
- [ ] Tooltips/help text
- [ ] Visual feedback

## Success Criteria
- [ ] Feature works in single player
- [ ] Feature syncs in multiplayer
- [ ] No performance impact
- [ ] Intuitive to use
- [ ] No critical bugs

## Notes
- [Add any additional notes or considerations]