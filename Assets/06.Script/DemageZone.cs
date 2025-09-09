using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DamageZone : MonoBehaviour
{
    [SerializeField] int DemageValue;
   void OnTriggerStay2D(Collider2D other)
   {
       PlayerController controller = other.GetComponent<PlayerController>();


       if (controller != null)
       {
           controller.ChangeHealth(DemageValue);
       }
   }
}
