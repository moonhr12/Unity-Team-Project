using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileCollision : MonoBehaviour
{

    public int damage;
    private void OnCollisionEnter(Collision collision)
    {
            Destroy(gameObject);
    }
}
