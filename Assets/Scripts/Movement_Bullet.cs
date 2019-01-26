using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Bullet : MonoBehaviour {

    public Vector2 direction_bullet = Vector2.zero;
    public float speed;

    private Rigidbody2D rigid;
	// Use this for initialization
	void Start () {
        rigid = GetComponent<Rigidbody2D>();
        speed = 4;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        rigid.velocity = direction_bullet * speed;

        // by Kollision mit Levenende zerstören
    }
}
