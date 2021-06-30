using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Umpire : MonoBehaviour
{
    public GameObject newWhistle;
    public Vector3 umpPos;
    public float umpOffset;
    public float umpZ;
    public Vector3 newWhistlePos;
    private void OnEnable()
    {
        FindObjectOfType<EventManager>().OnGoal += Whistle;
    }

    private void OnDisable()
    {
        FindObjectOfType<EventManager>().OnGoal += Whistle;
    }

    public void Whistle()
    {
        Instantiate(newWhistle, new Vector3 (1f, 1.5f, 9.6f), Quaternion.Euler(0,0,0));
    }

    public void getUmpOffset()
    {
        umpOffset = (transform.position.x +0.5f);
    }

    public void getUmpz()
    {
        umpZ = transform.position.z;
    }
    
    private void Start()
    {
        umpPos = this.transform.position;
        //newWhistlePos = 
        Debug.Log("umpire position is " + umpPos);
    }
}
