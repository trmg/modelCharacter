using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadMenu : MonoBehaviour
{
    public string sceneMenu;
    
    public void MainMenu()
    {
        SceneManager.LoadScene(sceneMenu); 
        PickupsManager.setOrbToFalse();
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
