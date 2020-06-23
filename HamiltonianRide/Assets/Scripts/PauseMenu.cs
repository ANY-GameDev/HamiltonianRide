using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField]
    [Tooltip("A key to pause the game in addition to escape")]
    KeyCode keyCode;
    public static bool gameIsPaused = false;
    public GameObject PauseMenuUI;

    void Update()
    {
        if (Input.GetKeyDown(keyCode) || Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }

    public void Pause()
    {
        gameIsPaused = !gameIsPaused;
        PauseMenuUI.SetActive(gameIsPaused);
        Time.timeScale = gameIsPaused ? 0f : 1f;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Pause();
    }
}