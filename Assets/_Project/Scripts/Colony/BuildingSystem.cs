using UnityEngine;
using System.Collections.Generic;

namespace SpaceColonyRPG.Colony
{
    public class BuildingSystem : MonoBehaviour
    {
        public static BuildingSystem Instance { get; private set; }

        [Header("Configuration")]
        public LayerMask placementCheckMask;
        public Material validPlacementMaterial;
        public Material invalidPlacementMaterial;

        [Header("Building Data")]
        public List<BuildingData> availableBuildings;

        [Header("Effects")]
        public GameObject placementEffectPrefab;
        public GameObject constructionCompletePrefab;

        // Placement state
        private GameObject currentPreview;
        private BuildingData selectedBuilding;
        private bool isPlacing = false;
        private bool canPlace = false;

        // Placed buildings
        private List<Building> placedBuildings = new List<Building>();

        void Awake()
        {
            Instance = this;
        }

        void Update()
        {
            if (isPlacing)
            {
                UpdatePlacementPreview();
                HandlePlacementInput();
            }
        }

        public void StartPlacement(BuildingData buildingData)
        {
            // Check if can afford
            if (!ResourceManager.Instance.CanAfford(buildingData.GetCosts()))
            {
                ColonyUIManager.Instance.ShowError("Insufficient resources!");
                return;
            }

            // Check requirements
            if (!CheckBuildingRequirements(buildingData))
            {
                ColonyUIManager.Instance.ShowError("Requirements not met!");
                return;
            }

            // Start placement
            selectedBuilding = buildingData;
            currentPreview = Instantiate(buildingData.prefab);

            // Setup preview
            SetupPreviewMaterials(currentPreview);

            // Disable components during preview
            var building = currentPreview.GetComponent<Building>();
            if (building) building.enabled = false;

            isPlacing = true;
        }

        void UpdatePlacementPreview()
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100f, placementCheckMask))
            {
                // Get grid position
                Vector2Int gridPos = GridSystem.Instance.WorldToGridPosition(hit.point);
                Vector3 worldPos = GridSystem.Instance.GridToWorldPosition(gridPos);

                // Update preview position
                currentPreview.transform.position = worldPos;

                // Check if can place
                canPlace = GridSystem.Instance.CanPlaceBuilding(gridPos, selectedBuilding.gridSize);

                // Update preview material
                UpdatePreviewMaterial(canPlace);
            }
        }

        void HandlePlacementInput()
        {
            if (Input.GetMouseButtonDown(0) && canPlace)
            {
                PlaceBuilding();
            }
            else if (Input.GetMouseButtonDown(1) || Input.GetKeyDown(KeyCode.Escape))
            {
                CancelPlacement();
            }
        }

        void PlaceBuilding()
        {
            // Get final position
            Vector2Int gridPos = GridSystem.Instance.WorldToGridPosition(currentPreview.transform.position);
            Vector3 worldPos = GridSystem.Instance.GridToWorldPosition(gridPos);

            // Spend resources
            ResourceManager.Instance.SpendResources(selectedBuilding.GetCosts());

            // Destroy preview
            Destroy(currentPreview);

            // Create actual building
            GameObject buildingObj = Instantiate(selectedBuilding.prefab, worldPos, Quaternion.identity);
            Transform buildingsParent = GameObject.Find("_Dynamic/Buildings")?.transform;
            if (buildingsParent) buildingObj.transform.SetParent(buildingsParent);

            // Setup building component
            Building building = buildingObj.GetComponent<Building>();
            if (!building) building = buildingObj.AddComponent<Building>();

            building.Initialize(selectedBuilding, gridPos);
            placedBuildings.Add(building);

            // Update grid
            GridSystem.Instance.OccupyCells(gridPos, selectedBuilding.gridSize, buildingObj);

            // Effects
            if (constructionCompletePrefab)
            {
                Instantiate(constructionCompletePrefab, worldPos, Quaternion.identity);
            }

            // Audio
            AudioManager audioManager = FindObjectOfType<AudioManager>();
            if (audioManager && audioManager.buildingPlaceSound)
            {
                audioManager.PlaySFX(audioManager.buildingPlaceSound);
            }

            // End placement
            isPlacing = false;
            selectedBuilding = null;

            // Update UI
            ColonyUIManager.Instance.RefreshBuildingButtons();
        }

        void CancelPlacement()
        {
            if (currentPreview)
            {
                Destroy(currentPreview);
            }

            isPlacing = false;
            selectedBuilding = null;
        }

        void SetupPreviewMaterials(GameObject preview)
        {
            Renderer[] renderers = preview.GetComponentsInChildren<Renderer>();
            foreach (var renderer in renderers)
            {
                Material[] mats = new Material[renderer.materials.Length];
                for (int i = 0; i < mats.Length; i++)
                {
                    mats[i] = validPlacementMaterial;
                }
                renderer.materials = mats;
            }
        }

        void UpdatePreviewMaterial(bool valid)
        {
            Material mat = valid ? validPlacementMaterial : invalidPlacementMaterial;
            Renderer[] renderers = currentPreview.GetComponentsInChildren<Renderer>();

            foreach (var renderer in renderers)
            {
                Material[] mats = renderer.materials;
                for (int i = 0; i < mats.Length; i++)
                {
                    mats[i] = mat;
                }
                renderer.materials = mats;
            }
        }

        bool CheckBuildingRequirements(BuildingData data)
        {
            // Check colony level
            if (ColonyManager.Instance && ColonyManager.Instance.colonyLevel < data.requiredColonyLevel)
                return false;

            // Check prerequisites
            foreach (var prereq in data.prerequisiteBuildings)
            {
                if (!HasBuilding(prereq))
                    return false;
            }

            return true;
        }

        bool HasBuilding(BuildingData buildingType)
        {
            return placedBuildings.Exists(b => b.buildingData == buildingType);
        }

        public List<Building> GetBuildingsOfType(BuildingData type)
        {
            return placedBuildings.FindAll(b => b.buildingData == type);
        }

        public int GetTotalEnergyProduction()
        {
            int total = 0;
            foreach (var building in placedBuildings)
            {
                if (building.isActive)
                {
                    foreach (var prod in building.buildingData.resourceProduction)
                    {
                        if (prod.resourceType == ResourceType.Energy)
                            total += prod.amountPerMinute;
                    }
                }
            }
            return total;
        }

        public int GetTotalEnergyConsumption()
        {
            int total = 0;
            foreach (var building in placedBuildings)
            {
                if (building.isActive)
                {
                    total += building.buildingData.energyConsumption;
                }
            }
            return total;
        }
    }
}
