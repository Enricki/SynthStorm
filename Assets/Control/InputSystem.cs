using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.OnScreen;

public class InputSystem : MonoBehaviour
{
    public OnScreenStick stick;

    [SerializeField]
    private float Speed = 5;

    private GameField gameField;
    private Vector2 moveInput;
    private Vector2Int targetIndexer;
    private Vector3 target;

    private void Awake()
    {
        gameField = GetComponentInParent<GameField>();
        gameField.GetCoords();

        targetIndexer.x = gameField.ZeroIndex.x;
        targetIndexer.y = gameField.ZeroIndex.y;
        target = gameField.CoordsArray[targetIndexer.x, targetIndexer.y];
    }

    private void Update()
    {
        Move();
    }

    //Move Player in space from start postion to target cell;
    void Move()
    {
        target = gameField.CoordsArray[targetIndexer.x, targetIndexer.y];
        transform.localPosition = Vector3.MoveTowards(transform.localPosition, target, Time.deltaTime * Speed);
    }

    //Check if input is on and set target direction (Must be lincked in Inspector);
    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();

        if (context.performed)
        {
            ChangeTarget(moveInput);
        }

        if (context.canceled)
        {
            StopAllCoroutines();
        }
    }

    //Recursion method for ChangeCoords
    void ChangeTarget(Vector2 direction)
    {
        StartCoroutine(ChangeCoords(direction));
    }

    //Change coordinates relative to the direction
    private IEnumerator ChangeCoords(Vector2 direction)
    {
        if (direction.x > 0)
        {
            if (targetIndexer.x >= gameField.FieldSize.x - 1)
            {
                targetIndexer.x = gameField.FieldSize.x - 1;
            }
            else
            {
                targetIndexer.x++;
            }
        }
        else if (direction.x < 0)
        {
            if (targetIndexer.x <= 0)
            {
                targetIndexer.x = 0;
            }
            else
            {
                targetIndexer.x--;
            }
        }
        else if (direction.y > 0)
        {
            if (targetIndexer.y >= gameField.FieldSize.y - 1)
            {
                targetIndexer.y = gameField.FieldSize.y - 1;
            }
            else
            {
                targetIndexer.y++;
            }
        }
        else if (direction.y < 0)
        {
            if (targetIndexer.y <= 0)
            {
                targetIndexer.y = 0;
            }
            else
            {
                targetIndexer.y--;
            }
        }
        yield return new WaitForSeconds(0.16f);
        ChangeTarget(direction);
    }
}
