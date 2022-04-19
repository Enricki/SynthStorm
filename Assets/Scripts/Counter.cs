using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
    public TMP_Text bestScoreLabel;
    public TMP_Text ScoreLabel;
    int inc = 0;
    string score = "Score: ";
    int bestScore;

    public void SaveScore()
    {
        if (inc > bestScore)
        {
            bestScore = inc;
            bestScoreLabel.text = bestScore.ToString();
        }
    }

    public void Save()
    {
            ScoreLabel.text = inc.ToString();
    }

    public void IncreseCount()
    {
        inc*=2;
        GetComponent<TMP_Text>().text = score + inc;
    }

    public void resetCounter()
    {
        inc = 0;
        GetComponent<TMP_Text>().text = score;
    }
}
