﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeChanger : MonoBehaviour {

    [SerializeField]
    private GameObject _shape;
    [SerializeField]
    private Sprite[] _polygon = new Sprite[6];
    private int[] _health = new int[] { 0, 1, 2, 3, 4, 5, 6 };
    private int i = 0;
    private int _condition;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(transform.tag == "Red")
        if(collision.gameObject.tag == "Green_Bullet")
        {
            i++;
                _condition = _health[i];
                if (_condition == 6)
                {
                    Destroy(collision.gameObject);
                    Destroy(_shape);
                }
                
            else
                {
                    GetComponent<SpriteRenderer>().sprite = _polygon[i];
                    Destroy(collision.gameObject);
                }
        }
        if (transform.tag == "Green")
            if (collision.gameObject.tag == "Red_Bullet")
            {
                i++;
                _condition = _health[i];
                if (_condition == 6)
                {
                    Destroy(collision.gameObject);
                    Destroy(_shape);
                }
                    
                else
                {
                    GetComponent<SpriteRenderer>().sprite = _polygon[i];
                    Destroy(collision.gameObject);
                }
            }
    }
}
