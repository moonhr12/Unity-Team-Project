using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class WASDMovementWithController : MonoBehaviour
{
    public float forwardSpeed = 5.0f;
    public float jumpSpeed = 10.0f;
    CharacterController controller;
    float fallSpeed;
    Vector3 moveVector;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        moveVector = transform.TransformDirection(Vector3.zero);
    }

    // Update is called once per frame
    void Update()
    {
        float backSpeed = forwardSpeed / 3.0f;
        float sideSpeed = forwardSpeed * 2.0f / 3.0f;
        float speed = 0.0f;
        bool moving = false;

        if (Input.GetKey(KeyCode.W))
        {
            moveVector = transform.TransformDirection(Vector3.forward);
            speed = forwardSpeed;
            moving = true;
        }

        if (Input.GetKey(KeyCode.S))
        {
            moveVector = transform.TransformDirection(-Vector3.forward);
            speed = backSpeed;
            moving = true;
        }

        if (Input.GetKey(KeyCode.A))
        {
            moveVector = transform.TransformDirection(-Vector3.right);
            speed = sideSpeed;
            moving = true;
        }

        if (Input.GetKey(KeyCode.D))
        {
            moveVector = transform.TransformDirection(Vector3.right);
            speed = sideSpeed;
            moving = true;
        }



        if (!controller.isGrounded)
        {
            Debug.Log("Falling");
            fallSpeed += Physics.gravity.y * Time.deltaTime;
            moving = false;
        } else
        {
            if (Input.GetButton("Jump"))
            {
                fallSpeed = jumpSpeed;
            }
            else
            {
                fallSpeed = 0;
            }
        }

        moveVector.y = fallSpeed;
        if (moving)
        {
            controller.Move(moveVector * speed * Time.deltaTime);
        } else
        {
            controller.Move(moveVector * Time.deltaTime);
            moveVector = Vector3.zero;
        }

    }
}
