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
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        updateHighScore();
        scoreText.text = "" + score;
        highScoreText.text = "" + highScore;
    }

    void updateHighScore()
    {
        if (score > highScore)
            highScore = score;
    }
}
