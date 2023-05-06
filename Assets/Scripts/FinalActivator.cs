using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalActivator : MonoBehaviour
{
    public GameObject endScreen;
    public GameObject currentScreen;

    private void OnEnable()
    {
        Invoke(nameof(EndGameVerification), 0.1f);
    }

    private void EndGameVerification()
    {
        if (AnswerCounter.instance.endGame)
        {
            endScreen.SetActive(true);
            currentScreen.SetActive(false);
        }
    }
}
