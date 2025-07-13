using UnityEngine;
using Mirror;
using UnityEngine.SceneManagement;

public class GameNetworkManager : NetworkManager
{
    public static GameNetworkManager Instance;
    
    void Awake() 
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    
    public void StartSoloColony()
    {
        networkAddress = "localhost";
        StartHost();
        LoadColonyScene();
    }
    
    public void JoinRaid(string address)
    {
        networkAddress = address;
        StartClient();
    }
    
    void LoadColonyScene()
    {
        if (isNetworkActive)
        {
            ServerChangeScene("ColonyScene");
        }
        else
        {
            SceneManager.LoadScene("ColonyScene");
        }
    }
    
    public override void OnServerAddPlayer(NetworkConnectionToClient conn)
    {
        base.OnServerAddPlayer(conn);
        
        Debug.Log($"Player {conn.connectionId} connected. Total players: {numPlayers}");
    }
    
    public override void OnServerDisconnect(NetworkConnectionToClient conn)
    {
        base.OnServerDisconnect(conn);
        
        Debug.Log($"Player {conn.connectionId} disconnected. Total players: {numPlayers}");
    }
}