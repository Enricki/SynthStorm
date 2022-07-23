
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WallDisplay : MonoBehaviour
{
    [SerializeField]
    List<WallData> wallDatas;
    Wall wall = new Wall();
    WallData wallData;
    List<BrickDisplay> Bricks = new List<BrickDisplay>();
    [SerializeField]

    private void Start()
    {
        InstantiateWall();
    }

    private void SetRandomData()
    {
        int randomIndex = Random.Range(0, wallDatas.Count);
        wall.SetData(wallDatas[randomIndex]);
        wallData = (WallData)wall.ActiveData;
    }

    public void InstantiateWall()
    {
        SetRandomData();
        wall.FillWall(wallData);
        wall.ShuffleCoords(wallData.WallSize, wallData.SpacingOffset);

        for (int i = 0; i < wall.Bricks.Count; i++)
        {
            BrickDisplay brickInstance = Instantiate(wallData.BrickPrefab, transform);
            brickInstance.UpdateDisplay(wall.Bricks[i]);
            brickInstance.transform.localPosition = wall.BricksCoords[i];
            Bricks.Add(brickInstance);
        }
    }

    public void Shuffle()
    {
        SetRandomData();
        wall.FillWall(wallData);
        wall.ShuffleCoords(wallData.WallSize, wallData.SpacingOffset);
        for (int i = 0; i < Bricks.Count; i++)
        {
            Bricks[i].UpdateDisplay(wall.Bricks[i]);
            Bricks[i].transform.localPosition = wall.BricksCoords[i];
            Bricks[i].gameObject.SetActive(true);
        }
    }

    
}
