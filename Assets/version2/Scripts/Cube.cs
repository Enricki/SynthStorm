using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class Cube : MonoBehaviour, IInteractable
{
    [SerializeField]
    ObjectType type;

    public ObjectType Type { get => type; }

    public abstract void OnInteract();

    [SerializeField]
    UnityEvent sendingEvent;

    public void Interact()
    {
        OnInteract();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Interact();
    }

    private void OnMouseDown()
    {
        sendingEvent?.Invoke();
        Interact();
    }
}

public enum ObjectType
{
    Death = 0,
    Loot = 1,
    Invis = 2,
    Multiplier = 3,
    Dash = 4
}
