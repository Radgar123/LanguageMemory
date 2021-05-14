using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI highScoreText;
    [SerializeField] private TextMeshProUGUI scoreText;

    public static int highScore;
    public static int score;
    
    
    // Update is called once per frame
    void Update()
    {
        updateHighScore();
        scoreText.text = "Score: " + score;
        highScoreText.text = "High Score: " + highScore;
    }

    void updateHighScore()
    {
        if (score > highScore)
            highScore = score;
    }
}
