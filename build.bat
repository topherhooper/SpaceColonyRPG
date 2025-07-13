@echo off
setlocal

:: Space Colony RPG - Build Script for Windows
echo ========================================
echo Space Colony RPG Build System
echo ========================================

:: Set Unity path - adjust this to your Unity installation
set UNITY_PATH="C:\Program Files\Unity\Hub\Editor\2022.3.4f1\Editor\Unity.exe"

:: Check if Unity exists
if not exist %UNITY_PATH% (
    echo ERROR: Unity not found at %UNITY_PATH%
    echo Please update UNITY_PATH in this script to point to your Unity installation
    echo Common locations:
    echo   C:\Program Files\Unity\Hub\Editor\[VERSION]\Editor\Unity.exe
    echo   C:\Program Files\Unity\Editor\Unity.exe
    exit /b 1
)

:: Get project path
set PROJECT_PATH=%cd%

:: Parse command line arguments
if "%1"=="" goto :usage
if /i "%1"=="windows" goto :build_windows
if /i "%1"=="win" goto :build_windows
if /i "%1"=="mac" goto :build_mac
if /i "%1"=="osx" goto :build_mac
if /i "%1"=="linux" goto :build_linux
if /i "%1"=="all" goto :build_all
if /i "%1"=="setup" goto :setup
if /i "%1"=="clean" goto :clean
goto :usage

:setup
echo Setting up project...
echo - Generating scenes...
echo - Creating prefabs...
echo - Configuring build settings...
%UNITY_PATH% -batchmode -quit -projectPath "%PROJECT_PATH%" -executeMethod QuickSetupHelper.SetupProject -logFile setup.log
echo Setup complete! Check setup.log for details.
goto :end

:build_windows
echo Building for Windows...
%UNITY_PATH% -batchmode -quit -projectPath "%PROJECT_PATH%" -executeMethod BuildScript.BuildWindowsCLI -logFile build_windows.log
if %ERRORLEVEL% EQU 0 (
    echo Build successful! Check Builds/Windows/
) else (
    echo Build failed! Check build_windows.log for errors.
)
goto :end

:build_mac
echo Building for Mac...
%UNITY_PATH% -batchmode -quit -projectPath "%PROJECT_PATH%" -executeMethod BuildScript.BuildMacCLI -logFile build_mac.log
if %ERRORLEVEL% EQU 0 (
    echo Build successful! Check Builds/Mac/
) else (
    echo Build failed! Check build_mac.log for errors.
)
goto :end

:build_linux
echo Building for Linux...
%UNITY_PATH% -batchmode -quit -projectPath "%PROJECT_PATH%" -executeMethod BuildScript.BuildLinuxCLI -logFile build_linux.log
if %ERRORLEVEL% EQU 0 (
    echo Build successful! Check Builds/Linux/
) else (
    echo Build failed! Check build_linux.log for errors.
)
goto :end

:build_all
echo Building for all platforms...
call :build_windows
call :build_mac
call :build_linux
echo All builds complete!
goto :end

:clean
echo Cleaning build folders...
if exist Builds rmdir /s /q Builds
if exist *.log del *.log
echo Clean complete!
goto :end

:usage
echo Usage: build.bat [command]
echo.
echo Commands:
echo   setup    - Setup project (generate scenes, prefabs)
echo   windows  - Build for Windows
echo   mac      - Build for Mac
echo   linux    - Build for Linux
echo   all      - Build for all platforms
echo   clean    - Clean build folders and logs
echo.
echo Examples:
echo   build.bat setup      - First time setup
echo   build.bat windows    - Build Windows executable
echo   build.bat all        - Build all platforms

:end
endlocal