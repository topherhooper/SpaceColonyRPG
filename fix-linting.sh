#!/bin/bash

echo "Fixing linting errors in C# files..."

# Find all C# files and fix trailing whitespace and tabs
find Assets -name "*.cs" -type f ! -path "*/TextMesh Pro/*" ! -path "*/Mirror/*" ! -path "*/ThirdParty/*" | while read file; do
    # Create a temporary file
    temp_file=$(mktemp)
    
    # Process the file line by line
    while IFS= read -r line || [ -n "$line" ]; do
        # Remove trailing whitespace
        cleaned_line=$(echo "$line" | sed 's/[[:space:]]*$//')
        # Convert tabs to spaces
        cleaned_line=$(echo "$cleaned_line" | sed 's/\t/    /g')
        # Write non-empty lines or lines that aren't just whitespace
        if [ -n "$cleaned_line" ]; then
            echo "$cleaned_line" >> "$temp_file"
        else
            # Keep truly empty lines (not lines with just spaces)
            echo "" >> "$temp_file"
        fi
    done < "$file"
    
    # Replace the original file
    mv "$temp_file" "$file"
    
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