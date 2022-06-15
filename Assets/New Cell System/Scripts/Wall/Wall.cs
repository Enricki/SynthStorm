using System.Collections.Generic;
using UnityEngine;

public class Wall: MonoBehaviour
{
    [SerializeField]
    private List<WallData> wallData;

    private WallData activeWallData;
    private CustomList<Vector3> bricksCoords;
    private CustomList<BrickData> bricksInWall = new CustomList<BrickData>();

    public CustomList<BrickData> BricksInWall { get => bricksInWall; }
    public WallData ActiveWallData { get => activeWallData; }
    public CustomList<Vector3> BricksCoords { get => bricksCoords; }


    private WallData GetRandomWallData()
    {
        WallData data;
        if (wallData.Count != 0)
        {
            int randomIndex = Random.Range(0, wallData.Count);
            data = wallData[randomIndex];
            return data;
        }
        else return null;
    }

    public void CreateWallData()
    {
        bricksInWall.Clear();
        for (int i = 0; i < activeWallData.WallSettings.Length; i++)
        {
            for (int j = 1; j <= activeWallData.WallSettings[i].BricksCount; j++)
            {
                bricksInWall.Add(activeWallData.WallSettings[i].BrickData);
            }
        }
        RandomizedList<BrickData> randomizedData = new RandomizedList<BrickData>(bricksInWall);
        bricksInWall.Merge(randomizedData);
    }



    public void CreateWallCoords()
    {
        activeWallData = GetRandomWallData();
        GridCoordinates grid = new GridCoordinates(activeWallData.WallSize, activeWallData.SpacingOffset);
        bricksCoords = new RandomizedList<Vector3>(grid.Coords);
        bricksCoords.Clone(grid.Coords);
    }

    public void ShuffleBriks()
    {
        RandomizedList<Vector3> bufferCoords = new RandomizedList<Vector3>(bricksCoords);
        bricksCoords.Merge(bufferCoords);
        activeWallData = GetRandomWallData();
        CreateWallData();
    }

    private void Start()
    {
        activeWallData = GetRandomWallData();
        CreateWallCoords();
        CreateWallData();
    }
}

struct FilledWall
{
    WallData data;
    List<Vector3> coords;
}