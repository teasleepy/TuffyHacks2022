using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //verify if colliding with player
        PlayerManager manager = collision.GetComponent<PlayerManager>();
        if(manager)
        {
            manager.PickupItem();

            //star will dissapear once touched by player
            //Destroy(gameObject);
            transform.position = new Vector2(1, 6);
        }
    }
   }
