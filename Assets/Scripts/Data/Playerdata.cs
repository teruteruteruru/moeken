using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
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

    public void SetPlayerWeight(string weight)
    {
        float.TryParse(weight, out playerWeight);
    }

    public void SetPlayerHeight(string height)
    {
        float.TryParse(height, out playerHeight);
    }

    public void SetPlayerAge(string age)
    {
        int.TryParse(age, out playerAge);
    }
}

