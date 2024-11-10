using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public static void ToRegisterScene()
    {
       SceneManager.LoadScene("RegisterScene"); 
    }

    public static void ToMainScene()
    {
       SceneManager.LoadScene("MainScene"); 
    }
} 
