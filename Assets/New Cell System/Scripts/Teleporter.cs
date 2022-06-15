using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public Vector3 regularTPPosition;
    private Vector3 startPosition;
    

    public Vector3 StartPosition { get => startPosition; }

    private void SetStartPosition()
    {
        startPosition = transform.position;
    }

    private void Start()
    {
        SetStartPosition();
    }
}
