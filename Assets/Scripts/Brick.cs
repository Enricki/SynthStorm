using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Brick : MonoBehaviour
{
    public Color color;

    private void Awake()
    {
        GetComponent<SpriteRenderer>().color = color;
    }
}
