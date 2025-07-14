using NUnit.Framework;
using UnityEngine;
using SpaceColonyRPG.Colony;
using System.Collections.Generic;

namespace SpaceColonyRPG.Tests.EditMode.Colony
{
    public class ResourceManagerTests
    {
        private ResourceManager resourceManager;
        private GameObject testObject;

        [SetUp]
        public void Setup()
        {
            testObject = new GameObject("TestResourceManager");
            resourceManager = testObject.AddComponent<ResourceManager>();

            // Initialize resources for testing
            resourceManager.resources = new List<ResourceManager.Resource>
            {
                new ResourceManager.Resource
                {
                    type = ResourceType.Metal,
                    displayName = "Metal",
                    currentAmount = 100,
                    maxCapacity = 500
                },
                new ResourceManager.Resource
                {
                    type = ResourceType.Energy,
                    displayName = "Energy",
                    currentAmount = 0,
                    maxCapacity = int.MaxValue
                },
                new ResourceManager.Resource
                {
                    type = ResourceType.Credits,
                    displayName = "Credits",
                    currentAmount = 50,
                    maxCapacity = int.MaxValue
                }
            };
        }

        [TearDown]
        public void TearDown()
        {
            Object.DestroyImmediate(testObject);
        }

        [Test]
        public void ModifyResource_AddResource_IncreasesAmount()
        {
            // Arrange
            int initialAmount = resourceManager.GetResourceAmount(ResourceType.Metal);

            // Act
            resourceManager.ModifyResource(ResourceType.Metal, 50);

            // Assert
            Assert.AreEqual(initialAmount + 50, resourceManager.GetResourceAmount(ResourceType.Metal));
        }

        [Test]
        public void ModifyResource_SubtractResource_DecreasesAmount()
        {
            // Arrange
            int initialAmount = resourceManager.GetResourceAmount(ResourceType.Metal);

            // Act
            resourceManager.ModifyResource(ResourceType.Metal, -30);

            // Assert
            Assert.AreEqual(initialAmount - 30, resourceManager.GetResourceAmount(ResourceType.Metal));
        }

        [Test]
        public void ModifyResource_BelowZero_ClampsToZero()
        {
            // Arrange
            resourceManager.GetResource(ResourceType.Metal).currentAmount = 10;

            // Act
            resourceManager.ModifyResource(ResourceType.Metal, -50);

            // Assert
            Assert.AreEqual(0, resourceManager.GetResourceAmount(ResourceType.Metal));
        }

        [Test]
        public void ModifyResource_AboveCapacity_ClampsToCapacity()
        {
            // Arrange
            var metalResource = resourceManager.GetResource(ResourceType.Metal);
            metalResource.currentAmount = 490;
            metalResource.maxCapacity = 500;

            // Act
            resourceManager.ModifyResource(ResourceType.Metal, 50);

            // Assert
            Assert.AreEqual(500, resourceManager.GetResourceAmount(ResourceType.Metal));
        }

        [Test]
        public void CanAfford_SingleResource_Sufficient_ReturnsTrue()
        {
            // Arrange
            resourceManager.GetResource(ResourceType.Metal).currentAmount = 100;

            // Act
            bool canAfford = resourceManager.CanAfford(ResourceType.Metal, 50);

            // Assert
            Assert.IsTrue(canAfford);
        }

        [Test]
        public void CanAfford_SingleResource_Insufficient_ReturnsFalse()
        {
            // Arrange
            resourceManager.GetResource(ResourceType.Metal).currentAmount = 30;

            // Act
            bool canAfford = resourceManager.CanAfford(ResourceType.Metal, 50);

            // Assert
            Assert.IsFalse(canAfford);
        }

        [Test]
        public void CanAfford_MultipleResources_AllSufficient_ReturnsTrue()
        {
            // Arrange
            var costs = new Dictionary<ResourceType, int>
            {
                { ResourceType.Metal, 50 },
                { ResourceType.Credits, 30 }
            };

            // Act
            bool canAfford = resourceManager.CanAfford(costs);

            // Assert
            Assert.IsTrue(canAfford);
        }

        [Test]
        public void CanAfford_MultipleResources_OneInsufficient_ReturnsFalse()
        {
            // Arrange
            var costs = new Dictionary<ResourceType, int>
            {
                { ResourceType.Metal, 50 },
                { ResourceType.Credits, 100 } // Only have 50
            };

            // Act
            bool canAfford = resourceManager.CanAfford(costs);

            // Assert
            Assert.IsFalse(canAfford);
        }

        [Test]
        public void SpendResources_ValidCosts_DeductsResources()
        {
            // Arrange
            var costs = new Dictionary<ResourceType, int>
            {
                { ResourceType.Metal, 30 },
                { ResourceType.Credits, 20 }
            };
            int initialMetal = resourceManager.GetResourceAmount(ResourceType.Metal);
            int initialCredits = resourceManager.GetResourceAmount(ResourceType.Credits);

            // Act
            resourceManager.SpendResources(costs);

            // Assert
            Assert.AreEqual(initialMetal - 30, resourceManager.GetResourceAmount(ResourceType.Metal));
            Assert.AreEqual(initialCredits - 20, resourceManager.GetResourceAmount(ResourceType.Credits));
        }

        [Test]
        public void IncreaseCapacity_IncreasesMaxCapacity()
        {
            // Arrange
            var resource = resourceManager.GetResource(ResourceType.Metal);
            int initialCapacity = resource.maxCapacity;

            // Act
            resourceManager.IncreaseCapacity(ResourceType.Metal, 100);

            // Assert
            Assert.AreEqual(initialCapacity + 100, resource.maxCapacity);
        }

        [Test]
        public void GetResource_ValidType_ReturnsResource()
        {
            // Act
            var resource = resourceManager.GetResource(ResourceType.Metal);

            // Assert
            Assert.IsNotNull(resource);
            Assert.AreEqual(ResourceType.Metal, resource.type);
        }

        [Test]
        public void GetResource_InvalidType_ReturnsNull()
        {
            // Arrange - remove all resources
            resourceManager.resources.Clear();

            // Act
            var resource = resourceManager.GetResource(ResourceType.Metal);

            // Assert
            Assert.IsNull(resource);
        }

        [TestCase(ResourceType.Metal, 100, 50, true)]
        [TestCase(ResourceType.Energy, 30, 50, false)]
        [TestCase(ResourceType.Credits, 50, 50, true)]
        public void CanAfford_VariousScenarios_ReturnsExpected(
            ResourceType resourceType, int available, int required, bool expected)
        {
            // Arrange
            var resource = resourceManager.GetResource(resourceType);
            if (resource != null)
                resource.currentAmount = available;

            // Act & Assert
            Assert.AreEqual(expected, resourceManager.CanAfford(resourceType, required));
        }

        [Test]
        public void ModifyResource_TriggersEvent()
        {
            // Arrange
            bool eventTriggered = false;
            ResourceType triggeredType = ResourceType.Metal;
            int triggeredAmount = 0;

            System.Action<ResourceType, int> handler = (type, amount) =>
            {
                eventTriggered = true;
                triggeredType = type;
                triggeredAmount = amount;
            };

            ResourceManager.OnResourceChanged += handler;

            // Act
            resourceManager.ModifyResource(ResourceType.Credits, 25);

            // Assert
            Assert.IsTrue(eventTriggered);
            Assert.AreEqual(ResourceType.Credits, triggeredType);
            Assert.AreEqual(75, triggeredAmount); // 50 + 25

            // Cleanup
            ResourceManager.OnResourceChanged -= handler;
        }
    }
}
