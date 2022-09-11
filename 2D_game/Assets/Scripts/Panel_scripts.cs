using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Panel_scripts : MonoBehaviour
{

    public Button exit_game;
    public Button return_game;

    // Start is called before the first frame update
    void Start()
    {
        return_game.onClick.AddListener(Return_game);
        exit_game.onClick.AddListener(Exit_game);
    }

   
    public void Return_game()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit_game()
    {
        Application.Quit();
    }

}




