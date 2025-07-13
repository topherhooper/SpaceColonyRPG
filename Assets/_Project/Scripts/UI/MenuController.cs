using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace SpaceColony.UI
{
    /// <summary>
    /// Simple menu controller that directly assigns button listeners
    /// Place this on the Canvas GameObject in MainMenu scene
    /// </summary>
    public class MenuController : MonoBehaviour
    {
        [Header("Main Menu Buttons")]
        [SerializeField] private Button soloColonyButton;
        [SerializeField] private Button joinRaidButton;
        [SerializeField] private Button hostRaidButton;
        [SerializeField] private Button settingsButton;
        [SerializeField] private Button quitButton;
        
        [Header("Join Raid Panel")]
        [SerializeField] private GameObject joinRaidPanel;
        [SerializeField] private Button connectButton;
        [SerializeField] private Button backFromJoinButton;
        
        [Header("Settings Panel")]
        [SerializeField] private GameObject settingsPanel;
        [SerializeField] private Button backFromSettingsButton;
        
        private void Start()
        {
            Debug.Log("[MenuController] Initializing menu buttons...");
            
            // Main menu buttons
            if (soloColonyButton != null)
            {
                soloColonyButton.onClick.RemoveAllListeners();
                soloColonyButton.onClick.AddListener(StartSoloColony);
                Debug.Log("[MenuController] Solo Colony button listener added");
            }
            else
            {
                Debug.LogError("[MenuController] Solo Colony button is null!");
            }
            
            if (joinRaidButton != null)
            {
                joinRaidButton.onClick.RemoveAllListeners();
                joinRaidButton.onClick.AddListener(ShowJoinRaidPanel);
            }
            
            if (hostRaidButton != null)
            {
                hostRaidButton.onClick.RemoveAllListeners();
                hostRaidButton.onClick.AddListener(HostRaid);
            }
            
            if (settingsButton != null)
            {
                settingsButton.onClick.RemoveAllListeners();
                settingsButton.onClick.AddListener(ShowSettings);
            }
            
            if (quitButton != null)
            {
                quitButton.onClick.RemoveAllListeners();
                quitButton.onClick.AddListener(QuitGame);
            }
            
            // Join panel buttons
            if (connectButton != null)
            {
                connectButton.onClick.RemoveAllListeners();
                connectButton.onClick.AddListener(ConnectToRaid);
            }
            
            if (backFromJoinButton != null)
            {
                backFromJoinButton.onClick.RemoveAllListeners();
                backFromJoinButton.onClick.AddListener(HideJoinRaidPanel);
            }
            
            // Settings panel buttons
            if (backFromSettingsButton != null)
            {
                backFromSettingsButton.onClick.RemoveAllListeners();
                backFromSettingsButton.onClick.AddListener(HideSettings);
            }
            
            // Ensure panels are hidden at start
            if (joinRaidPanel != null) joinRaidPanel.SetActive(false);
            if (settingsPanel != null) settingsPanel.SetActive(false);
        }
        
        private void StartSoloColony()
        {
            Debug.Log("[MenuController] StartSoloColony clicked!");
            
            // First try using UIManager if it exists
            if (UIManager.Instance != null)
            {
                Debug.Log("[MenuController] Using UIManager.StartSoloColony()");
                UIManager.Instance.StartSoloColony();
            }
            else
            {
                // Fallback: Direct scene load
                Debug.Log("[MenuController] UIManager not found, loading scene directly");
                
                // Check if ColonyScene is in build settings
                int sceneIndex = SceneUtility.GetBuildIndexByScenePath("Assets/_Project/Scenes/ColonyScene.unity");
                if (sceneIndex >= 0)
                {
                    Debug.Log($"[MenuController] Loading ColonyScene (index: {sceneIndex})");
                    SceneManager.LoadScene(sceneIndex);
                }
                else
                {
                    Debug.LogError("[MenuController] ColonyScene not found in build settings!");
                    // Try by name as last resort
                    SceneManager.LoadScene("ColonyScene");
                }
            }
        }
        
        private void ShowJoinRaidPanel()
        {
            Debug.Log("[MenuController] ShowJoinRaidPanel clicked!");
            if (joinRaidPanel != null)
            {
                joinRaidPanel.SetActive(true);
            }
            
            if (UIManager.Instance != null)
            {
                UIManager.Instance.ShowJoinRaidPanel();
            }
        }
        
        private void HideJoinRaidPanel()
        {
            Debug.Log("[MenuController] HideJoinRaidPanel clicked!");
            if (joinRaidPanel != null)
            {
                joinRaidPanel.SetActive(false);
            }
        }
        
        private void HostRaid()
        {
            Debug.Log("[MenuController] HostRaid clicked!");
            
            if (UIManager.Instance != null)
            {
                UIManager.Instance.HostRaid();
            }
            else if (GameNetworkManager.Instance != null)
            {
                // Direct network start
                GameNetworkManager.Instance.networkAddress = "localhost";
                GameNetworkManager.Instance.StartHost();
                SceneManager.LoadScene("RaidScene");
            }
        }
        
        private void ConnectToRaid()
        {
            Debug.Log("[MenuController] ConnectToRaid clicked!");
            
            // Get IP from input field if needed
            var inputField = joinRaidPanel?.GetComponentInChildren<TMPro.TMP_InputField>();
            if (inputField != null && GameNetworkManager.Instance != null)
            {
                string address = inputField.text;
                if (string.IsNullOrEmpty(address))
                {
                    address = "localhost";
                }
                
                Debug.Log($"[MenuController] Connecting to: {address}");
                GameNetworkManager.Instance.networkAddress = address;
                GameNetworkManager.Instance.StartClient();
            }
        }
        
        private void ShowSettings()
        {
            Debug.Log("[MenuController] ShowSettings clicked!");
            if (settingsPanel != null)
            {
                settingsPanel.SetActive(true);
            }
            
            if (UIManager.Instance != null)
            {
                UIManager.Instance.ShowSettingsPanel();
            }
        }
        
        private void HideSettings()
        {
            Debug.Log("[MenuController] HideSettings clicked!");
            if (settingsPanel != null)
            {
                settingsPanel.SetActive(false);
            }
        }
        
        private void QuitGame()
        {
            Debug.Log("[MenuController] QuitGame clicked!");
            
            if (UIManager.Instance != null)
            {
                UIManager.Instance.QuitGame();
            }
            else
            {
                #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
                #else
                Application.Quit();
                #endif
            }
        }
        
        // Auto-assign buttons if they're not assigned
        private void OnValidate()
        {
            if (soloColonyButton == null)
            {
                var buttons = GetComponentsInChildren<Button>(true);
                foreach (var button in buttons)
                {
                    if (button.name.Contains("SoloColony"))
                        soloColonyButton = button;
                    else if (button.name.Contains("JoinRaid") && !button.name.Contains("Back"))
                        joinRaidButton = button;
                    else if (button.name.Contains("HostRaid"))
                        hostRaidButton = button;
                    else if (button.name.Contains("Settings") && !button.name.Contains("Back"))
                        settingsButton = button;
                    else if (button.name.Contains("Quit"))
                        quitButton = button;
                    else if (button.name.Contains("Connect"))
                        connectButton = button;
                }
            }
            
            // Find panels
            if (joinRaidPanel == null)
            {
                var panels = GetComponentsInChildren<Transform>(true);
                foreach (var panel in panels)
                {
                    if (panel.name == "JoinRaidPanel")
                        joinRaidPanel = panel.gameObject;
                    else if (panel.name == "SettingsPanel")
                        settingsPanel = panel.gameObject;
                }
            }
        }
    }
}