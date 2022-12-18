using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Wall", menuName = "Data Objects/Create Stack")]
public class StackData : ScriptableObject
{
    [SerializeField]
    private string stackName;
    [SerializeField]
    [Range(0,5)]
    private int stackSizeX;
    [SerializeField]
    [Range(0, 5)]
    private int stackSizeY;
    [SerializeField]
    private float stackSpacingOffset;
    //[SerializeField]
    //StackVariant[] stackVariants;
    [SerializeField]
    BrickData brickData;
    [SerializeField]
    bool[,] bools = new bool[5,5];

    public Vector2Int StackSize { get => new Vector2Int(stackSizeX, stackSizeY); }
    public float StackSpacingOffset { get => stackSpacingOffset; }

//    public StackVariant[] StackVariant { get => stackVariants; }
    public BrickData BrickData { get => brickData; }

    public int coordsCount;
    public bool[,] Bools { get => bools; }
    public bool[] bBools = new bool[25];
}

[System.Serializable]
public struct StackVariant
{
    [SerializeField]
    private GameObject itemPrefab;
    [SerializeField]
    [Range(0, 5)]
    private int itemCount;

    public int ItemCount { get => itemCount; }
    public GameObject ItemPrefab { get => itemPrefab; }

}
