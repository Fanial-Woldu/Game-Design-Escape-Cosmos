using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour //Created by Bryan Castaneda
{

    public GameObject gameOverUI;  // Reference to the actual UI GameObject

    
    public void gameOver()
    {
        gameOverUI.SetActive(true);
    }

    public void RestartGame()
    {
        // Reset the last checkpoint
        Checkpoint.lastCheckpointPosition = Vector3.zero;
        SceneManager.LoadSceneAsync(1);
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }

    public void TakeQuiz()
    {
        SceneManager.LoadSceneAsync(2);
    }
}
