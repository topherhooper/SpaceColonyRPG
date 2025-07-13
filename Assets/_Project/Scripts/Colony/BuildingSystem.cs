using UnityEngine;
using System.Collections.Generic;

public class BuildingSystem : MonoBehaviour
{
    [Header("Building Settings")]
    public LayerMask groundLayer = 1 << 8;
    public LayerMask buildingLayer = 1 << 9;
    public GameObject[] buildingPrefabs;
    public Material validPlacementMat;
    public Material invalidPlacementMat;
    public float gridSize = 2f;
    
    [Header("Build Mode")]
    private GameObject currentBuilding;
    public int selectedBuildingIndex { get; private set; }
    private bool isBuilding = false;
    private Renderer[] buildingRenderers;
    private Material[] originalMaterials;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            ToggleBuildMode();
        }
        
        if (isBuilding && currentBuilding != null)
        {
            UpdatePlacementPreview();
            
            if (Input.GetMouseButtonDown(0) && CanPlaceBuilding())
            {
                PlaceBuilding();
            }
            
            if (Input.GetMouseButtonDown(1))
            {
                CancelPlacement();
            }
            
            if (Input.GetAxis("Mouse ScrollWheel") > 0f)
            {
                SelectNextBuilding();
            }
            else if (Input.GetAxis("Mouse ScrollWheel") < 0f)
            {
                SelectPreviousBuilding();
            }
        }
        
        for (int i = 0; i < Mathf.Min(buildingPrefabs.Length, 9); i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                selectedBuildingIndex = i;
                if (isBuilding)
                {
                    StartPlacement(selectedBuildingIndex);
                }
            }
        }
    }
    
    public void ToggleBuildMode()
    {
        isBuilding = !isBuilding;
        
        if (isBuilding)
        {
            StartPlacement(selectedBuildingIndex);
        }
        else
        {
            CancelPlacement();
        }
    }
    
    public void StartPlacement(int buildingIndex)
    {
        if (buildingIndex < 0 || buildingIndex >= buildingPrefabs.Length) return;
        
        CancelPlacement();
        
        selectedBuildingIndex = buildingIndex;
        currentBuilding = Instantiate(buildingPrefabs[buildingIndex]);
        currentBuilding.name = "BuildingPreview";
        
        buildingRenderers = currentBuilding.GetComponentsInChildren<Renderer>();
        originalMaterials = new Material[buildingRenderers.Length];
        for (int i = 0; i < buildingRenderers.Length; i++)
        {
            originalMaterials[i] = buildingRenderers[i].material;
        }
        
        Collider[] colliders = currentBuilding.GetComponentsInChildren<Collider>();
        foreach (Collider col in colliders)
        {
            col.enabled = false;
        }
        
        Building building = currentBuilding.GetComponent<Building>();
        if (building != null)
        {
            building.enabled = false;
        }
        
        isBuilding = true;
    }
    
    void UpdatePlacementPreview()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        
        if (Physics.Raycast(ray, out hit, 100f, groundLayer))
        {
            Vector3 pos = hit.point;
            pos.x = Mathf.Round(pos.x / gridSize) * gridSize;
            pos.z = Mathf.Round(pos.z / gridSize) * gridSize;
            pos.y = 0;
            
            currentBuilding.transform.position = pos;
            
            bool canPlace = CanPlaceBuilding();
            Material matToUse = canPlace ? validPlacementMat : invalidPlacementMat;
            
            foreach (Renderer renderer in buildingRenderers)
            {
                renderer.material = matToUse;
            }
        }
    }
    
    bool CanPlaceBuilding()
    {
        if (currentBuilding == null) return false;
        
        Building building = buildingPrefabs[selectedBuildingIndex].GetComponent<Building>();
        if (building != null)
        {
            if (!ResourceManager.Instance.CanAfford("Metal", building.metalCost) ||
                !ResourceManager.Instance.CanAfford("Energy", building.energyCost))
            {
                return false;
            }
        }
        
        Collider[] buildingColliders = currentBuilding.GetComponentsInChildren<Collider>();
        
        foreach (Collider collider in buildingColliders)
        {
            collider.enabled = true;
            
            Bounds bounds = collider.bounds;
            bounds.Expand(-0.1f);
            
            Collider[] overlaps = Physics.OverlapBox(bounds.center, bounds.extents, currentBuilding.transform.rotation, buildingLayer);
            
            collider.enabled = false;
            
            foreach (Collider overlap in overlaps)
            {
                if (overlap.transform.root != currentBuilding.transform)
                {
                    return false;
                }
            }
        }
        
        return true;
    }
    
    void PlaceBuilding()
    {
        Building buildingComponent = buildingPrefabs[selectedBuildingIndex].GetComponent<Building>();
        if (buildingComponent != null)
        {
            ResourceManager.Instance.SpendResource("Metal", buildingComponent.metalCost);
            ResourceManager.Instance.SpendResource("Energy", buildingComponent.energyCost);
        }
        
        GameObject placedBuilding = Instantiate(buildingPrefabs[selectedBuildingIndex], currentBuilding.transform.position, currentBuilding.transform.rotation);
        placedBuilding.name = buildingPrefabs[selectedBuildingIndex].name;
        
        if (AudioManager.Instance != null && AudioManager.Instance.buildingPlaceSound != null)
        {
            AudioManager.Instance.PlaySFX(AudioManager.Instance.buildingPlaceSound);
        }
        
        CancelPlacement();
        
        StartPlacement(selectedBuildingIndex);
    }
    
    void CancelPlacement()
    {
        if (currentBuilding != null)
        {
            Destroy(currentBuilding);
            currentBuilding = null;
        }
        
        isBuilding = false;
    }
    
    void SelectNextBuilding()
    {
        selectedBuildingIndex = (selectedBuildingIndex + 1) % buildingPrefabs.Length;
        if (isBuilding)
        {
            StartPlacement(selectedBuildingIndex);
        }
    }
    
    void SelectPreviousBuilding()
    {
        selectedBuildingIndex = selectedBuildingIndex - 1;
        if (selectedBuildingIndex < 0) selectedBuildingIndex = buildingPrefabs.Length - 1;
        if (isBuilding)
        {
            StartPlacement(selectedBuildingIndex);
        }
    }
    
    public bool IsInBuildMode()
    {
        return isBuilding;
    }
}