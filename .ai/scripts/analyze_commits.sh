#!/bin/bash
# Analyze git commits for patterns and insights

echo "=== Git Commit Analysis ==="
echo "Generated: $(date '+%Y-%m-%d %H:%M:%S')"
echo ""

# Function to show section
show_section() {
    echo ""
    echo "## $1"
    echo "---"
}

# Overall statistics
show_section "Repository Statistics"
echo "Total commits: $(git rev-list --all --count)"
echo "Contributors: $(git shortlog -sn --no-merges | wc -l)"
echo "First commit: $(git log --reverse --format='%ad' --date=short | head -1)"
echo "Latest commit: $(git log -1 --format='%ad' --date=short)"

# Commit patterns
show_section "Commit Type Distribution"
echo "Features: $(git log --all --grep='^feat' --oneline | wc -l)"
echo "Fixes: $(git log --all --grep='^fix' --oneline | wc -l)"
echo "Refactors: $(git log --all --grep='^refactor' --oneline | wc -l)"
echo "Performance: $(git log --all --grep='^perf' --oneline | wc -l)"
echo "Docs: $(git log --all --grep='^docs' --oneline | wc -l)"
echo "Tests: $(git log --all --grep='^test' --oneline | wc -l)"
echo "Chores: $(git log --all --grep='^chore' --oneline | wc -l)"

# Recent activity
show_section "Recent Activity (Last 7 Days)"
git log --since="7 days ago" --pretty=format:"%h - %s (%cr)" --abbrev-commit | head -10

# Most changed files
show_section "Most Frequently Changed Files"
git log --all --name-only --pretty=format:"" | sort | uniq -c | sort -rn | head -10

# Code evolution
show_section "Code Patterns"

echo "Mirror/Networking additions:"
git log -S "using Mirror" --oneline | wc -l

echo "Command patterns:"
git log -S "\[Command\]" --oneline | wc -l

echo "RPC patterns:"
git log -S "\[ClientRpc\]" --oneline | wc -l

echo "SyncVar usage:"
git log -S "\[SyncVar\]" --oneline | wc -l

# Find potential issues
show_section "Potential Issues"

echo "TODOs added:"
git grep -n "TODO" | wc -l

echo "FIXMEs added:"
git grep -n "FIXME" | wc -l

echo "Debug.Log statements:"
git grep -n "Debug\.Log" | wc -l

echo "Hardcoded values (possible magic numbers):"
git grep -E "[^0-9][0-9]{2,}[^0-9]" -- "*.cs" | wc -l

# Performance indicators
show_section "Performance Indicators"

echo "Update() methods:"
git grep -n "void Update()" -- "*.cs" | wc -l

echo "FixedUpdate() methods:"
git grep -n "void FixedUpdate()" -- "*.cs" | wc -l

echo "GetComponent calls:"
git grep -n "GetComponent" -- "*.cs" | wc -l

echo "GameObject.Find calls:"
git grep -n "GameObject\.Find" -- "*.cs" | wc -l

# Recent features and fixes
show_section "Recent Features (Last 30 Days)"
git log --since="30 days ago" --grep="^feat" --pretty=format:"- %s" | head -10

show_section "Recent Fixes (Last 30 Days)"
git log --since="30 days ago" --grep="^fix" --pretty=format:"- %s" | head -10

# Suggestions
show_section "Suggestions for Claude"
echo "1. Review files with most changes for refactoring opportunities"
echo "2. Check TODO/FIXME items for quick wins"
echo "3. Optimize files with multiple GetComponent calls"
echo "4. Consider caching GameObject.Find results"
echo "5. Review Update() methods for optimization"

echo ""
echo "=== End of Analysis ==="