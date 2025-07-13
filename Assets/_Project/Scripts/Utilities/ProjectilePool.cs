using UnityEngine;
using System.Collections.Generic;

public class ProjectilePool : MonoBehaviour
{
    public static ProjectilePool Instance;
    
    [Header("Pool Settings")]
    public GameObject projectilePrefab;
    public int initialPoolSize = 50;
    public bool expandable = true;
    
    private Queue<GameObject> pool = new Queue<GameObject>();
    private List<GameObject> activeProjectiles = new List<GameObject>();
    
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            InitializePool();
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    void InitializePool()
    {
        if (projectilePrefab == null)
        {
            Debug.LogError("Projectile prefab not assigned to pool!");
            return;
        }
        
        for (int i = 0; i < initialPoolSize; i++)
        {
            CreateNewProjectile();
        }
    }
    
    GameObject CreateNewProjectile()
    {
        GameObject obj = Instantiate(projectilePrefab);
        obj.SetActive(false);
        obj.transform.SetParent(transform);
        pool.Enqueue(obj);
        return obj;
    }
    
    public GameObject GetProjectile()
    {
        GameObject projectile = null;
        
        if (pool.Count > 0)
        {
            projectile = pool.Dequeue();
        }
        else if (expandable)
        {
            projectile = CreateNewProjectile();
            projectile = pool.Dequeue();
        }
        else
        {
            Debug.LogWarning("Projectile pool exhausted!");
            return null;
        }
        
        projectile.SetActive(true);
        projectile.transform.SetParent(null);
        activeProjectiles.Add(projectile);
        
        return projectile;
    }
    
    public void ReturnProjectile(GameObject projectile)
    {
        if (projectile == null) return;
        
        projectile.SetActive(false);
        projectile.transform.SetParent(transform);
        projectile.transform.position = Vector3.zero;
        projectile.transform.rotation = Quaternion.identity;
        
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
        
        activeProjectiles.Remove(projectile);
        pool.Enqueue(projectile);
    }
    
    public void ReturnAllProjectiles()
    {
        List<GameObject> projectilesToReturn = new List<GameObject>(activeProjectiles);
        
        foreach (GameObject projectile in projectilesToReturn)
        {
            ReturnProjectile(projectile);
        }
    }
    
    void OnDestroy()
    {
        ReturnAllProjectiles();
    }
}