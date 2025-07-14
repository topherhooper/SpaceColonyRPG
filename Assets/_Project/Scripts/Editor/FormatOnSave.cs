using UnityEditor;
using UnityEngine;
using System.IO;
using System.Linq;

namespace SpaceColonyRPG.Editor
{
    [InitializeOnLoad]
    public class FormatOnSave : AssetModificationProcessor
    {
        static FormatOnSave()
        {
            EditorApplication.projectChanged += OnProjectChanged;
        }
        
        static void OnProjectChanged()
        {
            // Auto-format is handled by IDE integration
        }
        
        static string[] OnWillSaveAssets(string[] paths)
        {
            foreach (string path in paths)
            {
                if (path.EndsWith(".cs"))
                {
                    FormatFile(path);
                }
            }
            
            return paths;
        }
        
        static void FormatFile(string path)
        {
            // Basic formatting fixes
            var content = File.ReadAllText(path);
            
            // Ensure file ends with newline
            if (!content.EndsWith("\n"))
            {
                content += "\n";
            }
            
            // Remove trailing whitespace
            var lines = content.Split('\n');
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = lines[i].TrimEnd();
            }
            
            content = string.Join("\n", lines);
            File.WriteAllText(path, content);
        }
    }
}