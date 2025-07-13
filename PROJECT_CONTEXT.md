# Project: Space Colony RPG Prototype

## Architecture Overview
- Multiplayer Framework: Mirror Networking
- Unity Version: 2022.3 LTS
- Render Pipeline: URP (Universal Render Pipeline)
- Input: Legacy Input System

## Code Structure
- Assets/_Project/Scripts/Colony - Colony building systems
- Assets/_Project/Scripts/Combat - Combat and weapons
- Assets/_Project/Scripts/Networking - Multiplayer code
- Assets/_Project/Scripts/Player - Player controller
- Assets/_Project/Scripts/UI - UI management
- Assets/_Project/Scripts/Utilities - Helper classes and managers

## Key Systems Status
- [ ] Basic multiplayer connection
- [ ] Player movement synced
- [ ] Combat system
- [ ] Colony building placement
- [ ] Resource management
- [ ] Raid/Strike transitions
- [ ] Colonist AI
- [ ] Building progression
- [ ] Enemy waves
- [ ] UI systems

## Current Focus
Working on: Day 0 Setup and Preparation
Blocking issues: None currently

## Code Conventions
- Managers use Singleton pattern
- Network variables use [SyncVar]
- UI elements prefixed with UI_
- Prefabs in designated folders
- Scripts use regions for organization
- Clear naming: NetworkedEnemy not Enemy
- Comments explain intent and current state

## Dependencies Installed
- Mirror Networking
- PolygonStarter (basic 3D models)
- SimpleLowPolyNature (environment assets)

## Testing Notes
- Use ParrelSync or build for multiplayer testing
- Host/Join with localhost for local testing
- Console logs important for debugging network issues