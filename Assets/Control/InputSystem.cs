using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputSystem : MonoBehaviour
{
    private PlayerInput input;
    Vector3 currentPos;
    Vector2 moveInput;
    float Speed = 13;
    Vector3 borders = new Vector3(4.4f, 4.4f);

    private void Awake()
    {
        currentPos = transform.position;
        input = GetComponent<PlayerInput>();
     //   input.onActionTriggered += Input_onActionTriggered;
    }

    private void Update()
    {
        if (currentPos != transform.position)
        Moving();
    }

    void Moving()
    {
        Vector3 target = transform.position;
        if (currentPos.x <= borders.x && currentPos.x >= -borders.x &&
            currentPos.y <= borders.y && currentPos.y >= -borders.y)
        {
            target = currentPos;
        }
        else
        {
            currentPos = target;
        }

        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * Speed);
    }


    public void SetMoveInput(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
        
        if (context.started)
        {
            if (moveInput.x > 0)
            {
                currentPos += Vector3.right * 1.1f;
            }
            else if (moveInput.x < 0)
            {
                currentPos += Vector3.left * 1.1f;
            }
            if (moveInput.y > 0)
            {
                currentPos += Vector3.up * 1.1f;
            }
            else if (moveInput.y < 0)
            {
                currentPos += Vector3.down * 1.1f;
            }
        }
    }
}
