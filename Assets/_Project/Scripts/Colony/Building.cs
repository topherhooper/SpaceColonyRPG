using UnityEngine;
using System.Collections;

namespace SpaceColonyRPG.Colony
{
    public class Building : MonoBehaviour
    {
        [Header("Data")]
        public BuildingData buildingData;
        public Vector2Int gridPosition;

        [Header("State")]
        public bool isActive = true;
        public bool hasEnoughPower = true;
        public bool hasEnoughWorkers = true;

        [Header("Visual")]
        public GameObject[] activationEffects;
        public GameObject noPowerIndicator;
        public Transform effectSpawnPoint;

        private float productionTimer = 0f;
        private float productionInterval = 60f; // 1 minute

        public void Initialize(BuildingData data, Vector2Int gridPos)
        {
            buildingData = data;
            gridPosition = gridPos;

            // Start production
            StartCoroutine(ProductionLoop());

            // Apply visual settings
            ApplyVisualSettings();

            // Update colony stats
            UpdateColonyStats(true);
        }

        void ApplyVisualSettings()
        {
            // Apply tint color
            if (buildingData.buildingTintColor != Color.white)
            {
                Renderer[] renderers = GetComponentsInChildren<Renderer>();
                foreach (var renderer in renderers)
                {
                    if (renderer.material)
                    {
                        renderer.material.color = buildingData.buildingTintColor;
                    }
                }
            }

            // Enable activation effects
            SetActivationEffects(true);
        }

        IEnumerator ProductionLoop()
        {
            while (true)
            {
                yield return new WaitForSeconds(1f);

                if (isActive && hasEnoughPower && hasEnoughWorkers)
                {
                    productionTimer += 1f;

                    if (productionTimer >= productionInterval)
                    {
                        ProduceResources();
                        productionTimer = 0f;
                    }
                }
            }
        }

        void ProduceResources()
        {
            foreach (var production in buildingData.resourceProduction)
            {
                ResourceManager.Instance.ModifyResource(
                    production.resourceType,
                    production.amountPerMinute
                );

                // Visual feedback
                if (buildingData.productionEffectPrefab && effectSpawnPoint)
                {
                    var effect = Instantiate(
                        buildingData.productionEffectPrefab,
                        effectSpawnPoint.position,
                        Quaternion.identity
                    );
                    Destroy(effect, 2f);
                }
            }
        }

        public void UpdatePowerStatus(bool hasPower)
        {
            hasEnoughPower = hasPower;

            if (noPowerIndicator)
                noPowerIndicator.SetActive(!hasPower);

            SetActivationEffects(hasPower && hasEnoughWorkers);
        }

        void SetActivationEffects(bool active)
        {
            foreach (var effect in activationEffects)
            {
                if (effect) effect.SetActive(active);
            }
        }

        void UpdateColonyStats(bool adding)
        {
            int multiplier = adding ? 1 : -1;

            // Housing capacity
            if (buildingData.housingCapacity > 0)
            {
                ResourceManager.Instance.IncreaseCapacity(
                    ResourceType.Colonists,
                    buildingData.housingCapacity * multiplier
                );
            }

            // Raid bonuses are handled by RaidManager when loading raid scene
        }

        void OnDestroy()
        {
            UpdateColonyStats(false);
        }
    }
}
