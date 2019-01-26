using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Enemy : MonoBehaviour {

    public float speed;
    private Rigidbody2D rigid;

    public float targetTime = 60.0f;

    // Use this for initialization
    void Start () {
        rigid = GetComponent<Rigidbody2D>();
        speed = 5;
    }
	
	// Update is called once per frame
	void Update () {



        targetTime -= Time.deltaTime;

        if (targetTime <= 0.0f)
        {
            timerEnded();
        }
    }

    private void timerEnded()
    {

    }
}
