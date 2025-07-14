using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using SpaceColonyRPG.Colony;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    
    [Header("Panels")]
    public GameObject mainMenuPanel;
    public GameObject colonyHUD;
    public GameObject raidHUD;
    public GameObject raidPrepPanel;
    public GameObject gameOverPanel;
    public GameObject buildingTooltip;
    public GameObject joinRaidPanel;
    public GameObject settingsPanel;
    public GameObject victoryDefeatPanel;
    public GameObject buildingPanel;
    
    [Header("Colony UI")]
    public Text metalText;
    public Text energyText;
    public Text foodText;
    public Text colonistCountText;
    public GameObject buildModeIndicator;
    
    [Header("Raid UI")]
    public Text timerText;
    public Text enemiesText;
    public Slider healthBar;
    public Text healthText;
    public Text levelText;
    public Slider xpBar;
    public Text xpText;
    
    [Header("Game Over UI")]
    public GameObject victoryPanel;
    public GameObject defeatPanel;
    public Text victoryMetalText;
    public Text victoryEnergyText;
    public Text defeatMessageText;
    
    [Header("Raid Prep UI")]
    public Transform upgradeButtonContainer;
    public GameObject upgradeButtonPrefab;
    public Text joinCodeText;
    public InputField ipAddressInput;
    public InputField ipInputField;
    
    void Awake()
    {
        Instance = this;
    }
    
    void Start()
    {
        // In main menu scene, we don't need GameStateManager
        string currentScene = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;
        
        if (currentScene == "MainMenu")
        {
            // Main menu is already set up in the scene
            Debug.Log("UIManager: MainMenu scene loaded");
        }
        else if (GameStateManager.Instance != null)
        {
            ShowPanel(GameStateManager.Instance.currentState);
        }
    }
    
    public void ShowPanel(GameStateManager.GameState state)
    {
        HideAllPanels();
        
        switch (state)
        {
            case GameStateManager.GameState.MainMenu:
                if (mainMenuPanel != null) mainMenuPanel.SetActive(true);
                break;
            case GameStateManager.GameState.Colony:
                if (colonyHUD != null) colonyHUD.SetActive(true);
                break;
            case GameStateManager.GameState.InRaid:
                if (raidHUD != null) raidHUD.SetActive(true);
                break;
        }
    }
    
    void HideAllPanels()
    {
        if (mainMenuPanel != null) mainMenuPanel.SetActive(false);
        if (colonyHUD != null) colonyHUD.SetActive(false);
        if (raidHUD != null) raidHUD.SetActive(false);
        if (raidPrepPanel != null) raidPrepPanel.SetActive(false);
        if (gameOverPanel != null) gameOverPanel.SetActive(false);
    }
    
    public void UpdateResourceDisplay()
    {
        if (ResourceManager.Instance == null) return;
        
        // For now, use dummy values until we integrate with proper ResourceManager
        if (metalText != null)
            metalText.text = $"Metal: 0";
        
        if (energyText != null)
            energyText.text = $"Energy: 0";
        
        if (foodText != null)
            foodText.text = $"Food: 0";
    }
    
    public void UpdateColonistCount(int count)
    {
        if (colonistCountText != null)
            colonistCountText.text = $"Colonists: {count}";
    }
    
    public void UpdateBuildModeIndicator(bool isBuilding)
    {
        if (buildModeIndicator != null)
            buildModeIndicator.SetActive(isBuilding);
    }
    
    public void UpdateRaidTimer(float timeRemaining)
    {
        if (timerText != null)
        {
            int minutes = Mathf.FloorToInt(timeRemaining / 60);
            int seconds = Mathf.FloorToInt(timeRemaining % 60);
            timerText.text = $"Time: {minutes:00}:{seconds:00}";
        }
    }
    
    public void UpdateEnemyCount(int count)
    {
        if (enemiesText != null)
            enemiesText.text = $"Enemies: {count}";
    }
    
    public void UpdateHealthDisplay(int current, int max)
    {
        if (healthBar != null)
        {
            healthBar.maxValue = max;
            healthBar.value = current;
        }
        
        if (healthText != null)
            healthText.text = $"{current}/{max}";
    }
    
    public void UpdatePlayerLevel(int level)
    {
        if (levelText != null)
            levelText.text = $"Level {level}";
    }
    
    public void UpdateExperience(int current, int needed)
    {
        if (xpBar != null)
        {
            xpBar.maxValue = needed;
            xpBar.value = current;
        }
        
        if (xpText != null)
            xpText.text = $"XP: {current}/{needed}";
    }
    
    public void ShowRaidPrepPanel()
    {
        if (raidPrepPanel != null)
        {
            raidPrepPanel.SetActive(true);
            UpdateUpgradeButtons();
            
            if (joinCodeText != null)
                joinCodeText.text = $"Join Code: {GetLocalIPAddress()}";
        }
    }
    
    void UpdateUpgradeButtons()
    {
        foreach (Transform child in upgradeButtonContainer)
        {
            Destroy(child.gameObject);
        }
        
        if (ColonyUpgrades.Instance == null || upgradeButtonPrefab == null) return;
        
        for (int i = 0; i < ColonyUpgrades.Instance.availableUpgrades.Count; i++)
        {
            ColonyUpgrades.Upgrade upgrade = ColonyUpgrades.Instance.availableUpgrades[i];
            GameObject button = Instantiate(upgradeButtonPrefab, upgradeButtonContainer);
            
            Text nameText = button.transform.Find("NameText")?.GetComponent<Text>();
            if (nameText != null) nameText.text = upgrade.name;
            
            Text descText = button.transform.Find("DescriptionText")?.GetComponent<Text>();
            if (descText != null) descText.text = upgrade.description;
            
            Text costText = button.transform.Find("CostText")?.GetComponent<Text>();
            if (costText != null)
            {
                string cost = "";
                if (upgrade.metalCost > 0) cost += $"Metal: {upgrade.metalCost} ";
                if (upgrade.energyCost > 0) cost += $"Energy: {upgrade.energyCost}";
                costText.text = cost;
            }
            
            Button btn = button.GetComponent<Button>();
            int index = i;
            btn.onClick.AddListener(() => OnUpgradeButtonClicked(index));
            
            btn.interactable = !upgrade.purchased && ColonyUpgrades.Instance.CanPurchaseUpgrade(index);
            
            if (upgrade.purchased)
            {
                Text purchasedText = button.transform.Find("PurchasedText")?.GetComponent<Text>();
                if (purchasedText != null) purchasedText.gameObject.SetActive(true);
            }
        }
    }
    
    void OnUpgradeButtonClicked(int index)
    {
        if (ColonyUpgrades.Instance != null)
        {
            ColonyUpgrades.Instance.PurchaseUpgrade(index);
            UpdateUpgradeButtons();
            UpdateResourceDisplay();
        }
    }
    
    public void ShowVictoryScreen(int metalGained, int energyGained)
    {
        if (gameOverPanel != null) gameOverPanel.SetActive(true);
        if (victoryPanel != null) victoryPanel.SetActive(true);
        if (defeatPanel != null) defeatPanel.SetActive(false);
        
        if (victoryMetalText != null)
            victoryMetalText.text = $"Metal Gained: +{metalGained}";
        
        if (victoryEnergyText != null)
            victoryEnergyText.text = $"Energy Gained: +{energyGained}";
    }
    
    public void ShowDefeatScreen()
    {
        if (gameOverPanel != null) gameOverPanel.SetActive(true);
        if (victoryPanel != null) victoryPanel.SetActive(false);
        if (defeatPanel != null) defeatPanel.SetActive(true);
        
        if (defeatMessageText != null)
            defeatMessageText.text = "The raid was unsuccessful. Return to your colony and try again!";
    }
    
    public void OnStartNewGameClicked()
    {
        GameStateManager.Instance?.StartNewGame();
    }
    
    public void OnContinueGameClicked()
    {
        GameStateManager.Instance?.ContinueGame();
    }
    
    public void OnHostRaidClicked()
    {
        GameStateManager.Instance?.StartRaid(true);
        if (raidPrepPanel != null) raidPrepPanel.SetActive(false);
    }
    
    public void OnJoinRaidClicked()
    {
        string address = ipAddressInput != null ? ipAddressInput.text : "localhost";
        GameStateManager.Instance?.StartRaid(false, address);
        if (raidPrepPanel != null) raidPrepPanel.SetActive(false);
    }
    
    public void OnReturnToColonyClicked()
    {
        // This is typically called automatically after raid ends
        // For manual return, we end the raid as a defeat
        GameStateManager.Instance?.EndRaid(false);
    }
    
    public void OnMainMenuClicked()
    {
        GameStateManager.Instance?.ReturnToMainMenu();
    }
    
    public void ShowBuildingTooltip(Building building, Vector3 worldPos)
    {
        if (buildingTooltip == null) return;
        
        buildingTooltip.SetActive(true);
        
        Vector3 screenPos = Camera.main.WorldToScreenPoint(worldPos);
        buildingTooltip.transform.position = screenPos + Vector3.up * 50f;
        
        Text nameText = buildingTooltip.transform.Find("NameText")?.GetComponent<Text>();
        if (nameText != null) nameText.text = building.buildingData ? building.buildingData.buildingName : "Unknown";
        
        Text progressText = buildingTooltip.transform.Find("ProgressText")?.GetComponent<Text>();
        if (progressText != null)
        {
            if (!building.isActive)
            {
                progressText.text = "Under Construction";
            }
            else if (building.buildingData && building.buildingData.resourceProduction.Length > 0)
            {
                var production = building.buildingData.resourceProduction[0];
                progressText.text = $"Producing: {production.amountPerMinute} {production.resourceType}/min";
            }
            else
            {
                progressText.text = "Operational";
            }
        }
    }
    
    public void HideBuildingTooltip()
    {
        if (buildingTooltip != null)
            buildingTooltip.SetActive(false);
    }
    
    string GetLocalIPAddress()
    {
        try
        {
            var host = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
        }
        catch (System.Exception)
        {
            // Fallback if we can't get IP
        }
        return "localhost";
    }
    
    // Menu navigation methods
    public void StartSoloColony()
    {
        Debug.Log("StartSoloColony button clicked");
        if (GameNetworkManager.Instance != null)
        {
            GameNetworkManager.Instance.StartSoloColony();
        }
        else
        {
            Debug.LogError("GameNetworkManager.Instance is null!");
        }
    }
    
    public void ShowJoinRaidPanel()
    {
        Debug.Log("ShowJoinRaidPanel button clicked");
        if (joinRaidPanel != null) joinRaidPanel.SetActive(true);
        if (mainMenuPanel != null) mainMenuPanel.SetActive(false);
    }
    
    public void HideJoinRaidPanel()
    {
        if (joinRaidPanel != null) joinRaidPanel.SetActive(false);
        if (mainMenuPanel != null) mainMenuPanel.SetActive(true);
    }
    
    public void HostRaid()
    {
        Debug.Log("HostRaid button clicked");
        if (GameNetworkManager.Instance != null)
        {
            GameNetworkManager.Instance.HostRaid();
        }
        else
        {
            Debug.LogError("GameNetworkManager.Instance is null!");
        }
    }
    
    public void ConnectToHost()
    {
        Debug.Log("ConnectToHost button clicked");
        string ipAddress = ipInputField != null ? ipInputField.text : "localhost";
        Debug.Log($"Attempting to connect to: {ipAddress}");
        
        if (GameNetworkManager.Instance != null)
        {
            GameNetworkManager.Instance.JoinRaid(ipAddress);
        }
        else
        {
            Debug.LogError("GameNetworkManager.Instance is null!");
        }
    }
    
    public void ShowSettingsPanel()
    {
        if (settingsPanel != null) settingsPanel.SetActive(true);
        if (mainMenuPanel != null) mainMenuPanel.SetActive(false);
    }
    
    public void HideSettingsPanel()
    {
        if (settingsPanel != null) settingsPanel.SetActive(false);
        if (mainMenuPanel != null) mainMenuPanel.SetActive(true);
    }
    
    public void QuitGame()
    {
        Debug.Log("QuitGame button clicked");
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif
    }
}