using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField]
    private PlayerMovement movement = default;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("Hit an obstacle");
            movement.enabled = false;
            FindObjectOfType<GameManagement>().EndGame();
        }
    }
}
