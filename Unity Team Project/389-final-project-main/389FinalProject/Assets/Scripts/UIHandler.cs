using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIHandler : MonoBehaviour
{
    GameObject gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager");
    }
    public void OnStartButtonClick()
    {
        gameManager.GetComponent<GameManager>().StartGame();
    }
}
