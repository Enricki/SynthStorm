using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Wall", menuName = "Data Objects/Create Stack")]
public class Stack : ScriptableObject
{
    [SerializeField]
    private string stackName;
    [SerializeField]
    private Vector2Int stackSize;
    [SerializeField]
    private float stackSpacingOffset;
    [SerializeField]
    StackVariant[] stackVariants;


    public Vector2Int StackSize { get => stackSize; }
    public float StackSpacingOffset { get => stackSpacingOffset; }

    public StackVariant[] StackVariant { get => stackVariants; }
}

[System.Serializable]
public struct StackVariant
{
    [SerializeField]
    private GameObject itemPrefab;
    [SerializeField]
    private int itemCount;

    public int ItemCount { get => itemCount; }
    public GameObject ItemPrefab { get => itemPrefab; }

}
