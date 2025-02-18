using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager2 : MonoBehaviour
{
    static GameManager2 gameManager2;

    public static GameManager2 Instance
    {
        get { return gameManager2; }
    }

    private int currentScore = 0;

    private void Awake()
    {
        gameManager2 = this;
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
