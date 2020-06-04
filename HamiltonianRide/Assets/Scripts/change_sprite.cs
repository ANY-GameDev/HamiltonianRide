using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class change_sprite : MonoBehaviour
{
    SpriteRenderer SR;
    public Sprite newSprite;
    public GameObject vertex;
    private void Start()
    {
        SR = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        Vertex v = vertex.GetComponent<Vertex>();
        if (v.getMark()){
            ChangeSprite();
        }
           
    }

    void ChangeSprite()
    {
        SR.sprite = newSprite;
    }

}
