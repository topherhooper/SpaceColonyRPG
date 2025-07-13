# Active Working Files

## Currently Working On
*Update this list as you work on files*

### Day 0 - Setup Phase
- ✅ .gitignore - Git configuration
- ✅ .claudeignore - Claude Code configuration  
- ✅ PROJECT_CONTEXT.md - Project overview
- ✅ MIRROR_QUICK_REF.md - Networking reference

### Next to Create (Day 1)
- [ ] Assets/_Project/Scripts/Networking/GameNetworkManager.cs
- [ ] Assets/_Project/Scripts/Player/PlayerController.cs
- [ ] Assets/_Project/Scripts/Player/PlayerCombat.cs
- [ ] Assets/_Project/Scripts/UI/UIManager.cs

## File Locations Quick Reference

### Core Scripts (to be created)
```
Assets/_Project/Scripts/
├── Colony/
│   ├── BuildingSystem.cs
│   ├── Colonist.cs
│   └── ResourceManager.cs
├── Combat/
│   ├── Projectile.cs
│   ├── Weapon.cs
│   └── DamageHandler.cs
├── Networking/
│   └── GameNetworkManager.cs
├── Player/
│   ├── PlayerController.cs
│   ├── PlayerCombat.cs
│   └── PlayerStats.cs
├── UI/
│   ├── UIManager.cs
│   ├── BuildingUI.cs
│   └── ResourceUI.cs
└── Utilities/
    ├── Singleton.cs
    └── ObjectPool.cs
```

### Prefab Locations
```
Assets/_Project/Prefabs/
├── Players/
│   └── Player_Prefab (to create)
├── Buildings/
│   ├── Building_Generator
│   └── Building_Turret
├── Enemies/
│   └── Enemy_Basic
└── Projectiles/
    └── Projectile_Laser
```

## Notes
- All player scripts must inherit from NetworkBehaviour
- UI scripts can be regular MonoBehaviour
- Prefabs need NetworkIdentity component for multiplayer