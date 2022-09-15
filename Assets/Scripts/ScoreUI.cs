using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    [SerializeField]
    TMP_Text score;

    [SerializeField]
    TMP_Text multiplier;

    [SerializeField]
    TMP_Text bestScore;

    public void DisplayScore(Counter counter)
    {
        score.text = counter.Score.ToString();
    }

    public void DisplayMultiplier(Counter counter)
    {
        multiplier.text = counter.Multiplier.ToString();
    }

    public void DisplayBestScore(Counter counter)
    {
        bestScore.text = counter.BestScore.ToString();
    }
}
