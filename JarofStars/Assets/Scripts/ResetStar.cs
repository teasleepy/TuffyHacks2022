using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetStar : MonoBehaviour
{
    public Rigidbody2D rb;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        JanitorManager janmanager = collision.GetComponent<JanitorManager>();
        if (janmanager)
        {

            //star will dissapear once touched by player
            //Destroy(gameObject);

            float randomNumber_x= Random.Range(-8, 8);
            

            transform.position = new Vector2(randomNumber_x, 15);


            //reset velocity (of the falling star) to 0 
            rb = GetComponent<Rigidbody2D>();
            rb.velocity = new Vector2(0, 0);


        }
        
    }
}
