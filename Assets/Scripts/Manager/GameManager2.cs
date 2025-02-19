using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager2 : MonoBehaviour
{
    static GameManager2 gameManager2;

    public static GameManager2 Instance
    {
        get { return gameManager2; }
    }

    private int currentScore = 0;

    UIManager uiManager;
    
    public UIManager UIManager
    {
        get { return uiManager; }
    }

    private void Awake()
    {
        gameManager2 = this;
        uiManager = FindObjectOfType<UIManager>();
    }

    // 재시작
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

   // 장애물 넘을시 점수 추가
    public void AddScore(int score)
    {
        currentScore += score;
        uiManager.UpdateScore(currentScore);
    }

    public void GameOver()
    {
        int bestScore = PlayerPrefs.GetInt("BestScore", 0);

        // 최고 점수 저장
        if (currentScore > bestScore)
        {
            PlayerPrefs.SetInt("BestScore", currentScore);
            PlayerPrefs.Save();
        }

        bestScore = PlayerPrefs.GetInt("BestScore");

        uiManager.ShowGameOverUI(currentScore, bestScore);
    }
}
