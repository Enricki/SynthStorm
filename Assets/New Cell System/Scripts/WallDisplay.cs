
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class WallDisplay : MonoBehaviour
{
    public WallData wallData;

    private CustomList<Vector3> randomCoords;

    private List<BrickDisplay> displays = new List<BrickDisplay>();

    public void ShuffleBriks()
    {
        RandomizedList<Vector3> bufferRandom = new RandomizedList<Vector3>(randomCoords);
        bufferRandom.Clone(randomCoords);
        randomCoords.Clear();
        randomCoords.Clone(bufferRandom);
        bufferRandom.Clear();
        for (int i = 0; i < displays.Count; i++)
        {
            displays[i].transform.localPosition = randomCoords[i];
        }
    }
    public void InstantiateWall()
    {
        Wall wall = new Wall(wallData);

        GridCoordinates grid = new GridCoordinates(wallData.WallSize, wallData.SpacingOffset);
        randomCoords = new RandomizedList<Vector3>(grid.Coords);
        randomCoords.Clone(grid.Coords);

        for (int i = 0; i < wall.BricksInWall.Count; i++)
        {
            BrickDisplay brick = Instantiate(wallData.BrickPrefab, transform);
            brick.brickData = wall.BricksInWall[i];
            brick.transform.localPosition = randomCoords[i];
            displays.Add(brick);
        }
    }


    private void Start()
    {
        InstantiateWall();
    }























    //[SerializeField]
    //private BrickDisplay brickPrefab;
    //public WallData wallData;

    //private List<BrickDisplay> bricksInWall = new List<BrickDisplay>();
    //public List<BrickDisplay> BricksInWall { get => bricksInWall; }

    //public void GenerateWall()
    //{
    //    List<Vector3> bricks = ShuffledBricks(wallData);
    //    int index = 0;
    //    for (int i = 0; i < wallData.WallSettings.Length; i++)
    //    {
    //        for (int n = 0; n < wallData.WallSettings[i].BricksCount; n++)
    //        {
    //            BrickDisplay brick = Instantiate(brickPrefab, transform);
    //            brick.brick = wallData.WallSettings[i].BrickData;
    //            brick.transform.localPosition = bricks[index];
    //            index++;
    //            bricksInWall.Add(brick);
    //        }
    //    }
    //}

    //public List<Vector3> ShuffledBricks(WallData data)
    //{
    //    GridCoordinates grid = new GridCoordinates(data.WallSize, data.SpacingOffset);
    //    List<Vector3> randomizedCoords = new List<Vector3>();
    //    for (int i = 0; i < grid.Coords.Count; i++)
    //    {
    //        if (i % data.WallSize.x == 0)
    //        {
    //            int randomX = Random.Range(0, wallData.WallSize.x);
    //            Vector3 coords = new Vector3(grid.Coords[i + randomX].x, grid.Coords[i].y);
    //            randomizedCoords.Add(coords);
    //        }
    //    }
    //    ListRandomizer(randomizedCoords);
    //    return randomizedCoords;
    //}

    //public void UpdateWall(BrickDisplay brick)
    //{
    //    List<Vector3> bricks = ShuffledBricks(wallData);
    //    for (int i = 0; i < bricksInWall.Count; i++)
    //    {
    //        brick.transform.localPosition = bricks[i];
    //    }
    //}

    //public void ListRandomizer<T>(List<T> list)
    //{
    //    for (int i = 0; i < list.Count; i++)
    //    {
    //        int randomIndex = Random.Range(0, list.Count);
    //        T temp = list[randomIndex];
    //        list[randomIndex] = list[0];
    //        list[0] = temp;
    //    }
    //}
}
