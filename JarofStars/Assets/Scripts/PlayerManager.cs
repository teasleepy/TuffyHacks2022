using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerManager : MonoBehaviour
{
    //FOR FUTURE 
    //public static PlayerManager instance;
    //public Text myText;

    public int starCount;

   
    public void PickupItem()
    {
        //FOR FUTURE 
        //myText.text = starCount.ToString();

        starCount++;

    }

    
}
