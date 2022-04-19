using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    [SerializeField]
    private GameEvent gameEvent;

    [SerializeField]
    private UnityEvent Actions;

    private void OnEnable()
    {
        gameEvent?.AddLitener(this);
    }

    private void OnDisable()
    {
        gameEvent?.RemoveListener(this);
    }

    public void EventRaised()
    {
        Actions.Invoke();
    }
}
