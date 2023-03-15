using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerShoot : MonoBehaviour
{
    public GameObject projectile;
    public float range;
    public float attackSpeed;
    public float projSpeed;
    public AudioClip harp;

    private bool canFire = true;

    private void Start()
    {
        canFire = true;
    }

    private void OnTriggerStay(Collider other)
    {
        
        if (other.gameObject.tag == "Enemy")
        {
            //print("Hit enemy");
            if (canFire)
            {
                //Fire
                AudioSource.PlayClipAtPoint(harp, transform.position, 0.1f);
                GameObject temp = Instantiate(projectile);
                temp.transform.position = transform.position;
                Vector3 dir = (other.gameObject.transform.position - transform.position).normalized;
                temp.GetComponent<Rigidbody>().velocity = dir * projSpeed;
                Physics.IgnoreCollision(temp.GetComponent<Collider>(), GetComponent<CapsuleCollider>());
                Physics.IgnoreCollision(temp.GetComponent<Collider>(), GetComponent<SphereCollider>());



                canFire = false;
                StartCoroutine(fireCooldown());
            }
        }
    }
    
    IEnumerator fireCooldown() {

        yield return new WaitForSeconds(1 / attackSpeed);
        canFire = true;
    
    }


}
