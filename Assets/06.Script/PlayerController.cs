using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    // 플레이어 캐릭터의 움직임과 관련된 변수 
    public float moveSpeed = 3.0f;
    public InputAction MoveAction;
    Rigidbody2D rigidbody2d;
    Vector2 move;


    // Start는 첫 번째 프레임 업데이트 전에 호출됩니다 
    void Start()
    {
        MoveAction.Enable();
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update는 프레임당 한 번씩 호출됩니다 
    void Update()
    {
        move = MoveAction.ReadValue<Vector2>();
        Debug.Log(move);
    }


    void FixedUpdate()
    {
        Vector2 position = (Vector2)rigidbody2d.position + move * moveSpeed * Time.deltaTime;
        rigidbody2d.MovePosition(position);
    }
}