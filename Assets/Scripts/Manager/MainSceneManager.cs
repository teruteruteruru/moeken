using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSceneManager : MonoBehaviour
{
    private Playerdata playerData;
    string fileName = "PlayerData.json";
    void Awake()
    {
       string PlayerDataPath = Resources.Load<TextAsset>(fileName).ToString();
       playerData = JsonUtility.FromJson<Playerdata>(PlayerDataPath);
    }
}
