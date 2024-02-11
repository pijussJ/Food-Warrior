using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static int score;
    public TextMeshProUGUI scoreText;


    void Awake()
    {
        score = 0;
    }
    void Update()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString(); // Update the score text with the current score value
        }
    }
}
