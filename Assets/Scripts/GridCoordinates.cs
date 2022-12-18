using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridCoordinates
{
    private List<Vector3> coords = new List<Vector3>();
    private Vector3[,] coordsArray;
    private Vector2Int gridZeroIndex;
    private Vector3 gridOrigin;
    public List<Vector3> Coords { get => coords; }
    public Vector3[,] CoordsArray { get => coordsArray; }

    public Vector2Int GridZeroIndex { get => gridZeroIndex; }
    public Vector3 GridOrigin { get => gridOrigin; }

    public GridCoordinates(Vector2Int gridSize, float gridSpacingOffset)
    {
        coordsArray = new Vector3[gridSize.x, gridSize.y];

        gridOrigin = -new Vector3(gridSize.x / 2, gridSize.y / 2) * gridSpacingOffset;
        Vector3 gridBorders = new Vector3(gridSize.x * gridSpacingOffset - gridSpacingOffset, gridSize.y * gridSpacingOffset - gridSpacingOffset) + gridOrigin;
        for (int y = 0; y < gridSize.y; y++)
        {
            for (int x = 0; x < gridSize.x; x++)
            {
                Vector3 cellLocalPosition = new Vector3(x * gridSpacingOffset, y * gridSpacingOffset) + gridOrigin;
                coords.Add(cellLocalPosition);
                coordsArray[x, y] = cellLocalPosition;

            //    Debug.Log("[" + x + "," + y + "]" + " " + coordsArray[x, y]);
            }
        }
        gridZeroIndex = new Vector2Int(gridSize.x / 2, gridSize.y / 2);
    }
}
