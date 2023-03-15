using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearHealth : MonoBehaviour
{

    public int maxHealth;
    public AudioClip deathNoise;
    public int currHealth;

    public ParticleSystem bleed;
    public ParticleSystem die;

    private void Start()
    {
        currHealth = maxHealth;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Projectile")
        {
            takeDamage(collision.gameObject.GetComponent<ProjectileCollision>().damage);
            Destroy(collision.gameObject);
            bleed.Play();
        }
    }


    void takeDamage(int damage)
    {
        currHealth -= damage;
        if(currHealth <= 0)
        {
            Destroy(gameObject);

            AudioSource.PlayClipAtPoint(deathNoise, transform.position, 0.1f);
            ParticleSystem diePS = Instantiate(die, gameObject.transform.position, gameObject.transform.rotation);
            diePS.Play();
            GameObject.Find("BeePlayer").GetComponent<Spawner>().wallet += 20;
        }
    }
}
