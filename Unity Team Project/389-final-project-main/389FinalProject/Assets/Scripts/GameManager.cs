using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class GameManager : MonoBehaviour
{
    Scene startScene;
    GameObject spawnPoints;
    public GameObject beePlayer;
    GameObject mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        spawnPoints = GameObject.Find("SpawnPoints");
    }

    public void StartGame()
    {
        print("Start Game");
        SceneManager.LoadScene("Environment");
        SceneManager.UnloadSceneAsync("StartMenu");
        GameObject bee = Instantiate(beePlayer, new Vector3(10, 30, 10), new Quaternion());
        mainCamera = bee.transform.GetChild(1).gameObject;
        spawnPoints.GetComponent<SpawnBears>().StartSpawning();
    }

    public void GameOver()
    {
        mainCamera.SetActive(false);
    }
}
