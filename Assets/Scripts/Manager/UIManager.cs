using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText1;
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI BestScoreText;

    public GameObject gameOverPanel;

    public Button restartButton;

    public void Start()
    {
        gameOverPanel.SetActive(false);
        restartButton.onClick.AddListener(() => GameManager2.Instance.RestartGame());
    }

    public void UpdateScore(int score)
    {
        scoreText1.text = score.ToString();
    }

    public void ShowGameOverUI(int finalScore)
    {
        gameOverPanel.SetActive(true);
        BestScoreText.text = finalScore.ToString();
    }
}
