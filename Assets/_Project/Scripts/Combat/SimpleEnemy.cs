using UnityEngine;
using Mirror;
using UnityEngine.AI;

public class SimpleEnemy : NetworkBehaviour
{
    [Header("AI Settings")]
    public float detectionRange = 10f;
    public float attackRange = 2f;
    public float moveSpeed = 3f;
    public float attackCooldown = 1f;
    
    [Header("Combat")]
    public int attackDamage = 10;
    
    private Transform target;
    private CombatStats combatStats;
    private NavMeshAgent navAgent;
    private float nextAttackTime;
    
    void Start()
    {
        combatStats = GetComponent<CombatStats>();
        navAgent = GetComponent<NavMeshAgent>();
        
        if (navAgent != null)
        {
            navAgent.speed = moveSpeed;
        }
        
        if (combatStats != null)
        {
            combatStats.OnDeath += OnDeath;
        }
    }
    
    [ServerCallback]
    void Update()
    {
        if (!NetworkServer.active) return;
        
        if (target == null)
        {
            FindNearestPlayer();
        }
        
        if (target != null)
        {
            float distance = Vector3.Distance(transform.position, target.position);
            
            if (distance > detectionRange)
            {
                target = null;
                if (navAgent != null) navAgent.isStopped = true;
            }
            else if (distance > attackRange)
            {
                MoveToTarget();
            }
            else
            {
                if (navAgent != null) navAgent.isStopped = true;
                Attack();
            }
        }
    }
    
    void FindNearestPlayer()
    {
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
        float nearestDistance = float.MaxValue;
        
        foreach (GameObject player in players)
        {
            if (!player.activeInHierarchy) continue;
            
            float distance = Vector3.Distance(transform.position, player.transform.position);
            if (distance < nearestDistance && distance < detectionRange)
            {
                nearestDistance = distance;
                target = player.transform;
            }
        }
    }
    
    void MoveToTarget()
    {
        if (navAgent != null && navAgent.enabled)
        {
            navAgent.isStopped = false;
            navAgent.SetDestination(target.position);
        }
        else
        {
            Vector3 direction = (target.position - transform.position).normalized;
            transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
            
            Quaternion lookRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
        }
    }
    
    void Attack()
    {
        if (Time.time >= nextAttackTime)
        {
            nextAttackTime = Time.time + attackCooldown;
            
            CombatStats targetStats = target.GetComponent<CombatStats>();
            if (targetStats != null)
            {
                targetStats.TakeDamage(attackDamage);
                RpcShowAttackEffect();
            }
        }
        
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }
    
    [ClientRpc]
    void RpcShowAttackEffect()
    {
        if (AudioManager.Instance != null)
        {
            AudioManager.Instance.PlaySFX(AudioManager.Instance.enemyHitSound);
        }
    }
    
    void OnDeath()
    {
        if (isServer)
        {
            LootDrop lootDrop = GetComponent<LootDrop>();
            if (lootDrop != null)
            {
                lootDrop.DropLoot(transform.position);
            }
            
            RaidManager raidManager = FindObjectOfType<RaidManager>();
            if (raidManager != null)
            {
                raidManager.OnEnemyKilled();
            }
            
            GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
            foreach (GameObject player in players)
            {
                PlayerProgression progression = player.GetComponent<PlayerProgression>();
                if (progression != null)
                {
                    progression.AddExperience(25);
                }
            }
            
            Invoke(nameof(DestroyEnemy), 0.5f);
        }
    }
    
    void DestroyEnemy()
    {
        NetworkServer.Destroy(gameObject);
    }
    
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, detectionRange);
        
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
    }
}