using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering.PostProcessing;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public Text highScoreText;
    public GameObject gameOverScreen;
    public PipeSpawnScript pipeSpawnScript;
    private PostProcessVolume ppv;

    private void Start()
    {
        highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        ppv = Camera.main.gameObject.GetComponent<PostProcessVolume>();
    }

    [ContextMenu("Increase Score")]
    public void addScore (int scoreToAdd) 
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
        if (playerScore > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", playerScore);
            highScoreText.text = playerScore.ToString();
        }
        
    }

    public void RestartGame()
    {
        ppv.enabled = false;
        gameOverScreen.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        pipeSpawnScript.StopPiepes();
        gameOverScreen.SetActive(true);
        ppv.enabled = true;
    }

    public void CloseGame()
    {
        Application.Quit();
    }
}
