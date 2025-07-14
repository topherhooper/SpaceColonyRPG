using UnityEngine;
using Mirror;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class GameNetworkManager : NetworkManager
{
    public static GameNetworkManager Instance;

    [Header("Game Prefabs")]
    public GameObject enemyPrefab;
    public GameObject[] buildingPrefabs;
    public GameObject colonistPrefab;
    public GameObject lootPickupPrefab;

    [Header("Game Settings")]
    public int maxPlayersPerRaid = 4;
    public string colonySceneName = "ColonyScene";
    public string raidSceneName = "RaidScene";
    public string mainMenuSceneName = "MainMenu";

    [Header("Network Info")]
    public List<NetworkPlayer> connectedPlayers = new List<NetworkPlayer>();

    public bool isRaidHost { get; private set; }
    public string currentIPAddress { get; private set; }

    public override void Awake()
    {
        base.Awake();

        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    public override void OnStartServer()
    {
        base.OnStartServer();
        Debug.Log("Server started!");
        isRaidHost = true;
    }

    public override void OnServerConnect(NetworkConnectionToClient conn)
    {
        base.OnServerConnect(conn);
        Debug.Log($"Player connected: {conn.connectionId}");
    }

    public override void OnServerDisconnect(NetworkConnectionToClient conn)
    {
        base.OnServerDisconnect(conn);
        Debug.Log($"Player disconnected: {conn.connectionId}");

        // Remove from player list
        NetworkPlayer player = conn.identity?.GetComponent<NetworkPlayer>();
        if (player != null && connectedPlayers.Contains(player))
        {
            connectedPlayers.Remove(player);
        }
    }

    public override void OnClientConnect()
    {
        base.OnClientConnect();
        Debug.Log("Connected to server!");
    }

    public override void OnClientDisconnect()
    {
        base.OnClientDisconnect();
        Debug.Log("Disconnected from server!");
        isRaidHost = false;

        // Return to main menu
        if (GameStateManager.Instance != null)
        {
            GameStateManager.Instance.ReturnToMainMenu();
        }
    }

    public override void OnServerAddPlayer(NetworkConnectionToClient conn)
    {
        // Spawn player at appropriate location based on scene
        Transform startPos = GetStartPosition();
        GameObject player = startPos != null
            ? Instantiate(playerPrefab, startPos.position, startPos.rotation)
            : Instantiate(playerPrefab);

        // Setup player
        NetworkPlayer networkPlayer = player.GetComponent<NetworkPlayer>();
        if (networkPlayer != null)
        {
            networkPlayer.playerName = $"Player {conn.connectionId}";
            connectedPlayers.Add(networkPlayer);
        }

        NetworkServer.AddPlayerForConnection(conn, player);
    }

    public void StartSoloColony()
    {
        Debug.Log($"[GameNetworkManager] StartSoloColony called. Scene to load: {colonySceneName}");

        // Make sure we're not connected
        if (NetworkClient.active || NetworkServer.active)
        {
            Debug.Log("[GameNetworkManager] Stopping network connections before loading colony...");
            StopHost();
        }

        // Check if scene exists in build settings
        bool sceneFound = false;
        for (int i = 0; i < SceneManager.sceneCountInBuildSettings; i++)
        {
            string scenePath = SceneUtility.GetScenePathByBuildIndex(i);
            string sceneName = System.IO.Path.GetFileNameWithoutExtension(scenePath);
            Debug.Log($"[GameNetworkManager] Build scene {i}: {sceneName} (path: {scenePath})");
            if (sceneName == colonySceneName)
            {
                sceneFound = true;
                break;
            }
        }

        if (!sceneFound)
        {
            Debug.LogError($"[GameNetworkManager] Scene '{colonySceneName}' not found in build settings!");
            return;
        }

        // Load colony scene
        Debug.Log($"[GameNetworkManager] Loading scene: {colonySceneName}");
        try
        {
            SceneManager.LoadScene(colonySceneName);
            Debug.Log("[GameNetworkManager] LoadScene called successfully");
        }
        catch (System.Exception e)
        {
            Debug.LogError($"[GameNetworkManager] Failed to load scene: {e.Message}");
        }
    }

    public void HostRaid()
    {
        Debug.Log("Hosting raid...");

        if (!NetworkClient.active && !NetworkServer.active)
        {
            StartHost();
            isRaidHost = true;

            // Wait for host to fully start before changing scene
            Invoke(nameof(LoadRaidSceneAsHost), 0.5f);
        }
    }

    void LoadRaidSceneAsHost()
    {
        if (NetworkServer.active)
        {
            ServerChangeScene(raidSceneName);
        }
    }

    public void JoinRaid(string ipAddress)
    {
        Debug.Log($"Joining raid at {ipAddress}...");

        if (!NetworkClient.active && !NetworkServer.active)
        {
            networkAddress = ipAddress;
            currentIPAddress = ipAddress;
            StartClient();
        }
    }

    public override void OnServerSceneChanged(string sceneName)
    {
        base.OnServerSceneChanged(sceneName);

        if (sceneName == raidSceneName)
        {
            // Start raid when scene loads
            if (RaidManager.Instance != null)
            {
                RaidManager.Instance.StartRaid();
            }
        }
    }

    // Network spawning methods
    public void SpawnEnemy(Vector3 position, Quaternion rotation)
    {
        if (!NetworkServer.active) return;

        GameObject enemy = Instantiate(enemyPrefab, position, rotation);
        NetworkServer.Spawn(enemy);
    }

    public void SpawnLoot(Vector3 position, string resourceName, int amount)
    {
        if (!NetworkServer.active) return;

        GameObject loot = Instantiate(lootPickupPrefab, position, Quaternion.identity);
        LootPickup pickup = loot.GetComponent<LootPickup>();
        if (pickup != null)
        {
            pickup.Setup(resourceName, amount);
        }
        NetworkServer.Spawn(loot);
    }

    public void ReturnToColonyAfterRaid()
    {
        if (NetworkServer.active)
        {
            // Stop hosting
            StopHost();
        }
        else if (NetworkClient.active)
        {
            // Stop client
            StopClient();
        }

        // Return to colony
        SceneManager.LoadScene(colonySceneName);
    }

    public int GetConnectedPlayerCount()
    {
        return connectedPlayers.Count;
    }

    public bool IsRaidFull()
    {
        return connectedPlayers.Count >= maxPlayersPerRaid;
    }
}

// Simple network player tracking
public class NetworkPlayer : NetworkBehaviour
{
    [SyncVar]
    public string playerName;

    [SyncVar]
    public int playerLevel = 1;

    [SyncVar]
    public bool isReady;
}
