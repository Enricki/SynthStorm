using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    [SerializeField]
    TMP_Text text;

    public void DisplayScore(Counter counter)
    {
        text.text = counter.Score.ToString();
    }
}
