using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PointController : MonoBehaviour
{
    public TextMeshProUGUI highScoreText;
    public TextMeshProUGUI scoreText;

    public static int highScore;
    public static int score;

    public static int actualCards = 0;
    public static int requiredAmound = 8;


    void Start()
    {
        score = PlayerPrefs.GetInt("Score", 0);
        highScoreText.text = "High score: " +  PlayerPrefs.GetInt("HighScore", 0).ToString();
        scoreText = GameObject.FindGameObjectWithTag("PointController").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        updateHighScore();
        scoreText.text = "Score: " + score;
    }

    void updateHighScore()
    {
        PlayerPrefs.SetInt("Score", score);

        if (score > PlayerPrefs.GetInt("HighScore", 0)) 
        {
            PlayerPrefs.SetInt("HighScore", score);
            highScoreText.text = "High score: " + score;
        }
            
    }

    public static void Reset() 
    {
        PlayerPrefs.DeleteKey("Score");
    }

   
}
