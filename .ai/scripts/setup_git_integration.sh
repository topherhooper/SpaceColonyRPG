#!/bin/bash
# Quick setup script for Git integration with Claude Code

echo "=== Setting up Git Integration for Claude Code ==="
echo ""

# Configure git commit template
echo "→ Configuring commit message template..."
git config --local commit.template .gitmessage
echo "✓ Commit template configured"

# Set up useful aliases
echo "→ Adding helpful Git aliases..."
git config --local alias.today "log --since='1 day ago' --oneline --author='$(git config user.name)'"
git config --local alias.features "log --grep='^feat' --oneline"
git config --local alias.fixes "log --grep='^fix' --oneline"
git config --local alias.st "status -sb"
git config --local alias.uncommit "reset --soft HEAD~1"
git config --local alias.visual "log --graph --pretty=format:'%Cred%h%Creset -%C(yellow)%d%Creset %s %Cgreen(%cr) %C(bold blue)<%an>%Creset' --abbrev-commit"
echo "✓ Git aliases configured"

# Create initial directories if needed
echo "→ Creating directory structure..."
mkdir -p .ai/logs
mkdir -p .ai/reports
mkdir -p .ai/scripts
mkdir -p .ai/workflows
mkdir -p .ai/knowledge
mkdir -p .ai/conventions
echo "✓ Directories created"

# Initialize logs
echo "→ Initializing logs..."
touch .ai/logs/development_log.md
echo "# Development Log" > .ai/logs/development_log.md
echo "Started: $(date '+%Y-%m-%d %H:%M:%S')" >> .ai/logs/development_log.md
echo "---" >> .ai/logs/development_log.md
echo "✓ Logs initialized"

# Create first daily report
echo "→ Creating initial daily report..."
./.ai/scripts/daily_report.sh > /dev/null 2>&1
echo "✓ Daily report created"

# Summary
echo ""
echo "=== Git Integration Setup Complete! ==="
echo ""
echo "What's been configured:"
echo "✓ Commit message template (.gitmessage)"
echo "✓ Pre-commit hook (auto-updates AI context)"
echo "✓ Post-commit hook (logs development progress)"
echo "✓ Helpful Git aliases"
echo "✓ AI context directories"
echo ""
echo "Useful commands:"
echo "- git today          # Show today's commits"
echo "- git features       # List all features"
echo "- git fixes          # List all bug fixes"
echo "- git visual         # Pretty commit graph"
echo "- git uncommit       # Undo last commit (keep changes)"
echo ""
echo "Next steps:"
echo "1. Make your first commit to test the hooks"
echo "2. Check .ai/last_changes.md after committing"
echo "3. Run '.ai/scripts/daily_report.sh' at end of day"
echo ""
echo "Happy coding! 🚀"