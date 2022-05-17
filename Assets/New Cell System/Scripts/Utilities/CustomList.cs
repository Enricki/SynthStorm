using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomList<T> : List<T>
{
    public void Clone(List<T> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            Add(list[i]);
        }
    }
}
