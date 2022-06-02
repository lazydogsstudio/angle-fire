using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GamePlayManager : MonoBehaviour
{

    private int totalScore = 0;
    private bool isGameOver = false;

    public Text totalScoreText;
    public GameObject gameOverPanel;

    void Update()
    {

        totalScoreText.text = totalScore.ToString();

        if (isGameOver)
        {
            gameOverPanel.SetActive(true);
        }
        else
        {
            gameOverPanel.SetActive(false);
        }

    }


    public void incrementScore()
    {
        totalScore++;
    }

    public void gameOver()
    {
        isGameOver = true;
    }

    public void reStart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
