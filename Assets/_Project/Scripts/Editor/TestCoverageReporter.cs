using UnityEditor;
using UnityEngine;
using System.IO;

namespace SpaceColonyRPG.Editor
{
    public class TestCoverageReporter
    {
        [MenuItem("Tools/Code Quality/Generate Test Coverage Report")]
        public static void GenerateCoverageReport()
        {
            // Note: Unity's Code Coverage package needs to be installed for this to work
            // Package: com.unity.testtools.codecoverage
            
            #if UNITY_2019_3_OR_NEWER && CODE_COVERAGE
            Coverage.StartRecording();
            
            // Run all tests
            TestRunner.RunAllTests();
            
            Coverage.StopRecording();
            
            // Generate HTML report
            var reportPath = Path.Combine(Application.dataPath, "../TestResults/CoverageReport");
            Coverage.GenerateHTMLReport(reportPath);
            
            EditorUtility.RevealInFinder(reportPath);
            #else
            EditorUtility.DisplayDialog("Code Coverage", 
                "Code Coverage requires Unity 2019.3+ and the Code Coverage package.\n\n" +
                "Install via Package Manager:\ncom.unity.testtools.codecoverage", 
                "OK");
            #endif
        }
        
        [MenuItem("Tools/Code Quality/View Test Results")]
        public static void ViewTestResults()
        {
            var resultsPath = Path.Combine(Application.dataPath, "../TestResults");
            
            if (!Directory.Exists(resultsPath))
            {
                Directory.CreateDirectory(resultsPath);
            }
            
            EditorUtility.RevealInFinder(resultsPath);
        }
    }
}