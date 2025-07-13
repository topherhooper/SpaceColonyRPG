using UnityEngine;
using Mirror;

public class PlayerController : NetworkBehaviour
{
    [Header("Player Info")]
    [SyncVar] public string playerName;
    [SyncVar] public int playerLevel = 1;
    
    [Header("Movement")]
    public float moveSpeed = 5f;
    public float rotationSpeed = 720f;
    
    private CharacterController characterController;
    private Camera playerCamera;
    
    public static PlayerController LocalPlayer { get; private set; }
    
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        
        if (isLocalPlayer)
        {
            LocalPlayer = this;
            
            GameObject cameraGO = new GameObject("Player Camera");
            playerCamera = cameraGO.AddComponent<Camera>();
            cameraGO.AddComponent<AudioListener>();
            
            cameraGO.transform.SetParent(transform);
            cameraGO.transform.localPosition = new Vector3(0, 10, -10);
            cameraGO.transform.localRotation = Quaternion.Euler(45, 0, 0);
            
            if (string.IsNullOrEmpty(playerName))
            {
                CmdSetPlayerName($"Player {netId}");
            }
        }
        else
        {
            enabled = false;
        }
    }
    
    void Update()
    {
        if (!isLocalPlayer) return;
        
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        
        Vector3 moveDirection = new Vector3(h, 0, v).normalized;
        
        if (moveDirection.magnitude > 0.1f)
        {
            Vector3 movement = moveDirection * moveSpeed * Time.deltaTime;
            characterController.Move(movement);
            
            Quaternion targetRotation = Quaternion.LookRotation(moveDirection);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
        
        Vector3 gravity = Vector3.down * 9.81f * Time.deltaTime;
        characterController.Move(gravity);
    }
    
    [Command]
    void CmdSetPlayerName(string newName)
    {
        playerName = newName;
    }
    
    public void AddResource(string resourceName, int amount)
    {
        Debug.Log($"Added {amount} {resourceName}");
    }
    
    void OnDestroy()
    {
        if (LocalPlayer == this)
        {
            LocalPlayer = null;
        }
    }
}