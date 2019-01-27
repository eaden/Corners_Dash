using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level_change : MonoBehaviour {

    public int levelToChangeTo = 2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Red")
        {
            GameManager.levellevel++;
            if(GameManager.levellevel>4)
                SceneManager.LoadScene(9);
            else
                SceneManager.LoadScene(levelToChangeTo);
            
            /*
            switch (levelToChangeTo)
            {
                case 0:
                    SceneManager.LoadScene();
                    break;
                default:
                    print("Hello");
                    break; 
            }
            if(levelToChangeTo == 0)
            */
        }
    }
}
