# 7-Day Hackathon Development Plan: Space RPG v0 Prototype

## Overview & Core Goals

**Prototype Objective**: Create a playable vertical slice demonstrating the core loop:
1. Solo colony building (place buildings, assign colonists)
2. Join multiplayer strike (2-player co-op)
3. Defeat enemies to earn resources
4. Return to colony and upgrade
5. Visible progression impact on next raid

**Tech Stack**: Unity 2022.3 LTS + Mirror Networking (free, quick setup)

## Day 1: Foundation & Networking (12 hours)

### Morning (4 hours)
```python
# Project Setup Checklist
- Create Unity project with URP
- Import Mirror Networking
- Set up Git repository
- Create folder structure:
  /Scripts/Colony
  /Scripts/Combat
  /Scripts/Networking
  /Scripts/Player
  /Prefabs
  /Materials
```

### Afternoon (4 hours)
```csharp
// Basic Networking Setup
public class GameNetworkManager : NetworkManager
{
    public static GameNetworkManager Instance;
    
    void Awake() 
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    
    public void StartSoloColony()
    {
        networkAddress = "localhost";
        StartHost();
        LoadColonyScene();
    }
    
    public void JoinRaid(string address)
    {
        networkAddress = address;
        StartClient();
    }
}
```

### Evening (4 hours)
```csharp
// Player Controller with Network Support
public class PlayerController : NetworkBehaviour
{
    [SyncVar] public string playerName;
    [SyncVar] public int playerLevel = 1;
    
    void Update()
    {
        if (!isLocalPlayer) return;
        
        // Basic WASD movement
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(h, 0, v) * 5f * Time.deltaTime);
    }
}
```

**Day 1 Deliverables**:
- ✓ Unity project with Mirror configured
- ✓ Basic multiplayer connection working
- ✓ Player spawning and movement synced

## Day 2: Combat System (12 hours)

### Morning (4 hours)
```csharp
// Simple Combat System
public class CombatStats : NetworkBehaviour
{
    [SyncVar(hook = nameof(OnHealthChanged))]
    public int health = 100;
    
    [SyncVar]
    public int maxHealth = 100;
    
    public int damage = 10;
    
    [Server]
    public void TakeDamage(int amount)
    {
        health = Mathf.Max(0, health - amount);
        if (health <= 0)
        {
            RpcDie();
        }
    }
    
    [ClientRpc]
    void RpcDie()
    {
        // Simple death - respawn after 3 seconds
        gameObject.SetActive(false);
        if (isLocalPlayer)
        {
            Invoke(nameof(RequestRespawn), 3f);
        }
    }
}
```

### Afternoon (4 hours)
```csharp
// Basic Enemy AI
public class SimpleEnemy : NetworkBehaviour
{
    public float detectionRange = 10f;
    public float attackRange = 2f;
    public float moveSpeed = 3f;
    
    private Transform target;
    private CombatStats combatStats;
    
    [ServerCallback]
    void Update()
    {
        if (!NetworkServer.active) return;
        
        // Find nearest player
        if (target == null)
        {
            var players = GameObject.FindGameObjectsWithTag("Player");
            float nearestDist = float.MaxValue;
            foreach (var player in players)
            {
                float dist = Vector3.Distance(transform.position, player.transform.position);
                if (dist < nearestDist && dist < detectionRange)
                {
                    nearestDist = dist;
                    target = player.transform;
                }
            }
        }
        
        // Move and attack
        if (target != null)
        {
            float dist = Vector3.Distance(transform.position, target.position);
            if (dist > attackRange)
            {
                transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
            }
            else
            {
                Attack();
            }
        }
    }
}
```

### Evening (4 hours)
```csharp
// Weapon System
public class Weapon : NetworkBehaviour
{
    public float fireRate = 0.5f;
    public GameObject projectilePrefab;
    
    private float nextFireTime;
    
    void Update()
    {
        if (!isLocalPlayer) return;
        
        if (Input.GetButton("Fire1") && Time.time > nextFireTime)
        {
            nextFireTime = Time.time + fireRate;
            CmdFire();
        }
    }
    
    [Command]
    void CmdFire()
    {
        var bullet = Instantiate(projectilePrefab, transform.position + transform.forward, transform.rotation);
        bullet.GetComponent<Rigidbody>().velocity = transform.forward * 20f;
        NetworkServer.Spawn(bullet);
        Destroy(bullet, 2f);
    }
}
```

