using UnityEngine;

namespace SpaceColonyRPG.Colony
{
    public class ColonyEnvironmentSetup : MonoBehaviour
    {
        [Header("Terrain Settings")]
        public Material alienGroundMaterial;
        public Texture2D heightmapTexture;
        public float terrainSize = 100f;
        public float maxHeight = 5f;
        
        [Header("Decoration Prefabs")]
        public GameObject[] rockPrefabs; // Use SimpleLowPolyNature rocks
        public GameObject[] alienTreePrefabs; // Recolored trees
        public GameObject[] crystalPrefabs; // Energy crystals
        public GameObject[] debrisPrefabs; // Space debris
        
        [Header("Spawn Settings")]
        public int minRocks = 30;
        public int maxRocks = 50;
        public int minTrees = 20;
        public int maxTrees = 40;
        public int minCrystals = 10;
        public int maxCrystals = 15;
        public int minDebris = 5;
        public int maxDebris = 10;
        
        void Start()
        {
            SetupTerrain();
            PlaceDecorations();
        }
        
        void SetupTerrain()
        {
            // Find existing terrain or create new one
            GameObject terrain = GameObject.Find("AlienTerrain");
            if (!terrain)
            {
                terrain = GameObject.CreatePrimitive(PrimitiveType.Plane);
                terrain.name = "AlienTerrain";
            }
            
            terrain.transform.localScale = new Vector3(terrainSize / 10f, 1, terrainSize / 10f);
            terrain.layer = LayerMask.NameToLayer("Ground");
            
            // Apply alien material
            if (alienGroundMaterial)
            {
                terrain.GetComponent<Renderer>().material = alienGroundMaterial;
            }
            
            // Add mesh collider if missing
            if (!terrain.GetComponent<MeshCollider>())
            {
                terrain.AddComponent<MeshCollider>();
            }
        }
        
        void PlaceDecorations()
        {
            // Create environment container
            GameObject envContainer = GameObject.Find("_Environment");
            if (!envContainer)
            {
                envContainer = new GameObject("_Environment");
            }
            
            // Place rocks
            PlaceObjectGroup(rockPrefabs, minRocks, maxRocks, "Rocks", envContainer.transform);
            
            // Place alien vegetation
            PlaceObjectGroup(alienTreePrefabs, minTrees, maxTrees, "Vegetation", envContainer.transform);
            
            // Place energy crystals
            PlaceObjectGroup(crystalPrefabs, minCrystals, maxCrystals, "Crystals", envContainer.transform);
            
            // Place debris
            PlaceObjectGroup(debrisPrefabs, minDebris, maxDebris, "Debris", envContainer.transform);
        }
        
        void PlaceObjectGroup(GameObject[] prefabs, int minCount, int maxCount, string groupName, Transform parent)
        {
            if (prefabs == null || prefabs.Length == 0) return;
            
            GameObject container = new GameObject(groupName);
            container.transform.SetParent(parent);
            
            int count = Random.Range(minCount, maxCount + 1);
            
            for (int i = 0; i < count; i++)
            {
                GameObject prefab = prefabs[Random.Range(0, prefabs.Length)];
                if (!prefab) continue;
                
                Vector3 position = GetRandomPosition();
                Quaternion rotation = Quaternion.Euler(0, Random.Range(0, 360), 0);
                
                GameObject obj = Instantiate(prefab, position, rotation, container.transform);
                
                // Random scale variation
                float scale = Random.Range(0.8f, 1.2f);
                obj.transform.localScale *= scale;
                
                // Add slight random tilt for natural look
                obj.transform.rotation *= Quaternion.Euler(
                    Random.Range(-5f, 5f), 
                    0, 
                    Random.Range(-5f, 5f)
                );
            }
        }
        
        Vector3 GetRandomPosition()
        {
            float margin = 10f; // Keep away from edges
            float x = Random.Range(-terrainSize/2 + margin, terrainSize/2 - margin);
            float z = Random.Range(-terrainSize/2 + margin, terrainSize/2 - margin);
            
            // Add slight height variation
            float y = Random.Range(0f, 0.5f);
            
            return new Vector3(x, y, z);
        }
        
        // Helper method to manually populate in editor
        [ContextMenu("Populate Environment")]
        public void PopulateEnvironment()
        {
            SetupTerrain();
            PlaceDecorations();
            Debug.Log("Environment populated!");
        }
    }
}