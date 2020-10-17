using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField]
    private Transform playerTransform = default;

    [SerializeField]
    private Text text = default;

    void Update()
    {
        text.text = playerTransform.position.z.ToString("0");
    }
}
