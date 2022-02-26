using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteStar : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {

        //Destroy(gameObject);
        transform.position = new Vector2(0, 6);
    }
}
