using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TutorialManager : MonoBehaviour
{
    [Header("Tutorial Panels")]
    public GameObject[] tutorialPanels;
    public GameObject tutorialContainer;
    
    [Header("UI Elements")]
    public Button nextButton;
    public Button previousButton;
    public Button skipButton;
    public Text pageIndicatorText;
    
    private int currentPanel = 0;
    private const string TUTORIAL_COMPLETE_KEY = "TutorialComplete";
    
    void Start()
    {
        if (PlayerPrefs.GetInt(TUTORIAL_COMPLETE_KEY, 0) == 0)
        {
            ShowTutorial();
        }
        else
        {
            if (tutorialContainer != null)
                tutorialContainer.SetActive(false);
        }
    }
    
    public void ShowTutorial()
    {
        if (tutorialContainer != null)
            tutorialContainer.SetActive(true);
        
        currentPanel = 0;
        ShowPanel(currentPanel);
        UpdateButtons();
    }
    
    void ShowPanel(int index)
    {
        for (int i = 0; i < tutorialPanels.Length; i++)
        {
            if (tutorialPanels[i] != null)
                tutorialPanels[i].SetActive(i == index);
        }
        
        UpdatePageIndicator();
    }
    
    public void NextPanel()
    {
        if (currentPanel < tutorialPanels.Length - 1)
        {
            currentPanel++;
            ShowPanel(currentPanel);
            UpdateButtons();
            
            if (AudioManager.Instance != null)
                AudioManager.Instance.PlayButtonClick();
        }
        else
        {
            CompleteTutorial();
        }
    }
    
    public void PreviousPanel()
    {
        if (currentPanel > 0)
        {
            currentPanel--;
            ShowPanel(currentPanel);
            UpdateButtons();
            
            if (AudioManager.Instance != null)
                AudioManager.Instance.PlayButtonClick();
        }
    }
    
    public void SkipTutorial()
    {
        CompleteTutorial();
    }
    
    void CompleteTutorial()
    {
        PlayerPrefs.SetInt(TUTORIAL_COMPLETE_KEY, 1);
        PlayerPrefs.Save();
        
        if (tutorialContainer != null)
            tutorialContainer.SetActive(false);
        
        if (AudioManager.Instance != null)
            AudioManager.Instance.PlayButtonClick();
    }
    
    void UpdateButtons()
    {
        if (previousButton != null)
            previousButton.interactable = currentPanel > 0;
        
        if (nextButton != null)
        {
            Text nextText = nextButton.GetComponentInChildren<Text>();
            if (nextText != null)
            {
                nextText.text = currentPanel < tutorialPanels.Length - 1 ? "Next" : "Finish";
            }
        }
    }
    
    void UpdatePageIndicator()
    {
        if (pageIndicatorText != null)
        {
            pageIndicatorText.text = $"{currentPanel + 1} / {tutorialPanels.Length}";
        }
    }
    
    public void ResetTutorial()
    {
        PlayerPrefs.SetInt(TUTORIAL_COMPLETE_KEY, 0);
        PlayerPrefs.Save();
    }
}