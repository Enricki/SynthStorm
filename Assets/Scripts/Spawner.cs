using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner: MonoBehaviour 
{
    public GameField gridPrefab;
    //public Wall wallPrefab;
    public Player playerPrefab;

    GameField grid;
    Player player;

    public void Spawn()
    {
        grid = Instantiate(gridPrefab, null);
        grid.transform.position = Vector3.zero;
//        grid.GenerateGrid();


        //Wall wall = Instantiate(wallPrefab, null);
        //wall.transform.position = new Vector3 (grid.gridBorders.x + 6 * grid.gridSpacingOffset, 0);
        //wall.GenerateWall();

        player = Instantiate(playerPrefab);
        player.transform.position = Vector3.zero;
    }

    public void Despawn()
    {
        Destroy(grid.gameObject);
        Destroy(player.gameObject);
    }

    public void OnOffSwitch()
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }
}
