# Session Start Checklist

## Claude, please:
1. Load .ai/context.md
2. Load .ai/current_sprint.md
3. Check BUGS_TO_FIX.md for blockers
4. Run: "git status" and "git log --oneline -5"
5. Check .ai/last_changes.md for recent work
6. Summarize: "What are we working on today?"

## Git Status Check
- Current branch?
- Any uncommitted changes?
- Last 5 commits summary?
- Any stashed work?

## Quick Status Check
- What day of the hackathon is it?
- What's the highest priority task?
- Are there any blocking bugs?
- What was completed in the last session?

## Session Goals
- [ ] Complete Unity configuration (Layers, Tags)
- [ ] Create basic material assets
- [ ] Set up core template scripts
- [ ] Test basic Mirror networking
- [ ] Commit progress every 30-60 minutes

## Context Reminders
- We're using Mirror, not Unity Netcode
- Server authoritative for all gameplay
- Time constraint: 7-day hackathon
- Performance target: 30 FPS with 50 units
- Platform: PC (Windows/Mac/Linux)
- Git workflow: feature branches, semantic commits

## Key File Locations
- Scripts: Assets/_Project/Scripts/
- Current tasks: .ai/current_sprint.md
- Bug tracking: BUGS_TO_FIX.md
- Architecture: .ai/architecture.md
- Git workflows: .ai/workflows/
- Development logs: .ai/logs/

## Today's Mantra
"Make it work first, optimize later"
"Commit early, commit often"