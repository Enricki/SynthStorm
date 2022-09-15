using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ListenersHub : MonoBehaviour
{
    [SerializeField]
    EventListener[] eventListeners;

    private void OnEnable()
    {
        foreach (var item in eventListeners)
        {
            item.GameEvent.AddListener(item);
        }
        
    }

    private void OnDisable()
    {
        foreach (var item in eventListeners)
        {
            item.GameEvent.RemoveListener(item);
        }
    }
}
