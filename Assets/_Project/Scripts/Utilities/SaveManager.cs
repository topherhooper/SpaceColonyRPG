using UnityEngine;
using System.Collections.Generic;
using SpaceColonyRPG.Colony;

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
        public Quaternion rotation;
        public float workProgress;
        public bool isConstructed;
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

public static class SaveManager
{
    private const string SAVE_KEY = "ColonySave";
    private const string HAS_SAVE_KEY = "HasSave";

    public static void SaveColony()
    {
        ColonySaveData saveData = new ColonySaveData();

        Building[] buildings = Object.FindObjectsOfType<Building>();
        foreach (Building building in buildings)
        {
            saveData.buildings.Add(new ColonySaveData.BuildingData
            {
                prefabName = building.buildingData ? building.buildingData.name : "",
                position = building.transform.position,
                rotation = building.transform.rotation,
                workProgress = 1f,
                isConstructed = building.isActive
            });
        }

        Colonist[] colonists = Object.FindObjectsOfType<Colonist>();
        foreach (Colonist colonist in colonists)
        {
            saveData.colonists.Add(new ColonySaveData.ColonistData
            {
                position = colonist.transform.position,
                currentState = colonist.currentState.ToString()
            });
        }

        if (ResourceManager.Instance != null)
        {
            foreach (ResourceManager.Resource resource in ResourceManager.Instance.resources)
            {
                saveData.resources.Add(new ColonySaveData.ResourceData
                {
                    name = resource.displayName,
                    amount = resource.currentAmount
                });
            }
        }

        if (ColonyUpgrades.Instance != null)
        {
            foreach (ColonyUpgrades.Upgrade upgrade in ColonyUpgrades.Instance.availableUpgrades)
            {
                if (upgrade.purchased)
                {
                    saveData.purchasedUpgrades.Add(upgrade.name);
                }
            }
        }

        if (PlayerController.LocalPlayer != null)
        {
            PlayerProgression progression = PlayerController.LocalPlayer.GetComponent<PlayerProgression>();
            if (progression != null)
            {
                saveData.playerLevel = progression.level;
                saveData.playerExperience = progression.experience;
            }
        }

        string json = JsonUtility.ToJson(saveData, true);
        PlayerPrefs.SetString(SAVE_KEY, json);
        PlayerPrefs.SetInt(HAS_SAVE_KEY, 1);
        PlayerPrefs.Save();

        Debug.Log("Colony saved successfully!");
    }

    public static void LoadColony()
    {
        if (!HasSave()) return;

        string json = PlayerPrefs.GetString(SAVE_KEY);
        ColonySaveData saveData = JsonUtility.FromJson<ColonySaveData>(json);

        if (saveData != null)
        {
            RestoreColony(saveData);
        }
    }

    static void RestoreColony(ColonySaveData saveData)
    {
        Building[] existingBuildings = Object.FindObjectsOfType<Building>();
        foreach (Building building in existingBuildings)
        {
            Object.Destroy(building.gameObject);
        }

        Colonist[] existingColonists = Object.FindObjectsOfType<Colonist>();
        foreach (Colonist colonist in existingColonists)
        {
            Object.Destroy(colonist.gameObject);
        }

        // TODO: Implement building loading
        // BuildingSystem buildingSystem = Object.FindObjectOfType<BuildingSystem>();
        // Need to update this to work with the new BuildingData ScriptableObject system

        if (ResourceManager.Instance != null)
        {
            // TODO: Implement resource loading
            // Need to update this to work with the current ResourceManager system
        }

        if (ColonyUpgrades.Instance != null)
        {
            foreach (ColonyUpgrades.Upgrade upgrade in ColonyUpgrades.Instance.availableUpgrades)
            {
                upgrade.purchased = saveData.purchasedUpgrades.Contains(upgrade.name);
            }
        }

        Debug.Log("Colony loaded successfully!");
    }

    public static bool HasSave()
    {
        return PlayerPrefs.GetInt(HAS_SAVE_KEY, 0) == 1;
    }

    public static void DeleteSave()
    {
        PlayerPrefs.DeleteKey(SAVE_KEY);
        PlayerPrefs.DeleteKey(HAS_SAVE_KEY);
        PlayerPrefs.Save();
    }
}