**Day 2 Deliverables**:
- ✓ Players can shoot projectiles
- ✓ Basic enemy AI that chases players
- ✓ Health/damage system working
- ✓ Death and respawn mechanics

## Day 3: Basic Colony System (12 hours)

### Morning (4 hours)
```csharp
// Grid-based Building System
public class BuildingSystem : MonoBehaviour
{
    public LayerMask groundLayer;
    public GameObject[] buildingPrefabs;
    public Material validPlacementMat;
    public Material invalidPlacementMat;
    
    private GameObject currentBuilding;
    private int selectedBuildingIndex;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            StartPlacement(selectedBuildingIndex);
        }
        
        if (currentBuilding != null)
        {
            UpdatePlacementPreview();
            
            if (Input.GetMouseButtonDown(0) && CanPlaceBuilding())
            {
                PlaceBuilding();
            }
        }
    }
    
    void UpdatePlacementPreview()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit, 100f, groundLayer))
        {
            // Snap to grid
            Vector3 pos = hit.point;
            pos.x = Mathf.Round(pos.x / 2f) * 2f;
            pos.z = Mathf.Round(pos.z / 2f) * 2f;
            pos.y = 0;
            
            currentBuilding.transform.position = pos;
            
            // Update material based on validity
            bool canPlace = CanPlaceBuilding();
            currentBuilding.GetComponent<Renderer>().material = canPlace ? validPlacementMat : invalidPlacementMat;
        }
    }
}
```

### Afternoon (4 hours)
```csharp
// Simple Colonist System
public class Colonist : MonoBehaviour
{
    public enum State { Idle, Working, Moving }
    public State currentState = State.Idle;
    
    public float moveSpeed = 3f;
    public float workSpeed = 1f;
    
    private Building targetBuilding;
    private Vector3 targetPosition;
    
    void Update()
    {
        switch (currentState)
        {
            case State.Idle:
                // Find work
                FindNearestJob();
                break;
                
            case State.Moving:
                // Move to target
                transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
                if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
                {
                    if (targetBuilding != null)
                    {
                        currentState = State.Working;
                    }
                    else
                    {
                        currentState = State.Idle;
                    }
                }
                break;
                
            case State.Working:
                // Work at building
                if (targetBuilding != null)
                {
                    targetBuilding.AddWork(workSpeed * Time.deltaTime);
                }
                break;
        }
    }
    
    void FindNearestJob()
    {
        var buildings = FindObjectsOfType<Building>();
        Building nearest = null;
        float nearestDist = float.MaxValue;
        
        foreach (var building in buildings)
        {
            if (building.NeedsWork())
            {
                float dist = Vector3.Distance(transform.position, building.transform.position);
                if (dist < nearestDist)
                {
                    nearest = building;
                    nearestDist = dist;
                }
            }
        }
        
        if (nearest != null)
        {
            targetBuilding = nearest;
            targetPosition = nearest.transform.position;
            currentState = State.Moving;
        }
    }
}
```

### Evening (4 hours)
```csharp
// Resource System
public class ResourceManager : MonoBehaviour
{
    public static ResourceManager Instance;
    
    [System.Serializable]
    public class Resource
    {
        public string name;
        public int amount;
        public Sprite icon;
    }
    
    public List<Resource> resources = new List<Resource>
    {
        new Resource { name = "Metal", amount = 100 },
        new Resource { name = "Energy", amount = 50 },
        new Resource { name = "Food", amount = 25 }
    };
    
    void Awake()
    {
        Instance = this;
    }
    
    public bool CanAfford(string resourceName, int amount)
    {
        var resource = resources.Find(r => r.name == resourceName);
        return resource != null && resource.amount >= amount;
    }
    
    public void SpendResource(string resourceName, int amount)
    {
        var resource = resources.Find(r => r.name == resourceName);
        if (resource != null)
        {
            resource.amount -= amount;
            UpdateUI();
        }
    }
    
    public void AddResource(string resourceName, int amount)
    {
        var resource = resources.Find(r => r.name == resourceName);
        if (resource != null)
        {
            resource.amount += amount;
            UpdateUI();
        }
    }
}
```

