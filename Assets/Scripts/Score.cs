using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
    public static Score Instance;

    [SerializeField] private TextMeshProUGUI currentScoreText;
    [SerializeField] private TextMeshProUGUI highScoreText;
    private int scoreText;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void Start()
    {
        currentScoreText.text = scoreText.ToString();
        highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    private void UpdateHighScore()
    {
        if (scoreText > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", scoreText);
            highScoreText.text = scoreText.ToString();
        }
    }

    public void UpdateScore()
    {
        scoreText++;
        currentScoreText.text = scoreText.ToString();
        UpdateHighScore();
    }
}
