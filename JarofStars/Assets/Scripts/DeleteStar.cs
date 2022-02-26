using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteStar : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        JanitorManager janmanager = collision.GetComponent<JanitorManager>();
        if (janmanager)
        {
            
            //star will dissapear once touched by player
            //Destroy(gameObject);
            transform.position = new Vector2(1, 6);
        }
        
    }
}
