using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField]
    private Transform playerTransform = default;

    private GameManagement gameManagement;

    void Awake()
    {
        gameManagement = FindObjectOfType<GameManagement>();
    }

    void Update()
    {
        gameManagement.ScoreUpdated(playerTransform.position.z.ToString("0"));
    }
}
