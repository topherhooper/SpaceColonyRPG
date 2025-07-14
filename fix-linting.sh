#!/bin/bash

echo "Fixing linting errors in C# files..."

# Find all C# files and fix trailing whitespace and tabs
find Assets -name "*.cs" -type f | while read file; do
    # Remove trailing whitespace and convert tabs to spaces
    sed -i 's/[[:space:]]*$//' "$file"
    sed -i 's/\t/    /g' "$file"
    
    # Ensure file ends with newline
    if [ -n "$(tail -c 1 "$file")" ]; then
        echo >> "$file"
    fi
done

echo "Linting fixes applied!"
echo "Files fixed:"
find Assets -name "*.cs" -type f -exec grep -l -E "(^[[:space:]]*$|[[:space:]]+$|\t)" {} \; 2>/dev/null | wc -l

# Also fix the test result files that were flagged
for file in TestResults/*.txt; do
    if [ -f "$file" ]; then
        # Ensure file ends with newline
        if [ -n "$(tail -c 1 "$file")" ]; then
            echo >> "$file"
        fi
    fi
done

echo "Done! You can now run 'git add -A' and commit the fixes."