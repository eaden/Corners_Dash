using System.Collections;
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
    [SerializeField]
    private GameObject _bullet;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            i++;
           GetComponent<SpriteRenderer>().sprite = _polygon[i];
            Destroy(_bullet);
            _condition = _health[i];
            if (_condition == 6)
                Destroy(_shape);
        }
    }
}
