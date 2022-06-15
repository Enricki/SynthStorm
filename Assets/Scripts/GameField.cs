using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameField : MonoBehaviour
{
    [SerializeField]
    private Cell CellPrefab;
    [SerializeField]
    private Vector2Int fieldSize;
    [SerializeField]
    private float spacingOffset;

    private List<Vector3> coords = new List<Vector3>();
    private Vector3[,] coordsArray;
    private List<Cell> cells = new List<Cell>();
    private Vector2Int zeroIndex;

    public List<Vector3> GridCoords { get => coords; }
    public Vector3[,] CoordsArray { get => coordsArray; }
    public Vector2Int FieldSize { get => fieldSize; }
    public Vector2Int ZeroIndex { get => zeroIndex; }


    private void Start()
    {
        GenerateField();
    }

    private void GenerateField()
    {
        GetCoords();
        for (int i = 0; i < coords.Count; i++)
        {
            Cell cell = Instantiate(CellPrefab, transform);
            cell.transform.position = coords[i];
            cells.Add(cell);
        }
    }

    public void GetCoords()
    {
        GridCoordinates grid = new GridCoordinates(fieldSize, spacingOffset);
        coords = grid.Coords;
        coordsArray = grid.CoordsArray;
        zeroIndex = grid.GridZeroIndex;
    }
}
