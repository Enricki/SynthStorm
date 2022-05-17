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

    private List<Cell> cells = new List<Cell>();

    private void Start()
    {
        GenerateField();
    }

    private void GenerateField()
    {
        GridCoordinates grid = new GridCoordinates(fieldSize, spacingOffset);
        for (int i = 0; i < grid.Coords.Count; i++)
        {
            Cell cell = Instantiate(CellPrefab, transform);
            cell.transform.position = grid.Coords[i];
            cells.Add(cell);
        }
    }
}
