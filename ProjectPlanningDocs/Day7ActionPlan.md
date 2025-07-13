# Day 7 Action Plan - Testing & Polish

## Morning Session (4 hours): Core Testing

### Hour 1: Unity Setup
1. Open Unity project
2. Run **SpaceColony > Quick Setup Helper**
   - Click "Create Basic Materials"
   - Click "Setup Layers and Tags"
   - Click "Create Basic Prefabs"
3. Create the 3 required scenes
4. Import any missing packages (Mirror, TextMeshPro)

### Hour 2: Prefab Assembly
Using the templates created:
1. **Player Prefab**
   - Add all required components (see UnitySetupGuide.md)
   - Assign to GameNetworkManager
   - Test movement in isolation

2. **Enemy Prefab**
   - Add AI components
   - Test spawning and movement
   - Verify target detection

3. **Projectile Prefab**
   - Configure physics
   - Test collision detection
   - Verify network spawning

### Hour 3: Scene Assembly
1. **MainMenu**
   - Wire up buttons to UIManager
   - Test scene transitions
   - Verify managers persist

2. **ColonyScene**
   - Place ground plane
   - Add building system
   - Test building placement

3. **RaidScene**
   - Add spawn points
   - Configure raid manager
   - Test enemy spawning

### Hour 4: Integration Testing
1. Full game loop test #1
   - Start game → Build colony → Start raid → Win → Return
   - Document all errors

2. Multiplayer test
   - Use ParrelSync or build
   - Test 2-player connection
   - Verify combat sync

## Afternoon Session (4 hours): Bug Fixing

### Priority 1 Fixes (Game Breaking)
- [ ] Null reference exceptions
- [ ] Network desync issues
- [ ] Scene transition failures
- [ ] Save/load corruption

### Priority 2 Fixes (Gameplay)
- [ ] Combat balance (health/damage values)
- [ ] Resource generation rates
- [ ] Enemy spawn balance
- [ ] Building costs

### Priority 3 Fixes (Polish)
- [ ] UI element positioning
- [ ] Missing audio hookups
- [ ] Visual feedback
- [ ] Control responsiveness

### Performance Optimization
1. **Profiler Analysis**
   - Check frame rate with 20 enemies
   - Monitor network traffic
   - Identify memory leaks

2. **Quick Wins**
   - Enable object pooling
   - Reduce particle counts
   - Optimize UI updates
   - LOD for distant objects

## Evening Session (4 hours): Final Polish

### Hour 1: Visual Polish
1. **Particle Effects**
   - Muzzle flash on shooting
   - Hit impacts
   - Death explosions
   - Level up effect

2. **UI Animations**
   - Button hover states
   - Panel transitions
   - Damage number pop-ups
   - Resource change indicators

### Hour 2: Audio Integration
1. **SFX Hookup**
   - Assign all clips to AudioManager
   - Test all sound triggers
   - Balance volumes

2. **Music**
   - Menu theme
   - Colony ambient
   - Combat music
   - Victory/defeat stingers

### Hour 3: Tutorial & UX
1. **Tutorial Content**
   - Write 5 tutorial panels
   - Colony basics
   - Combat controls
   - Building guide
   - Multiplayer setup

2. **UX Improvements**
   - Clear button labels
   - Tooltip help text
   - Error messages
   - Loading indicators

### Hour 4: Final Testing & Build
1. **Final Test Checklist**
   - [ ] 10-minute full playthrough
   - [ ] All features working
   - [ ] No critical bugs
   - [ ] Multiplayer stable

2. **Build Creation**
   - Build Settings configuration
   - Create Windows build
   - Create Mac/Linux builds
   - Test executable runs

## Emergency Time Savers

If running behind, skip these in order:
1. ~~Tutorial system (just add README)~~
2. ~~Multiple building types (use just generator)~~
3. ~~Save/load (session-based only)~~
4. ~~Colonist AI (auto-generate resources)~~
5. ~~Visual polish (basic colors only)~~

## Success Metrics

### Minimum Viable Prototype
- [x] Scripts compile without errors
- [ ] Player can move and shoot
- [ ] Enemies spawn and attack
- [ ] Buildings can be placed
- [ ] Resources update correctly
- [ ] Multiplayer connection works
- [ ] Game loop completes

### Good Prototype
- [ ] All above + visual feedback
- [ ] Balanced gameplay (5-10 min rounds)
- [ ] No major bugs in 30 min session
- [ ] Save/load functioning
- [ ] Tutorial helps new players

### Excellent Prototype
- [ ] All above + polish
- [ ] Smooth 60 FPS performance
- [ ] Full audio integration
- [ ] Engaging 20+ minute sessions
- [ ] Players want to play again

## Testing Helpers

### Console Commands (Add to a debug script)
```csharp
// Press keys in play mode:
// F1: Add 100 resources
// F2: Spawn enemy at cursor  
// F3: Level up player
// F4: Win current raid
// F5: Toggle god mode
```

### Quick Balance Testing
```
Starting Resources: 100/50/25 (Metal/Energy/Food)
Generator Cost: 50 Metal → 5 Energy/10s
Enemy Health: 50-100 based on level
Player Damage: 10-20 per shot
Raid Duration: 5 minutes
Win Bonus: 50 + (level * 10) Metal
```

## Post-Hackathon Notes

Document these for future development:
1. Most requested features
2. Biggest pain points
3. Performance bottlenecks
4. Best gameplay moments
5. Technical debt to address

## Final Reminders

- **Test early, test often**
- **Prioritize game-breaking bugs**
- **Simple and working > complex and broken**
- **Have fun and celebrate completion!**

Remember: You've built a complete multiplayer game in 7 days. That's an incredible achievement regardless of polish level!