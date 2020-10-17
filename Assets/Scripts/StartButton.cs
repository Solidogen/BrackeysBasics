using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    [SerializeField]
    private Button button = default;

    void Awake()
    {
        button.onClick.AddListener(delegate {
            GoToNextLevel();
        });
    }

    private void GoToNextLevel()
    {
        FindObjectOfType<GameManagement>().GoToNextLevel();
    }
}
