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
        GameManager.levellevel = 0;
    }

    public void endGame()
    {
        Application.Quit();
    }

    public void main_menu()
    {
        SceneManager.LoadScene(0);
    }

    public void load_city()
    {
        SceneManager.LoadScene(2);
    }

    public void load_airport()
    {
        SceneManager.LoadScene(3);
    }

    public void load_woods()
    {
        SceneManager.LoadScene(4);
    }

    public void load_home()
    {
        SceneManager.LoadScene(5);
    }

}
