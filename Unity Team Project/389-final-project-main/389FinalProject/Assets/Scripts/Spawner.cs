using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    public GameObject ObjectToSpawn1;
    public GameObject ObjectToSpawn2;
    public GameObject ObjectToSpawn3;
    public GameObject ObjectToSpawn4;
    public GameObject ObjectToSpawn5;
    public GameObject ObjectToSpawn6;

    public float spawnInterval = 3.0f;
    public Vector3 front = new Vector3 (0, 0, 20);

    public float timer = 0.0f;
    public float wallet = 100.0f;

    public Text walletUI;
    // Start is called before the first frame update
    void Update()
    {
        // cool down to spawn plant
        timer += Time.deltaTime;
        if (Input.GetKeyDown("1") && timer > spawnInterval && wallet >= 5)
        {
            // spawn first plant
            
            timer = 0.0f;
            GameObject clone = Instantiate(ObjectToSpawn1, transform.position + transform.TransformDirection(front), transform.rotation, null);
            clone.transform.Translate(new Vector3(0, 10, 0));
            wallet -= 5;
        }
        
        if (Input.GetKeyDown("2") && timer > spawnInterval && wallet >= 10)
        {
            // spawn second plant
            timer = 0.0f;
            GameObject clone = Instantiate(ObjectToSpawn2, transform.position + transform.TransformDirection(front), transform.rotation, null);
            clone.transform.Translate(new Vector3(0, 10, 0));
            wallet -= 10;
        }
        
        if (Input.GetKeyDown("3") && timer > spawnInterval && wallet >= 15)
        {
            // spawn third plant
            timer = 0.0f;
            GameObject clone = Instantiate(ObjectToSpawn3, transform.position + transform.TransformDirection(front), transform.rotation, null);
            clone.transform.Translate(new Vector3(0, 10, 0));
            wallet -= 15;
        }
        
        if (Input.GetKeyDown("4") && timer > spawnInterval && wallet >= 25)
        {
            // spawn forth plant
            timer = 0.0f;
            GameObject clone = Instantiate(ObjectToSpawn4, transform.position + transform.TransformDirection(front), transform.rotation, null);
            clone.transform.Translate(new Vector3(0, 10, 0));
            wallet -= 25;
        }

        if (Input.GetKeyDown("5") && timer > spawnInterval && wallet >= 35)
        {
            // spawn fifth plant
            timer = 0.0f;
            GameObject clone = Instantiate(ObjectToSpawn5, transform.position + transform.TransformDirection(front), transform.rotation, null);
            clone.transform.Translate(new Vector3(0, 10, 0));
            wallet -= 35;

        }

        if (Input.GetKeyDown("6") && timer > spawnInterval && wallet >= 65)
        {
            // spawn sixth plant
            timer = 0.0f;
            GameObject clone = Instantiate(ObjectToSpawn6, transform.position + transform.TransformDirection(front), transform.rotation, null);
            clone.transform.Translate(new Vector3(0, 10, 0));
            wallet -= 65;
        }
        
        walletUI.text = "Bank: $" + wallet;
    }

    
}
