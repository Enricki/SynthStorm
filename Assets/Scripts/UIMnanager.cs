using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMnanager : MonoBehaviour
{
    public GameObject Obj;
    IEnumerator WaitForSpawn(GameObject obj, float delay)
    {
        yield return new WaitForSeconds(delay);
        obj.SetActive(true);
    }


    public void DelayedSpawn(float delay)
    {
        StartCoroutine(WaitForSpawn(Obj, delay));
    }
}
