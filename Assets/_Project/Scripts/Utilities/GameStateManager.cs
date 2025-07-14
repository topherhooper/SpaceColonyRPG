using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using SpaceColonyRPG.Colony;

public class GameStateManager : MonoBehaviour
{
    public static GameStateManager Instance;

    public enum GameState
    {
        MainMenu,
        Colony,
        PreparingRaid,
        InRaid,
        PostRaid,
    }

    [Header("Current State")]
    public GameState currentState = GameState.MainMenu;

    [Header("Settings")]
    public float postRaidReturnDelay = 5f;

    private void Awake()
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

    private void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log($"Scene loaded: {scene.name}");

        switch (scene.name)
        {
            case "MainMenu":
                currentState = GameState.MainMenu;
                break;
            case "ColonyScene":
                currentState = GameState.Colony;
                OnColonySceneLoaded();
                break;
            case "RaidScene":
                currentState = GameState.InRaid;
                OnRaidSceneLoaded();
                break;
        }
    }

    public void StartNewGame()
    {
        currentState = GameState.Colony;

        // ResourceManager.Instance.InitializeForColony(); // TODO: Implement this method
        ColonyUpgrades.Instance.ResetForNewGame();

        SceneManager.LoadScene("ColonyScene");
    }

    public void ContinueGame()
    {
        currentState = GameState.Colony;

        SaveManager.LoadColony();

        SceneManager.LoadScene("ColonyScene");
    }

    public void PrepareForRaid()
    {
        SaveColonyState();

        currentState = GameState.PreparingRaid;

        if (UIManager.Instance != null)
        {
            UIManager.Instance.ShowRaidPrepPanel();
        }
    }

    public void StartRaid(bool hosting, string address = "localhost")
    {
        currentState = GameState.InRaid;

        StartCoroutine(StartRaidCoroutine(hosting, address));
    }

    private IEnumerator StartRaidCoroutine(bool hosting, string address)
    {
        if (hosting)
        {
            GameNetworkManager.Instance.StartHost();
        }
        else
        {
            GameNetworkManager.Instance.networkAddress = address;
            GameNetworkManager.Instance.StartClient();
        }

        yield return new WaitForSeconds(0.5f);

        if (GameNetworkManager.Instance != null && GameNetworkManager.Instance.isNetworkActive)
        {
            if (hosting)
            {
                GameNetworkManager.Instance.ServerChangeScene("RaidScene");
            }
        }
        else
        {
            Debug.LogError("Failed to start network!");
            currentState = GameState.Colony;
        }
    }

    public void EndRaid(bool victory)
    {
        currentState = GameState.PostRaid;

        if (victory)
        {
            int bonusMetal =
                50
                + (
                    PlayerController.LocalPlayer != null
                        ? PlayerController.LocalPlayer.playerLevel * 10
                        : 50
                );
            int bonusEnergy =
                25
                + (
                    PlayerController.LocalPlayer != null
                        ? PlayerController.LocalPlayer.playerLevel * 5
                        : 25
                );

            ResourceManager.Instance.ModifyResource(ResourceType.Metal, bonusMetal);
            ResourceManager.Instance.ModifyResource(ResourceType.Energy, bonusEnergy);

            if (UIManager.Instance != null)
            {
                UIManager.Instance.ShowVictoryScreen(bonusMetal, bonusEnergy);
            }
        }
        else
        {
            if (UIManager.Instance != null)
            {
                UIManager.Instance.ShowDefeatScreen();
            }
        }

        StartCoroutine(ReturnToColony());
    }

    private IEnumerator ReturnToColony()
    {
        yield return new WaitForSeconds(postRaidReturnDelay);

        if (GameNetworkManager.Instance != null && GameNetworkManager.Instance.isNetworkActive)
        {
            if (GameNetworkManager.Instance.mode == Mirror.NetworkManagerMode.Host)
            {
                GameNetworkManager.Instance.StopHost();
            }
            else
            {
                GameNetworkManager.Instance.StopClient();
            }
        }

        yield return new WaitForSeconds(0.5f);

        currentState = GameState.Colony;
        SceneManager.LoadScene("ColonyScene");
    }

    private void SaveColonyState()
    {
        SaveManager.SaveColony();
    }

    private void OnColonySceneLoaded()
    {
        // ResourceManager.Instance.InitializeForColony(); // TODO: Implement this method

        if (ColonyUpgrades.Instance != null && PlayerController.LocalPlayer != null)
        {
            ColonyUpgrades.Instance.ApplyUpgradesToPlayer(PlayerController.LocalPlayer);
        }
    }

    private void OnRaidSceneLoaded()
    {
        // ResourceManager.Instance.InitializeForRaid(); // TODO: Implement this method
    }

    public void ReturnToMainMenu()
    {
        if (GameNetworkManager.Instance != null && GameNetworkManager.Instance.isNetworkActive)
        {
            GameNetworkManager.Instance.StopHost();
            GameNetworkManager.Instance.StopClient();
        }

        currentState = GameState.MainMenu;
        SceneManager.LoadScene("MainMenu");
    }
}
