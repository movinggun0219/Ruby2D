using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    
    public InputAction MoveAction;

    void Start()
    {
        MoveAction.Enable();
        //QualitySettings.vSyncCount = 0;
        //Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        // if(Keyboard.current.upArrowKey.isPressed)
        Vector2 move = MoveAction.ReadValue<Vector2>();
        Debug.Log(move);
        Vector2 position = (Vector2)transform.position + move * 3f * Time.deltaTime;;
        transform.position = position;
    }
}
