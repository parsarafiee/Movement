using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;

    Vector3 velocity;

    public float gravity = -9.81f;

    public Transform groundCheck;
    public float groundDistanc=0.4f;

    public LayerMask groundMask;

    bool isgrounded;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //isgrounded = Physics.CheckSphere(groundCheck.position, groundDistanc, groundMask);
        
        //if (isgrounded&& velocity.y <0)
        //{
        //    velocity.y = -2f;
        //}
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right *x+transform.forward*z;

        controller.Move(move* speed*Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}
