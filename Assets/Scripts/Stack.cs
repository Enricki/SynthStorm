using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stack : MonoBehaviour
{
    [SerializeField]
    private GameObject CubePrefab;

    [SerializeField]
    private StackData[] stackData;

    [SerializeField]
    private bool Rotatable;

    private StackData activeStackData;

    private List<GameObject> Cubes = new List<GameObject>();

    private void Awake()
    {
        UpdateStack();
    }

    public void UpdateStack()
    {
        ChooseRandomData();

        Vector2Int size = activeStackData.StackSize;
        float offset = activeStackData.StackSpacingOffset;
        GridCoordinates coordinates = new GridCoordinates(size, offset);
        if (Cubes.Count == 0)
        {
            for (int i = 0; i < coordinates.Coords.Count; i++)
            {
                GameObject newObj = Instantiate(CubePrefab, transform);
                newObj.transform.localPosition = coordinates.Coords[i];
                newObj.name = activeStackData.name;
                newObj.GetComponent<Display>().UpdateDisplay(activeStackData.BrickData);
                Cubes.Add(newObj);
            }
        }
        UpdateData();

        if (Rotatable)
        {
            Rotate();
        }
    }

    void ChooseRandomData()
    {
        activeStackData = stackData[Random.Range(0, stackData.Length)];
    }

    void UpdateData()
    {
        bool[] activeCells = activeStackData.bBools;
        for (int i = 0; i < Cubes.Count; i++)
        {
            Cubes[i].name = activeStackData.name;
            Cubes[i].GetComponent<Display>().UpdateDisplay(activeStackData.BrickData);
            if (activeCells[i])
            {
                Cubes[i].SetActive(true);
            }
            else
            {
                Cubes[i].SetActive(false);
            }

        }
    }

    void Rotate()
    {
        int[] rotAngle = new int[4] { 0, 180, -90, 90 };
        transform.Rotate(new Vector3(0,0,rotAngle[Random.Range(0, 3)]));
    }
}
