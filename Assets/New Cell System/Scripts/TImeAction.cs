using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimeAction : MonoBehaviour
{
    [SerializeField]
    private UnityEvent actions;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        TimedAction(actions);
    }

    public void TimedAction(UnityEvent action)
    {
      //  Invoke(action, 3f);
    }
}
