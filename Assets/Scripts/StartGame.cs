using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class StartGame : MonoBehaviour
{

    public string sceneCredits;
    public static int dificuldade;
    
    Dictionary<int, string> cenas = new Dictionary<int, string>(){{0, "EasyGame"}, {1, "MediumGame"}, {2, "HardGame"}};
    
    public void StarGame()
    {   
        SceneManager.LoadScene(cenas[dificuldade]);    
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Credits()
    {
        SceneManager.LoadScene(sceneCredits);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
