using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float kickForce;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();     
    }

    //Ball movement if kicked by player, in the direction player is facing
    void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
            if (Input.GetKey("e"))
            {
                Vector3 direction = (collision.transform.position - this.transform.position).normalized;
                rb.AddForce(-direction * kickForce, ForceMode.Impulse);
            }
        }
    }    
    
}
