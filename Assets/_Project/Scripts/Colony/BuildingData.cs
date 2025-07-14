using UnityEngine;
using System.Collections.Generic;

namespace SpaceColonyRPG.Colony
{
    [CreateAssetMenu(fileName = "BuildingData", menuName = "Colony/Building Data")]
    public class BuildingData : ScriptableObject
    {
        [Header("Basic Info")]
        public string buildingName;
        public string description;
        public GameObject prefab;
        public Sprite icon;
        public BuildingCategory category;

        [Header("Grid")]
        public Vector2Int gridSize = Vector2Int.one;

        [Header("Costs")]
        public int metalCost;
        public int energyCost;
        public int creditsCost;
        public int researchCost;

        [Header("Requirements")]
        public int requiredColonyLevel = 1;
        public BuildingData[] prerequisiteBuildings;

        [Header("Production")]
        public ResourceProduction[] resourceProduction;
        public int energyConsumption; // Energy used per minute
        public int colonistsRequired; // Workers needed

        [Header("Effects")]
        public int housingCapacity; // For Habitat Pod
        public float raidDamageBonus; // For Armory
        public float raidShieldBonus; // For Shield Generator
        public float raidHealthRegenBonus; // For Medical Bay

        [Header("Visuals")]
        public Color buildingTintColor = Color.white;
        public GameObject constructionEffectPrefab;
        public GameObject productionEffectPrefab;

        [System.Serializable]
        public class ResourceProduction
        {
            public ResourceType resourceType;
            public int amountPerMinute;
        }

        public Dictionary<ResourceType, int> GetCosts()
        {
            var costs = new Dictionary<ResourceType, int>();

            if (metalCost > 0) costs[ResourceType.Metal] = metalCost;
            if (energyCost > 0) costs[ResourceType.Energy] = energyCost;
            if (creditsCost > 0) costs[ResourceType.Credits] = creditsCost;
            if (researchCost > 0) costs[ResourceType.Research] = researchCost;

            return costs;
        }
    }

    public enum BuildingCategory
    {
        Infrastructure,
        Production,
        Military,
        Research,
        Defense
    }
}
