#!/bin/bash

# Space Colony RPG - WSL Build Script
# Simplified build commands using WSL Unity path

echo "========================================"
echo "Space Colony RPG - WSL Build System"
echo "========================================"

# Unity path (using WSL mount)
# Update this to match your Unity installation
UNITY_PATH="/mnt/c/Program Files/Unity/Hub/Editor/6000.1.11f1/Editor/Unity.exe"

# Project path
PROJECT_PATH="."

# Color codes for output
RED='\033[0;31m'
GREEN='\033[0;32m'
YELLOW='\033[1;33m'
NC='\033[0m' # No Color

# Function to run Unity command
run_unity() {
    "$UNITY_PATH" -batchmode -quit -projectPath "$PROJECT_PATH" $@
}

# Function to check log for failures
check_log_for_failures() {
    local log_file=$1
    local operation=$2
    
    if [ ! -f "$log_file" ]; then
        echo -e "${RED}❌ $operation failed! Log file not found: $log_file${NC}"
        return 1
    fi
    
    # Check for various failure indicators
    local has_errors=0
    
    # Check for compilation errors
    if grep -q "error CS" "$log_file"; then
        echo -e "${RED}❌ Compilation errors found!${NC}"
        grep "error CS" "$log_file" | head -10
        has_errors=1
    fi
    
    # Check for script errors
    if grep -q "Scripts have compiler errors" "$log_file"; then
        echo -e "${RED}❌ Script compilation failed!${NC}"
        has_errors=1
    fi
    
    # Check for fatal errors
    if grep -q "Fatal Error" "$log_file"; then
        echo -e "${RED}❌ Fatal error detected!${NC}"
        grep -A 5 "Fatal Error" "$log_file"
        has_errors=1
    fi
    
    # Check for Unity instance conflicts
    if grep -q "Another Unity instance is running" "$log_file"; then
        echo -e "${RED}❌ Another Unity instance is running with this project!${NC}"
        echo "Please close Unity Editor and try again."
        has_errors=1
    fi
    
    # Check for build failures
    if grep -q "Build failed" "$log_file"; then
        echo -e "${RED}❌ Build failed!${NC}"
        grep -B 5 -A 5 "Build failed" "$log_file"
        has_errors=1
    fi
    
    # Check for exceptions (excluding known safe ones)
    if grep -E "Exception:|UnhandledException:" "$log_file" | grep -v "SocketException" | grep -v "IOException" > /dev/null; then
        echo -e "${YELLOW}⚠️  Exceptions detected:${NC}"
        grep -E "Exception:|UnhandledException:" "$log_file" | grep -v "SocketException" | grep -v "IOException" | head -5
    fi
    
    return $has_errors
}

# Function to show build progress from log
show_build_progress() {
    local log_file=$1
    
    if [ ! -f "$log_file" ]; then
        return
    fi
    
    echo -e "\n${YELLOW}=== Build Progress ===${NC}"
    
    # Show important build steps
    grep -E "(Building:|Compiling:|Packaging:|PlayerBuild|Mono:|Burst:|Total time:|Build succeeded)" "$log_file" | tail -20
    
    # Show shader compilation progress
    local shader_count=$(grep -c "Compiling shader" "$log_file" 2>/dev/null || echo "0")
    if [ "$shader_count" -gt 0 ]; then
        echo "Compiled $shader_count shaders"
    fi
    
    # Show asset processing
    if grep -q "Refreshing native plugins" "$log_file"; then
        echo "✓ Native plugins refreshed"
    fi
    
    if grep -q "Registering precompiled user dll" "$log_file"; then
        local dll_count=$(grep -c "Registering precompiled user dll" "$log_file")
        echo "✓ Registered $dll_count user DLLs"
    fi
    
    echo -e "${YELLOW}======================${NC}\n"
}

