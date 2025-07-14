using NUnit.Framework;
using UnityEngine;
using SpaceColonyRPG.Colony;
using System.Collections.Generic;

namespace SpaceColonyRPG.Tests.EditMode.Colony
{
    public class BuildingSystemTests
    {
        private BuildingSystem buildingSystem;
        private GameObject testObject;
        private GameObject gridSystemObject;
        private GridSystem gridSystem;
        private ResourceManager resourceManager;
        private ColonyManager colonyManager;
        private BuildingData testBuildingData;

        [SetUp]
        public void Setup()
        {
            // Create BuildingSystem
            testObject = new GameObject("TestBuildingSystem");
            buildingSystem = testObject.AddComponent<BuildingSystem>();
            
            // Create and setup GridSystem
            gridSystemObject = new GameObject("TestGridSystem");
            gridSystem = gridSystemObject.AddComponent<GridSystem>();
            gridSystem.gridWidth = 10;
            gridSystem.gridHeight = 10;
            gridSystem.cellSize = 2f;
            
            // Create ResourceManager
            var resourceManagerObject = new GameObject("TestResourceManager");
            resourceManager = resourceManagerObject.AddComponent<ResourceManager>();
            SetupResourceManager();
            
            // Create ColonyManager
            var colonyManagerObject = new GameObject("TestColonyManager");
            colonyManager = colonyManagerObject.AddComponent<ColonyManager>();
            colonyManager.colonyLevel = 1;
            
            // Create test BuildingData
            testBuildingData = ScriptableObject.CreateInstance<BuildingData>();
            testBuildingData.buildingName = "Test Building";
            testBuildingData.description = "A test building";
            testBuildingData.category = BuildingCategory.Infrastructure;
            testBuildingData.gridSize = new Vector2Int(2, 2);
            testBuildingData.metalCost = 50;
            testBuildingData.energyCost = 10;
            testBuildingData.requiredColonyLevel = 1;
            testBuildingData.prefab = new GameObject("BuildingPrefab");
            
            // Setup BuildingSystem
            buildingSystem.availableBuildings = new List<BuildingData> { testBuildingData };
            buildingSystem.placementCheckMask = LayerMask.GetMask("Ground");
            
            // Create placement materials
            buildingSystem.validPlacementMaterial = new Material(Shader.Find("Standard"));
            buildingSystem.invalidPlacementMaterial = new Material(Shader.Find("Standard"));
            
            // Force singleton instances
            var instanceProperty = typeof(GridSystem).GetProperty("Instance");
            instanceProperty.SetValue(null, gridSystem);
            
            var resourceInstanceProperty = typeof(ResourceManager).GetProperty("Instance");
            resourceInstanceProperty.SetValue(null, resourceManager);
            
            var colonyInstanceProperty = typeof(ColonyManager).GetProperty("Instance");
            colonyInstanceProperty.SetValue(null, colonyManager);
            
            var buildingInstanceProperty = typeof(BuildingSystem).GetProperty("Instance");
            buildingInstanceProperty.SetValue(null, buildingSystem);
        }

        [TearDown]
        public void TearDown()
        {
            // Clean up singletons
            var instanceProperty = typeof(GridSystem).GetProperty("Instance");
            instanceProperty.SetValue(null, null);
            
            var resourceInstanceProperty = typeof(ResourceManager).GetProperty("Instance");
            resourceInstanceProperty.SetValue(null, null);
            
            var colonyInstanceProperty = typeof(ColonyManager).GetProperty("Instance");
            colonyInstanceProperty.SetValue(null, null);
            
            var buildingInstanceProperty = typeof(BuildingSystem).GetProperty("Instance");
            buildingInstanceProperty.SetValue(null, null);
            
            // Destroy objects
            Object.DestroyImmediate(testBuildingData.prefab);
            Object.DestroyImmediate(testBuildingData);
            Object.DestroyImmediate(buildingSystem.validPlacementMaterial);
            Object.DestroyImmediate(buildingSystem.invalidPlacementMaterial);
            Object.DestroyImmediate(testObject);
            Object.DestroyImmediate(gridSystemObject);
            Object.DestroyImmediate(resourceManager.gameObject);
            Object.DestroyImmediate(colonyManager.gameObject);
        }

