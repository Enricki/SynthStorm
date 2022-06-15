using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
    private int score;

    public int Score { get => score; }

    public void AddScore()
    {
        score++;
    }

    public void ResetScore()
    {
        score = 0;
    }
}
