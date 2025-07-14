using UnityEngine;
using System.Collections;

namespace SpaceColonyRPG.Colony
{
    public class ColonyManager : MonoBehaviour
    {
        public static ColonyManager Instance { get; private set; }
        
        [Header("Colony Stats")]
        public int colonyLevel = 1;
        public float colonyInfluence = 0f;
        
        [Header("Systems")]
        public GridSystem gridSystem;
        public BuildingSystem buildingSystem;
        public ResourceManager resourceManager;
        public ColonistManager colonistManager;
        public ColonyUIManager uiManager;
        
        [Header("Configuration")]
        public float resourceUpdateInterval = 1f;
        public float powerCheckInterval = 5f;
        
        void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Destroy(gameObject);
                return;
            }
        }
        
        void Start()
        {
            // Initialize systems in order
            StartCoroutine(InitializeSystems());
            
            // Start update loops
            StartCoroutine(ResourceUpdateLoop());
            StartCoroutine(PowerCheckLoop());
        }
        
        IEnumerator InitializeSystems()
        {
            // Small delays to ensure proper initialization order
            yield return new WaitForSeconds(0.1f);
            
            // Load any saved colony data
            LoadColonyData();
            
            Debug.Log("Colony Manager initialized!");
        }
        
        IEnumerator ResourceUpdateLoop()
        {
            while (true)
            {
                yield return new WaitForSeconds(resourceUpdateInterval);
                
                // This is handled by individual buildings now
                // But we can add global effects here
            }
        }
        
        IEnumerator PowerCheckLoop()
        {
            while (true)
            {
                yield return new WaitForSeconds(powerCheckInterval);
                
                CheckPowerStatus();
            }
        }
        
        void CheckPowerStatus()
        {
            int production = buildingSystem.GetTotalEnergyProduction();
            int consumption = buildingSystem.GetTotalEnergyConsumption();
            
            bool hasPower = production >= consumption;
            
            // Update all buildings
            foreach (var building in FindObjectsOfType<Building>())
            {
                building.UpdatePowerStatus(hasPower);
            }
            
            // Update UI
            if (uiManager) uiManager.UpdateColonyStats();
        }
        
        public void IncreaseColonyLevel()
        {
            colonyLevel++;
            colonyInfluence += 100f;
            
            // Unlock new buildings
            if (uiManager) uiManager.RefreshBuildingButtons();
            
            // Celebration effect
            Debug.Log($"Colony reached level {colonyLevel}!");
        }
        
        public ColonySaveData CreateSaveData()
        {
            var saveData = new ColonySaveData();
            
            // Save colony stats
            saveData.colonyLevel = colonyLevel;
            saveData.colonyInfluence = colonyInfluence;
            
            // Save resources
            if (resourceManager)
            {
                foreach (var resource in resourceManager.resources)
                {
                    saveData.resources.Add(new ColonySaveData.ResourceData
                    {
                        type = resource.type,
                        amount = resource.currentAmount,
                        capacity = resource.maxCapacity
                    });
                }
            }
            
            // Save buildings
            foreach (var building in FindObjectsOfType<Building>())
            {
                saveData.buildings.Add(new ColonySaveData.SavedBuildingData
                {
                    buildingType = building.buildingData.name,
                    gridPosition = building.gridPosition,
                    isActive = building.isActive
                });
            }
            
            // Save colonist count
            if (colonistManager)
            {
                saveData.colonistCount = colonistManager.GetColonistCount();
            }
            
            return saveData;
        }
        
        void LoadColonyData()
        {
            // For hackathon, just use PlayerPrefs
            if (PlayerPrefs.HasKey("ColonyLevel"))
            {
                colonyLevel = PlayerPrefs.GetInt("ColonyLevel");
                
                // Load resources
                if (resourceManager)
                {
                    var metalResource = resourceManager.GetResource(ResourceType.Metal);
                    if (metalResource != null)
                    {
                        metalResource.currentAmount = PlayerPrefs.GetInt("Metal", 100);
                    }
                    
                    var creditsResource = resourceManager.GetResource(ResourceType.Credits);
                    if (creditsResource != null)
                    {
                        creditsResource.currentAmount = PlayerPrefs.GetInt("Credits", 0);
                    }
                }
            }
        }
        
        public void SaveColonyData()
        {
            PlayerPrefs.SetInt("ColonyLevel", colonyLevel);
            if (resourceManager)
            {
                PlayerPrefs.SetInt("Metal", resourceManager.GetResourceAmount(ResourceType.Metal));
                PlayerPrefs.SetInt("Credits", resourceManager.GetResourceAmount(ResourceType.Credits));
            }
            PlayerPrefs.Save();
        }
        
        public float CalculateRaidBonus(RaidBonusType type)
        {
            float bonus = 0f;
            
            foreach (var building in FindObjectsOfType<Building>())
            {
                if (building.buildingData)
                {
                    switch (type)
                    {
                        case RaidBonusType.Damage:
                            bonus += building.buildingData.raidDamageBonus;
                            break;
                        case RaidBonusType.Shield:
                            bonus += building.buildingData.raidShieldBonus;
                            break;
                        case RaidBonusType.HealthRegen:
                            bonus += building.buildingData.raidHealthRegenBonus;
                            break;
                    }
                }
            }
            
            return bonus;
        }
        
        public void PrepareForRaid()
        {
            // Save colony state
            SaveColonyData();
            
            // Calculate and store raid bonuses
            PlayerPrefs.SetFloat("RaidDamageBonus", CalculateRaidBonus(RaidBonusType.Damage));
            PlayerPrefs.SetFloat("RaidShieldBonus", CalculateRaidBonus(RaidBonusType.Shield));
            PlayerPrefs.SetFloat("RaidHealthRegenBonus", CalculateRaidBonus(RaidBonusType.HealthRegen));
            
            // Transition to raid
            GameStateManager gameStateManager = FindObjectOfType<GameStateManager>();
            if (gameStateManager)
            {
                gameStateManager.StartRaid(true);
            }
        }
        
        public void ReturnFromRaid(int creditsEarned)
        {
            // Add raid rewards
            if (resourceManager)
            {
                resourceManager.ModifyResource(ResourceType.Credits, creditsEarned);
            }
            
            // Check for colony level up
            if (resourceManager && resourceManager.GetResourceAmount(ResourceType.Credits) >= colonyLevel * 100)
            {
                IncreaseColonyLevel();
            }
        }
    }
    
    public enum RaidBonusType
    {
        Damage,
        Shield,
        HealthRegen
    }
    
    [System.Serializable]
    public class ColonySaveData
    {
        public int colonyLevel;
        public float colonyInfluence;
        public System.Collections.Generic.List<ResourceData> resources = new System.Collections.Generic.List<ResourceData>();
        public System.Collections.Generic.List<SavedBuildingData> buildings = new System.Collections.Generic.List<SavedBuildingData>();
        public int colonistCount;
        
        [System.Serializable]
        public class ResourceData
        {
            public ResourceType type;
            public int amount;
            public int capacity;
        }
        
        [System.Serializable]
        public class SavedBuildingData
        {
            public string buildingType;
            public Vector2Int gridPosition;
            public bool isActive;
        }
    }
}