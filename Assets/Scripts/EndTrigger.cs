using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider colliderInfo)
    {
        if (colliderInfo.tag == "Player")
        {
            FindObjectOfType<GameManagement>().CompleteLevel();
        }
    }
}