**Day 3 Deliverables**:
- ✓ Grid-based building placement
- ✓ 3 building types (generator, barracks, storage)
- ✓ Basic colonist AI
- ✓ Resource tracking system

## Day 4: Loot & Progression (12 hours)

### Morning (4 hours)
```csharp
// Loot Drop System
public class LootDrop : NetworkBehaviour
{
    [System.Serializable]
    public class LootItem
    {
        public string resourceName;
        public int minAmount;
        public int maxAmount;
        public float dropChance;
    }
    
    public LootItem[] possibleLoot;
    
    [Server]
    public void DropLoot(Vector3 position)
    {
        foreach (var item in possibleLoot)
        {
            if (Random.value <= item.dropChance)
            {
                int amount = Random.Range(item.minAmount, item.maxAmount + 1);
                var loot = Instantiate(lootPickupPrefab, position + Random.insideUnitSphere, Quaternion.identity);
                loot.GetComponent<LootPickup>().Setup(item.resourceName, amount);
                NetworkServer.Spawn(loot);
            }
        }
    }
}

// Loot Pickup
public class LootPickup : NetworkBehaviour
{
    [SyncVar]
    public string resourceName;
    
    [SyncVar]
    public int amount;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (isServer)
            {
                // Add to player's resources
                var player = other.GetComponent<PlayerController>();
                player.AddResource(resourceName, amount);
                
                // Show pickup effect
                RpcShowPickupEffect();
                
                // Destroy
                NetworkServer.Destroy(gameObject);
            }
        }
    }
}
```

### Afternoon (4 hours)
```csharp
// Simple Progression System
public class PlayerProgression : NetworkBehaviour
{
    [SyncVar]
    public int level = 1;
    
    [SyncVar]
    public int experience = 0;
    
    [SyncVar]
    public int damageBonus = 0;
    
    [SyncVar]
    public int healthBonus = 0;
    
    public int ExperienceToNextLevel => level * 100;
    
    [Server]
    public void AddExperience(int amount)
    {
        experience += amount;
        
        while (experience >= ExperienceToNextLevel)
        {
            experience -= ExperienceToNextLevel;
            LevelUp();
        }
    }
    
    [Server]
    void LevelUp()
    {
        level++;
        damageBonus += 2;
        healthBonus += 10;
        
        // Apply bonuses
        GetComponent<CombatStats>().maxHealth += 10;
        GetComponent<CombatStats>().health = GetComponent<CombatStats>().maxHealth;
        
        RpcLevelUpEffect();
    }
    
    [ClientRpc]
    void RpcLevelUpEffect()
    {
        // Play level up VFX/SFX
        Debug.Log($"LEVEL UP! Now level {level}");
    }
}
```

### Evening (4 hours)
```csharp
// Colony Upgrades that affect Combat
public class ColonyUpgrades : MonoBehaviour
{
    [System.Serializable]
    public class Upgrade
    {
        public string name;
        public string description;
        public int metalCost;
        public int energyCost;
        public bool purchased;
        
        // Effects
        public int damageBonus;
        public int healthBonus;
        public float moveSpeedBonus;
    }
    
    public List<Upgrade> availableUpgrades = new List<Upgrade>
    {
        new Upgrade 
        { 
            name = "Reinforced Armor",
            description = "+20 Health in raids",
            metalCost = 50,
            healthBonus = 20
        },
        new Upgrade
        {
            name = "Enhanced Weapons",
            description = "+5 Damage in raids",
            metalCost = 75,
            damageBonus = 5
        }
    };
    
    public void PurchaseUpgrade(int index)
    {
        var upgrade = availableUpgrades[index];
        
        if (!upgrade.purchased && 
            ResourceManager.Instance.CanAfford("Metal", upgrade.metalCost) &&
            ResourceManager.Instance.CanAfford("Energy", upgrade.energyCost))
        {
            ResourceManager.Instance.SpendResource("Metal", upgrade.metalCost);
            ResourceManager.Instance.SpendResource("Energy", upgrade.energyCost);
            
            upgrade.purchased = true;
            ApplyUpgrade(upgrade);
        }
    }
    
    public void ApplyUpgradesToPlayer(PlayerController player)
    {
        foreach (var upgrade in availableUpgrades)
        {
            if (upgrade.purchased)
            {
                var combat = player.GetComponent<CombatStats>();
                combat.damage += upgrade.damageBonus;
                combat.maxHealth += upgrade.healthBonus;
                combat.health = combat.maxHealth;
            }
        }
    }
}
```

