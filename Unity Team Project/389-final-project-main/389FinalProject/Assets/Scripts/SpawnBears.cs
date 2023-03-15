using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnBears : MonoBehaviour
{
    GameObject spawnPoint1, spawnPoint2, spawnPoint3;
    public GameObject bear;



    //Variables for level 1
    public int waveNumber;
    public int bearAdder;


    void Start()
    {
        spawnPoint1 = GameObject.Find("SP1");
        spawnPoint2 = GameObject.Find("SP2");
        spawnPoint3 = GameObject.Find("SP3");
        int index = SceneManager.GetActiveScene().buildIndex;
        if(index == 3)
        {
            runEndless();
        }
        else
        {
            runLevelOne();
        }
    }

    public void StartSpawning() {
        StartCoroutine(BearSpawn());
    }

    private IEnumerator BearSpawn()
    {
        for (int i = 0; i < 100; i++)
        {
            GameObject clone1 = Instantiate(bear, spawnPoint1.transform.position, spawnPoint1.transform.rotation);
            clone1.GetComponent<Chaser>().player = GameObject.Find("TreeToProtect");

            GameObject clone2 = Instantiate(bear, spawnPoint2.transform.position, spawnPoint2.transform.rotation);
            clone2.GetComponent<Chaser>().player = GameObject.Find("TreeToProtect");

            GameObject clone3 = Instantiate(bear, spawnPoint3.transform.position, spawnPoint3.transform.rotation);
            clone3.GetComponent<Chaser>().player = GameObject.Find("TreeToProtect");

            yield return new WaitForSeconds(4.0f);
        }
    }

    public void runLevelOne()
    {
        waveNumber = 0;
        bearAdder = 2;
        StartCoroutine(levelOne());
    }

    public void runEndless()
    {
        waveNumber = 0;
        bearAdder = 1;
        StartCoroutine(endlessLevel());
    }
    private IEnumerator levelOne()
    {

        for (int i = 0; i < 5 + (bearAdder * waveNumber); i++) { 
        GameObject clone1 = Instantiate(bear, spawnPoint1.transform.position, spawnPoint1.transform.rotation);
        clone1.GetComponent<Chaser>().player = GameObject.Find("TreeToProtect");

        GameObject clone2 = Instantiate(bear, spawnPoint2.transform.position, spawnPoint2.transform.rotation);
        clone2.GetComponent<Chaser>().player = GameObject.Find("TreeToProtect");

        GameObject clone3 = Instantiate(bear, spawnPoint3.transform.position, spawnPoint3.transform.rotation);
        clone3.GetComponent<Chaser>().player = GameObject.Find("TreeToProtect");
        }
        waveNumber++;

        yield return new WaitForSeconds(30.0f);
        if(waveNumber < 6)
            StartCoroutine(levelOne());
    }

    private IEnumerator endlessLevel()
    {
        for (int i = 0; i < 1 + (bearAdder * waveNumber); i++)
        {
            GameObject clone1 = Instantiate(bear, spawnPoint1.transform.position, spawnPoint1.transform.rotation);
            clone1.GetComponent<Chaser>().player = GameObject.Find("TreeToProtect");

            GameObject clone2 = Instantiate(bear, spawnPoint2.transform.position, spawnPoint2.transform.rotation);
            clone2.GetComponent<Chaser>().player = GameObject.Find("TreeToProtect");

            GameObject clone3 = Instantiate(bear, spawnPoint3.transform.position, spawnPoint3.transform.rotation);
            clone3.GetComponent<Chaser>().player = GameObject.Find("TreeToProtect");
        }
        waveNumber++;
        if (waveNumber % 5 == 0)
            bearAdder++;
        yield return new WaitForSeconds(10.0f);
        StartCoroutine(endlessLevel());

    }
}
