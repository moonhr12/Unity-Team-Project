using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VictoryScript : MonoBehaviour
{
    public Canvas victoryCanvas;
    public Canvas overlay;
    public Text waveNum;

    GameObject[] enemies;

    private void Start()
    {
        victoryCanvas.enabled = false;
    }
    private void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        int waveNumber = GetComponent<SpawnBears>().waveNumber;

        waveNum.text = "Wave: " + waveNumber;


        print(enemies.Length);
        if(enemies.Length == 0 && waveNumber > 5)
        {
            
            victoryCanvas.enabled = true;
            overlay.enabled = false;
            Time.timeScale = 0;
        }
    }

}
