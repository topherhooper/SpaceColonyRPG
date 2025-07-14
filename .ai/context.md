# Space Colony RPG - AI Context

## Project State
- **Current Phase**: Prototype/MVP
- **Day**: 0 of 7 (Pre-Hackathon Setup)
- **Last Updated**: 2025-07-13
- **Time Investment**: Day 0 (4-6 hours prep)

## Tech Stack
- Engine: Unity 2022.3 LTS
- Rendering: URP (Universal Render Pipeline)
- Networking: Mirror (latest version)
- Language: C# (.NET Standard 2.1)
- Platform: PC (Windows/Mac/Linux)
- Input: Legacy Input System (for simplicity)

## Architecture Decisions
- **Multiplayer**: Client-Server (not P2P)
- **Authority**: Server authoritative for gameplay
- **Colony Sim**: MonoBehaviour-based (hackathon speed over architecture)
- **State Management**: Mirror SyncVars for shared state
- **Scene Management**: Single scene (combined Colony/Raid)
- **Object Pooling**: For projectiles and VFX only

## Current Systems Status

### ✅ Complete
- Project structure created
- Git repository with .gitignore
- Mirror Networking imported
- Basic assets imported (PolygonStarter, SimpleLowPolyNature)
- Claude Code configuration

### 🚧 In Progress
- Unity project configuration (Layers, Tags)
- Basic materials setup
- Template scripts

### 📋 Planned (By Priority)
1. **Day 1**: Basic multiplayer + movement
2. **Day 2**: Combat system
3. **Day 3**: Colony building
4. **Day 4**: Resource management + Colonist AI
5. **Day 5**: Raid mode transitions
6. **Day 6**: Polish + Balancing
7. **Day 7**: Testing + Submission prep

## Code Locations
- **Core Systems**: Assets/_Project/Scripts/Core/
- **Features**: Assets/_Project/Scripts/[Feature]/
- **Networking**: Assets/_Project/Scripts/Networking/
- **Current Work**: See current_sprint.md
- **Templates**: .ai-templates/

## Project Goals
1. **Minimum Viable**: 2-player coop colony defense
2. **Target**: 4-player with basic progression
3. **Stretch**: 8-player with full colony simulation

## Known Constraints
- 7-day development time
- Must be playable online
- Performance target: 30 FPS with 50 units
- Max build size: 1GB

## Development Philosophy
- "Make it work, then make it good"
- Test multiplayer EARLY and OFTEN
- Prefab everything for easy tweaking
- Comment unclear code for future reference
- Use existing assets when possible