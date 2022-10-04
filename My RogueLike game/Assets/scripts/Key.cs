using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : Pickup
{
    private GameManager gm;
    
   void OnTriggerEnter2D(Collider other)
    {
        if(other.gameObject.CompareTag('Player'))
        {
            gm.AddKey(amount);
            Destroy(GameObject);
        }
    }
}
