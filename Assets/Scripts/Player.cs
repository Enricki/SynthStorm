using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float speed = 10f;
    Grid grid;
    Vector3 upStep = new Vector3 (0, 1.1f);
    Vector3 rightStep = new Vector3(1.1f, 0);
    float x;
    float y;
    Vector3 targetPosition = new Vector3 (0.0f, 9.9f);
    
    private void Start()
    {
        grid = this.GetComponentInParent<Grid>();
        x = transform.position.x;
        y = transform.position.y;
    }

    void Movement(Vector3 targetPosition)
    {
        Vector3 movingVector = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime * speed);
        transform.position = movingVector;
    }
    bool canMove = true;
    void Controll()
    {
        if (Input.GetAxisRaw("Vertical") == 0)
        {
            canMove = true;
            StopAllCoroutines();
        }
        else if (Input.GetAxisRaw("Vertical") > 0)
        {
            if (canMove)
            {
                StartCoroutine(Move(upStep));
            }

        }
        else if (Input.GetAxisRaw("Vertical") < 0)
        {
            if (canMove)
            {
                StartCoroutine(Move(-upStep));
            }
        }
        Debug.Log(canMove);
    }


    IEnumerator Move(Vector3 vector)
    {
        Movement(vector);
        yield return new WaitForSeconds(0.3f);
        canMove = false;
    }

    private void Update()
    {
        Controll();
     //   Move();
    }
    void Move()
    {


        if (Input.GetButtonDown("UP"))
        {
            Movement(transform.position + upStep);
            Debug.Log("UP");
        }
        else if (Input.GetButtonUp("DOWN"))
        {
            Movement(transform.position - upStep);
            Debug.Log("DOWN");
        }
        else if (Input.GetButtonUp("RIGHT"))
        {
            Movement(transform.position + rightStep);
            Debug.Log("RIGHT");
        }
        else if (Input.GetButtonUp("LEFT"))
        {
            Movement(transform.position - rightStep);
            Debug.Log("LEFT");
        }


        //if (Input.anyKey)
        //{
        //    if (y <= grid.gridBorders.y && y >= -grid.gridBorders.y
        //        && x <= grid.gridBorders.x && x >= -grid.gridBorders.x)
        //    {
        //        transform.localPosition = new Vector3(x, y);
        //    }
        //    else
        //    {
        //        x = transform.localPosition.x;
        //        y = transform.localPosition.y;
        //    }
        //}

    }
}
