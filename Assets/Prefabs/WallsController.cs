using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallsController : MonoBehaviour
{
    public Wall wallPrefab;

    int TimeStep = 2;
    List<Wall> Walls = new List<Wall>();
    Wall currentWall;

    public void Repeat()
    {
        StartCoroutine(SpawnWalls());
    }
    IEnumerator SpawnWalls()
    {
        
        Wall wall = Instantiate(wallPrefab, this.transform);
        wall.transform.position = new Vector3 (wall.gridSpacingOffset * 10, 0);
        wall.GenerateGrid();
        yield return new WaitForSeconds(TimeStep);
        Repeat();
    }

    public void Destroy()
    {
        StopAllCoroutines();
    }
}