# Function to check compilation
check_compile() {
    echo "Running compilation check..."
    local log_file="compile_check.log"
    
    run_unity -executeMethod UnityEditor.AssetDatabase.Refresh -logFile "$log_file" 2>&1
    local unity_exit_code=$?
    
    # Check Unity exit code
    if [ $unity_exit_code -ne 0 ]; then
        echo -e "${RED}❌ Unity exited with error code: $unity_exit_code${NC}"
        check_log_for_failures "$log_file" "Compilation check"
        return 1
    fi
    
    # Check log for errors
    if check_log_for_failures "$log_file" "Compilation check"; then
        echo -e "${GREEN}✅ No compilation errors found!${NC}"
        return 0
    else
        return 1
    fi
}

# Function to setup project
setup_project() {
    echo "Setting up project (generating scenes, prefabs, materials)..."
    local log_file="setup.log"
    
    echo -e "${YELLOW}Running setup automation...${NC}"
    
    run_unity -executeMethod SetupAutomation.RunCompleteSetup -logFile "$log_file" 2>&1
    local unity_exit_code=$?
    
    # Show setup progress from log
    if [ -f "$log_file" ]; then
        echo -e "\n${YELLOW}=== Setup Progress ===${NC}"
        grep -E "(Creating|Generated|Setup|Added|Created material|Created directory)" "$log_file" | tail -20
        echo -e "${YELLOW}======================${NC}\n"
    fi
    
    # Check Unity exit code
    if [ $unity_exit_code -ne 0 ]; then
        echo -e "${RED}❌ Unity exited with error code: $unity_exit_code${NC}"
        check_log_for_failures "$log_file" "Setup"
        return 1
    fi
    
    # Check log for errors
    if check_log_for_failures "$log_file" "Setup"; then
        echo -e "${GREEN}✅ Setup completed successfully!${NC}"
        
        # Check if scenes were created
        if [ -f "Assets/_Project/Scenes/MainMenu.unity" ] && 
           [ -f "Assets/_Project/Scenes/ColonyScene.unity" ] && 
           [ -f "Assets/_Project/Scenes/RaidScene.unity" ]; then
            echo -e "${GREEN}✅ All scenes created successfully!${NC}"
        else
            echo -e "${YELLOW}⚠️  Some scenes may not have been created. Check manually.${NC}"
        fi
        
        # Show what was created
        echo -e "\n${GREEN}Created assets:${NC}"
        echo "- Scenes: $(find Assets/_Project/Scenes -name "*.unity" 2>/dev/null | wc -l)"
        echo "- Prefabs: $(find Assets/_Project/Prefabs -name "*.prefab" 2>/dev/null | wc -l)"
        echo "- Materials: $(find Assets/_Project/Materials -name "*.mat" 2>/dev/null | wc -l)"
        
        return 0
    else
        return 1
    fi
}

