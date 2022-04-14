using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell: MonoBehaviour
{
    Vector2 size = Vector2.one;
    public bool visible = true;

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
    

}
