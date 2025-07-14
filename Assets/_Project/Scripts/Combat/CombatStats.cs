using UnityEngine;
using Mirror;

public class CombatStats : NetworkBehaviour
{
    [Header("Health")]
    [SyncVar(hook = nameof(OnHealthChanged))]
    public int health = 100;

    [SyncVar]
    public int maxHealth = 100;

    [Header("Combat")]
    public int damage = 10;

    public delegate void HealthChangedDelegate(int oldHealth, int newHealth);
    public event HealthChangedDelegate OnHealthChangedEvent;

    public delegate void DeathDelegate();
    public event DeathDelegate OnDeath;

    private bool isDead = false;

    void Start()
    {
        health = maxHealth;
    }

    [Server]
    public void TakeDamage(int amount)
    {
        if (isDead) return;

        health = Mathf.Max(0, health - amount);

        if (health <= 0 && !isDead)
        {
            isDead = true;
            RpcDie();
        }
    }

    [Server]
    public void Heal(int amount)
    {
        if (isDead) return;

        health = Mathf.Min(maxHealth, health + amount);
    }

    [ClientRpc]
    void RpcDie()
    {
        OnDeath?.Invoke();

        gameObject.SetActive(false);

        if (isLocalPlayer)
        {
            Invoke(nameof(RequestRespawn), 3f);
        }
    }

    void RequestRespawn()
    {
        if (isLocalPlayer)
        {
            CmdRequestRespawn();
        }
    }

    [Command]
    void CmdRequestRespawn()
    {
        Respawn();
    }

    [Server]
    public void Respawn()
    {
        isDead = false;
        health = maxHealth;

        Transform spawnPoint = NetworkManager.singleton.GetStartPosition();
        if (spawnPoint != null)
        {
            transform.position = spawnPoint.position;
            transform.rotation = spawnPoint.rotation;
        }
        else
        {
            transform.position = Vector3.zero;
        }

        RpcRespawn();
    }

    [ClientRpc]
    void RpcRespawn()
    {
        gameObject.SetActive(true);
    }

    void OnHealthChanged(int oldHealth, int newHealth)
    {
        OnHealthChangedEvent?.Invoke(oldHealth, newHealth);

        if (VisualEffects.Instance != null && oldHealth > newHealth)
        {
            int damage = oldHealth - newHealth;
            Vector3 damagePos = transform.position + Vector3.up * 2f;
            VisualEffects.Instance.ShowDamageNumber(damagePos, damage, Color.red);
        }
    }

    public float GetHealthPercentage()
    {
        return (float)health / maxHealth;
    }
}
