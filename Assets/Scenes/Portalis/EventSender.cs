using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventSender : MonoBehaviour
{
    [SerializeField]
    private UnityEvent Event;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Event?.Invoke();
    }

    public void SetEvent(UnityEvent _event)
    {
        Event = _event;
    }
}