# Function to build Windows
build_windows() {
    echo "Building for Windows..."
    local log_file="build_windows.log"
    
    # Try to clean previous build, but don't fail if we can't
    if [ -d "Builds/Windows/" ]; then
        echo "Attempting to clean previous build..."
        rm -rf Builds/Windows/ 2>/dev/null || {
            echo -e "${YELLOW}⚠️  Could not fully clean previous build. Files may be in use.${NC}"
            echo "Trying alternative cleanup..."
            # Try to at least remove what we can
            find Builds/Windows/ -type f -exec rm -f {} \; 2>/dev/null || true
            find Builds/Windows/ -type d -empty -delete 2>/dev/null || true
        }
    fi
    
    echo -e "${YELLOW}Starting Unity build process...${NC}"
    echo "This may take several minutes. Monitoring progress..."
    echo ""
    
    # Start Unity build in background and monitor log
    run_unity -buildWindows64Player Builds/Windows/SpaceColonyRPG.exe -logFile "$log_file" 2>&1 &
    local unity_pid=$!
    
    # Monitor the log file while Unity is running
    local last_size=0
    while kill -0 $unity_pid 2>/dev/null; do
        if [ -f "$log_file" ]; then
            local current_size=$(stat -c%s "$log_file" 2>/dev/null || echo 0)
            if [ "$current_size" -gt "$last_size" ]; then
                # Show new progress indicators
                tail -n +$((last_size/100)) "$log_file" | grep -E "(Building player|Compiling scripts|Packaging assets|Building scenes|PlayerBuild)" | tail -5
                last_size=$current_size
            fi
        fi
        sleep 2
    done
    
    # Wait for Unity to finish and get exit code
    wait $unity_pid
    local unity_exit_code=$?
    
    # Show final build progress summary
    show_build_progress "$log_file"
    
    # Check Unity exit code
    if [ $unity_exit_code -ne 0 ]; then
        echo -e "${RED}❌ Unity exited with error code: $unity_exit_code${NC}"
        check_log_for_failures "$log_file" "Build"
        return 1
    fi
    
    # Check if build succeeded by looking for the executable
    if [ -f "Builds/Windows/SpaceColonyRPG.exe" ]; then
        # Check log for errors even if exe exists
        if check_log_for_failures "$log_file" "Build"; then
            echo -e "${GREEN}✅ Build successful! Output: Builds/Windows/SpaceColonyRPG.exe${NC}"
            
            # Show build size
            local build_size=$(du -sh Builds/Windows/ 2>/dev/null | cut -f1)
            echo "Build size: $build_size"
            
            # Show build time if available
            local build_time=$(grep "Total time:" "$log_file" | tail -1)
            if [ -n "$build_time" ]; then
                echo "$build_time"
            fi
            
            return 0
        else
            echo -e "${YELLOW}⚠️  Build created but errors were detected. The build may not work correctly.${NC}"
            return 1
        fi
    else
        echo -e "${RED}❌ Build failed! Executable not created.${NC}"
        check_log_for_failures "$log_file" "Build"
        
        # Show last few lines of log for context
        echo -e "\n${RED}Last 20 lines of build log:${NC}"
        tail -20 "$log_file"
        
        return 1
    fi
}

# Function to quick test
quick_test() {
    echo "Running quick compilation test..."
    local log_file="test.log"
    
    run_unity -executeMethod BuildScript.ValidateBeforeBuild -logFile "$log_file" 2>&1
    local unity_exit_code=$?
    
    # Check Unity exit code
    if [ $unity_exit_code -ne 0 ]; then
        echo -e "${RED}❌ Unity exited with error code: $unity_exit_code${NC}"
        check_log_for_failures "$log_file" "Test"
        return 1
    fi
    
    # Check log for errors
    if check_log_for_failures "$log_file" "Test"; then
        echo -e "${GREEN}✅ Tests passed!${NC}"
        return 0
    else
        return 1
    fi
}

