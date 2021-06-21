using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crowd : MonoBehaviour
{
    Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void OnEnable()
    {
        FindObjectOfType<EventManager>().OnGoal += CrowdCheer;       
    }

    private void OnDisable()
    {
        FindObjectOfType<EventManager>().OnGoal -= CrowdCheer;
    }

    void CrowdCheer()
    {
        print("The Crowd Goes Wild");
        rb.AddForce(0, 5, 0, ForceMode.Impulse);
    }
}
