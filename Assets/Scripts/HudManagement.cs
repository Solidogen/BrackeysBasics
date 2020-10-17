using UnityEngine;
using UnityEngine.UI;

public class HudManagement : MonoBehaviour
{
    [SerializeField]
    private Text scoreText = default;

    [SerializeField]
    private Text playerDeathText = default;

    [SerializeField]
    private GameObject levelCompletePanel = default;

    void Awake()
    {
        playerDeathText.gameObject.SetActive(false);
        levelCompletePanel.gameObject.SetActive(false);
    }

    public void ShowUpdatedScore(string score)
    {
        scoreText.text = score;
    }

    public void ShowPlayerDeath()
    {
        playerDeathText.gameObject.SetActive(true);
    }

    public void ShowLevelCompleted()
    {
        levelCompletePanel.gameObject.SetActive(true);
    }
}
