using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizedList<T> : CustomList<T>
{
    public RandomizedList(List<T> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            int randomIndex = Random.Range(0, list.Count);
            T temp = list[randomIndex];
            list[randomIndex] = list[0];
            list[0] = temp;
        }
    }
}
