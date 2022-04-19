using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    Rigidbody2D selfRigidbody;
    public int score = 2;

    private void Start()
    {
        selfRigidbody = GetComponent<Rigidbody2D>();
    }
}