**Day 4 Deliverables**:
- ✓ Enemies drop loot on death
- ✓ Loot gives resources
- ✓ Basic level/XP system
- ✓ Colony upgrades that affect combat stats

## Day 5: Game Flow & Scene Management (12 hours)

### Morning (4 hours)
```csharp
// Game State Manager
public class GameStateManager : MonoBehaviour
{
    public static GameStateManager Instance;
    
    public enum GameState
    {
        MainMenu,
        Colony,
        PreparingRaid,
        InRaid,
        PostRaid
    }
    
    public GameState currentState;
    
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    public void StartNewGame()
    {
        currentState = GameState.Colony;
        SceneManager.LoadScene("ColonyScene");
    }
    
    public void PrepareForRaid()
    {
        // Save colony state
        SaveColonyState();
        
        currentState = GameState.PreparingRaid;
        
        // Load raid prep UI
        UIManager.Instance.ShowRaidPrepPanel();
    }
    
    public void StartRaid(bool hosting)
    {
        currentState = GameState.InRaid;
        
        if (hosting)
        {
            GameNetworkManager.Instance.StartHost();
        }
        else
        {
            GameNetworkManager.Instance.StartClient();
        }
        
        SceneManager.LoadScene("RaidScene");
    }
    
    public void EndRaid(bool victory)
    {
        currentState = GameState.PostRaid;
        
        // Calculate rewards
        if (victory)
        {
            int bonusMetal = 50 + (PlayerController.LocalPlayer.level * 10);
            int bonusEnergy = 25 + (PlayerController.LocalPlayer.level * 5);
            
            ResourceManager.Instance.AddResource("Metal", bonusMetal);
            ResourceManager.Instance.AddResource("Energy", bonusEnergy);
        }
        
        // Return to colony
        StartCoroutine(ReturnToColony());
    }
}
```

### Afternoon (4 hours)
```csharp
// Raid Manager
public class RaidManager : NetworkBehaviour
{
    [Header("Raid Configuration")]
    public int baseEnemyCount = 5;
    public float raidDuration = 300f; // 5 minutes
    public Transform[] spawnPoints;
    
    [SyncVar]
    public float timeRemaining;
    
    [SyncVar]
    public int enemiesRemaining;
    
    [SyncVar]
    public int playersReady;
    
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
        // Wait for players to load
        yield return new WaitForSeconds(3f);
        
        // Spawn enemies based on player count and levels
        int playerCount = NetworkManager.singleton.numPlayers;
        int totalLevel = 0;
        
        foreach (var conn in NetworkServer.connections.Values)
        {
            var player = conn.identity.GetComponent<PlayerController>();
            totalLevel += player.playerLevel;
        }
        
        int enemyCount = baseEnemyCount + (playerCount * 3) + (totalLevel / 2);
        SpawnEnemies(enemyCount);
        
        // Start raid timer
        StartCoroutine(RaidTimer());
    }
    
    void SpawnEnemies(int count)
    {
        enemiesRemaining = count;
        
        for (int i = 0; i < count; i++)
        {
            Vector3 spawnPos = spawnPoints[Random.Range(0, spawnPoints.Length)].position;
            spawnPos += Random.insideUnitSphere * 5f;
            spawnPos.y = 0;
            
            var enemy = Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
            NetworkServer.Spawn(enemy);
        }
    }
    
    [Server]
    public void OnEnemyKilled()
    {
        enemiesRemaining--;
        
        if (enemiesRemaining <= 0)
        {
            EndRaid(true);
        }
    }
    
    [Server]
    void EndRaid(bool victory)
    {
        RpcEndRaid(victory);
    }
    
    [ClientRpc]
    void RpcEndRaid(bool victory)
    {
        GameStateManager.Instance.EndRaid(victory);
    }
}
```

