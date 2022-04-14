using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerObj : MonoBehaviour
{
    [SerializeField]
    private UnityEvent Actions;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Touched!");
        Actions?.Invoke();
    }
}
