using UnityEditor;
using UnityEngine;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace SpaceColonyRPG.Editor
{
    public class CodeLinter : EditorWindow
    {
        private Vector2 scrollPosition;
        private string lintOutput = "";
        private bool isLinting = false;
        
        [MenuItem("Tools/Code Quality/Code Linter")]
        public static void ShowWindow()
        {
            GetWindow<CodeLinter>("Code Linter");
        }
        
        void OnGUI()
        {
            EditorGUILayout.Space();
            
            using (new EditorGUI.DisabledScope(isLinting))
            {
                if (GUILayout.Button("Run Lint Check", GUILayout.Height(30)))
                {
                    RunLintCheck();
                }
            }
            
            if (GUILayout.Button("Auto-Fix Issues", GUILayout.Height(30)))
            {
                AutoFixIssues();
            }
            
            EditorGUILayout.Space();
            EditorGUILayout.LabelField("Lint Results:", EditorStyles.boldLabel);
            
            scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition);
            EditorGUILayout.TextArea(lintOutput, GUILayout.ExpandHeight(true));
            EditorGUILayout.EndScrollView();
        }
        
        void RunLintCheck()
        {
            isLinting = true;
            lintOutput = "Running lint check...\n";
            
            var projectPath = Path.GetDirectoryName(Application.dataPath);
            var scriptFiles = Directory.GetFiles(
                Path.Combine(projectPath, "Assets"), 
                "*.cs", 
                SearchOption.AllDirectories
            ).Where(f => !f.Contains("TextMesh Pro") && !f.Contains("Mirror") && !f.Contains("Packages"));
            
            var issues = new StringBuilder();
            int totalIssues = 0;
            
            foreach (var file in scriptFiles)
            {
                var fileIssues = AnalyzeFile(file);
                if (fileIssues.Length > 0)
                {
                    issues.AppendLine($"\n{Path.GetRelativePath(projectPath, file)}:");
                    issues.AppendLine(fileIssues);
                    totalIssues++;
                }
            }
            
            if (totalIssues == 0)
            {
                lintOutput = "✅ No linting issues found!";
            }
            else
            {
                lintOutput = $"❌ Found issues in {totalIssues} files:\n{issues}";
            }
            
            isLinting = false;
            Repaint();
        }
        
        string AnalyzeFile(string filePath)
        {
            var issues = new StringBuilder();
            var lines = File.ReadAllLines(filePath);
            
            for (int i = 0; i < lines.Length; i++)
            {
                var line = lines[i];
                var lineNumber = i + 1;
                
                // Check for common issues
                if (line.TrimEnd() != line)
                {
                    issues.AppendLine($"  Line {lineNumber}: Trailing whitespace");
                }
                
                if (line.Contains("\t"))
                {
                    issues.AppendLine($"  Line {lineNumber}: Tab character found (use spaces)");
                }
                
                if (line.Length > 120)
                {
                    issues.AppendLine($"  Line {lineNumber}: Line too long ({line.Length} > 120 characters)");
                }
                
                // Unity specific checks
                if (line.Contains("FindObjectOfType") && !line.Contains("// PERF:"))
                {
                    issues.AppendLine($"  Line {lineNumber}: FindObjectOfType is expensive (add // PERF: comment if intentional)");
                }
                
                if (line.Contains("GameObject.Find") && !line.Contains("// PERF:"))
                {
                    issues.AppendLine($"  Line {lineNumber}: GameObject.Find is expensive (add // PERF: comment if intentional)");
                }
                
                // Check for missing braces
                if ((line.TrimStart().StartsWith("if ") || line.TrimStart().StartsWith("else") || 
                     line.TrimStart().StartsWith("for ") || line.TrimStart().StartsWith("while ")) &&
                    !line.Contains("{") && i + 1 < lines.Length && !lines[i + 1].TrimStart().StartsWith("{"))
                {
                    issues.AppendLine($"  Line {lineNumber}: Missing braces for control statement");
                }
                
                // Check for public fields that should be private with SerializeField
                if (line.Contains("public ") && !line.Contains("static") && !line.Contains("const") && 
                    !line.Contains("class") && !line.Contains("interface") && !line.Contains("enum") &&
                    !line.Contains("(") && line.Contains(";"))
                {
                    issues.AppendLine($"  Line {lineNumber}: Consider using [SerializeField] private instead of public field");
                }
            }
            
            return issues.ToString();
        }
        
        void AutoFixIssues()
        {
            EditorUtility.DisplayProgressBar("Auto-fixing code issues", "Processing files...", 0);
            
            var projectPath = Path.GetDirectoryName(Application.dataPath);
            var scriptFiles = Directory.GetFiles(
                Path.Combine(projectPath, "Assets"), 
                "*.cs", 
                SearchOption.AllDirectories
            ).Where(f => !f.Contains("TextMesh Pro") && !f.Contains("Mirror") && !f.Contains("Packages"));
            
            int current = 0;
            int total = scriptFiles.Count();
            
            foreach (var file in scriptFiles)
            {
                EditorUtility.DisplayProgressBar(
                    "Auto-fixing code issues", 
                    Path.GetFileName(file), 
                    (float)current / total
                );
                
                FixFile(file);
                current++;
            }
            
            EditorUtility.ClearProgressBar();
            AssetDatabase.Refresh();
            RunLintCheck();
        }
        
        void FixFile(string filePath)
        {
            var lines = File.ReadAllLines(filePath);
            bool modified = false;
            
            for (int i = 0; i < lines.Length; i++)
            {
                var original = lines[i];
                var fixedLine = lines[i].TrimEnd().Replace("\t", "    ");
                
                if (original != fixedLine)
                {
                    lines[i] = fixedLine;
                    modified = true;
                }
            }
            
            // Ensure file ends with newline
            if (lines.Length > 0 && !string.IsNullOrEmpty(lines[lines.Length - 1]))
            {
                var newLines = lines.ToList();
                newLines.Add("");
                lines = newLines.ToArray();
                modified = true;
            }
            
            if (modified)
            {
                File.WriteAllLines(filePath, lines);
            }
        }
    }
}