# Function to run all unit tests
run_all_tests() {
    echo -e "${YELLOW}Running all unit tests...${NC}"
    echo "========================================"
    
    # Run linting first
    echo -e "\n${YELLOW}🔍 Running code linter...${NC}"
    local lint_issues=$(find Assets -name "*.cs" -type f ! -path "*/TextMesh Pro/*" ! -path "*/Mirror/*" ! -path "*/ThirdParty/*" -exec grep -l -E "(^\s*$|[ \t]+$|\t)" {} \; 2>/dev/null | wc -l)
    
    if [ "$lint_issues" -gt 0 ]; then
        echo -e "${RED}❌ Linting errors found in $lint_issues files${NC}"
        echo "Run './fix-linting.sh' to automatically fix these issues."
        echo ""
        echo "Files with issues:"
        find Assets -name "*.cs" -type f ! -path "*/TextMesh Pro/*" ! -path "*/Mirror/*" ! -path "*/ThirdParty/*" -exec grep -l -E "(^\s*$|[ \t]+$|\t)" {} \; 2>/dev/null | head -10
        echo ""
        echo -e "${YELLOW}Continuing with tests despite linting errors...${NC}"
    else
        echo -e "${GREEN}✅ Code linting passed!${NC}"
    fi
    
    # Create test results directory
    mkdir -p TestResults
    
    # Run Edit Mode tests
    echo -e "\n${YELLOW}🧪 Running Edit Mode tests...${NC}"
    local edit_log="TestResults/editmode-log.txt"
    local edit_results="TestResults/editmode-results.xml"
    
    run_unity -runTests -testPlatform EditMode -testResults "$edit_results" -logFile "$edit_log" 2>&1
    local edit_exit_code=$?
    
    # Check Edit Mode results
    if [ $edit_exit_code -eq 0 ]; then
        echo -e "${GREEN}✅ Edit Mode tests passed!${NC}"
        
        # Show test summary if available
        if [ -f "$edit_results" ]; then
            local total_tests=$(grep -o 'testcasecount="[0-9]*"' "$edit_results" | grep -o '[0-9]*' | head -1)
            local passed_tests=$(grep -o 'passed="[0-9]*"' "$edit_results" | grep -o '[0-9]*' | head -1)
            local failed_tests=$(grep -o 'failed="[0-9]*"' "$edit_results" | grep -o '[0-9]*' | head -1)
            
            if [ -n "$total_tests" ]; then
                echo "  Total: $total_tests, Passed: ${passed_tests:-0}, Failed: ${failed_tests:-0}"
            fi
        fi
    else
        echo -e "${RED}❌ Edit Mode tests failed!${NC}"
        
        # Show failed tests from log
        if [ -f "$edit_log" ]; then
            echo -e "\n${RED}=== Failed Test Details ===${NC}"
            
            # Show failed test names
            grep -E "(FAILED:|Failed:)" "$edit_log" | head -10
            
            # Show assertion failures
            echo -e "\n${RED}=== Assertion Failures ===${NC}"
            grep -A 3 -B 1 "Assert\." "$edit_log" | grep -v "^--$" | head -20
            
            # Show exceptions
            if grep -q "Exception:" "$edit_log"; then
                echo -e "\n${RED}=== Exceptions ===${NC}"
                grep -A 5 "Exception:" "$edit_log" | head -20
            fi
            
            # Show compilation errors if any
            if grep -q "error CS" "$edit_log"; then
                echo -e "\n${RED}=== Compilation Errors ===${NC}"
                grep "error CS" "$edit_log" | head -10
            fi
            
            echo -e "\n${YELLOW}Full log available at: $edit_log${NC}"
        fi
    fi
    
    # Run Play Mode tests
    echo -e "\n${YELLOW}🧪 Running Play Mode tests...${NC}"
    local play_log="TestResults/playmode-log.txt"
    local play_results="TestResults/playmode-results.xml"
    
    run_unity -runTests -testPlatform PlayMode -testResults "$play_results" -logFile "$play_log" 2>&1
    local play_exit_code=$?
    
    # Check Play Mode results
    if [ $play_exit_code -eq 0 ]; then
        echo -e "${GREEN}✅ Play Mode tests passed!${NC}"
        
        # Show test summary if available
        if [ -f "$play_results" ]; then
            local total_tests=$(grep -o 'testcasecount="[0-9]*"' "$play_results" | grep -o '[0-9]*' | head -1)
            local passed_tests=$(grep -o 'passed="[0-9]*"' "$play_results" | grep -o '[0-9]*' | head -1)
            local failed_tests=$(grep -o 'failed="[0-9]*"' "$play_results" | grep -o '[0-9]*' | head -1)
            
            if [ -n "$total_tests" ]; then
                echo "  Total: $total_tests, Passed: ${passed_tests:-0}, Failed: ${failed_tests:-0}"
            fi
        fi
    else
        echo -e "${RED}❌ Play Mode tests failed!${NC}"
        
        # Show failed tests from log
        if [ -f "$play_log" ]; then
            echo -e "\n${RED}=== Failed Test Details ===${NC}"
            
            # Show failed test names
            grep -E "(FAILED:|Failed:)" "$play_log" | head -10
            
            # Show assertion failures
            echo -e "\n${RED}=== Assertion Failures ===${NC}"
            grep -A 3 -B 1 "Assert\." "$play_log" | grep -v "^--$" | head -20
            
            # Show exceptions
            if grep -q "Exception:" "$play_log"; then
                echo -e "\n${RED}=== Exceptions ===${NC}"
                grep -A 5 "Exception:" "$play_log" | head -20
            fi
            
            # Show compilation errors if any
            if grep -q "error CS" "$play_log"; then
                echo -e "\n${RED}=== Compilation Errors ===${NC}"
                grep "error CS" "$play_log" | head -10
            fi
            
            echo -e "\n${YELLOW}Full log available at: $play_log${NC}"
        fi
    fi
    
    # Overall summary
    echo -e "\n========================================"
    if [ $edit_exit_code -eq 0 ] && [ $play_exit_code -eq 0 ]; then
        echo -e "${GREEN}✅ All tests passed!${NC}"
        echo -e "Test results saved in TestResults/"
        return 0
    else
        echo -e "${RED}❌ Some tests failed!${NC}"
        echo -e "Check TestResults/ for detailed logs"
        return 1
    fi
}

