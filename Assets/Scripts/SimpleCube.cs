using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCube : MonoBehaviour
{
    [SerializeField]
    private Display _display;
    [SerializeField]
    private Collider2D _collider;

    public void setActive(bool isActive)
    {
        _display.setActive(isActive);
        _collider.enabled = isActive;
    }
}
