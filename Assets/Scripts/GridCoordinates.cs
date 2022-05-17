using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridCoordinates
{
    private List<Vector3> cellsCoords = new List<Vector3>();
    public List<Vector3> Coords { get => cellsCoords; }

    public GridCoordinates(Vector2Int gridSize, float gridSpacingOffset)
    {
        Vector3 gridOrigin = -new Vector3(gridSize.x / 2, gridSize.y / 2) * gridSpacingOffset;
        Vector3 gridBorders = new Vector3(gridSize.x * gridSpacingOffset - gridSpacingOffset, gridSize.y * gridSpacingOffset - gridSpacingOffset) + gridOrigin;
        for (int y = 0; y < gridSize.y; y++)
        {
            for (int x = 0; x < gridSize.x; x++)
            {
                Vector3 cellLocalPosition = new Vector3(x * gridSpacingOffset, y * gridSpacingOffset) + gridOrigin;
                cellsCoords.Add(cellLocalPosition);
            }
        }
    }
}
