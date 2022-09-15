using UnityEngine;
using UnityEngine.Events;


public class GameEventListener: MonoBehaviour
{
    [SerializeField]
    EventListener eventListener;

    private void OnEnable()
    {
        eventListener.GameEvent.AddListener(eventListener);
    }

    private void OnDisable()
    {
        eventListener.GameEvent.RemoveListener(eventListener);
    }
}

[System.Serializable]
public struct EventListener
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