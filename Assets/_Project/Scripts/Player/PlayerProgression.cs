using UnityEngine;
using Mirror;

public class PlayerProgression : NetworkBehaviour
{
    [Header("Level & Experience")]
    [SyncVar(hook = nameof(OnLevelChanged))]
    public int level = 1;
    
    [SyncVar(hook = nameof(OnExperienceChanged))]
    public int experience = 0;
    
    [Header("Stat Bonuses")]
    [SyncVar]
    public int damageBonus = 0;
    
    [SyncVar]
    public int healthBonus = 0;
    
    [SyncVar]
    public float moveSpeedBonus = 0f;
    
    public int ExperienceToNextLevel => level * 100;
    
    public delegate void LevelUpDelegate(int newLevel);
    public event LevelUpDelegate OnLevelUp;
    
    public delegate void ExperienceChangedDelegate(int newExperience);
    public event ExperienceChangedDelegate OnExperienceChangedEvent;
    
    void Start()
    {
        if (isLocalPlayer)
        {
            ApplyStats();
        }
    }
    
    [Server]
    public void AddExperience(int amount)
    {
        experience += amount;
        
        while (experience >= ExperienceToNextLevel)
        {
            experience -= ExperienceToNextLevel;
            LevelUp();
        }
    }
    
    [Server]
    void LevelUp()
    {
        level++;
        damageBonus += 2;
        healthBonus += 10;
        moveSpeedBonus += 0.2f;
        
        CombatStats combatStats = GetComponent<CombatStats>();
        if (combatStats != null)
        {
            combatStats.maxHealth += 10;
            combatStats.health = combatStats.maxHealth;
            combatStats.damage += 2;
        }
        
        PlayerController controller = GetComponent<PlayerController>();
        if (controller != null)
        {
            controller.moveSpeed += 0.2f;
        }
        
        RpcLevelUpEffect();
    }
    
    [ClientRpc]
    void RpcLevelUpEffect()
    {
        OnLevelUp?.Invoke(level);
        
        if (AudioManager.Instance != null && AudioManager.Instance.levelUpSound != null)
        {
            AudioManager.Instance.PlaySFX(AudioManager.Instance.levelUpSound);
        }
        
        if (VisualEffects.Instance != null)
        {
            VisualEffects.Instance.ShowLevelUpEffect(transform.position);
        }
        
        Debug.Log($"LEVEL UP! Now level {level}");
    }
    
    void OnLevelChanged(int oldLevel, int newLevel)
    {
        if (UIManager.Instance != null)
        {
            UIManager.Instance.UpdatePlayerLevel(newLevel);
        }
    }
    
    void OnExperienceChanged(int oldXP, int newXP)
    {
        OnExperienceChangedEvent?.Invoke(newXP);
        
        if (UIManager.Instance != null)
        {
            UIManager.Instance.UpdateExperience(newXP, ExperienceToNextLevel);
        }
    }
    
    void ApplyStats()
    {
        CombatStats combatStats = GetComponent<CombatStats>();
        if (combatStats != null)
        {
            combatStats.damage += damageBonus;
            combatStats.maxHealth += healthBonus;
            combatStats.health = combatStats.maxHealth;
        }
        
        PlayerController controller = GetComponent<PlayerController>();
        if (controller != null)
        {
            controller.moveSpeed += moveSpeedBonus;
        }
    }
    
    public float GetExperiencePercentage()
    {
        return (float)experience / ExperienceToNextLevel;
    }
}