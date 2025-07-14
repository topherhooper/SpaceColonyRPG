# Git Patterns for Space Colony RPG

## Commit Message Patterns

### Feature Commits
```bash
feat(player): add WASD movement controls
feat(networking): implement player spawn synchronization
feat(combat): create projectile pooling system
feat(colony): add building placement preview
feat(ui): create resource display HUD
```

### Fix Commits
```bash
fix(networking): resolve authority check on commands
fix(player): prevent movement while dead
fix(combat): correct projectile spawn position
fix(colony): validate building placement on grid
fix(ui): update health bar synchronization
```

### Performance Commits
```bash
perf(enemy): implement object pooling for spawns
perf(colony): cache pathfinding results
perf(networking): reduce update frequency for distant objects
perf(ui): batch UI updates per frame
```

### Refactor Commits
```bash
refactor(player): extract input handling to separate component
refactor(combat): consolidate damage calculation methods
refactor(networking): standardize RPC naming convention
refactor(core): implement singleton base class
```

## Branch Naming Patterns

### Feature Branches
```bash
feature/day1-player-movement
feature/day2-basic-combat
feature/day3-building-system
feature/day4-colonist-ai
feature/day5-wave-spawning
```

### Fix Branches
```bash
fix/day2-projectile-sync
fix/day3-building-collision
fix/day4-pathfinding-error
fix/day5-ui-scaling
```

### Experimental Branches
```bash
experiment/procedural-map
experiment/advanced-ai
experiment/shader-effects
```

## Code Evolution Patterns

### System Development Order
1. **Core Systems First**
   ```
   feat(core): create singleton base class
   feat(core): implement object pooling system
   feat(core): add event system
   ```

2. **Player Systems**
   ```
   feat(player): create player prefab with NetworkIdentity
   feat(player): add movement controller
   feat(player): implement input handling
   feat(player): add player stats component
   ```

3. **Networking Layer**
   ```
   feat(networking): create custom NetworkManager
   feat(networking): implement player spawning
   feat(networking): add connection UI
   feat(networking): handle disconnections
   ```

4. **Gameplay Features**
   ```
   feat(combat): implement shooting mechanics
   feat(colony): create building system
   feat(enemy): add enemy AI
   feat(resources): implement resource management
   ```

## Anti-patterns to Avoid

### Based on Common Reverts
```bash
# ❌ Commits that often get reverted:
- "Big refactor" (too many changes at once)
- "Fixed stuff" (unclear what was fixed)
- "WIP" pushed to main branch
- "Updated files" (no context)

# ✅ Better approaches:
- Small, focused commits
- Clear, descriptive messages
- Feature branches for experiments
- Meaningful context in messages
```

### Performance Regression Patterns
```bash
# Common performance mistakes in history:
1. Adding Update() to every component
2. Not caching GetComponent calls
3. Instantiate without pooling
4. String concatenation in loops
5. Find operations in Update

# Check before committing:
git grep -n "Update()" -- "*.cs" | wc -l
git grep -n "GetComponent" -- "*.cs" | wc -l
```

## Useful Git Aliases for Game Dev

Add to `.git/config`:
```ini
[alias]
    # Show today's work
    today = log --since='1 day ago' --oneline --author='your-name'
    
    # Find feature additions
    features = log --grep='^feat' --oneline
    
    # Find bug fixes
    fixes = log --grep='^fix' --oneline
    
    # Show file evolution
    evolution = log --follow -p --
    
    # Find when code was added
    find-add = log -S
    
    # Quick status
    st = status -sb
    
    # Prettier log
    lg = log --graph --pretty=format:'%Cred%h%Creset -%C(yellow)%d%Creset %s %Cgreen(%cr) %C(bold blue)<%an>%Creset' --abbrev-commit
    
    # Show changed files
    changed = diff --name-status
    
    # Uncommit (keep changes)
    uncommit = reset --soft HEAD~1
    
    # Amend without editing message
    amend = commit --amend --no-edit
```

## Integration Patterns

### Pre-Feature Checklist
```bash
# Before starting new feature
git checkout main
git pull origin main
git checkout -b feature/dayX-feature-name

# Create context
echo "# Feature: [Name]" > .ai/branch_context.md
echo "## Goals:" >> .ai/branch_context.md
echo "- [ ] Goal 1" >> .ai/branch_context.md

# Find similar work
git log --grep="similar-feature" --oneline
```

### Post-Feature Checklist
```bash
# After completing feature
git diff main --stat                  # Review scope
git log main..HEAD --oneline          # Review commits

# Clean up if needed
git rebase -i main                     # Organize commits

# Final checks
grep -r "TODO" --include="*.cs"       # Incomplete work
grep -r "Debug.Log" --include="*.cs"  # Remove debug logs
```

## Learning from History

### Find Patterns
```bash
# How are systems typically implemented?
git log --grep="^feat.*system" -10 --oneline

# What fixes follow features?
git log --grep="^feat.*combat" -5 --oneline
git log --grep="^fix.*combat" -5 --oneline

# Performance improvement patterns
git log --grep="^perf" -p | grep -B5 -A5 "^-.*Update()"
```

### Avoid Repeated Mistakes
```bash
# Find reverted commits
git log --grep="Revert" --oneline

# Analyze why they were reverted
git show <reverted-commit-hash>

# Document in .ai/knowledge/common_errors.md
```

## Quick Decision Helpers

### "Should I commit now?"
- Have you made one logical change? → Yes, commit
- Has it been 30+ minutes? → Yes, commit WIP
- Are you switching context? → Yes, commit WIP
- Is it the end of a work session? → Yes, commit

### "What branch should I use?"
- New feature → feature/dayX-name
- Fixing a bug → fix/dayX-issue
- Trying something risky → experiment/idea
- Hotfix for main → hotfix/critical-issue

### "How detailed should my message be?"
- One-line summary: Always (50 chars max)
- Body: If "why" isn't obvious
- Footer: If breaking changes or issue refs
- Examples in code: If complex implementation