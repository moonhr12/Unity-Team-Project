using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{

    public Canvas gameOver;
    public Canvas overlay;
    public AudioClip defeatNoise;



    private void Start()
    {
        gameOver.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Time.timeScale = 0;
            gameOver.enabled = true;
            overlay.enabled = false;
            AudioSource.PlayClipAtPoint(defeatNoise, Vector3.zero);
            GameObject.Find("Music").GetComponent<AudioSource>().enabled = false;
        }
    }
}
