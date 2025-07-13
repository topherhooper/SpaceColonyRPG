# Known Bugs and Issues

## Active Bugs
*Record bugs as you find them with file locations*

### Example Format:
```
BUG: Player can shoot while dead
FILE: Assets/_Project/Scripts/Player/PlayerCombat.cs
LINE: ~45
FIX: Add isDead check before firing
PRIORITY: High
```

## Fixed Bugs
*Move bugs here when resolved*

### Day 0
- None yet

## Common Unity Issues & Solutions

### Mirror Networking
- **Issue**: "Trying to send command for object without authority"
  - **Fix**: Check hasAuthority or isLocalPlayer before Commands

- **Issue**: NetworkIdentity missing on spawned object
  - **Fix**: Add NetworkIdentity component to prefab

### Build Errors
- **Issue**: Scenes not included in build
  - **Fix**: File > Build Settings > Add Open Scenes

- **Issue**: Pink materials in build
  - **Fix**: Edit > Project Settings > Graphics > Always Included Shaders