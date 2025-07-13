using UnityEngine;
using Mirror;

public class Weapon : NetworkBehaviour
{
    [Header("Weapon Settings")]
    public float fireRate = 0.5f;
    public GameObject projectilePrefab;
    public Transform firePoint;
    public int damage = 10;
    
    private float nextFireTime;
    private PlayerController playerController;
    
    void Start()
    {
        playerController = GetComponent<PlayerController>();
        
        if (firePoint == null)
        {
            GameObject firePointGO = new GameObject("Fire Point");
            firePoint = firePointGO.transform;
            firePoint.SetParent(transform);
            firePoint.localPosition = new Vector3(0, 0.5f, 1f);
        }
    }
    
    void Update()
    {
        if (!isLocalPlayer) return;
        
        if (Input.GetButton("Fire1") && Time.time > nextFireTime)
        {
            nextFireTime = Time.time + fireRate;
            CmdFire();
        }
    }
    
    [Command]
    void CmdFire()
    {
        if (projectilePrefab == null) return;
        
        Vector3 spawnPos = firePoint != null ? firePoint.position : transform.position + transform.forward;
        GameObject bullet = Instantiate(projectilePrefab, spawnPos, transform.rotation);
        
        Projectile proj = bullet.GetComponent<Projectile>();
        if (proj != null)
        {
            proj.damage = damage;
            proj.owner = gameObject;
        }
        
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.linearVelocity = transform.forward * 20f;
        }
        
        NetworkServer.Spawn(bullet);
        
        RpcFireEffect();
        
        Destroy(bullet, 2f);
    }
    
    [ClientRpc]
    void RpcFireEffect()
    {
        if (AudioManager.Instance != null && AudioManager.Instance.shootSound != null)
        {
            AudioManager.Instance.PlaySFX(AudioManager.Instance.shootSound);
        }
        
        if (VisualEffects.Instance != null && firePoint != null)
        {
            VisualEffects.Instance.ShowMuzzleFlash(firePoint.position);
        }
    }
}