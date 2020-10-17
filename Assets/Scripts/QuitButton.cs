using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour
{
    [SerializeField]
    private Button button = default;

    void Awake()
    {
        button.onClick.AddListener(delegate {
            Quit();
        });
    }

    private void Quit()
    {
        FindObjectOfType<GameManagement>().QuitGame();
    }
}
