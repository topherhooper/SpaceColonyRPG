using UnityEngine;
using Mirror;

public class LootPickup : NetworkBehaviour
{
    [SyncVar]
    public string resourceName;

    [SyncVar]
    public int amount;

    [Header("Pickup Settings")]
    public float pickupRadius = 2f;
    public float floatSpeed = 1f;
    public float floatHeight = 0.5f;
    public float rotationSpeed = 90f;

    private float startY;
    private float floatTimer;
    private bool collected = false;

    void Start()
    {
        startY = transform.position.y;
    }

    void Update()
    {
        floatTimer += Time.deltaTime * floatSpeed;
        Vector3 pos = transform.position;
        pos.y = startY + Mathf.Sin(floatTimer) * floatHeight;
        transform.position = pos;

        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }

    public void Setup(string resource, int amt)
    {
        resourceName = resource;
        amount = amt;
    }

    void OnTriggerEnter(Collider other)
    {
        if (!isServer || collected) return;

        if (other.CompareTag("Player"))
        {
            collected = true;

            PlayerController player = other.GetComponent<PlayerController>();
            if (player != null)
            {
                player.AddResource(resourceName, amount);
            }

            RpcShowPickupEffect();

            NetworkServer.Destroy(gameObject);
        }
    }

    [ClientRpc]
    void RpcShowPickupEffect()
    {
        if (AudioManager.Instance != null && AudioManager.Instance.lootPickupSound != null)
        {
            AudioManager.Instance.PlaySFX(AudioManager.Instance.lootPickupSound);
        }

        if (VisualEffects.Instance != null)
        {
            VisualEffects.Instance.ShowLootSparkle(transform.position);
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, pickupRadius);
    }
}
