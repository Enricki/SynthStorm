using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
    private int score = 0;
    private int step = 1;
    private int multiplier = 1;

    public int Multiplier { get => multiplier; }
    public int Score { get => score; }

    public void AddScore()
    {
        int currentScore = step * multiplier;
        score += currentScore;
    }

    public void ResetScore()
    {
        score = 0;
    }

    public void MultipleScore(int aplier)
    {
        multiplier = aplier;
    }
}
