using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    public Cell CellPrefab;
    public Vector2Int gridSize;
    public float gridSpacingOffset;

    public Vector3 gridOrigin;
    public Vector3 gridBorders;

    public List<Cell> cells = new List<Cell>();

    public void GenerateGrid()
    {
        gridOrigin = -new Vector3(gridSize.x / 2, gridSize.y / 2) * gridSpacingOffset;
        gridBorders = new Vector3(gridSize.x * gridSpacingOffset - gridSpacingOffset, gridSize.y * gridSpacingOffset - gridSpacingOffset) + gridOrigin;
        for (int x = 0; x < gridSize.x; x++)
        {
            for (int y = 0; y < gridSize.y; y++)
            {
                Cell cell = Instantiate(CellPrefab, transform);
                Vector3 cellLocalPosition = new Vector3(x * gridSpacingOffset, y * gridSpacingOffset) + gridOrigin;
                cell.transform.localPosition = cellLocalPosition;
                cells.Add(cell);
            }
        }
    }
}
