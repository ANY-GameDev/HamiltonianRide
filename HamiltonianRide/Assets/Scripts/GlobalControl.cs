using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalControl : MonoBehaviour
{
    float score;
    public static GlobalControl Instance;

    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
            score = 0;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    public float GetScore() { return score; }

    public void SetScore(float points)
    {
        score += points;
        if (score < 0)
        {
            score = 0;
        }
    }
}