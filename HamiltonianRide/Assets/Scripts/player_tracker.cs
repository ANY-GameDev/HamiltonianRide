﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_tracker : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(player.transform.position.x,
                                            player.transform.position.y,
                                            transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x,
                                            player.transform.position.y,
                                            transform.position.z);
    }
}
