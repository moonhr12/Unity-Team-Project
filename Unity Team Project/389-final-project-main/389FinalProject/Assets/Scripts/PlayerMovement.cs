using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 10.0f;

    private CharacterController cc;

    void Start()
    {
        cc = gameObject.GetComponent<CharacterController>();

    }

    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            cc.Move(transform.forward * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            cc.Move(-transform.forward * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            cc.Move(-transform.right * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            cc.Move(transform.right * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            cc.Move(-transform.up * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            cc.Move(transform.up * speed * Time.deltaTime);
        }
    }
}
