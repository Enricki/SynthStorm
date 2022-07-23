using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Brick : DataConnector
{
    EventSender eventSender;

    public EventSender EventSender { get => eventSender; }

    public void SetSender(EventSender sender)
    {
        eventSender = sender;
    }
}
