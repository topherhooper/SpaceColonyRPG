#!/bin/bash

# Space Colony RPG - Quick Compile Check Script
# Run this to check for compilation errors without opening Unity

echo "========================================"
echo "Space Colony RPG - Compilation Check"
echo "========================================"

# Unity path (using WSL mount)
# Update this to match your Unity installation
UNITY_PATH="/mnt/c/Program Files/Unity/Hub/Editor/6000.1.11f1/Editor/Unity.exe"

# Check if Unity exists
if [ ! -f "$UNITY_PATH" ]; then
    echo "ERROR: Unity not found at $UNITY_PATH"
    echo "Please update UNITY_PATH in this script"
    exit 1
fi

echo "Checking for compilation errors..."
echo ""

# Run Unity compile check and filter for errors/warnings
"$UNITY_PATH" -batchmode -quit -projectPath . -executeMethod UnityEditor.AssetDatabase.Refresh -logFile /dev/stdout 2>&1 | grep -E -i "(error|warning|exception|failed|missing)" | grep -v "UnityEngine.Debug:Log"

# Check exit status
if [ ${PIPESTATUS[0]} -eq 0 ]; then
    echo ""
    echo "✅ Compilation check complete!"
    
    # Count errors
    ERROR_COUNT=$("$UNITY_PATH" -batchmode -quit -projectPath . -executeMethod UnityEditor.AssetDatabase.Refresh -logFile /dev/stdout 2>&1 | grep -c -i "error")
    WARNING_COUNT=$("$UNITY_PATH" -batchmode -quit -projectPath . -executeMethod UnityEditor.AssetDatabase.Refresh -logFile /dev/stdout 2>&1 | grep -c -i "warning")
    
    echo "Errors: $ERROR_COUNT"
    echo "Warnings: $WARNING_COUNT"
else
    echo ""
    echo "❌ Unity failed to run. Check the path and try again."
    exit 1
fi