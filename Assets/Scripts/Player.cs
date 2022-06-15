using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.SetActive(false);
    }

    public void Looting()
    {
        Debug.Log("Loot");
    }

    public void OnDeath()
    {
        Debug.Log("Dead");
    }

    public void Dash()
    {
        Debug.Log("Dash!");
    }
}
