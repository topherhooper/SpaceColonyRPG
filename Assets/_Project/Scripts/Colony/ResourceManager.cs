using UnityEngine;
using System;
using System.Collections.Generic;

namespace SpaceColonyRPG.Colony
{
    public class ResourceManager : MonoBehaviour
    {
        public static ResourceManager Instance { get; private set; }

        [Header("Resource Configuration")]
        public List<Resource> resources = new List<Resource>();

        [Header("Starting Resources")]
        public int startingMetal = 100;
        public int startingEnergy = 0;
        public int startingCredits = 0;
        public int startingColonists = 2;

        // Events
        public static event Action<ResourceType, int> OnResourceChanged;

        [Serializable]
        public class Resource
        {
            public ResourceType type;
            public string displayName;
            public Sprite icon;
            public int currentAmount;
            public int maxCapacity;
            public Color displayColor = Color.white;
        }

        void Awake()
        {
            Instance = this;
            InitializeResources();
        }

        void InitializeResources()
        {
            // Create resource entries
            resources = new List<Resource>
            {
                new Resource
                {
                    type = ResourceType.Metal,
                    displayName = "Metal",
                    currentAmount = startingMetal,
                    maxCapacity = 500,
                    displayColor = new Color(0.7f, 0.7f, 0.8f)
                },
                new Resource
                {
                    type = ResourceType.Energy,
                    displayName = "Energy",
                    currentAmount = startingEnergy,
                    maxCapacity = int.MaxValue, // Energy is flow-based
                    displayColor = new Color(0.3f, 0.8f, 1f)
                },
                new Resource
                {
                    type = ResourceType.Credits,
                    displayName = "Credits",
                    currentAmount = startingCredits,
                    maxCapacity = int.MaxValue,
                    displayColor = new Color(1f, 0.9f, 0.3f)
                },
                new Resource
                {
                    type = ResourceType.Colonists,
                    displayName = "Colonists",
                    currentAmount = startingColonists,
                    maxCapacity = 2, // Starts with housing for 2
                    displayColor = new Color(0.3f, 1f, 0.3f)
                },
                new Resource
                {
                    type = ResourceType.Research,
                    displayName = "Research",
                    currentAmount = 0,
                    maxCapacity = int.MaxValue,
                    displayColor = new Color(0.8f, 0.3f, 1f)
                }
            };
        }

        public bool CanAfford(ResourceType type, int amount)
        {
            var resource = GetResource(type);
            return resource != null && resource.currentAmount >= amount;
        }

        public bool CanAfford(Dictionary<ResourceType, int> costs)
        {
            foreach (var cost in costs)
            {
                if (!CanAfford(cost.Key, cost.Value))
                    return false;
            }
            return true;
        }

        public void SpendResources(Dictionary<ResourceType, int> costs)
        {
            foreach (var cost in costs)
            {
                ModifyResource(cost.Key, -cost.Value);
            }
        }

        public void ModifyResource(ResourceType type, int amount)
        {
            var resource = GetResource(type);
            if (resource != null)
            {
                int oldAmount = resource.currentAmount;
                resource.currentAmount = Mathf.Clamp(
                    resource.currentAmount + amount,
                    0,
                    resource.maxCapacity
                );

                if (oldAmount != resource.currentAmount)
                {
                    OnResourceChanged?.Invoke(type, resource.currentAmount);
                }
            }
        }

        public Resource GetResource(ResourceType type)
        {
            return resources.Find(r => r.type == type);
        }

        public int GetResourceAmount(ResourceType type)
        {
            var resource = GetResource(type);
            return resource?.currentAmount ?? 0;
        }

        public void IncreaseCapacity(ResourceType type, int amount)
        {
            var resource = GetResource(type);
            if (resource != null)
            {
                resource.maxCapacity += amount;
            }
        }
    }

    public enum ResourceType
    {
        Metal,
        Energy,
        Credits,
        Colonists,
        Research
    }
}
