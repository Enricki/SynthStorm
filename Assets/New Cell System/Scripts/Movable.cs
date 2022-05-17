using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movable : MonoBehaviour
{
    private float speed = 3f;
    public Vector3 Movement(Vector3 startPosition, Vector3 targetPosition)
    {
        Vector3 position = Vector3.MoveTowards(startPosition, targetPosition, Time.deltaTime * speed);
        return position;
    }

    private void Update()
    {
        transform.position = Movement(transform.position, new Vector3(-22f, 0));
    }
}
