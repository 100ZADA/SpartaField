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

    // �����
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

   // ��ֹ� ������ ���� �߰�
    public void AddScore(int score)
    {
        currentScore += score;
        uiManager.UpdateScore(currentScore);
    }

    public void GameOver()
    {
        int bestScore = PlayerPrefs.GetInt("BestScore", 0);

        // �ְ� ���� ����
        if (currentScore > bestScore)
        {
            PlayerPrefs.SetInt("BestScore", currentScore);
            PlayerPrefs.Save();
        }

        bestScore = PlayerPrefs.GetInt("BestScore");

        uiManager.ShowGameOverUI(currentScore, bestScore);
    }
}