### Evening (4 hours)
```csharp
// Save System for Colony State
[System.Serializable]
public class ColonySaveData
{
    public List<BuildingData> buildings = new List<BuildingData>();
    public List<ColonistData> colonists = new List<ColonistData>();
    public List<ResourceData> resources = new List<ResourceData>();
    public List<string> purchasedUpgrades = new List<string>();
    public int playerLevel;
    public int playerExperience;
    
    [System.Serializable]
    public class BuildingData
    {
        public string prefabName;
        public Vector3 position;
        public float workProgress;
    }
    
    [System.Serializable]
    public class ColonistData
    {
        public Vector3 position;
        public string currentState;
    }
    
    [System.Serializable]
    public class ResourceData
    {
        public string name;
        public int amount;
    }
}

public class SaveManager : MonoBehaviour
{
    const string SAVE_KEY = "ColonySave";
    
    public static void SaveColony()
    {
        var saveData = new ColonySaveData();
        
        // Save buildings
        foreach (var building in FindObjectsOfType<Building>())
        {
            saveData.buildings.Add(new ColonySaveData.BuildingData
            {
                prefabName = building.prefabName,
                position = building.transform.position,
                workProgress = building.workProgress
            });
        }
        
        // Save colonists
        foreach (var colonist in FindObjectsOfType<Colonist>())
        {
            saveData.colonists.Add(new ColonySaveData.ColonistData
            {
                position = colonist.transform.position,
                currentState = colonist.currentState.ToString()
            });
        }
        
        // Save resources
        foreach (var resource in ResourceManager.Instance.resources)
        {
            saveData.resources.Add(new ColonySaveData.ResourceData
            {
                name = resource.name,
                amount = resource.amount
            });
        }
        
        // Save to PlayerPrefs (quick for hackathon)
        string json = JsonUtility.ToJson(saveData);
        PlayerPrefs.SetString(SAVE_KEY, json);
        PlayerPrefs.Save();
    }
    
    public static void LoadColony()
    {
        if (PlayerPrefs.HasKey(SAVE_KEY))
        {
            string json = PlayerPrefs.GetString(SAVE_KEY);
            var saveData = JsonUtility.FromJson<ColonySaveData>(json);
            
            // Restore colony state
            RestoreColony(saveData);
        }
    }
}
```

**Day 5 Deliverables**:
- ✓ Main menu → Colony → Raid → Colony flow
- ✓ Raid timer and win/lose conditions
- ✓ Dynamic enemy spawning based on players
- ✓ Colony state persistence

## Day 6: UI & Polish (12 hours)

### Morning (4 hours)
```csharp
// Main UI Manager
public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    
    [Header("Panels")]
    public GameObject mainMenuPanel;
    public GameObject colonyHUD;
    public GameObject raidHUD;
    public GameObject raidPrepPanel;
    public GameObject gameOverPanel;
    
    [Header("Colony UI")]
    public Text metalText;
    public Text energyText;
    public Text foodText;
    public Text colonistCountText;
    
    [Header("Raid UI")]
    public Text timerText;
    public Text enemiesText;
    public Slider healthBar;
    public Text levelText;
    public Slider xpBar;
    
    void Awake()
    {
        Instance = this;
    }
    
    public void UpdateResourceDisplay()
    {
        metalText.text = $"Metal: {ResourceManager.Instance.GetResource("Metal")}";
        energyText.text = $"Energy: {ResourceManager.Instance.GetResource("Energy")}";
        foodText.text = $"Food: {ResourceManager.Instance.GetResource("Food")}";
    }
    
    public void UpdateRaidDisplay(float timeRemaining, int enemies)
    {
        timerText.text = $"Time: {Mathf.FloorToInt(timeRemaining / 60)}:{Mathf.FloorToInt(timeRemaining % 60):00}";
        enemiesText.text = $"Enemies: {enemies}";
    }
    
    public void ShowRaidPrepPanel()
    {
        raidPrepPanel.SetActive(true);
        
        // Show available upgrades
        UpdateUpgradeButtons();
    }
}
```

