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

    public List<T> Merge(CustomList<T> inputList)
    {
        inputList.Clone(this);
        Clear();
        Clone(inputList);
        return this;
    }
}
