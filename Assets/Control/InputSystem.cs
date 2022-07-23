using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.OnScreen;

public class InputSystem : MonoBehaviour
{
    GameField gameField;
    Vector2Int index;
    private PlayerInput input;
    Vector3 currentPos;
    Vector2 moveInput;
    float Speed = 7;
    Vector3 borders = new Vector3(4.4f, 4.4f);
    public
    OnScreenStick stick;
    private void Awake()
    {
        gameField = GetComponentInParent<GameField>();
        gameField.GetCoords();
        index.x = gameField.ZeroIndex.x;
        index.y = gameField.ZeroIndex.y;

        currentPos = gameField.CoordsArray[index.x, index.y];

        input = GetComponent<PlayerInput>();
    }

    private void Update()
    {
        ChangePosition();
    }

    void ChangePosition()
    {
        Vector3 target;
        target = gameField.CoordsArray[index.x, index.y];
        transform.localPosition = Vector3.MoveTowards(transform.localPosition, target, Time.deltaTime * Speed);
    }


    List<Vector2Int> trail = new List<Vector2Int>();


    public void SetMoveInput(InputAction.CallbackContext context)
    {



        moveInput = context.ReadValue<Vector2>();
        int x = index.x;
        int y = index.y;
        if (context.started)
        {
            timer = -1;
            trail.Clear();
            if (moveInput.x > 0)
            {
                while (x < gameField.FieldSize.x - 1)
                {
                    x++;
                    trail.Add(new Vector2Int(x, y));
                }

            }
            else if (moveInput.x < 0)
            {
                while (x > 0)
                {
                    x--;
                    trail.Add(new Vector2Int(x, y));
                }

            }

            if (moveInput.y > 0)
            {
                while (y < gameField.FieldSize.y - 1)
                {
                    y++;
                    trail.Add(new Vector2Int(x, y));
                }
            }
            else if (moveInput.y < 0)
            {
                while (y > 0)
                {
                    y--;
                    trail.Add(new Vector2Int(x, y));
                }
            }
            Repeat();
        }

        if (context.performed)
        {

        }


        if (context.canceled)
        {
            StopAllCoroutines();
            timer = -1;
            
        }
    }


    private int timer = -1;
    private IEnumerator Timer()
    {
        timer++;
        if (timer > trail.Count)
        {
            timer = trail.Count;
        }
        yield return new WaitForSeconds(0.06f);
        if (timer < trail.Count)
        {
            index = trail[timer];
        }
        
        Repeat();
    }

    private void Repeat()
    {
        StartCoroutine(Timer());
        
    }
}
