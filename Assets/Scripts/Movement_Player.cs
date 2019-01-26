using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Player : MonoBehaviour {

    public float speed;
    private Vector2 updown = Vector2.zero;
    private Vector2 leftright = Vector2.zero;

    private Rigidbody2D rigid;

	// Use this for initialization
	void Start () {
        rigid = GetComponent<Rigidbody2D>();
        speed = 5;
	}
	
	// Update is called once per frame
	void Update () {
        
    }
    void FixedUpdate()
    {
        updown = Vector2.zero;
        leftright = Vector2.zero;
        if (Input.GetKey(KeyCode.W))
            updown = new Vector2(0, 1);
        if (Input.GetKey(KeyCode.S))
            updown = new Vector2(0, -1);
        if (Input.GetKey(KeyCode.A))
            leftright = new Vector2(-1, 0);
        if (Input.GetKey(KeyCode.D))
            leftright = new Vector2(1, 0);
        rigid.velocity = (leftright + updown) * speed;
        if (Input.anyKey == false)
            rigid.velocity = new Vector2(0, 0);
    }
}
