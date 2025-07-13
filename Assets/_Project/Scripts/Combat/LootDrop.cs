using UnityEngine;
using Mirror;
using System.Collections.Generic;

public class LootDrop : NetworkBehaviour
{
    [System.Serializable]
    public class LootItem
    {
        public string resourceName;
        public int minAmount;
        public int maxAmount;
        [Range(0f, 1f)]
        public float dropChance;
    }
    
    [Header("Loot Settings")]
    public LootItem[] possibleLoot = new LootItem[]
    {
        new LootItem { resourceName = "Metal", minAmount = 5, maxAmount = 15, dropChance = 0.8f },
        new LootItem { resourceName = "Energy", minAmount = 3, maxAmount = 10, dropChance = 0.6f },
        new LootItem { resourceName = "Food", minAmount = 2, maxAmount = 8, dropChance = 0.4f }
    };
    
    public GameObject lootPickupPrefab;
    public float dropSpread = 2f;
    public float dropForce = 5f;
    
    [Server]
    public void DropLoot(Vector3 position)
    {
        foreach (LootItem item in possibleLoot)
        {
            if (Random.value <= item.dropChance)
            {
                int amount = Random.Range(item.minAmount, item.maxAmount + 1);
                
                if (lootPickupPrefab != null)
                {
                    Vector3 dropPos = position + Random.insideUnitSphere * dropSpread;
                    dropPos.y = position.y + 0.5f;
                    
                    GameObject loot = Instantiate(lootPickupPrefab, dropPos, Quaternion.identity);
                    
                    LootPickup pickup = loot.GetComponent<LootPickup>();
                    if (pickup != null)
                    {
                        pickup.Setup(item.resourceName, amount);
                    }
                    
                    Rigidbody rb = loot.GetComponent<Rigidbody>();
                    if (rb != null)
                    {
                        Vector3 force = Random.insideUnitSphere * dropForce;
                        force.y = Mathf.Abs(force.y) + 2f;
                        rb.AddForce(force, ForceMode.Impulse);
                    }
                    
                    NetworkServer.Spawn(loot);
                }
                else
                {
                    Debug.LogWarning("Loot pickup prefab not assigned!");
                }
            }
        }
    }
}