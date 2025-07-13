using UnityEngine;
using Mirror;
using System.Collections;
using System.Collections.Generic;

public class RaidManager : NetworkBehaviour
{
    public static RaidManager Instance;
    
    [Header("Raid Configuration")]
    public int baseEnemyCount = 5;
    public float raidDuration = 300f;
    public Transform[] spawnPoints;
    public GameObject enemyPrefab;
    
    [Header("Raid State")]
    [SyncVar(hook = nameof(OnTimeRemainingChanged))]
    public float timeRemaining;
    
    [SyncVar(hook = nameof(OnEnemiesRemainingChanged))]
    public int enemiesRemaining;
    
    [SyncVar]
    public int playersReady;
    
    [SyncVar]
    public bool raidStarted = false;
    
    [SyncVar]
    public bool raidEnded = false;
    
    private List<GameObject> spawnedEnemies = new List<GameObject>();
    
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }
    
    void Start()
    {
        if (isServer)
        {
            timeRemaining = raidDuration;
            StartCoroutine(WaitForPlayersAndStart());
        }
    }
    
    IEnumerator WaitForPlayersAndStart()
    {
        yield return new WaitForSeconds(3f);
        
        if (!raidStarted)
        {
            StartRaid();
        }
    }
    
    [Server]
    public void StartRaid()
    {
        raidStarted = true;
        
        int playerCount = NetworkManager.singleton.numPlayers;
        int totalLevel = 0;
        
        foreach (NetworkConnectionToClient conn in NetworkServer.connections.Values)
        {
            if (conn.identity != null)
            {
                PlayerController player = conn.identity.GetComponent<PlayerController>();
                if (player != null)
                {
                    totalLevel += player.playerLevel;
                }
            }
        }
        
        int enemyCount = baseEnemyCount + (playerCount * 3) + (totalLevel / 2);
        SpawnEnemies(enemyCount, totalLevel);
        
        StartCoroutine(RaidTimer());
    }
    
    [Server]
    void SpawnEnemies(int count, int totalPlayerLevel)
    {
        if (enemyPrefab == null)
        {
            Debug.LogError("Enemy prefab not assigned!");
            return;
        }
        
        enemiesRemaining = count;
        
        for (int i = 0; i < count; i++)
        {
            Vector3 spawnPos;
            
            if (spawnPoints != null && spawnPoints.Length > 0)
            {
                Transform spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
                spawnPos = spawnPoint.position + Random.insideUnitSphere * 5f;
            }
            else
            {
                float angle = Random.Range(0f, 360f) * Mathf.Deg2Rad;
                float distance = Random.Range(15f, 25f);
                spawnPos = new Vector3(Mathf.Sin(angle) * distance, 0, Mathf.Cos(angle) * distance);
            }
            
            spawnPos.y = 0;
            
            GameObject enemy = Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
            spawnedEnemies.Add(enemy);
            
            int bonusHealth = totalPlayerLevel * 5;
            CombatStats stats = enemy.GetComponent<CombatStats>();
            if (stats != null)
            {
                stats.maxHealth += bonusHealth;
                stats.health = stats.maxHealth;
            }
            
            NetworkServer.Spawn(enemy);
        }
    }
    
    [Server]
    IEnumerator RaidTimer()
    {
        while (timeRemaining > 0 && !raidEnded)
        {
            timeRemaining -= Time.deltaTime;
            
            if (timeRemaining <= 0)
            {
                EndRaid(false);
            }
            
            yield return null;
        }
    }
    
    [Server]
    public void OnEnemyKilled()
    {
        enemiesRemaining--;
        
        if (enemiesRemaining <= 0 && !raidEnded)
        {
            EndRaid(true);
        }
    }
    
    [Server]
    void EndRaid(bool victory)
    {
        if (raidEnded) return;
        
        raidEnded = true;
        
        foreach (GameObject enemy in spawnedEnemies)
        {
            if (enemy != null)
            {
                NetworkServer.Destroy(enemy);
            }
        }
        
        RpcEndRaid(victory);
    }
    
    [ClientRpc]
    void RpcEndRaid(bool victory)
    {
        if (GameStateManager.Instance != null)
        {
            GameStateManager.Instance.EndRaid(victory);
        }
    }
    
    void OnTimeRemainingChanged(float oldTime, float newTime)
    {
        if (UIManager.Instance != null)
        {
            UIManager.Instance.UpdateRaidTimer(newTime);
        }
    }
    
    void OnEnemiesRemainingChanged(int oldCount, int newCount)
    {
        if (UIManager.Instance != null)
        {
            UIManager.Instance.UpdateEnemyCount(newCount);
        }
    }
    
    void OnDrawGizmosSelected()
    {
        if (spawnPoints != null)
        {
            Gizmos.color = Color.red;
            foreach (Transform point in spawnPoints)
            {
                if (point != null)
                {
                    Gizmos.DrawWireSphere(point.position, 5f);
                }
            }
        }
    }
}