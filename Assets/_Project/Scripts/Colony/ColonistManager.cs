using UnityEngine;
using System.Collections.Generic;

namespace SpaceColonyRPG.Colony
{
    public class ColonistManager : MonoBehaviour
    {
        public static ColonistManager Instance { get; private set; }
        
        [Header("Configuration")]
        public GameObject colonistPrefab; // Use Bean character
        public Transform colonistContainer;
        public int startingColonists = 2;
        
        [Header("Spawn Settings")]
        public Vector3 spawnAreaCenter = Vector3.zero;
        public float spawnAreaRadius = 10f;
        
        private List<Colonist> colonists = new List<Colonist>();
        private List<Transform> wanderPoints = new List<Transform>();
        
        void Awake()
        {
            Instance = this;
        }
        
        void Start()
        {
            // Generate wander points
            GenerateWanderPoints();
            
            // Spawn initial colonists
            for (int i = 0; i < startingColonists; i++)
            {
                SpawnColonist();
            }
            
            // Subscribe to resource changes
            ResourceManager.OnResourceChanged += OnResourceChanged;
        }
        
        void GenerateWanderPoints()
        {
            // Create points around colony for colonists to wander between
            int pointCount = 20;
            for (int i = 0; i < pointCount; i++)
            {
                GameObject point = new GameObject($"WanderPoint_{i}");
                point.transform.parent = transform;
                
                // Random position within bounds
                float angle = Random.Range(0f, 360f) * Mathf.Deg2Rad;
                float distance = Random.Range(5f, 40f);
                Vector3 pos = new Vector3(
                    Mathf.Sin(angle) * distance,
                    0,
                    Mathf.Cos(angle) * distance
                );
                
                point.transform.position = pos;
                wanderPoints.Add(point.transform);
            }
        }
        
        public void SpawnColonist()
        {
            if (!colonistPrefab || !ResourceManager.Instance) return;
            
            // Check housing capacity
            var colonistResource = ResourceManager.Instance.GetResource(ResourceType.Colonists);
            if (colonistResource.currentAmount >= colonistResource.maxCapacity)
            {
                Debug.Log("No housing available for new colonist!");
                return;
            }
            
            // Spawn colonist
            Vector3 spawnPos = spawnAreaCenter + Random.insideUnitSphere * spawnAreaRadius;
            spawnPos.y = 0;
            
            GameObject colonistObj = Instantiate(colonistPrefab, spawnPos, Quaternion.identity);
            if (colonistContainer) colonistObj.transform.SetParent(colonistContainer);
            
            // Setup colonist
            Colonist colonist = colonistObj.GetComponent<Colonist>();
            if (!colonist) colonist = colonistObj.AddComponent<Colonist>();
            
            colonist.Initialize($"Colonist_{colonists.Count + 1}", wanderPoints);
            colonists.Add(colonist);
            
            // Update resource count
            ResourceManager.Instance.ModifyResource(ResourceType.Colonists, 1);
        }
        
        void OnResourceChanged(ResourceType type, int newAmount)
        {
            if (type == ResourceType.Colonists)
            {
                // Handle colonist count changes if needed
            }
        }
        
        public List<Colonist> GetIdleColonists()
        {
            return colonists.FindAll(c => c.currentState == ColonistState.Idle);
        }
        
        public int GetColonistCount()
        {
            return colonists.Count;
        }
        
        void OnDestroy()
        {
            ResourceManager.OnResourceChanged -= OnResourceChanged;
        }
    }
}