using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Rigidbody2D rb;

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

            //reset velocity (of the falling star) to 0 
            rb = GetComponent<Rigidbody2D>();
            rb.velocity = new Vector2(0, 0);

        }
    }
   }
