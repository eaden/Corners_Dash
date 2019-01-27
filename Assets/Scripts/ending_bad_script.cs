using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ending_bad_script : MonoBehaviour {

    private float text_time = 25f;
    public Text text;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        text_time -= Time.deltaTime;
        if (text_time <= 20.0f)
        {
            text.text = "Honey?";
        }
        if (text_time <= 15.0f)
        {
            text.text = "I'm...";
        }
        if (text_time <= 10.0f)
        {
            text.text = "Home.";
        }
        if (text_time <= 5.0f && GameManager.levellevel>4)
        {
            text.text = "You did it. I missed you. Welcome home.";
        }
    }
}
