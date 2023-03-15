using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
   public void QuitButton()
    {
        Application.Quit();
    }


    public void TryAgainButton()
    {
        Time.timeScale = 1;
        Scene scene = SceneManager.GetActiveScene(); 
        SceneManager.LoadScene(scene.name);
    }

    public void toLevel1()
    {
        Time.timeScale = 1;  
        SceneManager.LoadScene(1);
    }

    public void toLevel2()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
    }

    public void toEndless()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(3);
    }


    public void toTitle()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
