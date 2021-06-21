using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    
    public float speed;
    public float rotationSpeed;
    // Update is called once per frame

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.AddRelativeForce(0, 0.01f, Input.GetAxisRaw("Vertical") * speed);
        rb.AddTorque(transform.up * rotationSpeed * Input.GetAxisRaw("Horizontal"));
    }

    
}
