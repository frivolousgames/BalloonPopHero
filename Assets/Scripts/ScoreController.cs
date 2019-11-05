using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public static int score;

    Text scoreText;
    public Text endScoreText;
    public Text highScoreText_end;
    public Text highScoreText_play;

    int highScore;

    public static bool powerUpTime;

    private void Awake()
    {
        scoreText = GetComponent<Text>();
        //score = 90;

    }

    private void Update()
    {
        scoreText.text = score.ToString();
        endScoreText.text = score.ToString();
        highScore = PlayerPrefs.GetInt("Highscore", 0);
        if(score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("Highscore", highScore);
        }
        highScoreText_end.text = highScore.ToString();
        highScoreText_play.text = highScore.ToString();

        //Debug.Log("Score " + score);
        if(score > 375)
        {
            powerUpTime = true;
        }
        else
        {
            powerUpTime = false;
        }

        Debug.Log("PU Time " + powerUpTime);
    }
}
