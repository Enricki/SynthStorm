using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid2D : MonoBehaviour
{
    public Cell CellPrefab;
    public Player PlayerPrefab;
    public Wall WallPrefab;
    public Vector2Int gridSize;
    public float gridSpacingOffset;
    Vector3 gridOrigin = Vector3.zero;
    public Vector3 borders;

    float step;

    private void Start()
    {
        step = 1 + gridSpacingOffset;
        GenerateGrid();
    }

    void GenerateGrid()
    {
        gridOrigin = -new Vector3(gridSize.x / 2, gridSize.y / 2) * gridSpacingOffset;
        borders = new Vector3(gridSize.x * gridSpacingOffset - gridSpacingOffset, gridSize.y * gridSpacingOffset - gridSpacingOffset) + gridOrigin;

        for (int x = 0; x < gridSize.x; x++)
        {
            for (int y = 0; y < gridSize.y; y++)
            {
                Vector3 spawnPosition = new Vector3(x * gridSpacingOffset, y * gridSpacingOffset) + gridOrigin;
                string cellName = "Cell [" + x + "," + y + "]";
                Cell cell = Instantiate(CellPrefab, transform);
                cell.transform.position = spawnPosition;
            }
        }

        Player player = Instantiate(PlayerPrefab, transform);
        player.transform.position = Vector3.zero;

        Wall wall = Instantiate(WallPrefab, transform);
        wall.transform.position = borders;
       // wall.GenerateWall();
    }
}
