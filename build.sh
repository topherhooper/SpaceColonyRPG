#!/bin/bash

# Space Colony RPG - Build Script for Mac/Linux
echo "========================================"
echo "Space Colony RPG Build System"
echo "========================================"

# Set Unity path - adjust this to your Unity installation
if [[ "$OSTYPE" == "darwin"* ]]; then
    # macOS
    UNITY_PATH="/Applications/Unity/Hub/Editor/2022.3.4f1/Unity.app/Contents/MacOS/Unity"
else
    # Linux
    UNITY_PATH="/opt/unity/2022.3.4f1/Editor/Unity"
fi

# Check if Unity exists
if [ ! -f "$UNITY_PATH" ]; then
    echo "ERROR: Unity not found at $UNITY_PATH"
    echo "Please update UNITY_PATH in this script to point to your Unity installation"
    echo "Common locations:"
    echo "  Mac: /Applications/Unity/Hub/Editor/[VERSION]/Unity.app/Contents/MacOS/Unity"
    echo "  Linux: /opt/unity/[VERSION]/Editor/Unity"
    exit 1
fi

# Get project path
PROJECT_PATH=$(pwd)

# Function definitions
setup_project() {
    echo "Setting up project..."
    echo "- Generating scenes..."
    echo "- Creating prefabs..."
    echo "- Configuring build settings..."
    "$UNITY_PATH" -batchmode -quit -projectPath "$PROJECT_PATH" -executeMethod QuickSetupHelper.SetupProject -logFile setup.log
    echo "Setup complete! Check setup.log for details."
}

build_windows() {
    echo "Building for Windows..."
    "$UNITY_PATH" -batchmode -quit -projectPath "$PROJECT_PATH" -executeMethod BuildScript.BuildWindowsCLI -logFile build_windows.log
    if [ $? -eq 0 ]; then
        echo "Build successful! Check Builds/Windows/"
    else
        echo "Build failed! Check build_windows.log for errors."
    fi
}

build_mac() {
    echo "Building for Mac..."
    "$UNITY_PATH" -batchmode -quit -projectPath "$PROJECT_PATH" -executeMethod BuildScript.BuildMacCLI -logFile build_mac.log
    if [ $? -eq 0 ]; then
        echo "Build successful! Check Builds/Mac/"
    else
        echo "Build failed! Check build_mac.log for errors."
    fi
}

build_linux() {
    echo "Building for Linux..."
    "$UNITY_PATH" -batchmode -quit -projectPath "$PROJECT_PATH" -executeMethod BuildScript.BuildLinuxCLI -logFile build_linux.log
    if [ $? -eq 0 ]; then
        echo "Build successful! Check Builds/Linux/"
    else
        echo "Build failed! Check build_linux.log for errors."
    fi
}

build_all() {
    echo "Building for all platforms..."
    build_windows
    build_mac
    build_linux
    echo "All builds complete!"
}

clean_builds() {
    echo "Cleaning build folders..."
    rm -rf Builds
    rm -f *.log
    echo "Clean complete!"
}

show_usage() {
    echo "Usage: ./build.sh [command]"
    echo ""
    echo "Commands:"
    echo "  setup    - Setup project (generate scenes, prefabs)"
    echo "  windows  - Build for Windows"
    echo "  mac      - Build for Mac"
    echo "  linux    - Build for Linux"
    echo "  all      - Build for all platforms"
    echo "  clean    - Clean build folders and logs"
    echo ""
    echo "Examples:"
    echo "  ./build.sh setup      - First time setup"
    echo "  ./build.sh windows    - Build Windows executable"
    echo "  ./build.sh all        - Build all platforms"
}

# Parse command line arguments
case "$1" in
    setup)
        setup_project
        ;;
    windows|win)
        build_windows
        ;;
    mac|osx)
        build_mac
        ;;
    linux)
        build_linux
        ;;
    all)
        build_all
        ;;
    clean)
        clean_builds
        ;;
    *)
        show_usage
        exit 1
        ;;
esac