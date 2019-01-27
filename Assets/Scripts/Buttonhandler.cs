using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttonhandler : MonoBehaviour {

    public void newGame()
    {
        SceneManager.LoadScene(1);
    }

    public void level_select()
    {
        SceneManager.LoadScene(6);
    }

    public void endGame()
    {
        Application.Quit();
    }
}
