using UnityEngine;

namespace SpaceColonyRPG.Colony
{
    public class GridSystem : MonoBehaviour
    {
        public static GridSystem Instance { get; private set; }
        
        [Header("Grid Configuration")]
        public int gridWidth = 50;
        public int gridHeight = 50;
        public float cellSize = 2f;
        
        [Header("Visuals")]
        public bool showGrid = true;
        public Color gridColor = new Color(1, 1, 1, 0.1f);
        public GameObject gridLinePrefab; // Simple quad stretched thin
        
        private GridCell[,] grid;
        private GameObject gridVisualContainer;
        
        public struct GridCell
        {
            public bool isOccupied;
            public GameObject occupyingBuilding;
            public Vector2Int position;
        }
        
        void Awake()
        {
            Instance = this;
            InitializeGrid();
            if (showGrid) CreateGridVisuals();
        }
        
        void InitializeGrid()
        {
            grid = new GridCell[gridWidth, gridHeight];
            
            for (int x = 0; x < gridWidth; x++)
            {
                for (int z = 0; z < gridHeight; z++)
                {
                    grid[x, z] = new GridCell 
                    { 
                        position = new Vector2Int(x, z),
                        isOccupied = false,
                        occupyingBuilding = null
                    };
                }
            }
        }
        
        void CreateGridVisuals()
        {
            gridVisualContainer = new GameObject("GridVisuals");
            gridVisualContainer.transform.parent = transform;
            
            // For hackathon - simple visual representation
            // In production, would create actual grid lines
        }
        
        public Vector3 GridToWorldPosition(Vector2Int gridPos)
        {
            float x = (gridPos.x - gridWidth / 2f) * cellSize;
            float z = (gridPos.y - gridHeight / 2f) * cellSize;
            return new Vector3(x, 0, z);
        }
        
        public Vector2Int WorldToGridPosition(Vector3 worldPos)
        {
            int x = Mathf.RoundToInt(worldPos.x / cellSize + gridWidth / 2f);
            int z = Mathf.RoundToInt(worldPos.z / cellSize + gridHeight / 2f);
            return new Vector2Int(x, z);
        }
        
        public bool CanPlaceBuilding(Vector2Int gridPos, Vector2Int size)
        {
            // Check bounds
            if (gridPos.x < 0 || gridPos.y < 0 || 
                gridPos.x + size.x > gridWidth || 
                gridPos.y + size.y > gridHeight)
                return false;
                
            // Check occupancy
            for (int x = 0; x < size.x; x++)
            {
                for (int z = 0; z < size.y; z++)
                {
                    if (grid[gridPos.x + x, gridPos.y + z].isOccupied)
                        return false;
                }
            }
            
            return true;
        }
        
        public void OccupyCells(Vector2Int gridPos, Vector2Int size, GameObject building)
        {
            for (int x = 0; x < size.x; x++)
            {
                for (int z = 0; z < size.y; z++)
                {
                    grid[gridPos.x + x, gridPos.y + z].isOccupied = true;
                    grid[gridPos.x + x, gridPos.y + z].occupyingBuilding = building;
                }
            }
        }
        
        public void FreeCells(Vector2Int gridPos, Vector2Int size)
        {
            for (int x = 0; x < size.x; x++)
            {
                for (int z = 0; z < size.y; z++)
                {
                    grid[gridPos.x + x, gridPos.y + z].isOccupied = false;
                    grid[gridPos.x + x, gridPos.y + z].occupyingBuilding = null;
                }
            }
        }
        
        void OnDrawGizmos()
        {
            if (!showGrid || grid == null) return;
            
            Gizmos.color = gridColor;
            
            // Draw grid bounds
            Vector3 bottomLeft = GridToWorldPosition(new Vector2Int(0, 0));
            Vector3 bottomRight = GridToWorldPosition(new Vector2Int(gridWidth, 0));
            Vector3 topLeft = GridToWorldPosition(new Vector2Int(0, gridHeight));
            Vector3 topRight = GridToWorldPosition(new Vector2Int(gridWidth, gridHeight));
            
            Gizmos.DrawLine(bottomLeft, bottomRight);
            Gizmos.DrawLine(bottomRight, topRight);
            Gizmos.DrawLine(topRight, topLeft);
            Gizmos.DrawLine(topLeft, bottomLeft);
        }
    }
}