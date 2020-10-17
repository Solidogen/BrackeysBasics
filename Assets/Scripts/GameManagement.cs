using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
{
    private bool playedHasDied = false;
    private bool levelHasCompleted = false;
    private float restartDelay = 2f;
    private HudManagement hudManagement;

    void Awake()
    {
        hudManagement = FindObjectOfType<HudManagement>();
    }

    public void ScoreUpdated(string score)
    {
        hudManagement.ShowUpdatedScore(score);
    }

    public void PlayerDied()
    {
        if (!playedHasDied && !levelHasCompleted)
        {
            playedHasDied = true;
            hudManagement.ShowPlayerDeath();
            Invoke(nameof(RestartLevel), restartDelay);
        }
    }

    public void CompleteLevel()
    {
        if (!levelHasCompleted && !playedHasDied)
        {
            levelHasCompleted = true;
            hudManagement.ShowLevelCompleted();
        }
    }

    public void GoToNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
