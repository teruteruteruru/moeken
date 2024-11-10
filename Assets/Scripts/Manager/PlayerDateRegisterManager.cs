using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class PlayerDataRegisterManager : MonoBehaviour
{
    [SerializeField] TMP_InputField inputName;
    [SerializeField] TMP_InputField inputAge;
    [SerializeField] TMP_InputField inputHeight;

    string filePath;
    string fileName = "PlayerData.json";
    void Awake()
    {
        filePath = Application.persistentDataPath + "/Resources/" + fileName;
    }
    
    public void RegisterPlayerData()
    {
        string name = inputName.text;
        string age = inputAge.text;
        string height = inputHeight.text;

        Playerdata playerdata = new Playerdata();
        
        playerdata.SetPlayerHeight(height);
        playerdata.SetPlayerWeight(age);
        playerdata.SetPlayerAge(name);
        
        var playerDataJson = JsonUtility.ToJson(playerdata);
        StreamWriter writer = new StreamWriter(filePath);
        writer.WriteLine(playerDataJson);
        writer.Close();
        
        SceneChanger.ToMainScene();
    }
}