### Afternoon (4 hours)
```csharp
// Building UI
public class BuildingUI : MonoBehaviour
{
    public GameObject buildingButtonPrefab;
    public Transform buttonContainer;
    public BuildingSystem buildingSystem;
    
    [System.Serializable]
    public class BuildingInfo
    {
        public string name;
        public Sprite icon;
        public GameObject prefab;
        public int metalCost;
        public int energyCost;
        public KeyCode hotkey;
    }
    
    public BuildingInfo[] availableBuildings;
    
    void Start()
    {
        CreateBuildingButtons();
    }
    
    void CreateBuildingButtons()
    {
        for (int i = 0; i < availableBuildings.Length; i++)
        {
            var info = availableBuildings[i];
            var button = Instantiate(buildingButtonPrefab, buttonContainer);
            
            // Set up button
            button.GetComponentInChildren<Text>().text = info.name;
            button.GetComponentInChildren<Image>().sprite = info.icon;
            
            int index = i;
            button.GetComponent<Button>().onClick.AddListener(() =>
            {
                TrySelectBuilding(index);
            });
        }
    }
    
    void Update()
    {
        // Hotkey support
        for (int i = 0; i < availableBuildings.Length; i++)
        {
            if (Input.GetKeyDown(availableBuildings[i].hotkey))
            {
                TrySelectBuilding(i);
            }
        }
    }
    
    void TrySelectBuilding(int index)
    {
        var info = availableBuildings[index];
        
        if (ResourceManager.Instance.CanAfford("Metal", info.metalCost) &&
            ResourceManager.Instance.CanAfford("Energy", info.energyCost))
        {
            buildingSystem.StartPlacement(index);
        }
        else
        {
            // Show "insufficient resources" feedback
            ShowInsufficientResourcesPopup();
        }
    }
}
```

### Evening (4 hours)
```csharp
// Polish Features
public class VisualEffects : MonoBehaviour
{
    [Header("Prefabs")]
    public GameObject damageNumberPrefab;
    public GameObject levelUpEffectPrefab;
    public GameObject buildingCompleteEffectPrefab;
    public GameObject lootSparkleEffectPrefab;
    
    public static VisualEffects Instance;
    
    void Awake()
    {
        Instance = this;
    }
    
    public void ShowDamageNumber(Vector3 position, int damage, Color color)
    {
        var damageNum = Instantiate(damageNumberPrefab, position, Quaternion.identity);
        var text = damageNum.GetComponent<TextMeshPro>();
        text.text = damage.ToString();
        text.color = color;
        
        // Animate upward and fade
        StartCoroutine(AnimateDamageNumber(damageNum));
    }
    
    IEnumerator AnimateDamageNumber(GameObject obj)
    {
        float duration = 1f;
        float elapsed = 0;
        Vector3 startPos = obj.transform.position;
        
        while (elapsed < duration)
        {
            elapsed += Time.deltaTime;
            float t = elapsed / duration;
            
            obj.transform.position = startPos + Vector3.up * (t * 2f);
            obj.GetComponent<TextMeshPro>().alpha = 1f - t;
            
            yield return null;
        }
        
        Destroy(obj);
    }
}

// Audio Manager
public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    
    [Header("SFX")]
    public AudioClip shootSound;
    public AudioClip enemyHitSound;
    public AudioClip enemyDeathSound;
    public AudioClip buildingPlaceSound;
    public AudioClip levelUpSound;
    public AudioClip lootPickupSound;
    
    private AudioSource sfxSource;
    
    void Awake()
    {
        Instance = this;
        sfxSource = gameObject.AddComponent<AudioSource>();
    }
    
    public void PlaySFX(AudioClip clip, float volume = 1f)
    {
        sfxSource.PlayOneShot(clip, volume);
    }
}
```

**Day 6 Deliverables**:
- ✓ Complete UI for all game states
- ✓ Building placement UI with costs
- ✓ Visual feedback (damage numbers, effects)
- ✓ Basic sound effects
- ✓ Hotkeys for common actions

## Day 7: Testing & Final Polish (12 hours)

### Morning (4 hours)
**Bug Fixing Checklist**:
```markdown
□ Test full game loop 5 times
□ Fix any null reference exceptions
□ Ensure multiplayer sync works properly
□ Balance enemy health/damage
□ Verify save/load works correctly
□ Test all UI buttons function
□ Check resource costs make sense
□ Verify colonist AI doesn't get stuck
```

