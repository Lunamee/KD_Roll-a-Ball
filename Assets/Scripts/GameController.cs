using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    // Panel
    [SerializeField] GameObject PlayPanel;
    [SerializeField] GameObject MenuPanel;
    [SerializeField] GameObject GameOverPanel;
    [SerializeField] GameObject GameClearPanel;
    [SerializeField] GameObject TimerPanel;

    // Button
    [SerializeField] GameObject StartButton;
    [SerializeField] GameObject PauseButton;

    public ButtonColorController buttonColorController;
    public TimeController timeController;


    private void Start()
    {
        Time.timeScale = 1.0f;

        PlayPanel.SetActive(true);
        TimerPanel.SetActive(true);
        MenuPanel.SetActive(false);
        GameOverPanel.SetActive(false);
        GameClearPanel.SetActive(false);
    }

    public void OnMenuButtonClicked()
    {
        PlayPanel.SetActive(true);
        MenuPanel.SetActive(false);
    }

    public void OnPlayButtonClicked()
    {
        PlayPanel.SetActive(false);
        MenuPanel.SetActive(true);
    }

    public void OnPauseButtonClicked()
    {
        Time.timeScale = 0f;
        PauseButton.SetActive(false);
        StartButton.SetActive(true);
    }

    public void OnStartButtonClicked()
    {
        Time.timeScale = 1f;
        PauseButton.SetActive(true);
        StartButton.SetActive(false);

    }

    public void SelectGameOverDescription()
    {
        GameOverPanel.SetActive(true);
        PlayPanel.SetActive(false);
        MenuPanel.SetActive(false);
        TimerPanel.SetActive(false);

        timeController.timerflag = false;
    }

    public void SelectGameClearDescription()
    {
        GameClearPanel.SetActive(true);
        TimerPanel.SetActive(false);
        PlayPanel.SetActive(false);
        MenuPanel.SetActive(false);
    }

    public void ReturnTittle()
    {        
        SceneManager.LoadScene("titlescene");
    }

    public void ReturnStart()
    {
        Scene loadScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(loadScene.name);
    }
}
