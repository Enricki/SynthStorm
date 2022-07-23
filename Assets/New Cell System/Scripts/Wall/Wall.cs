using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Wall: DataConnector
{
    private List<Brick> bricks = new List<Brick>();

    public List<Brick> Bricks { get =>bricks; }

    public void FillWall(WallData wallData)
    {
        for (int i = 0; i < wallData.WallSettings.Length; i++)
        {
            for (int j = 1; j <= wallData.WallSettings[i].BricksCount; j++)
            {
                Brick brick = new Brick();
                brick.SetData(wallData.WallSettings[i].BrickData);
                bricks.Add(brick);
            }
        }
    }

    private CustomList<Vector3> bricksCoords = new CustomList<Vector3>();
    public CustomList<Vector3> BricksCoords { get => bricksCoords; }

    public void CreateWallCoords(Vector2Int size, float offset)
    {
        GridCoordinates grid = new GridCoordinates(size, offset);
        bricksCoords.Clone(grid.Coords);
 
    }

    public void ShuffleCoords(Vector2Int size, float offset)
    {
        CreateWallCoords(size, offset);
        RandomizedList<Vector3> bufferCoords = new RandomizedList<Vector3>(bricksCoords);
        bricksCoords.Merge(bufferCoords);
    }
}