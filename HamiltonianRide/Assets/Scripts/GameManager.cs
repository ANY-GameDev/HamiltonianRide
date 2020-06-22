﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


enum OverReason
{
    lostCovid,
    lostVertex,
    won
}
public class GameManager : MonoBehaviour
{
    int numberOfVertices;
    OverReason overReason;
    bool isGameOver;
    GameObject gameOverPanel;
    Dictionary<OverReason, string> reason2msg;

    void Start()
    {
        InitLevel();
        Initreason2msg();

    }

    private void InitLevel()
    {
        isGameOver = false;
        foreach (GameObject go in Resources.FindObjectsOfTypeAll(typeof(GameObject)) as GameObject[])
        {
            if (go.tag == "GameOverPanel")
            {
                gameOverPanel = go;
            }
        }
        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(false);
        }
        numberOfVertices = GameObject.FindGameObjectsWithTag("Vertex").Length;

    }

    void Update()
    {
        if (isGameOver)
        {
            gameOverPanel.SetActive(true);
            if (overReason == OverReason.won)
            {
                gameOverPanel.GetComponentInChildren<Text>().color = Color.green;
            }
        }
    }

    private void Initreason2msg()
    {
        reason2msg = new Dictionary<OverReason, string>();
        reason2msg.Add(OverReason.lostCovid, "Game over - Covid infected");
        reason2msg.Add(OverReason.lostVertex, "Game over - Visited vertex twice");
        reason2msg.Add(OverReason.won, "Congrats - You won the level");

    }

    public void UpdateNumberOfVertices()
    {
        numberOfVertices--;
        if (numberOfVertices <= 0)
        {
            overReason = OverReason.won;
            GameOver((int)overReason);
            Debug.Log("Game won");
        }
    }
    public void GameOver(int reason)
    {
        Debug.Log("Game Over");
        overReason = (OverReason)reason;
        gameOverPanel.GetComponentInChildren<Text>().text = reason2msg[overReason];
        if (overReason == OverReason.won)
        {
            Invoke("NextLevel", 2);
        }
        else
        {
            Invoke("Restart", 2);
        }
        isGameOver = true;
    }

    public bool GetIsGameOver()
    {
        return isGameOver;
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
