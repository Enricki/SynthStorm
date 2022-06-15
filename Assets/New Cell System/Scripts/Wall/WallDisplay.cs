
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (Wall))]
public class WallDisplay : MonoBehaviour
{
    //public List<WallData> wallData;

    //private WallData activeWallData;

    //private CustomList<Vector3> randomCoords;

    Wall wall;  

    private List<BrickDisplay> displays = new List<BrickDisplay>();

    private void Start()
    {
        wall = GetComponent<Wall>();
        InstantiateWall();
    }

    //public void ShuffleBriks()
    //{
    //    wall.CreateWallData();
    //    int randomIndex = Random.Range(0, wallData.Count);
    //    activeWallData = wallData[randomIndex];
    ////    Wall wall = new Wall(activeWallData);
    //    for (int j = 0; j < wall.BricksInWall.Count; j++)
    //    {
    //        displays[j].UpdateDisplay(wall.BricksInWall[j]);
    //    }


    //    RandomizedList<Vector3> bufferRandom = new RandomizedList<Vector3>(randomCoords);
    //    bufferRandom.Clone(randomCoords);
    //    randomCoords.Clear();
    //    randomCoords.Clone(bufferRandom);
    //    bufferRandom.Clear();
    //    for (int i = 0; i < displays.Count; i++)
    //    {
    //        displays[i].transform.localPosition = randomCoords[i];
    //        displays[i].gameObject.SetActive(true);
    //    }
    //}

    public void InstantiateWall()
    {
        for (int i = 0; i < wall.BricksInWall.Count; i++)
        {
            BrickDisplay brickInstance = Instantiate(wall.ActiveWallData.BrickPrefab, transform);
            brickInstance.brickData = wall.BricksInWall[i];
            brickInstance.transform.localPosition = wall.BricksCoords[i];
            displays.Add(brickInstance);
        }
    }


    public void UpdateVisual()
    {
        wall.ShuffleBriks();
        for (int i = 0; i < displays.Count; i++)
        {
            displays[i].brickData = wall.BricksInWall[i];
            displays[i].transform.localPosition = wall.BricksCoords[i];
            displays[i].gameObject.SetActive(true);
        }
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
