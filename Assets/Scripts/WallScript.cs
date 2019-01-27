﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Green_Bullet" || collision.gameObject.tag == "Red_Bullet")
        {
            Destroy(collision.gameObject);
        }
    }
}