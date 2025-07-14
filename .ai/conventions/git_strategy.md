# Git Strategy & Conventions

## Commit Strategy for AI Collaboration

### Micro-commits During Hackathon
- Commit every 30-60 minutes
- Each commit = one logical change
- Clear messages help Claude understand progress
- Use semantic commit format

### Example Development Session
```bash
git commit -m "feat(combat): add basic projectile spawning"
git commit -m "fix(combat): add NetworkIdentity to projectile prefab"
git commit -m "feat(combat): sync projectile position with Mirror"
git commit -m "perf(combat): implement projectile pooling"
git commit -m "test(combat): verify projectile damage calculation"
git commit -m "docs(combat): add usage comments to ProjectileController"
```

## Why This Helps Claude
1. **Bug Tracking**: Can trace when bugs were introduced
2. **Pattern Learning**: Understands your implementation order
3. **Context Awareness**: Knows what changed recently
4. **Better Suggestions**: Provides relevant examples from history

## Branch Strategy

### Naming Convention
```
<type>/<day>-<feature>
```

### Types
- `feature/` - New functionality
- `fix/` - Bug fixes
- `experiment/` - Risky or exploratory work
- `refactor/` - Code improvements
- `hotfix/` - Emergency fixes to main

### Examples
```bash
feature/day1-player-movement
feature/day2-combat-system
fix/day3-projectile-sync
experiment/day4-procedural-generation
refactor/day5-optimize-networking
```

## Commit Message Format

### Structure
```
<type>(<scope>): <subject>

[optional body]

[optional footer]
```

### Types
- `feat`: New feature
- `fix`: Bug fix
- `docs`: Documentation only
- `style`: Code style (formatting, semicolons)
- `refactor`: Code change that neither fixes nor adds
- `perf`: Performance improvement
- `test`: Adding tests
- `chore`: Maintenance tasks

### Scopes
- `networking`: Mirror/multiplayer code
- `combat`: Weapons, damage, projectiles
- `colony`: Building, resources, colonists
- `ui`: User interface
- `core`: Core systems, managers
- `player`: Player controller, stats
- `enemy`: Enemy AI, spawning

### Subject Rules
- Use imperative mood ("add" not "added")
- No period at the end
- Max 50 characters
- Capitalize first letter

### Body Rules
- Explain what and why, not how
- Wrap at 72 characters
- Separate from subject with blank line

### Footer Rules
- Reference issues: `Fixes #123`
- Breaking changes: `BREAKING CHANGE: description`
- Co-authors: `Co-authored-by: Name <email>`

## Git Workflow

### Daily Flow
```bash
# Start of day
git checkout main
git pull origin main
git checkout -b feature/day3-building-system

# During development (every 30-60 min)
git add -p  # Selective staging
git commit  # Uses template

# End of feature
git checkout main
git merge feature/day3-building-system
git push origin main

# Clean up
git branch -d feature/day3-building-system
```

### Before Pushing
```bash
# Review commits
git log --oneline -10

# Clean up if needed
git rebase -i HEAD~5

# Verify
git diff origin/main

# Push
git push origin main
```

## Interactive Rebase Guidelines

### When to Rebase
- Before merging feature branch
- To clean up WIP commits
- To fix commit messages
- To reorder for logical flow

### Common Operations
```bash
# Squash related commits
pick a1b2c3d feat(player): add movement input
squash d4e5f6g fix(player): correct input scaling
squash g7h8i9j fix(player): clamp movement bounds

# Reword commit messages
reword a1b2c3d feat(player): add movement system

# Drop unnecessary commits
drop j1k2l3m DEBUG: temporary logging

# Reorder for clarity
pick a1b2c3d feat(core): add event system
pick g7h8i9j feat(player): create player prefab
pick d4e5f6g feat(player): add movement
```

## Git Hooks Integration

### Pre-commit
- Updates .ai/context.md timestamp
- Generates .ai/last_changes.md
- Runs basic validation

### Post-commit  
- Updates development log
- Creates daily summary
- Tracks progress

## Quick Reference

### Essential Commands
```bash
# Status and history
git status -sb                    # Brief status
git log --oneline -10            # Recent commits
git log --grep="feat" -5         # Find features

# Committing
git add -p                       # Interactive staging
git commit                       # Use template
git commit --amend              # Fix last commit

# Branches
git checkout -b feature/name     # New feature branch
git branch -d branch-name       # Delete branch
git branch -vv                  # Show all branches

# Finding code
git grep "pattern"              # Search in files
git log -S "code"              # When code was added
git blame file.cs              # Who changed what

# Undoing
git reset --soft HEAD~1        # Undo commit, keep changes
git checkout -- file.cs        # Discard changes
git stash                      # Save work temporarily
```

### Git Aliases (add to .git/config)
```ini
[alias]
    st = status -sb
    co = checkout
    br = branch
    ci = commit
    unstage = reset HEAD --
    last = log -1 HEAD
    visual = !gitk
    today = log --since='1 day ago' --oneline
    features = log --grep='^feat' --oneline
    fixes = log --grep='^fix' --oneline
```

## Common Scenarios

### "I need to switch tasks quickly"
```bash
git stash save "WIP: working on projectile sync"
git checkout other-branch
# ... work ...
git checkout original-branch  
git stash pop
```

### "I committed to wrong branch"
```bash
git reset --soft HEAD~1  # Undo commit
git stash               # Save changes
git checkout correct-branch
git stash pop
git commit
```

### "I need to find when bug started"
```bash
git bisect start
git bisect bad                  # Current is broken
git bisect good v1.0           # v1.0 was working
# Git will checkout commits to test
git bisect good/bad            # Mark each
git bisect reset               # When done
```

## Best Practices

1. **Never commit directly to main during development**
   - Always use feature branches
   - Merge when feature is complete

2. **Write commits as documentation**
   - Future you will thank you
   - Claude will understand better

3. **Keep commits atomic**
   - One logical change per commit
   - Easy to revert if needed

4. **Test before committing**
   - At minimum, code should compile
   - Ideally, test the feature

5. **Use meaningful branch names**
   - Include day number for hackathon
   - Clear feature description

6. **Regular pushes**
   - Backup your work
   - Enable collaboration
   - Show progress