using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Wall : Grid, IMovable
{
    float speed = 5;
    [SerializeField]
    private UnityEvent Actions;

    public Cell brick;

    void Update()
    {
        Movement();
    }
    public void Movement()
    {
        
        Vector3 targetPosition = new Vector3(-11f, 0);
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime * speed);
        ////////////////Самокат
        if (transform.position == targetPosition)
        {
            DestoySelf();
        }
        /////////////////
    }


    public void DestoySelf()
    {
        Destroy(this.gameObject);
    }
    public void GenerateWall()
    {
        GenerateGrid();
        int removeIndex = Random.Range(0, cells.Count);
        Destroy(cells[removeIndex].gameObject);
        cells.RemoveAt(removeIndex);
        ShuffleBricks();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Done!");
        Actions?.Invoke();
        GetComponent<BoxCollider2D>().enabled = false;
    }

    void ShuffleBricks()
    {
        for (int i = 0; i < cells.Count; i++)
        {
            
            Vector3 currentCellPosition = cells[i].gameObject.transform.position;
            float x = Randomizer(currentCellPosition.x, currentCellPosition.x + gridSpacingOffset * 2, currentCellPosition.x - gridSpacingOffset * 2);
            Vector3 newPosition = new Vector3(x, currentCellPosition.y);
            cells[i].gameObject.transform.position = newPosition;
        }
    }

    float Randomizer(float one, float two, float three)
    {
        float randomValue = Random.value;

        bool first = randomValue <= 0.33f;
        bool second = randomValue > 0.33f && randomValue <= 0.66;
        bool third = randomValue > 0.66f;

        if (first)
        {
            return one;
        }
        else if (second)
        {
            return two;
        }
        else if (third)
        {
            return three;
        }
        else return 0;
    }
}
