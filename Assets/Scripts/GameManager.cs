using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    private static GameManager _instance;

    public static GameManager Instance { get { return _instance; } }


    public static int levellevel = 0;

    public static bool firstLevel = false;
    public static bool secondLevel = false;
    public static bool thirdLevel = false;
    public static bool forthLevel = false;
    public static bool fifthLevel = false;

    private void Awake()
    {
        //DontDestroyOnLoad(gameObject);
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
