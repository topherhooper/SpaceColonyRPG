#!/bin/bash

# Space Colony RPG - WSL Build Script
# Simplified build commands using WSL Unity path

echo "========================================"
echo "Space Colony RPG - WSL Build System"
echo "========================================"

# Unity path (using WSL mount)
# Update this to match your Unity installation
UNITY_PATH="/mnt/c/Program Files/Unity/Hub/Editor/2022.3.4f1/Editor/Unity.exe"

# Project path
PROJECT_PATH="."

# Function to run Unity command
run_unity() {
    "$UNITY_PATH" -batchmode -quit -projectPath "$PROJECT_PATH" $@
}

# Function to check compilation
check_compile() {
    echo "Running compilation check..."
    run_unity -executeMethod UnityEditor.AssetDatabase.Refresh -logFile /dev/stdout 2>&1 | grep -E -i "(error|warning|exception)" || echo "No errors found!"
}

# Function to setup project
setup_project() {
    echo "Setting up project (generating scenes, prefabs, materials)..."
    run_unity -executeMethod SetupAutomation.RunCompleteSetup -logFile setup.log
    echo "Setup complete! Check setup.log for details."
}

# Function to build Windows
build_windows() {
    echo "Building for Windows..."
    run_unity -buildWindows64Player Builds/Windows/SpaceColonyRPG.exe -logFile build_windows.log
    
    # Check for errors
    if grep -i "error" build_windows.log; then
        echo "❌ Build failed! Errors found in build_windows.log"
        return 1
    else
        echo "✅ Build successful! Output: Builds/Windows/SpaceColonyRPG.exe"
        return 0
    fi
}

# Function to quick test
quick_test() {
    echo "Running quick compilation test..."
    run_unity -executeMethod BuildScript.ValidateBeforeBuild -logFile /dev/stdout
}

# Parse command
case "$1" in
    check|compile)
        check_compile
        ;;
    setup)
        setup_project
        ;;
    build|windows)
        build_windows
        ;;
    test)
        quick_test
        ;;
    clean)
        echo "Cleaning build artifacts..."
        rm -rf Builds/
        rm -f *.log
        echo "Clean complete!"
        ;;
    *)
        echo "Usage: $0 {check|setup|build|test|clean}"
        echo ""
        echo "Commands:"
        echo "  check   - Quick compilation check"
        echo "  setup   - Generate all scenes and prefabs"
        echo "  build   - Build Windows executable"
        echo "  test    - Run validation tests"
        echo "  clean   - Remove build artifacts"
        echo ""
        echo "Examples:"
        echo "  $0 check   # Check for compile errors"
        echo "  $0 setup   # First-time setup"
        echo "  $0 build   # Create Windows build"
        exit 1
        ;;
esac