﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Get player object information
    public GameObject Player;
    private Vector3 cameraOffset;

    // Start is called before the first frame update
    void Start()
    {
        // Camera offset from player
        cameraOffset.Set(0, 5, -7);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.transform.position + cameraOffset;
    }
}