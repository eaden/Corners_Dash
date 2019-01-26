using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeChanger : MonoBehaviour {

    [SerializeField]
    private GameObject _shape;
    [SerializeField]
    private Sprite[] _polygon = new Sprite[6];
    private int i = 0;
    [SerializeField]
    private GameObject _bullet;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            i++;
           GetComponent<SpriteRenderer>().sprite = _polygon[i];
            Destroy(_bullet);
        }
    }
}
