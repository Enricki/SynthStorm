using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ListenersHub : MonoBehaviour
{
    [SerializeField]
    GameEventListener[] eventListeners;



    private void OnEnable()
    {
        for (int i = 0; i < eventListeners.Length; i++)
        {
            eventListeners[i].GameEvent?.AddLitener(eventListeners[i]);
        }
    }

    private void OnDisable()
    {
        for (int i = 0; i < eventListeners.Length; i++)
        {
            eventListeners[i].GameEvent?.RemoveListener(eventListeners[i]);
        }
    }
}

[System.Serializable]
public class GameEventListener
{
    [SerializeField]
    private GameEvent gameEvent;

    [SerializeField]
    private UnityEvent actions;

    public GameEvent GameEvent { get => gameEvent; }
    public UnityEvent Actions { get => actions; }

    public void EventRaised()
    {
        actions.Invoke();
    }
}
