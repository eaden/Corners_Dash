﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aiming_Player : MonoBehaviour {

    public GameObject bullet;
    private Rigidbody2D rigid;
    private Vector3 shotDirection = Vector3.zero;
    private Vector3 shotTarget = Vector3.zero;

	// Use this for initialization
	void Start () {
		rigid = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        shotDirection = Vector3.zero;
        shotTarget = Input.mousePosition;
        if (Input.GetMouseButtonDown(0))
        {
            /*
            shotDirection = shotTarget - transform.position;
            Vector2 v2_direction = new Vector2(shotDirection.x, shotDirection.y);
            print(v2_direction);
            GameObject current_bullet = Instantiate(bullet, transform.position, Quaternion.identity);
            current_bullet.GetComponent<Movement_Bullet>().direction_bullet = v2_direction;
            */

            Vector3 shootDirection;
            shootDirection = Input.mousePosition;
            shootDirection.z = 0.0f;
            shootDirection = Camera.main.ScreenToWorldPoint(shootDirection);
            shootDirection.z = 0.0f;
            shootDirection = (shootDirection - transform.position).normalized;
            shootDirection.z = 0.0f;
            // print(transform.position);
            //print(shootDirection);
            

            GameObject current_bullet = Instantiate(bullet, transform.position, Quaternion.Euler(0,0, Mathf.Atan2(shootDirection.y, shootDirection.x) * Mathf.Rad2Deg - 90));
            current_bullet.GetComponent<Movement_Bullet>().direction_bullet = new Vector2(shootDirection.x, shootDirection.y);

        }


    }
}
