using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    [SerializeField]
    TMP_Text text;
    public int score = 2;

    private void Start()
    {
        SetScore();
    }

    public void SetScore()
    {
        text.text = score.ToString();
    }

    public void DoubleScore()
    {
        score = score * 2;
    }

    public void AddScore()
    {
        score++;
    }
}
