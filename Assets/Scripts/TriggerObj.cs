using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerObj : MonoBehaviour
{
    [SerializeField]
    private UnityEvent actions;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        actions?.Invoke();
    }

    public void SetEvents(UnityEvent dataEvents)
    {
        actions = dataEvents;
    }
}
