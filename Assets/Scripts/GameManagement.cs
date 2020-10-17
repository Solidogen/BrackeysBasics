using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
{
    private bool gameHasEnded = false;
    private float restartDelay = 1f;

    public void EndGame()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            FindObjectOfType<HudManagement>().ShowPlayerDeath();
            Invoke(nameof(RestartGame), restartDelay);
        }
    }

    public void CompleteLevel()
    {
        FindObjectOfType<HudManagement>().ShowLevelCompleted();
        Invoke(nameof(RestartGame), restartDelay);
    }

    private void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
