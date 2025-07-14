using NUnit.Framework;
using UnityEngine;
using SpaceColonyRPG.Colony;

namespace SpaceColonyRPG.Tests.EditMode.Colony
{
    public class GridSystemTests
    {
        private GridSystem gridSystem;
        private GameObject testObject;

        [SetUp]
        public void Setup()
        {
            testObject = new GameObject("TestGridSystem");
            gridSystem = testObject.AddComponent<GridSystem>();

            // Set up test grid configuration
            gridSystem.gridWidth = 10;
            gridSystem.gridHeight = 10;
            gridSystem.cellSize = 2f;

            // Manually initialize the grid since Awake won't be called in tests
            var gridField = typeof(GridSystem).GetField("grid",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            var grid = new GridSystem.GridCell[gridSystem.gridWidth, gridSystem.gridHeight];

            for (int x = 0; x < gridSystem.gridWidth; x++)
            {
                for (int z = 0; z < gridSystem.gridHeight; z++)
                {
                    grid[x, z] = new GridSystem.GridCell
                    {
                        position = new Vector2Int(x, z),
                        isOccupied = false,
                        occupyingBuilding = null
                    };
                }
            }

            gridField.SetValue(gridSystem, grid);
        }

        [TearDown]
        public void TearDown()
        {
            Object.DestroyImmediate(testObject);
        }

        [Test]
        public void GridToWorldPosition_CenterCell_ReturnsCorrectPosition()
        {
            // Arrange
            Vector2Int gridPos = new Vector2Int(5, 5);

            // Act
            Vector3 worldPos = gridSystem.GridToWorldPosition(gridPos);

            // Assert
            Assert.AreEqual(0f, worldPos.x, 0.01f);
            Assert.AreEqual(0f, worldPos.y, 0.01f);
            Assert.AreEqual(0f, worldPos.z, 0.01f);
        }

        [Test]
        public void WorldToGridPosition_OriginPosition_ReturnsCenterGrid()
        {
            // Arrange
            Vector3 worldPos = Vector3.zero;

            // Act
            Vector2Int gridPos = gridSystem.WorldToGridPosition(worldPos);

            // Assert
            Assert.AreEqual(5, gridPos.x);
            Assert.AreEqual(5, gridPos.y);
        }

        [Test]
        public void GridToWorldPosition_CornerCell_ReturnsCorrectPosition()
        {
            // Arrange
            Vector2Int gridPos = new Vector2Int(0, 0);

            // Act
            Vector3 worldPos = gridSystem.GridToWorldPosition(gridPos);

            // Assert
            Assert.AreEqual(-10f, worldPos.x, 0.01f); // (0 - 5) * 2
            Assert.AreEqual(0f, worldPos.y, 0.01f);
            Assert.AreEqual(-10f, worldPos.z, 0.01f); // (0 - 5) * 2
        }

        [Test]
        public void CanPlaceBuilding_EmptyCell_ReturnsTrue()
        {
            // Arrange
            Vector2Int position = new Vector2Int(2, 2);
            Vector2Int size = new Vector2Int(1, 1);

            // Act
            bool canPlace = gridSystem.CanPlaceBuilding(position, size);

            // Assert
            Assert.IsTrue(canPlace);
        }

        [Test]
        public void CanPlaceBuilding_OutOfBounds_ReturnsFalse()
        {
            // Arrange
            Vector2Int position = new Vector2Int(9, 9);
            Vector2Int size = new Vector2Int(2, 2); // Would go out of bounds

            // Act
            bool canPlace = gridSystem.CanPlaceBuilding(position, size);

            // Assert
            Assert.IsFalse(canPlace);
        }

        [Test]
        public void CanPlaceBuilding_NegativePosition_ReturnsFalse()
        {
            // Arrange
            Vector2Int position = new Vector2Int(-1, 2);
            Vector2Int size = new Vector2Int(1, 1);

            // Act
            bool canPlace = gridSystem.CanPlaceBuilding(position, size);

            // Assert
            Assert.IsFalse(canPlace);
        }

        [Test]
        public void OccupyCells_SingleCell_MarksAsOccupied()
        {
            // Arrange
            Vector2Int position = new Vector2Int(3, 3);
            Vector2Int size = new Vector2Int(1, 1);
            GameObject building = new GameObject("TestBuilding");

            // Act
            gridSystem.OccupyCells(position, size, building);

            // Assert
            Assert.IsFalse(gridSystem.CanPlaceBuilding(position, size));

            // Cleanup
            Object.DestroyImmediate(building);
        }

        [Test]
        public void OccupyCells_MultipleCell_MarksAllAsOccupied()
        {
            // Arrange
            Vector2Int position = new Vector2Int(2, 2);
            Vector2Int size = new Vector2Int(2, 2);
            GameObject building = new GameObject("TestBuilding");

            // Act
            gridSystem.OccupyCells(position, size, building);

            // Assert
            Assert.IsFalse(gridSystem.CanPlaceBuilding(new Vector2Int(2, 2), new Vector2Int(1, 1)));
            Assert.IsFalse(gridSystem.CanPlaceBuilding(new Vector2Int(3, 2), new Vector2Int(1, 1)));
            Assert.IsFalse(gridSystem.CanPlaceBuilding(new Vector2Int(2, 3), new Vector2Int(1, 1)));
            Assert.IsFalse(gridSystem.CanPlaceBuilding(new Vector2Int(3, 3), new Vector2Int(1, 1)));

            // Cleanup
            Object.DestroyImmediate(building);
        }

        [Test]
        public void FreeCells_OccupiedCells_MarksAsFree()
        {
            // Arrange
            Vector2Int position = new Vector2Int(4, 4);
            Vector2Int size = new Vector2Int(1, 1);
            GameObject building = new GameObject("TestBuilding");
            gridSystem.OccupyCells(position, size, building);

            // Act
            gridSystem.FreeCells(position, size);

            // Assert
            Assert.IsTrue(gridSystem.CanPlaceBuilding(position, size));

            // Cleanup
            Object.DestroyImmediate(building);
        }

        [Test]
        public void CanPlaceBuilding_PartialOverlap_ReturnsFalse()
        {
            // Arrange
            Vector2Int occupiedPos = new Vector2Int(3, 3);
            Vector2Int occupiedSize = new Vector2Int(2, 2);
            GameObject existingBuilding = new GameObject("ExistingBuilding");
            gridSystem.OccupyCells(occupiedPos, occupiedSize, existingBuilding);

            Vector2Int newPos = new Vector2Int(4, 4);
            Vector2Int newSize = new Vector2Int(2, 2);

            // Act
            bool canPlace = gridSystem.CanPlaceBuilding(newPos, newSize);

            // Assert
            Assert.IsFalse(canPlace);

            // Cleanup
            Object.DestroyImmediate(existingBuilding);
        }

        [Test]
        public void WorldToGridPosition_SnapsToNearestCell()
        {
            // Arrange
            Vector3 worldPos = new Vector3(2.7f, 0, -3.2f);

            // Act
            Vector2Int gridPos = gridSystem.WorldToGridPosition(worldPos);
            Vector3 snappedWorldPos = gridSystem.GridToWorldPosition(gridPos);

            // Assert
            Assert.AreEqual(2f, snappedWorldPos.x, 0.01f);
            Assert.AreEqual(-4f, snappedWorldPos.z, 0.01f);
        }

        [TestCase(0, 0, 1, 1, true)]  // Top-left corner
        [TestCase(9, 9, 1, 1, true)]  // Bottom-right corner
        [TestCase(5, 5, 3, 3, true)]  // Center large building
        [TestCase(8, 8, 3, 3, false)] // Out of bounds
        public void CanPlaceBuilding_BoundaryTests(int x, int z, int width, int height, bool expected)
        {
            // Arrange
            Vector2Int position = new Vector2Int(x, z);
            Vector2Int size = new Vector2Int(width, height);

            // Act
            bool canPlace = gridSystem.CanPlaceBuilding(position, size);

            // Assert
            Assert.AreEqual(expected, canPlace);
        }

        [Test]
        public void GridToWorldAndBack_RoundTrip_PreservesPosition()
        {
            // Arrange
            Vector2Int originalGridPos = new Vector2Int(7, 3);

            // Act
            Vector3 worldPos = gridSystem.GridToWorldPosition(originalGridPos);
            Vector2Int resultGridPos = gridSystem.WorldToGridPosition(worldPos);

            // Assert
            Assert.AreEqual(originalGridPos, resultGridPos);
        }
    }
}
