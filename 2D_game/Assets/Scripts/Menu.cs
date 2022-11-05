using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{

    public string SceneName;

    public Button play;
    public Button exit;

    // Start is called before the first frame update
    void Start()
    {
        play.onClick.AddListener(Play_game);

        exit.onClick.AddListener(Exit_game);
    }

    public void Play_game()
    {
        SceneManager.LoadScene(SceneName);
    }

    public void Exit_game()
    {
        Application.Quit();
    }

}
   
