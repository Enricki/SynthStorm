using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackGenerator : MonoBehaviour
{
    [SerializeField]
    Stack stack;

    CustomList<Vector3> coords;

    private List<GameObject> bricks = new List<GameObject>();
    void GenerateCoords()
    {
        GridCoordinates gridCoordinates = new GridCoordinates(stack.StackSize, stack.StackSpacingOffset);
        coords = new RandomizedList<Vector3>(gridCoordinates.Coords);

        for (int i = 0; i < gridCoordinates.Coords.Count; i++)
        {
            coords.Add(gridCoordinates.Coords[i]);
        }
    }


    public void UpdateBricks()
    {
        coords.Clear();
        GenerateCoords();
        for (int i = 0; i < bricks.Count; i++)
        {
            bricks[i].transform.localPosition = coords[0];
            bricks[i].GetComponent<SimpleCube>().setActive(true);
            coords.RemoveAt(0);
        }
    }

    void GenerateStack()
    {
        
        GenerateCoords();
        StackVariant[] stackVariant = stack.StackVariant;

        for (int i = 0; i < stackVariant.Length; i++)
        {
            for (int j = 0; j < stackVariant[i].ItemCount; j++)
            {
                GameObject go = Instantiate(stack.StackVariant[i].ItemPrefab, transform);
                go.transform.localPosition = coords[0];
                bricks.Add(go);
                coords.RemoveAt(0);
            }
        }
    }
    private void Start()
    {
        GenerateStack();
    }
}
