using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public Canvas pauseMenu;
    public Canvas overlay;

    bool paused;
    void Start()
    {
        Time.timeScale = 1;
        pauseMenu.enabled = false;
        paused = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused)
            {
                unpause();
            }
            else
            {
                pauseMenu.enabled = true;
                overlay.enabled = false;
                paused = true;
                Time.timeScale = 0;
            }
        }
    }


    public void unpause()
    {
        pauseMenu.enabled = false;
        paused = false;
        overlay.enabled = true;
        Time.timeScale = 1;
    }

    public void quit()
    {
        Application.Quit();
    }

    public void toTitle()
    {
        SceneManager.LoadScene(0);
    }


}
