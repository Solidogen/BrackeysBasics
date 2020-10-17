using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AfterLevelCompleteAnimation : MonoBehaviour
{
    public void AfterAnimation()
    {
        FindObjectOfType<GameManagement>().GoToNextLevel();
    }
}
