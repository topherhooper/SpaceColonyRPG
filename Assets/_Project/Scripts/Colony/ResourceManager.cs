using UnityEngine;
using System.Collections.Generic;
using System;

public class ResourceManager : MonoBehaviour
{
    public static ResourceManager Instance;
    
    [System.Serializable]
    public class Resource
    {
        public string name;
        public int amount;
        public Sprite icon;
        
        public Resource(string resourceName, int startAmount)
        {
            name = resourceName;
            amount = startAmount;
        }
    }
    
    [Header("Resources")]
    public List<Resource> resources = new List<Resource>
    {
        new Resource("Metal", 100),
        new Resource("Energy", 50),
        new Resource("Food", 25)
    };
    
    public delegate void ResourceChangedDelegate(string resourceName, int oldAmount, int newAmount);
    public event ResourceChangedDelegate OnResourceChanged;
    
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
    
    public bool CanAfford(string resourceName, int amount)
    {
        Resource resource = resources.Find(r => r.name == resourceName);
        return resource != null && resource.amount >= amount;
    }
    
    public void SpendResource(string resourceName, int amount)
    {
        Resource resource = resources.Find(r => r.name == resourceName);
        if (resource != null && resource.amount >= amount)
        {
            int oldAmount = resource.amount;
            resource.amount -= amount;
            OnResourceChanged?.Invoke(resourceName, oldAmount, resource.amount);
            UpdateUI();
        }
    }
    
    public void AddResource(string resourceName, int amount)
    {
        Resource resource = resources.Find(r => r.name == resourceName);
        if (resource != null)
        {
            int oldAmount = resource.amount;
            resource.amount += amount;
            OnResourceChanged?.Invoke(resourceName, oldAmount, resource.amount);
            UpdateUI();
        }
        else
        {
            resources.Add(new Resource(resourceName, amount));
            OnResourceChanged?.Invoke(resourceName, 0, amount);
            UpdateUI();
        }
    }
    
    public int GetResource(string resourceName)
    {
        Resource resource = resources.Find(r => r.name == resourceName);
        return resource != null ? resource.amount : 0;
    }
    
    void UpdateUI()
    {
        if (UIManager.Instance != null)
        {
            UIManager.Instance.UpdateResourceDisplay();
        }
    }
    
    public void InitializeForColony()
    {
        resources.Clear();
        resources.Add(new Resource("Metal", 200));
        resources.Add(new Resource("Energy", 100));
        resources.Add(new Resource("Food", 50));
        UpdateUI();
    }
    
    public void InitializeForRaid()
    {
        
    }
}