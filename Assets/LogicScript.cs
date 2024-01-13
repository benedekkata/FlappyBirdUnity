using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public PipeSpawnScript pipeSpawnScript;

    [ContextMenu("Increase Score")]
    public void addScore (int scoreToAdd) 
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void RestartGame()
    {
        gameOverScreen.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        pipeSpawnScript.StopPiepes();
        gameOverScreen.SetActive(true);
    }

    public void CloseGame()
    {
        Application.Quit();
    }
}
