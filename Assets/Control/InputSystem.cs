using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputSystem : MonoBehaviour
{
    GameField gameField;
    Vector2Int index;
    private PlayerInput input;
    Vector3 currentPos;
    Vector2 moveInput;
    float Speed = 5;
    Vector3 borders = new Vector3(4.4f, 4.4f);

    private void Awake()
    {
        gameField = GetComponentInParent<GameField>();
        gameField.GetCoords();
        index.x = gameField.ZeroIndex.x;
        index.y = gameField.ZeroIndex.y;
        Debug.Log(index);
        currentPos = gameField.CoordsArray[index.x, index.y];

        input = GetComponent<PlayerInput>();

        //foreach (var item in gameField.CoordsArray)
        //{
        //    Debug.Log(item);
        //}

        //   input.onActionTriggered += Input_onActionTriggered;
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

    public void SetMoveInput(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();

        if (context.started)
        {
            if (moveInput.x > 0)
            {
                if (index.x < gameField.FieldSize.x - 1)
                    index.x++;
            }
            else if (moveInput.x < 0)
            {
                if (index.x > 0)
                    index.x--;
            }

            if (moveInput.y > 0)
            {
                if (index.y < gameField.FieldSize.y - 1)
                    index.y++;
            }
            else if (moveInput.y < 0)
            {
                if (index.y > 0)
                    index.y--;
            }
            Debug.Log(index);
        }
    }
}