# Function to run specific test category
run_test_category() {
    local category=$1
    echo -e "${YELLOW}Running $category tests...${NC}"
    
    local log_file="TestResults/${category,,}-log.txt"
    local results_file="TestResults/${category,,}-results.xml"
    
    mkdir -p TestResults
    
    # Determine test filter based on category
    local test_filter=""
    case $category in
        "Colony")
            test_filter="SpaceColonyRPG.Tests.EditMode.Colony"
            ;;
        "Combat")
            test_filter="SpaceColonyRPG.Tests.EditMode.Combat"
            ;;
        "Integration")
            test_filter="SpaceColonyRPG.Tests.PlayMode.Integration"
            ;;
        *)
            echo -e "${RED}Unknown test category: $category${NC}"
            echo "Available categories: Colony, Combat, Integration"
            return 1
            ;;
    esac
    
    # Run tests with filter
    run_unity -runTests -testPlatform EditMode -testFilter "$test_filter" -testResults "$results_file" -logFile "$log_file" 2>&1
    local exit_code=$?
    
    if [ $exit_code -eq 0 ]; then
        echo -e "${GREEN}✅ $category tests passed!${NC}"
    else
        echo -e "${RED}❌ $category tests failed!${NC}"
        
        # Show failures
        if [ -f "$log_file" ]; then
            echo -e "\n${RED}=== Failed Test Details ===${NC}"
            
            # Show failed test names
            grep -E "(FAILED:|Failed:)" "$log_file" | head -10
            
            # Show assertion failures
            echo -e "\n${RED}=== Assertion Failures ===${NC}"
            grep -A 3 -B 1 "Assert\." "$log_file" | grep -v "^--$" | head -20
            
            # Show exceptions
            if grep -q "Exception:" "$log_file"; then
                echo -e "\n${RED}=== Exceptions ===${NC}"
                grep -A 5 "Exception:" "$log_file" | head -20
            fi
            
            # Show compilation errors if any
            if grep -q "error CS" "$log_file"; then
                echo -e "\n${RED}=== Compilation Errors ===${NC}"
                grep "error CS" "$log_file" | head -10
            fi
            
            echo -e "\n${YELLOW}Full log available at: $log_file${NC}"
        fi
    fi
    
    return $exit_code
}

# Function to show recent errors from all logs
show_errors() {
    echo "Checking all log files for errors..."
    echo ""
    
    for log_file in *.log; do
        if [ -f "$log_file" ]; then
            echo "=== $log_file ==="
            grep -E "(error CS|Fatal Error|Build failed|Scripts have compiler errors)" "$log_file" 2>/dev/null | head -5
            echo ""
        fi
    done
}

