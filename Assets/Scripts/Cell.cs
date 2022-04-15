using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell: MonoBehaviour
{
    Vector2 size = Vector2.one;
    public bool visible = true;
    Cell cell;
    public Vector2 Size
    {
        get
        {
            return size;
        }
        private set
        {
            size = value;
        }
    }


    private void Start()
    {
        cell = GetComponent<Cell>();
    }

    public void SetInvisible()
    {
        Debug.Log("To you");
    }

}
