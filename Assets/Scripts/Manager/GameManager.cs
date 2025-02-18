using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static GameManager gameManager;

    public static GameManager Instance
    {
        get { return gameManager; }
    }

    public PlayerController player { get; private set; }

    // MiniScene���� ���
    private int currentScore = 0;

    private void Awake()
    {
        gameManager = this;
        player = FindObjectOfType<PlayerController>();
        player.Init(this);
    }

    public void GameOver()
    {
        Debug.Log("Game Over");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void AddScore(int score)
    {
        currentScore += score;

        Debug.Log("Score : " + currentScore);
    }
}
