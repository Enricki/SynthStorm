using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootField : MonoBehaviour
{
    [SerializeField]
    private GameObject CellPrefab;
    [SerializeField]
    private Vector2Int fieldSize;
    [SerializeField]
    private float spacingOffset;
    [SerializeField]
    private RuntimeAnimatorController controller;

    private List<Vector3> coords = new List<Vector3>();
    private Vector3[,] coordsArray;
    private List<GameObject> cells = new List<GameObject>();
    private Vector2Int zeroIndex;

    public List<Vector3> GridCoords { get => coords; }
    public Vector3[,] CoordsArray { get => coordsArray; }
    public Vector2Int FieldSize { get => fieldSize; }
    public Vector2Int ZeroIndex { get => zeroIndex; }


    private void Start()
    {
        GenerateField();
        ActivateRandomCell();
    }

    private void GenerateField()
    {
        GetCoords();
        for (int i = 0; i < coords.Count; i++)
        {
            GameObject cell = Instantiate(CellPrefab, transform);
            cell.transform.position = coords[i];
            cells.Add(cell);
            cell.SetActive(false);
        }
    }

    public void GetCoords()
    {
        GridCoordinates grid = new GridCoordinates(fieldSize, spacingOffset);
        coords = grid.Coords;
        coordsArray = grid.CoordsArray;
        zeroIndex = grid.GridZeroIndex;
    }

    GameObject activeCell;
    public void ActivateRandomCell()
    {
        if (activeCell != null)
        {
            activeCell.SetActive(false);
        }
        int index = Random.Range(0, cells.Count);
        cells[index].SetActive(true);
        activeCell = cells[index];
        activeCell.SetActive(true);
        Animator anim = activeCell.GetComponent<Animator>();
        anim.runtimeAnimatorController = controller;
        anim.Play("Appearance");
        StartCoroutine(Appear(anim));
    }

    IEnumerator Appear(Animator animator)
    {
        yield return new WaitForSeconds(0.5f);
        animator.runtimeAnimatorController = null;
    }
}
