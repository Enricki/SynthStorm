using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WallsController : MonoBehaviour
{
    [SerializeField]
    int wallsInScene;
    [SerializeField]
    WallDisplay wallPrefab;
    [SerializeField]
    private List<Levels> levels;

    private List<WallDisplay> walls = new List<WallDisplay>();

    private int TimeStep = 4;

    Vector3 spawnPosition;
    private void Start()
    {
        Repeat();
    }

    public void GenerateWalls()
    {

    }
    public void Repeat()
    {
        StartCoroutine(SpawnWalls());
    }

    IEnumerator SpawnWalls()
    {
        GenerateNewWall();
        yield return new WaitForSeconds(TimeStep);
        Repeat();
    }

    public void GenerateNewWall()
    {
        int randomDataIndex = Random.Range(0, levels[0].Walls.Count);
        WallDisplay wallDisplay = Instantiate(wallPrefab, transform);
        spawnPosition = wallDisplay.transform.position;
        wallDisplay.wallData = levels[0].Walls[randomDataIndex];
        Debug.Log(wallDisplay.wallData);
//        wallDisplay.GenerateWall();   
        walls.Add(wallDisplay);
    }
}


[System.Serializable]
public class Levels
{
    public string name;

    [SerializeField]
    List<WallData> walls;

    public List<WallData> Walls { get => walls; }
}

