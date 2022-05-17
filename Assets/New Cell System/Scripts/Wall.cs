using UnityEngine;

public class Wall
{
    private CustomList<BrickData> bricksInWall = new CustomList<BrickData>();

    public CustomList<BrickData> BricksInWall { get => bricksInWall; }

    public Wall(WallData wallData)
    {
        bricksInWall.Clear();
        for (int i = 0; i < wallData.WallSettings.Length; i++)
        {
            for (int j = 1; j <= wallData.WallSettings[i].BricksCount; j++)
            {
                bricksInWall.Add(wallData.WallSettings[i].BrickData);
            }
        }
        RandomizedList<BrickData> randomizedData = new RandomizedList<BrickData>(bricksInWall);
        randomizedData.Clone(bricksInWall);
        bricksInWall.Clear();
        bricksInWall.Clone(randomizedData);
        randomizedData.Clear();
    }
}
