using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
   // 플레이어 캐릭터 이동 관련 변수
   public InputAction MoveAction;
   Rigidbody2D rigidbody2d;
   Vector2 move;
   public float speed = 3.0f;


   // 체력 시스템 관련 변수
   public int maxHealth = 5;
   public int health { get { return currentHealth; } }

   public int currentHealth = 1;

   // 데미지존 주기 변수
   public float timeInvincible = 2.0f;
   bool isInvincible;
   float damageCooldown;
   // 힐존 주기 변수
   public float hilltime = 1.0f;
   bool ishill;
   float hillcooldown;

   // Start는 첫 프레임 업데이트 전 호출됩니다.
   void Start()
   {
      MoveAction.Enable();
      rigidbody2d = GetComponent<Rigidbody2D>();
      //currentHealth = maxHealth;
   }

   // Update is called once per frame
   void Update()
   {
      move = MoveAction.ReadValue<Vector2>();

      if (isInvincible)
      {
         damageCooldown -= Time.deltaTime;
         if (damageCooldown < 0)
         {
            isInvincible = false;
         }
      }
      if (ishill)
      {
         hillcooldown -= Time.deltaTime;
         if (hillcooldown < 0)
         {
            ishill = false;
         }
      }

   }

   // FixedUpdate는 물리 시스템과 동일한 호출 빈도를 가집니다.
   void FixedUpdate()
   {
      Vector2 position = (Vector2)rigidbody2d.position + move * speed * Time.deltaTime;
      rigidbody2d.MovePosition(position);
   }


   public void ChangeHealth(int amount)
   {
      if (amount < 0)
      {
         if (isInvincible)
         {
            return;
         }
         isInvincible = true;
         damageCooldown = timeInvincible;
      }
      else if (amount > 0)
      {
         if (ishill)
         {
            return;
         }
         ishill = true;
         hillcooldown = hilltime;
      }
      currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
      Debug.Log(currentHealth + "/" + maxHealth);
   }
   
}