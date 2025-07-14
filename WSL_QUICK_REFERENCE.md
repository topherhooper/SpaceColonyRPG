# WSL Unity Quick Reference

## One-Time Setup
```bash
# Add Unity alias to ~/.bashrc (adjust version as needed)
echo "alias unity='/mnt/c/Program\ Files/Unity/Hub/Editor/2022.3.4f1/Editor/Unity.exe'" >> ~/.bashrc
source ~/.bashrc

# For this specific project, you can also add:
echo "alias unity-scr='cd /mnt/c/Users/hoope/Projects/UnityProjects/SpaceColonyRPG && unity'" >> ~/.bashrc
```

## Daily Development Commands

### 1. Check Compilation (Most Used)
```bash
./compile-check.sh
```

### 2. Full Project Setup
```bash
./build-wsl.sh setup
```

### 3. Build Game
```bash
./build-wsl.sh build
```

### 4. Clean Build Files
```bash
./build-wsl.sh clean
```

## Advanced Commands

### Check Specific Errors
```bash
# Show only CS errors
unity -batchmode -quit -projectPath . -executeMethod UnityEditor.AssetDatabase.Refresh -logFile /dev/stdout | grep "CS[0-9]"

# Show Mirror/Network errors
unity -batchmode -quit -projectPath . -executeMethod UnityEditor.AssetDatabase.Refresh -logFile /dev/stdout | grep -i "mirror\|network"
```

### Build with Live Output
```bash
unity -batchmode -quit -projectPath . -buildWindows64Player Builds/SpaceColonyRPG.exe -logFile /dev/stdout
```

### Watch Mode (Auto-compile on file change)
```bash
# Install inotify-tools first: sudo apt-get install inotify-tools
while true; do 
    inotifywait -r -e modify Assets/_Project/Scripts/
    clear
    ./compile-check.sh
done
```

## Common Issues

### Unity Path Wrong
Edit `compile-check.sh` and `build-wsl.sh`, update:
```bash
UNITY_PATH="/mnt/c/Program Files/Unity/Hub/Editor/[YOUR_VERSION]/Editor/Unity.exe"
```

### Permission Denied
```bash
chmod +x compile-check.sh build-wsl.sh
```

### Can't Find Scripts
Make sure you're in project root:
```bash
cd /mnt/c/Users/hoope/Projects/UnityProjects/SpaceColonyRPG
```

## Tips

1. **Always run `./compile-check.sh` before building** - it's much faster
2. **Use `| less` to page through long error lists**
3. **Use `| grep -v "Warning"` to hide warnings**
4. **Add `2>&1` to capture all output including errors**

## Example Workflow

```bash
# 1. Navigate to project
cd /mnt/c/Users/hoope/Projects/UnityProjects/SpaceColonyRPG

# 2. Make your code changes in VS Code
code .

# 3. Check compilation
./compile-check.sh

# 4. If errors, see details
unity -batchmode -quit -projectPath . -executeMethod UnityEditor.AssetDatabase.Refresh -logFile /dev/stdout 2>&1 | less

# 5. Build when ready
./build-wsl.sh build

# 6. Run the game
./Builds/Windows/SpaceColonyRPG.exe
```