using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Wall", menuName = "Data Objects/Create Wall")]
public class WallData : ScriptableObject
{
    [SerializeField]
    private string wallName;
    [SerializeField]
    private Vector2Int wallSize;
    [SerializeField]
    private float spacingOffset;
    [Space(20)]
    [SerializeField]
    private WallSettings[] wallSettings;
    [SerializeField]
    private BrickDisplay brickPrefab;

    public BrickDisplay BrickPrefab { get => brickPrefab; }
    public Vector2Int WallSize { get => wallSize; }
    public float SpacingOffset { get => spacingOffset; }

    public WallSettings[] WallSettings { get => wallSettings; }
}

[System.Serializable]
public class WallSettings
{
    [SerializeField]
    BrickData brickData;
    [SerializeField]
    private int bricksCount;

    public BrickData BrickData { get => brickData; }
    public int BricksCount { get => bricksCount; }
    
}