using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameEvent", menuName = "Events/Create Game Event")]
public class GameEvent : ScriptableObject
{
    private List<EventListener> listeners = new List<EventListener>();

    public void AddListener(EventListener listener)
    {
        listeners.Add(listener);
    }

    public void RemoveListener(EventListener listener)
    {
        listeners.Remove(listener);
    }

    public void EventInit()
    {
        //EventListener listener;
        //int subsCount = listeners.Count;
        //for (int i = 0; i < listeners.Count; i++)
        //{
        //    listeners[i].EventRaised();
        //    if (listeners.Count != subsCount)
        //    {
        //        subsCount = listeners.Count;
        //        i = 0;
        //    }
        //}

        foreach (var item in listeners)
        {
            int listenersCount = listeners.Count;
            item.EventRaised();
            if (listeners.Count != listenersCount)
            {
                break;
            }
        }
    }
}
