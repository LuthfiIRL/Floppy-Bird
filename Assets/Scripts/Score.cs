using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
    public static Score Instance;

    [SerializeField] private TextMeshPro currentScoreText;
    [SerializeField] private TextMeshPro highScoreText;
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
            PlayerPrefs.SetInt("HighSco", scoreText);
            highScoreText.text = scoreText.ToString();
        }
    }
}
