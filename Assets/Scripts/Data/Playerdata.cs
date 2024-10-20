using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerdata
{
   
    public float PlayerWeight => playerWeight;
    public float PlayerHeight => playerHeight;
    public int PlayerAge => playerAge;
 
    private float playerWeight;
    private float playerHeight;
    private int playerAge;

    public Playerdata()
    {
        playerWeight = 0f;
        playerHeight = 0f;
        playerAge = 0;
    }
}

