using UnityEngine;

public class Building : MonoBehaviour
{
    [Header("Building Info")]
    public string buildingName = "Basic Building";
    public string prefabName;
    
    [Header("Resource Costs")]
    public int metalCost = 50;
    public int energyCost = 25;
    
    [Header("Production")]
    public bool isProducer = false;
    public string producedResource = "Energy";
    public int productionAmount = 5;
    public float productionInterval = 10f;
    
    [Header("Construction")]
    public float constructionTime = 10f;
    public float workProgress = 0f;
    public bool isConstructed = false;
    
    [Header("Colonist Work")]
    public bool needsWorker = true;
    public Transform workPosition;
    public bool hasWorker = false;
    
    private float nextProductionTime;
    private GameObject constructionVisual;
    private GameObject completeVisual;
    
    void Start()
    {
        prefabName = buildingName;
        
        Transform construction = transform.Find("ConstructionSite");
        Transform complete = transform.Find("Model");
        
        if (construction != null)
        {
            constructionVisual = construction.gameObject;
        }
        
        if (complete != null)
        {
            completeVisual = complete.gameObject;
        }
        
        if (workPosition == null)
        {
            GameObject workPosGO = new GameObject("WorkPosition");
            workPosition = workPosGO.transform;
            workPosition.SetParent(transform);
            workPosition.localPosition = new Vector3(2f, 0, 0);
        }
        
        UpdateVisuals();
    }
    
    void Update()
    {
        if (!isConstructed) return;
        
        if (isProducer && (!needsWorker || hasWorker))
        {
            if (Time.time >= nextProductionTime)
            {
                ProduceResource();
                nextProductionTime = Time.time + productionInterval;
            }
        }
    }
    
    public void AddWork(float amount)
    {
        if (isConstructed) return;
        
        workProgress += amount;
        
        if (workProgress >= constructionTime)
        {
            CompleteConstruction();
        }
        
        UpdateVisuals();
    }
    
    void CompleteConstruction()
    {
        isConstructed = true;
        workProgress = constructionTime;
        
        if (AudioManager.Instance != null && AudioManager.Instance.buildingPlaceSound != null)
        {
            AudioManager.Instance.PlaySFX(AudioManager.Instance.buildingPlaceSound);
        }
        
        if (VisualEffects.Instance != null)
        {
            VisualEffects.Instance.ShowBuildingCompleteEffect(transform.position);
        }
        
        UpdateVisuals();
    }
    
    void ProduceResource()
    {
        ResourceManager.Instance.AddResource(producedResource, productionAmount);
    }
    
    public bool NeedsWork()
    {
        if (!isConstructed) return true;
        
        if (needsWorker && !hasWorker) return true;
        
        return false;
    }
    
    public void SetWorker(bool hasWorkerNow)
    {
        hasWorker = hasWorkerNow;
    }
    
    void UpdateVisuals()
    {
        if (constructionVisual != null)
        {
            constructionVisual.SetActive(!isConstructed);
        }
        
        if (completeVisual != null)
        {
            completeVisual.SetActive(isConstructed);
        }
    }
    
    public float GetConstructionProgress()
    {
        return Mathf.Clamp01(workProgress / constructionTime);
    }
    
    void OnDrawGizmosSelected()
    {
        if (workPosition != null)
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawWireSphere(workPosition.position, 0.5f);
        }
    }
}