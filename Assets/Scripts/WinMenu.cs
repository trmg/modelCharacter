using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    public string sceneMenu;
   
    public void MainMenu()
    {
        SceneManager.LoadScene(sceneMenu); 
    }
}
   
