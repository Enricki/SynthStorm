using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Cooldown : MonoBehaviour
{
    [SerializeField]
    private float cooldownTime = 2;
    [SerializeField]
    private UnityEvent startEvents;
    [SerializeField]
    public UnityEvent endEvents;

    public void EmptyEvent()
    {
        //Just empty event;
    }

    private float nextStepTime = 0;

    public void TimedEvent()
    {
        
        StartCoroutine(tCooldown(startEvents, endEvents));
    }

    IEnumerator tCooldown(UnityEvent startEvent, UnityEvent endEvent)
    {
        if (Time.time > nextStepTime)
        {
            startEvent?.Invoke();
            //    print(nextStepTime + " : " + Time.time);
            nextStepTime = Time.time + cooldownTime;
            yield return new WaitForSeconds(cooldownTime);
            endEvent?.Invoke();
        }
    }
}
