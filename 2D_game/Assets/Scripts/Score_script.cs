using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_script : MonoBehaviour
{
    public int score;
    public int score_record;

    public Text scoreText;
    public Text record_score_Text;

    void Start()
    {
        scoreText.text = "Score:" + score_record.ToString();
        record_score_Text.text = "Record_score:" + scoreText.text;
    }

    void Update()
    {
        score_record = score;
        scoreText.text = score_record.ToString();

        if (PlayerPrefs.GetInt("score") <= score_record)
        {
            PlayerPrefs.SetInt("score", score_record);
        }

        record_score_Text.text = "Record_score: " + PlayerPrefs.GetInt("score").ToString();
    }



    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Score"))
        {
            score += 10;
        }
    }
}