# Parse command
case "$1" in
    check|compile)
        check_compile
        exit $?
        ;;
    setup)
        setup_project
        exit $?
        ;;
    build|windows)
        build_windows
        exit $?
        ;;
    test)
        quick_test
        exit $?
        ;;
    tests|test-all)
        run_all_tests
        exit $?
        ;;
    test-category)
        if [ -z "$2" ]; then
            echo -e "${RED}Error: Test category required${NC}"
            echo "Usage: $0 test-category {Colony|Combat|Integration}"
            exit 1
        fi
        run_test_category "$2"
        exit $?
        ;;
    lint)
        echo -e "${YELLOW}🔍 Running code linter...${NC}"
        lint_issues=$(find Assets -name "*.cs" -type f ! -path "*/TextMesh Pro/*" ! -path "*/Mirror/*" ! -path "*/ThirdParty/*" -exec grep -l -E "(^\s*$|[ \t]+$|\t)" {} \; 2>/dev/null)
        
        if [ -z "$lint_issues" ]; then
            echo -e "${GREEN}✅ No linting issues found!${NC}"
            exit 0
        else
            echo -e "${RED}❌ Linting errors found in:${NC}"
            echo "$lint_issues"
            echo ""
            echo "Run './fix-linting.sh' to automatically fix these issues."
            exit 1
        fi
        ;;
    fix-lint)
        if [ -f "./fix-linting.sh" ]; then
            ./fix-linting.sh
        else
            echo -e "${RED}fix-linting.sh not found!${NC}"
            exit 1
        fi
        ;;
    errors)
        show_errors
        ;;
    clean)
        echo "Cleaning build artifacts..."
        rm -rf Builds/ 2>/dev/null || {
            echo -e "${YELLOW}⚠️  Some files could not be removed. They may be in use.${NC}"
            # Try Windows-side cleanup
            echo "Attempting Windows-side cleanup..."
            cmd.exe /c "rd /s /q Builds" 2>/dev/null || true
        }
        rm -f *.log 2>/dev/null
        echo -e "${GREEN}✅ Clean complete!${NC}"
        ;;
    force-clean)
        echo "Force cleaning build artifacts (Windows side)..."
        # Use Windows commands to force remove
        cmd.exe /c "taskkill /f /im SpaceColonyRPG.exe" 2>/dev/null || true
        sleep 1
        cmd.exe /c "rd /s /q Builds" 2>/dev/null || {
            echo -e "${YELLOW}⚠️  Could not remove Builds folder. Try closing all programs using these files.${NC}"
        }
        rm -f *.log 2>/dev/null
        echo -e "${GREEN}✅ Force clean complete!${NC}"
        ;;
    *)
        echo "Usage: $0 {check|setup|build|test|tests|test-category|lint|fix-lint|errors|clean|force-clean}"
        echo ""
        echo "Commands:"
        echo "  check        - Quick compilation check"
        echo "  setup        - Generate all scenes and prefabs"
        echo "  build        - Build Windows executable"
        echo "  test         - Run validation tests"
        echo "  tests        - Run all unit tests with linting (EditMode + PlayMode)"
        echo "  test-category <name> - Run specific test category (Colony/Combat/Integration)"
        echo "  lint         - Check code for linting issues"
        echo "  fix-lint     - Automatically fix linting issues"
        echo "  errors       - Show recent errors from all logs"
        echo "  clean        - Remove build artifacts"
        echo "  force-clean  - Force remove build artifacts (Windows side)"
        echo ""
        echo "Examples:"
        echo "  $0 check   # Check for compile errors"
        echo "  $0 setup   # First-time setup"
        echo "  $0 build   # Create Windows build"
        echo "  $0 tests   # Run all unit tests with linting"
        echo "  $0 lint    # Check for code style issues"
        echo "  $0 fix-lint # Auto-fix code style issues"
        echo "  $0 test-category Colony  # Run only Colony tests"
        echo "  $0 errors  # Show all recent errors"
        exit 1
        ;;
esac