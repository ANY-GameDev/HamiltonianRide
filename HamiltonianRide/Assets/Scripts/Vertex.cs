using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Vertex : MonoBehaviour
{
    SpriteRenderer SR;
    public Sprite newSprite;
    bool isMarked;
    [SerializeField]
    GameManager gm;
    void Start()
    {
        SR = GetComponent<SpriteRenderer>();
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        isMarked = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public bool getMark()
    {
        return isMarked;
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
                changeSprite();
                gm.UpdateNumberOfVertices();
                Debug.Log("Reached vertex");

            }
        }
    }

    void changeSprite()
    {
        SR.sprite = newSprite;
    }
}
