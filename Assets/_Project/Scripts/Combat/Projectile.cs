using UnityEngine;
using Mirror;

public class Projectile : NetworkBehaviour
{
    [HideInInspector] public int damage = 10;
    [HideInInspector] public GameObject owner;
    
    public LayerMask hitLayers = -1;
    public GameObject hitEffectPrefab;
    
    void OnTriggerEnter(Collider other)
    {
        if (!isServer) return;
        
        if (other.gameObject == owner) return;
        
        if (other.transform.root.gameObject == owner) return;
        
        CombatStats targetStats = other.GetComponent<CombatStats>();
        if (targetStats != null)
        {
            targetStats.TakeDamage(damage);
            RpcShowHitEffect(other.transform.position);
        }
        
        NetworkServer.Destroy(gameObject);
    }
    
    [ClientRpc]
    void RpcShowHitEffect(Vector3 hitPos)
    {
        if (hitEffectPrefab != null)
        {
            GameObject effect = Instantiate(hitEffectPrefab, hitPos, Quaternion.identity);
            Destroy(effect, 1f);
        }
        
        if (AudioManager.Instance != null && AudioManager.Instance.enemyHitSound != null)
        {
            AudioManager.Instance.PlaySFX(AudioManager.Instance.enemyHitSound);
        }
    }
}