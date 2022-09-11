using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_script : MonoBehaviour
{
    public int score;

    public Text scoreText;

    void Start()
    {
        scoreText.text = "Score:" + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score:" + score;
    }

    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Score"))
        {
            score += 10;
        }
    }
}
