using UnityEngine;
using Mirror;

namespace SpaceColony.Utilities
{
    /// <summary>
    /// Helper to set up test multiplayer scene
    /// Add this to an empty GameObject and run
    /// </summary>
    public class TestSceneSetup : MonoBehaviour
    {
        [Header("Scene Setup Instructions")]
        [TextArea(15, 25)]
        public string setupInstructions = @"TEST MULTIPLAYER SCENE SETUP:

1. SCENE SETUP
   - Create new scene: 'TestMultiplayer'
   - Add Directional Light
   - Add Ground Plane (scale 10,1,10)
   - Add NetworkManager GameObject

2. NETWORK MANAGER
   - Add Component: NetworkManager
   - Network Info > Network Address: localhost
   - Network Info > Max Connections: 4
   - Spawn Info > Player Prefab: (assign later)
   - Spawn Info > Auto Create Player: True

3. SPAWN POINTS
   - Create 4 empty GameObjects
   - Name: SpawnPoint1, SpawnPoint2, etc.
   - Add Component: NetworkStartPosition
   - Position them around the map

4. SIMPLE PLAYER PREFAB
   - Create Capsule
   - Name: Player_Test
   - Add Components:
     * NetworkIdentity
     * NetworkTransform
     * CharacterController
   - Save as Prefab
   - Assign to NetworkManager

5. TEST INSTRUCTIONS
   - Build project
   - Run build as Host
   - Run Editor as Client
   - Both should see each other!";

        [Header("Quick Actions")]
        public bool createNetworkManager = false;
        public bool createSpawnPoints = false;
        public GameObject playerPrefab;

        void OnValidate()
        {
            if (createNetworkManager)
            {
                createNetworkManager = false;
                CreateNetworkManager();
            }

            if (createSpawnPoints)
            {
                createSpawnPoints = false;
                CreateSpawnPoints();
            }
        }

        void CreateNetworkManager()
        {
            GameObject nm = GameObject.Find("NetworkManager");
            if (nm == null)
            {
                nm = new GameObject("NetworkManager");
                nm.AddComponent<NetworkManager>();
                Debug.Log("[TestSceneSetup] Created NetworkManager");
            }
            else
            {
                Debug.LogWarning("[TestSceneSetup] NetworkManager already exists!");
            }
        }

        void CreateSpawnPoints()
        {
            Vector3[] positions = new Vector3[]
            {
                new Vector3(-5, 0, 5),
                new Vector3(5, 0, 5),
                new Vector3(5, 0, -5),
                new Vector3(-5, 0, -5)
            };

            for (int i = 0; i < positions.Length; i++)
            {
                GameObject spawn = new GameObject($"SpawnPoint{i + 1}");
                spawn.transform.position = positions[i];
                spawn.AddComponent<NetworkStartPosition>();
                Debug.Log($"[TestSceneSetup] Created {spawn.name} at {positions[i]}");
            }
        }
    }
}