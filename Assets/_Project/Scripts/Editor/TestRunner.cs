using UnityEngine;
using UnityEditor;
using UnityEditor.TestTools.TestRunner.Api;
using System;
using System.Linq;

namespace SpaceColonyRPG.Editor
{
    public class TestRunner
    {
        private static bool testsPass = false;
        private static bool testsComplete = false;

        [MenuItem("Tools/Code Quality/Run All Tests")]
        public static void RunAllTests()
        {
            var testRunnerApi = ScriptableObject.CreateInstance<TestRunnerApi>();
            testRunnerApi.RegisterCallbacks(new TestCallbacks());

            var filter = new Filter()
            {
                testMode = TestMode.EditMode | TestMode.PlayMode
            };

            testRunnerApi.Execute(new ExecutionSettings(filter));
        }

        public static bool RunTestsCommandLine()
        {
            testsPass = false;
            testsComplete = false;

            RunAllTests();

            // Wait for tests to complete (with timeout)
            var startTime = DateTime.Now;
            while (!testsComplete && (DateTime.Now - startTime).TotalSeconds < 300)
            {
                System.Threading.Thread.Sleep(100);
            }

            return testsPass;
        }

        private class TestCallbacks : ICallbacks
        {
            public void RunStarted(ITestAdaptor testsToRun)
            {
                UnityEngine.Debug.Log($"Starting test run with {CountTests(testsToRun)} tests");
            }

            public void RunFinished(ITestResultAdaptor result)
            {
                testsPass = result.FailCount == 0;
                testsComplete = true;

                UnityEngine.Debug.Log($"Tests completed. Passed: {result.PassCount}, Failed: {result.FailCount}");

                if (result.FailCount > 0)
                {
                    LogFailedTests(result);
                }
            }

            public void TestStarted(ITestAdaptor test)
            {
                UnityEngine.Debug.Log($"Running: {test.FullName}");
            }

            public void TestFinished(ITestResultAdaptor result)
            {
                if (!result.HasChildren && result.TestStatus == TestStatus.Failed)
                {
                    UnityEngine.Debug.LogError($"FAILED: {result.FullName}\n{result.Message}");
                }
            }

            private int CountTests(ITestAdaptor test)
            {
                if (!test.HasChildren)
                    return 1;

                return test.Children.Sum(child => CountTests(child));
            }

            private void LogFailedTests(ITestResultAdaptor result)
            {
                if (!result.HasChildren)
                {
                    if (result.TestStatus == TestStatus.Failed)
                    {
                        UnityEngine.Debug.LogError($"Failed: {result.FullName}");
                    }
                }
                else
                {
                    foreach (var child in result.Children)
                    {
                        LogFailedTests(child);
                    }
                }
            }
        }
    }
}