        private void SetupResourceManager()
        {
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
                    currentAmount = 50,
                    maxCapacity = int.MaxValue
                }
            };
        }

        [Test]
        public void StartPlacement_ValidBuilding_CanAfford_StartsPlacement()
        {
            // Arrange
            var isPlacingField = typeof(BuildingSystem).GetField("isPlacing", 
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

            // Act
            buildingSystem.StartPlacement(testBuildingData);

            // Assert
            bool isPlacing = (bool)isPlacingField.GetValue(buildingSystem);
            Assert.IsTrue(isPlacing);
        }

        [Test]
        public void StartPlacement_InsufficientResources_DoesNotStartPlacement()
        {
            // Arrange
            resourceManager.GetResource(ResourceType.Metal).currentAmount = 10; // Not enough
            var isPlacingField = typeof(BuildingSystem).GetField("isPlacing", 
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

            // Act
            buildingSystem.StartPlacement(testBuildingData);

            // Assert
            bool isPlacing = (bool)isPlacingField.GetValue(buildingSystem);
            Assert.IsFalse(isPlacing);
        }

        [Test]
        public void StartPlacement_RequirementsNotMet_DoesNotStartPlacement()
        {
            // Arrange
            testBuildingData.requiredColonyLevel = 5; // Higher than current level
            var isPlacingField = typeof(BuildingSystem).GetField("isPlacing", 
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

            // Act
            buildingSystem.StartPlacement(testBuildingData);

            // Assert
            bool isPlacing = (bool)isPlacingField.GetValue(buildingSystem);
            Assert.IsFalse(isPlacing);
        }

        [Test]
        public void HasBuilding_BuildingExists_ReturnsTrue()
        {
            // Arrange
            var placedBuildingsField = typeof(BuildingSystem).GetField("placedBuildings", 
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            var placedBuildings = (List<Building>)placedBuildingsField.GetValue(buildingSystem);
            
            var buildingObject = new GameObject("TestBuilding");
            var building = buildingObject.AddComponent<Building>();
            building.buildingData = testBuildingData;
            placedBuildings.Add(building);

            // Act
            var hasBuilding = InvokePrivateMethod<bool>(buildingSystem, "HasBuilding", testBuildingData);

            // Assert
            Assert.IsTrue(hasBuilding);

            // Cleanup
            Object.DestroyImmediate(buildingObject);
        }

        [Test]
        public void GetBuildingsOfType_ReturnsCorrectBuildings()
        {
            // Arrange
            var placedBuildingsField = typeof(BuildingSystem).GetField("placedBuildings", 
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            var placedBuildings = (List<Building>)placedBuildingsField.GetValue(buildingSystem);
            
            var buildingObject1 = new GameObject("TestBuilding1");
            var building1 = buildingObject1.AddComponent<Building>();
            building1.buildingData = testBuildingData;
            placedBuildings.Add(building1);
            
            var buildingObject2 = new GameObject("TestBuilding2");
            var building2 = buildingObject2.AddComponent<Building>();
            building2.buildingData = testBuildingData;
            placedBuildings.Add(building2);

            // Act
            var buildings = buildingSystem.GetBuildingsOfType(testBuildingData);

            // Assert
            Assert.AreEqual(2, buildings.Count);
            Assert.Contains(building1, buildings);
            Assert.Contains(building2, buildings);

            // Cleanup
            Object.DestroyImmediate(buildingObject1);
            Object.DestroyImmediate(buildingObject2);
        }

        [Test]
        public void GetTotalEnergyProduction_CalculatesCorrectly()
        {
            // Arrange
            testBuildingData.resourceProduction = new BuildingData.ResourceProduction[]
            {
                new BuildingData.ResourceProduction 
                { 
                    resourceType = ResourceType.Energy, 
                    amountPerMinute = 10 
                }
            };
            
            var placedBuildingsField = typeof(BuildingSystem).GetField("placedBuildings", 
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            var placedBuildings = (List<Building>)placedBuildingsField.GetValue(buildingSystem);
            
            var buildingObject = new GameObject("TestBuilding");
            var building = buildingObject.AddComponent<Building>();
            building.buildingData = testBuildingData;
            building.isActive = true;
            placedBuildings.Add(building);

            // Act
            int totalProduction = buildingSystem.GetTotalEnergyProduction();

            // Assert
            Assert.AreEqual(10, totalProduction);

            // Cleanup
            Object.DestroyImmediate(buildingObject);
        }

        [Test]
        public void GetTotalEnergyConsumption_CalculatesCorrectly()
        {
            // Arrange
            testBuildingData.energyConsumption = 5;
            
            var placedBuildingsField = typeof(BuildingSystem).GetField("placedBuildings", 
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            var placedBuildings = (List<Building>)placedBuildingsField.GetValue(buildingSystem);
            
            var buildingObject1 = new GameObject("TestBuilding1");
            var building1 = buildingObject1.AddComponent<Building>();
            building1.buildingData = testBuildingData;
            building1.isActive = true;
            placedBuildings.Add(building1);
            
            var buildingObject2 = new GameObject("TestBuilding2");
            var building2 = buildingObject2.AddComponent<Building>();
            building2.buildingData = testBuildingData;
            building2.isActive = false; // Inactive building
            placedBuildings.Add(building2);

            // Act
            int totalConsumption = buildingSystem.GetTotalEnergyConsumption();

            // Assert
            Assert.AreEqual(5, totalConsumption); // Only active building counts

            // Cleanup
            Object.DestroyImmediate(buildingObject1);
            Object.DestroyImmediate(buildingObject2);
        }

        [Test]
        public void CheckBuildingRequirements_NoPrerequisites_ReturnsTrue()
        {
            // Arrange
            testBuildingData.prerequisiteBuildings = new BuildingData[0];
            testBuildingData.requiredColonyLevel = 1;

            // Act
            var meetsRequirements = InvokePrivateMethod<bool>(buildingSystem, "CheckBuildingRequirements", testBuildingData);

            // Assert
            Assert.IsTrue(meetsRequirements);
        }

        [Test]
        public void CheckBuildingRequirements_MissingPrerequisite_ReturnsFalse()
        {
            // Arrange
            var prerequisiteBuilding = ScriptableObject.CreateInstance<BuildingData>();
            prerequisiteBuilding.buildingName = "Prerequisite";
            testBuildingData.prerequisiteBuildings = new BuildingData[] { prerequisiteBuilding };

            // Act
            var meetsRequirements = InvokePrivateMethod<bool>(buildingSystem, "CheckBuildingRequirements", testBuildingData);

            // Assert
            Assert.IsFalse(meetsRequirements);

            // Cleanup
            Object.DestroyImmediate(prerequisiteBuilding);
        }

        // Helper method to invoke private methods
        private T InvokePrivateMethod<T>(object obj, string methodName, params object[] parameters)
        {
            var method = obj.GetType().GetMethod(methodName, 
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            return (T)method.Invoke(obj, parameters);
        }
    }
}