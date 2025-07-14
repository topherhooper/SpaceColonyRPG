using UnityEngine;
using System.Collections.Generic;

namespace SpaceColonyRPG.Colony
{
    public class ColonyUpgrades : MonoBehaviour
    {
    public static ColonyUpgrades Instance;

    [System.Serializable]
    public class Upgrade
    {
        public string name;
        public string description;
        public int metalCost;
        public int energyCost;
        public bool purchased;

        public int damageBonus;
        public int healthBonus;
        public float moveSpeedBonus;
        public float fireRateBonus;
    }

    [Header("Available Upgrades")]
    public List<Upgrade> availableUpgrades = new List<Upgrade>
    {
        new Upgrade
        {
            name = "Reinforced Armor",
            description = "+20 Health in raids",
            metalCost = 50,
            energyCost = 0,
            healthBonus = 20
        },
        new Upgrade
        {
            name = "Enhanced Weapons",
            description = "+5 Damage in raids",
            metalCost = 75,
            energyCost = 0,
            damageBonus = 5
        },
        new Upgrade
        {
            name = "Speed Boosters",
            description = "+1 Move Speed in raids",
            metalCost = 40,
            energyCost = 30,
            moveSpeedBonus = 1f
        },
        new Upgrade
        {
            name = "Rapid Fire Module",
            description = "+20% Fire Rate in raids",
            metalCost = 60,
            energyCost = 40,
            fireRateBonus = 0.2f
        }
    };

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

    public bool CanPurchaseUpgrade(int index)
    {
        if (index < 0 || index >= availableUpgrades.Count) return false;

        Upgrade upgrade = availableUpgrades[index];

        if (upgrade.purchased) return false;

        return ResourceManager.Instance.CanAfford(ResourceType.Metal, upgrade.metalCost) &&
               ResourceManager.Instance.CanAfford(ResourceType.Energy, upgrade.energyCost);
    }

    public void PurchaseUpgrade(int index)
    {
        if (!CanPurchaseUpgrade(index)) return;

        Upgrade upgrade = availableUpgrades[index];

        ResourceManager.Instance.ModifyResource(ResourceType.Metal, -upgrade.metalCost);
        ResourceManager.Instance.ModifyResource(ResourceType.Energy, -upgrade.energyCost);

        upgrade.purchased = true;

        if (AudioManager.Instance != null && AudioManager.Instance.buildingPlaceSound != null)
        {
            AudioManager.Instance.PlaySFX(AudioManager.Instance.buildingPlaceSound);
        }

        Debug.Log($"Purchased upgrade: {upgrade.name}");
    }

    public void ApplyUpgradesToPlayer(PlayerController player)
    {
        if (player == null) return;

        int totalDamageBonus = 0;
        int totalHealthBonus = 0;
        float totalSpeedBonus = 0f;
        float totalFireRateBonus = 0f;

        foreach (Upgrade upgrade in availableUpgrades)
        {
            if (upgrade.purchased)
            {
                totalDamageBonus += upgrade.damageBonus;
                totalHealthBonus += upgrade.healthBonus;
                totalSpeedBonus += upgrade.moveSpeedBonus;
                totalFireRateBonus += upgrade.fireRateBonus;
            }
        }

        CombatStats combat = player.GetComponent<CombatStats>();
        if (combat != null)
        {
            combat.damage += totalDamageBonus;
            combat.maxHealth += totalHealthBonus;
            combat.health = combat.maxHealth;
        }

        player.moveSpeed += totalSpeedBonus;

        Weapon weapon = player.GetComponent<Weapon>();
        if (weapon != null && totalFireRateBonus > 0)
        {
            weapon.fireRate *= (1f - totalFireRateBonus);
        }
    }

    public List<Upgrade> GetPurchasedUpgrades()
    {
        List<Upgrade> purchased = new List<Upgrade>();
        foreach (Upgrade upgrade in availableUpgrades)
        {
            if (upgrade.purchased)
            {
                purchased.Add(upgrade);
            }
        }
        return purchased;
    }

    public void ResetForNewGame()
    {
        foreach (Upgrade upgrade in availableUpgrades)
        {
            upgrade.purchased = false;
        }
    }
    }
}
