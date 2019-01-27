using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ending_move_bad : MonoBehaviour {

    public GameObject bullet;

    public float ENEMYSHOOTSCALE = 0f;

    public float speed;
    private Rigidbody2D rigid;
    private int behaviour;

    private float walkTime = 1.0f;
    private float stopTime;
    private float stopTime_init;
    bool isWalking = false;

    private float shootingTime;
    public bool shootHimNow = true;

    Vector2 enemy_dir_random = Vector2.zero;

    // Use this for initialization
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        speed = 3;
        behaviour = Random.Range(0, 2);
        stopTime = Random.Range(0, 15) / 10f;
        stopTime_init = stopTime;
        walkTime = Random.Range(0, 20) / 10f;

        shootingTime = 20f;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        shootingTime -= Time.deltaTime;
        if (shootingTime <= 0.0f)
        {
            if(shootHimNow)
            {
                shootHim(behaviour);
                if (GameManager.levellevel < 5)
                    shootHimNow = false;
                else
                    shootingTime = 0.5f;
            }
            
        }
    }

    void shootHim(int behaviour)
    {
        Vector3 shootDirection;
        shootDirection = (GameManager.Instance.gameObject.transform.position - gameObject.transform.position).normalized;

        GameObject current_bullet = Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, Mathf.Atan2(shootDirection.y, shootDirection.x) * Mathf.Rad2Deg - 90));
        current_bullet.transform.localScale += new Vector3(ENEMYSHOOTSCALE, ENEMYSHOOTSCALE, ENEMYSHOOTSCALE);

        current_bullet.GetComponent<Movement_Bullet>().direction_bullet = new Vector2(shootDirection.x, shootDirection.y).normalized;

    }

    void actOnBehaviour(int behaviour)
    {

        walkTime -= Time.deltaTime;

        if (walkTime <= 0.0f)
        {
            isWalking = false;
            walkTime = Random.Range(0, 20) / 10f;
            if (behaviour == 1)
                enemy_dir_random = new Vector2(Random.Range(0, 21) / 10f - 1, Random.Range(0, 21) / 10f - 1).normalized;
        }



        if (behaviour == 0)
        {
            Vector3 enemy_dir = (GameManager.Instance.gameObject.transform.position - gameObject.transform.position).normalized;
            rigid.velocity = enemy_dir * speed;
        }

        if (behaviour == 1)
        {
            rigid.velocity = enemy_dir_random * speed;
        }

    }
}
