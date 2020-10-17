using UnityEngine;

public class FollowPlayer : MonoBehaviour
{   
    [SerializeField]
    private Transform playerTransform = default;

    [SerializeField]
    private Vector3 cameraOffset = default;

    void Update()
    {
        transform.position = playerTransform.position + cameraOffset;
    }
}
