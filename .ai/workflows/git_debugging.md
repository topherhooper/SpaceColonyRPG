# Git-Powered Debugging Workflow

## When a Bug Appears

### 1. Identify When It Last Worked
```bash
# Questions for Claude:
"When was [feature] last working correctly?"
"What commits touched [system] recently?"
"Show me the git log for [file] in the last week"
```

### 2. Git Bisect Process
```bash
# Start bisect
git bisect start
git bisect bad                    # Current commit is broken
git bisect good <commit-hash>     # Known good commit

# Claude helps create test script
Claude: "Write a test script for git bisect run"
```

Example test script:
```bash
#!/bin/bash
# test_projectile_sync.sh
# Returns 0 if working, 1 if broken

# Build the project
Unity -batchmode -quit -projectPath . -buildTarget StandaloneWindows64

# Run specific test
if grep -q "NetworkIdentity" Assets/_Project/Prefabs/Projectiles/Projectile_Laser.prefab; then
    exit 0  # Good - has NetworkIdentity
else
    exit 1  # Bad - missing NetworkIdentity
fi
```

### 3. Find the Breaking Commit
```bash
git bisect run ./test_projectile_sync.sh

# Result shows exact commit
# Claude can then analyze:
Claude: "Show me the full diff of the breaking commit"
Claude: "What else changed in nearby commits?"
```

## Understanding Bug Context

### Blame Analysis
```bash
# Not just who, but why
Claude: "git blame [file] and explain each change's context"

# Example:
git blame -L 45,60 Assets/_Project/Scripts/Combat/ProjectileController.cs

# Claude provides:
# - Why each line was changed
# - Related commits
# - Potential impact
```

### Change History
```bash
# See how a specific function evolved
git log -L :FireProjectile:Assets/_Project/Scripts/Player/PlayerCombat.cs

# Claude analyzes:
# - When function was added
# - How it changed over time
# - Why changes were made
```

### Related Changes
```bash
# Find all commits that touched both files
git log --all -- fileA fileB

# Find commits with specific changes
git log -G"NetworkServer.Spawn" --all
```

## Debug Patterns

### Pattern 1: Network Sync Issues
```bash
# Claude Debug Process:
1. "When did networking last work?"
2. "Show all commits with 'Mirror' or 'Network'"
3. "Check if prefab changes match code changes"

git log --grep="network" --since="2 days ago"
git diff <last-working>..HEAD -- "*.prefab"
```

### Pattern 2: Performance Regression
```bash
# Find when performance dropped
1. "Identify commits that changed Update methods"
2. "Look for added loops or repeated calls"

git log -S"Update()" -p
git log --since="1 week ago" --grep="perf"
```

### Pattern 3: Missing References
```bash
# Track down when reference was removed
1. "When was this field last assigned?"
2. "Check prefab history"

git log -S"targetPrefab" -p
git log -- "*.prefab" | head -20
```

## Time Travel Debugging

### Checkout Previous State
```bash
# Test old version without losing work
git stash                        # Save current changes
git checkout <commit-hash>       # Go to past state
# Test the old version
git checkout -                   # Return to previous branch
git stash pop                    # Restore changes
```

### Compare Working vs Broken
```bash
# Side-by-side comparison
git diff <working-commit>..<broken-commit> -- <specific-file>

# Claude helps interpret:
Claude: "Explain the significant differences"
Claude: "Which change likely caused the issue?"
```

## Advanced Debugging

### Find Introduction Point
```bash
# When was bug-prone code introduced?
git log -S"problematic code" --reverse

# First occurrence analysis
Claude: "Show the commit that first introduced [pattern]"
```

### Cross-Reference Issues
```bash
# Find related bugs
git log --grep="fix.*projectile"
git log --grep="bug.*network"

# Claude identifies patterns:
Claude: "Are these bugs related to our current issue?"
```

### Dependency Analysis
```bash
# What changed when we updated Mirror?
git log --grep="Mirror" --grep="update" --all-match
git diff <before-update>..<after-update> -- Packages/manifest.json
```

## Debug Helpers

### Create Debug Branch
```bash
# Isolate debugging work
git checkout -b debug/projectile-sync-issue

# Make experimental fixes
# If successful, cherry-pick to main branch
```

### Debug Commits
```bash
# Temporary commits for testing
git commit -m "DEBUG: Add logging to projectile spawn"
git commit -m "DEBUG: Disable object pooling"

# Clean up later with:
git rebase -i HEAD~5  # Remove debug commits
```

## Common Unity/Mirror Debug Scenarios

### Scenario: "It works in Editor but not in Build"
```bash
Claude: "Find all editor-only code in recent commits"
git log -S"UNITY_EDITOR" --since="1 week ago"
git grep -n "UNITY_EDITOR"
```

### Scenario: "Multiplayer desyncs after few minutes"
```bash
Claude: "Find all SyncVar changes"
git log -S"SyncVar" -p
Claude: "Check for floating point in SyncVars"
```

### Scenario: "Prefab loses references"
```bash
Claude: "Show prefab history"
git log -- "*.prefab" --follow
Claude: "Find when reference was valid"
```

## Git Debug Commands Reference

```bash
# Useful aliases for debugging
git config --global alias.find 'log -S'
git config --global alias.changes 'diff --name-status'
git config --global alias.graph 'log --graph --oneline --all'
git config --global alias.today 'log --since="1 day ago" --oneline'
git config --global alias.yesterday 'log --since="2 days ago" --until="1 day ago"'

# Usage:
git find "NetworkIdentity"       # When was this added?
git changes HEAD~5..HEAD         # What files changed?
git graph -20                    # Visual branch history
git today                        # Today's commits
```

## Post-Debug Actions

### Document the Fix
```bash
# Create detailed commit message
git commit -m "fix(networking): restore NetworkIdentity to projectile prefab

The projectile prefab lost its NetworkIdentity component in commit a3b4c5d
when the prefab was recreated. This caused projectiles to only appear on
the host.

Fixes #123"
```

### Prevent Regression
```
Claude: "Create a test to prevent this bug from returning"
Claude: "Add debug assertion to catch this earlier"
```

### Update Documentation
```bash
# Add to known issues
echo "## Projectile Sync\nEnsure all projectile prefabs have NetworkIdentity" >> .ai/knowledge/common_errors.md

git add .ai/knowledge/common_errors.md
git commit -m "docs: add projectile sync issue to known errors"
```