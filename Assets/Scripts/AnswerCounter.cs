using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerCounter : MonoBehaviour
{
    public static AnswerCounter instance;

    public int counter;
    public int maxAnswers;
    public bool endGame = false;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject); 
    }
    
    public void IncrementRightAnswer()
    {
        counter++;
        endGame = counter == maxAnswers;
    }
}
