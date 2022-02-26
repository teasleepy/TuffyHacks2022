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

            //star will be reset once touched by player

            //so that stars won't appear in same position every time 
            float randomNumber = Random.Range(-8, 8);

            transform.position = new Vector2(randomNumber, 7); //FOR FUTURE change y position to random too?

            //reset velocity (of the falling star) to 0 
            rb = GetComponent<Rigidbody2D>();
            rb.velocity = new Vector2(0, 0);

        }
    }
   }
