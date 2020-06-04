using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    [SerializeField]
    GameObject gameOverPanel;
    Dictionary<OverReason, string> reason2msg;

    void Start()
    {
        Initreason2msg();
        isGameOver = false;
        gameOverPanel.SetActive(false);
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

    // Update is called once per frame
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
        isGameOver = true;
    }

    public bool GetIsGameOver()
    {
        return isGameOver;
    }
}
