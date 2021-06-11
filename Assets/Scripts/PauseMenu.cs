using System.Security.Cryptography;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public string sceneMenu;

    public GameObject pauseMenuUI;
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                Resume();
            } else
            {
                Pause();
            }
        }
    }

    void Resume()
    {   
        pauseMenuUI.SetActive(false);
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        GameIsPaused = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void MainMenu()
    {
        GameIsPaused = false;
        SceneManager.LoadScene(sceneMenu); 
        PickupsManager.setOrbToFalse();
    }

    public void Restart()
    {
        GameIsPaused = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        PickupsManager.setOrbToFalse();
    }

    public void Exit()
    {
        Application.Quit();
    }
}
