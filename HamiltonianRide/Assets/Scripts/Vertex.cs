using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vertex : MonoBehaviour
{
    bool isMarked;
    [SerializeField]
    GameManager gm;
    void Start()
    {
        isMarked = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (isMarked)
            {
                gm.GameOver(1);
            }
            else
            {
                isMarked = true;
                gm.UpdateNumberOfVertices();
                Debug.Log("Reached vertex");

            }
        }
    }
}
