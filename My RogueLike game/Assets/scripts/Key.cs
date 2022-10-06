using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : Pickups
{
    private GameManager gm;
    
    void Start()
    {
        gm = GameObject.Find("GameManager"). GetComponent<GameManager>();
    }

   void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            gm.AddKey(amount);
            Destroy(gameObject);
        }
    }
}
