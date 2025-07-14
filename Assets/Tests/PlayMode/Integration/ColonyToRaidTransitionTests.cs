using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using SpaceColonyRPG.Colony;

namespace SpaceColonyRPG.Tests.PlayMode.Integration
{
    public class ColonyToRaidTransitionTests
    {
        private GameObject colonyManagerObject;
        private ColonyManager colonyManager;

        [SetUp]
        public void Setup()
        {
            // Create test scene objects
            colonyManagerObject = new GameObject("TestColonyManager");
            colonyManager = colonyManagerObject.AddComponent<ColonyManager>();

            // Create other required managers
            CreateTestManagers();
        }

        [TearDown]
        public void TearDown()
        {
            Object.DestroyImmediate(colonyManagerObject);
            CleanupTestManagers();
        }

        [UnityTest]
        public IEnumerator PrepareForRaid_SavesColonyData()
        {
            // Arrange
            colonyManager.colonyLevel = 3;

            // Act
            colonyManager.PrepareForRaid();
            yield return new WaitForSeconds(0.1f);

            // Assert
            Assert.AreEqual(3, PlayerPrefs.GetInt("ColonyLevel"));
        }

        [UnityTest]
        public IEnumerator PrepareForRaid_CalculatesRaidBonuses()
        {
            // Arrange
            // Would need to set up buildings with bonuses

            // Act
            colonyManager.PrepareForRaid();
            yield return new WaitForSeconds(0.1f);

            // Assert
            Assert.IsTrue(PlayerPrefs.HasKey("RaidDamageBonus"));
            Assert.IsTrue(PlayerPrefs.HasKey("RaidShieldBonus"));
            Assert.IsTrue(PlayerPrefs.HasKey("RaidHealthRegenBonus"));
        }

        [UnityTest]
        public IEnumerator ReturnFromRaid_AddsCredits()
        {
            // Arrange
            var resourceManager = CreateResourceManager();
            int initialCredits = resourceManager.GetResourceAmount(ResourceType.Credits);

            // Act
            colonyManager.ReturnFromRaid(100);
            yield return null;

            // Assert
            Assert.AreEqual(initialCredits + 100, resourceManager.GetResourceAmount(ResourceType.Credits));

            // Cleanup
            Object.DestroyImmediate(resourceManager.gameObject);
        }

        [UnityTest]
        public IEnumerator ColonyLevelUp_TriggersWhenCreditsReachThreshold()
        {
            // Arrange
            var resourceManager = CreateResourceManager();
            colonyManager.colonyLevel = 1;
            resourceManager.GetResource(ResourceType.Credits).currentAmount = 50;

            // Act
            colonyManager.ReturnFromRaid(100); // Total: 150, threshold for level 2 is 100
            yield return new WaitForSeconds(0.1f);

            // Assert
            Assert.AreEqual(2, colonyManager.colonyLevel);

            // Cleanup
            Object.DestroyImmediate(resourceManager.gameObject);
        }

        private void CreateTestManagers()
        {
            // Create minimal manager setup for testing
            if (GridSystem.Instance == null)
            {
                var gridObject = new GameObject("TestGridSystem");
                var gridSystem = gridObject.AddComponent<GridSystem>();
                var instanceProperty = typeof(GridSystem).GetProperty("Instance");
                instanceProperty.SetValue(null, gridSystem);
            }
        }

        private void CleanupTestManagers()
        {
            // Clean up singleton instances
            var gridInstance = typeof(GridSystem).GetProperty("Instance");
            if (gridInstance != null)
            {
                var grid = gridInstance.GetValue(null) as GridSystem;
                if (grid != null)
                {
                    Object.DestroyImmediate(grid.gameObject);
                    gridInstance.SetValue(null, null);
                }
            }

            var resourceInstance = typeof(ResourceManager).GetProperty("Instance");
            if (resourceInstance != null)
            {
                var resource = resourceInstance.GetValue(null) as ResourceManager;
                if (resource != null)
                {
                    Object.DestroyImmediate(resource.gameObject);
                    resourceInstance.SetValue(null, null);
                }
            }
        }

        private ResourceManager CreateResourceManager()
        {
            var resourceObject = new GameObject("TestResourceManager");
            var resourceManager = resourceObject.AddComponent<ResourceManager>();

            // Initialize with test data
            resourceManager.resources = new System.Collections.Generic.List<ResourceManager.Resource>
            {
                new ResourceManager.Resource
                {
                    type = ResourceType.Credits,
                    displayName = "Credits",
                    currentAmount = 0,
                    maxCapacity = int.MaxValue
                }
            };

            // Set as singleton instance
            var instanceProperty = typeof(ResourceManager).GetProperty("Instance");
            instanceProperty.SetValue(null, resourceManager);

            return resourceManager;
        }
    }
}
