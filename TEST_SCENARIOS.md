# Test Scenarios

## Multiplayer Connection Test
**When**: After NetworkManager setup
1. Build project (Ctrl+B)
2. Run build (Player 1)
3. Run in Editor (Player 2)
4. Player 1: Click "Host"
5. Player 2: Set IP to "localhost", click "Client"
6. **EXPECTED**: Both see each other's capsules
7. **ACTUAL**: [Update with results]

## Player Movement Test
**When**: After PlayerController implementation
1. Connect 2 players (see above)
2. Move with WASD on Player 1
3. **EXPECTED**: Player 2 sees smooth movement
4. **ACTUAL**: [Update with results]

## Combat Test
**When**: After combat system
1. Connect 2 players
2. Player 1 shoots at Player 2 (Left click)
3. **EXPECTED**: 
   - Projectile spawns and moves
   - Damage applied on hit
   - Health syncs to all clients
4. **ACTUAL**: [Update with results]

## Building Placement Test
**When**: After building system
1. Press 'B' to enter build mode
2. Green preview should follow mouse
3. Red when invalid placement
4. Left-click to place
5. **EXPECTED**: 
   - Building appears
   - Resources deducted
   - Other players see building
6. **ACTUAL**: [Update with results]

## Colonist AI Test
**When**: After colonist implementation
1. Place a building that spawns colonists
2. **EXPECTED**:
   - Colonist spawns at building
   - Moves to nearby resources
   - Returns to base
   - All players see movement
3. **ACTUAL**: [Update with results]

## Performance Tests

### 10 Player Stress Test
1. Build project
2. Run 10 instances (use batch script)
3. All join same host
4. Monitor:
   - FPS in host
   - Network traffic
   - Sync delays
5. **TARGET**: 30+ FPS with 10 players

### 100 Enemy Stress Test
1. Spawn 100 enemies
2. Monitor:
   - FPS drop
   - Network messages/sec
   - Update time
3. **TARGET**: 30+ FPS with 100 enemies

## Quick Checks Before Build
- [ ] All prefabs have NetworkIdentity
- [ ] Player prefab assigned to NetworkManager
- [ ] Scenes added to Build Settings
- [ ] Offline scene set (usually Menu)
- [ ] Online scene set (usually Game)
- [ ] Network address is "localhost" for testing