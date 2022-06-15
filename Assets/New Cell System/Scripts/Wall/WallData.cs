using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Wall", menuName = "Data Objects/Create Wall")]
public class WallData : ScriptableObject
{
    [SerializeField]
    private string wallName;
    [SerializeField]
    private BrickDisplay brickPrefab;
    [SerializeField]
    private Vector2Int wallSize;
    [SerializeField]
    private float spacingOffset;
    [Space(20)]
    [SerializeField]
    private WallSettings[] wallSettings;

    public WallSettings[] WallSettings { get => wallSettings; }
    public BrickDisplay BrickPrefab { get => brickPrefab; }
    public Vector2Int WallSize { get => wallSize; }
    public float SpacingOffset { get => spacingOffset; }
}

[System.Serializable]
public class WallSettings
{
    [SerializeField]
    private BrickData brickData;
    [SerializeField]
    private int bricksCount;

    public BrickData BrickData { get => brickData; }
    public int BricksCount { get => bricksCount; }
}