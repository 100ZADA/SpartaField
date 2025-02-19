using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI PlayscoreText;
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI BestScoreText;

    public GameObject gameOverPanel;

    public Button StartButton;
    public Button restartButton;

    // ���� �����
    public void Start()
    {
        gameOverPanel.SetActive(false);
        restartButton.onClick.AddListener(() => GameManager2.Instance.RestartGame());
    }

    public void UpdateScore(int score)
    {
        PlayscoreText.text = score.ToString();
        ScoreText.text = score.ToString();
    }

    // ���� ������ UI ������Ʈ
    public void ShowGameOverUI(int finalScore, int bestScore)
    {
        gameOverPanel.SetActive(true);

        PlayscoreText.text = finalScore.ToString();
        ScoreText.text = finalScore.ToString();
        BestScoreText.text = bestScore.ToString();
    }
}
