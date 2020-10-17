using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField]
    private Transform playerTransform = default;

    private HudManagement hudManagement;

    void Awake()
    {
        hudManagement = FindObjectOfType<HudManagement>();
    }

    void Update()
    {
        hudManagement.UpdateScore(playerTransform.position.z.ToString("0"));
    }
}
