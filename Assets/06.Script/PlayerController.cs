using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public InputAction LeftAction;
    void Start()
    {
        LeftAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = 0.0f; // 좌우
        float vertical = 0.0f;  // 상하
        // 좌우 이동 키입력
        if (LeftAction.IsPressed() || Keyboard.current.aKey.isPressed)
        {
            horizontal = -1.0f;
        }
        else if (Keyboard.current.rightArrowKey.isPressed || Keyboard.current.dKey.isPressed)
        {
            horizontal = 1.0f;
        }
        Debug.Log(horizontal);
       
        // 상하 이동 키입력
        if (Keyboard.current.downArrowKey.isPressed || Keyboard.current.sKey.isPressed)
        {
            vertical = -1.0f;
        }
        else if (Keyboard.current.upArrowKey.isPressed || Keyboard.current.wKey.isPressed)
        {
            vertical = 1.0f;
        }
        Debug.Log(horizontal);

        //이동 계산식 
        Vector2 position = transform.position;

        position.x += 0.1f * horizontal ;
        position.y += 0.1f * vertical;
        transform.position = position;
    }
}
