using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverMenu : MonoBehaviour
{
    public GameObject gameOverUI;
    public static GameOverMenu instance;
    public string level;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de GameOverMenu dans la scène");
            return;
        }

        instance = this;
    }
    private void Start()
    {
        gameOverUI.SetActive(false);
    }
    public void OnPlayerDeath()
    {
        gameOverUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RetryButton()
    {
        Time.timeScale = 1f;
        Debug.Log("Refresh scene");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        gameOverUI.SetActive(false);
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene(level);
        Time.timeScale = 1f;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