### Afternoon (4 hours)
**Performance Optimization**:
```csharp
// Object Pooling for Projectiles
public class ObjectPool : MonoBehaviour
{
    public GameObject prefab;
    public int poolSize = 20;
    
    private Queue<GameObject> pool = new Queue<GameObject>();
    
    void Start()
    {
        for (int i = 0; i < poolSize; i++)
        {
            var obj = Instantiate(prefab);
            obj.SetActive(false);
            pool.Enqueue(obj);
        }
    }
    
    public GameObject Get()
    {
        if (pool.Count > 0)
        {
            var obj = pool.Dequeue();
            obj.SetActive(true);
            return obj;
        }
        else
        {
            return Instantiate(prefab);
        }
    }
    
    public void Return(GameObject obj)
    {
        obj.SetActive(false);
        pool.Enqueue(obj);
    }
}
```

### Evening (4 hours)
**Final Features & Polish**:
```csharp
// Quick Tutorial System
public class TutorialManager : MonoBehaviour
{
    public GameObject[] tutorialPanels;
    private int currentPanel = 0;
    
    void Start()
    {
        if (PlayerPrefs.GetInt("TutorialComplete", 0) == 0)
        {
            ShowTutorial();
        }
    }
    
    public void ShowTutorial()
    {
        tutorialPanels[0].SetActive(true);
    }
    
    public void NextPanel()
    {
        tutorialPanels[currentPanel].SetActive(false);
        currentPanel++;
        
        if (currentPanel < tutorialPanels.Length)
        {
            tutorialPanels[currentPanel].SetActive(true);
        }
        else
        {
            PlayerPrefs.SetInt("TutorialComplete", 1);
        }
    }
}

// Win Screen with Stats
public class VictoryScreen : MonoBehaviour
{
    public Text enemiesKilledText;
    public Text resourcesGainedText;
    public Text timeText;
    public Text levelText;
    
    public void ShowVictoryStats(RaidStats stats)
    {
        enemiesKilledText.text = $"Enemies Defeated: {stats.enemiesKilled}";
        resourcesGainedText.text = $"Resources Gained: {stats.totalResourcesGained}";
        timeText.text = $"Time: {FormatTime(stats.raidDuration)}";
        levelText.text = $"Level: {stats.playerLevel} (+{stats.experienceGained} XP)";
    }
}
```

## Final Deliverables Checklist

### Core Features (Must Have)
- [x] **Colony Building**: Place 3 types of buildings on grid
- [x] **Colonist AI**: Basic work assignment
- [x] **Resource System**: Metal, Energy, Food
- [x] **Multiplayer Raids**: 2-player co-op
- [x] **Combat**: Shooting, enemies, health
- [x] **Loot System**: Enemies drop resources
- [x] **Progression**: Level up, colony upgrades
- [x] **Game Loop**: Colony → Raid → Upgrade → Repeat

### Nice to Have (If Time Permits)
- [ ] Different enemy types
- [ ] More building varieties
- [ ] Special abilities for players
- [ ] Colony defense events
- [ ] Leaderboard system

### Build & Distribution
```bash
# Build Settings
- Platform: Windows/Mac/Linux Standalone
- Resolution: 1920x1080
- Quality: Medium
- Compression: LZ4

# Files to Include
- README.txt with controls
- How_To_Host_Multiplayer.txt
- Known_Issues.txt
```

## Post-Hackathon Next Steps

1. **Gather Feedback**: Share with 10+ testers
2. **Priority Fixes**: Address game-breaking bugs
3. **Feature Roadmap**: Plan next 3 features based on feedback
4. **Community Building**: Create Discord, start devlog
5. **Monetization Planning**: F2P vs Premium considerations

## Emergency Shortcuts

If running behind schedule, cut these features in order:
1. Colony colonist AI (make buildings auto-generate resources)
2. Save/Load system (just reset each session)
3. Multiple building types (start with just one)
4. Visual effects and polish
5. Tutorial system

**Remember**: A working, fun core loop is better than many half-implemented features!