using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
   private int numberOfHits;

   private void Start()
   {
      numberOfHits = 0;
   }

   private void OnCollisionEnter(Collision other)
   {
      if(other.gameObject.CompareTag("Hit"))
         return;
      numberOfHits++;
      Debug.Log($"You have collided with walls {numberOfHits} times", other.gameObject);
   }
}
