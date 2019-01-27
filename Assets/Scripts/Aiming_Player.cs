using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aiming_Player : MonoBehaviour {


    public int shootMode = 0;

    public GameObject bullet;
    private Rigidbody2D rigid;
    private Vector3 shotDirection = Vector3.zero;
    private Vector3 shotTarget = Vector3.zero;

    private float shot_wait_time_fest = 0.5f;
    public float shot_wait_time = 0.5f;
    private bool shotPossible = true;

    // Use this for initialization
    void Start () {
		rigid = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        
        shotDirection = Vector3.zero;
        shotTarget = Input.mousePosition;
        
        
        if(shotPossible == false)
        {
            shot_wait_time -= Time.deltaTime;
            if (shot_wait_time <= 0.0f)
            {
                shotPossible = true;
                shot_wait_time = shot_wait_time_fest;
            }
        }
        
        if (shotPossible && Input.GetMouseButtonDown(0))
        {
            shotPossible = false;
            
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
            if(shootMode == 0)
                current_bullet.GetComponent<Movement_Bullet>().direction_bullet = new Vector2(shootDirection.x+Random.Range(0,11)/20f-0.25f, shootDirection.y + Random.Range(0, 11) / 20f - 0.25f).normalized;
            if (shootMode == 1)
                current_bullet.GetComponent<Movement_Bullet>().direction_bullet = new Vector2(shootDirection.x + Random.Range(0, 11) / 10f - 0.5f, shootDirection.y + Random.Range(0, 11) / 10f - 0.5f).normalized;
            if (shootMode == 2)
                current_bullet.GetComponent<Movement_Bullet>().direction_bullet = new Vector2(shootDirection.x + Random.Range(0, 11) / 5f - 1f, shootDirection.y + Random.Range(0, 11) / 5f - 1f).normalized;

        }


    }
}
