using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallReset : MonoBehaviour
{
    Vector3 originalPos;
    Rigidbody rb;
    
    
    private void Start()
    {
        //Gets and stores ball's original position
        originalPos = gameObject.transform.position;
        rb = GetComponent<Rigidbody>();
    }
    private void OnEnable()
    {
        FindObjectOfType<EventManager>().OnGoal += BallPosReset;
    }

    private void Disable()
    {
        FindObjectOfType<EventManager>().OnGoal += BallPosReset;
    }

    void BallPosReset()
    { 
        StartCoroutine("ResetBall");
    }

    //Wait 3 seconds, set velocity to 0, return to beginning position
    IEnumerator ResetBall()
    {                          
        yield return new WaitForSeconds(3);        
        rb.velocity = new Vector3(0, 0, 0);
        gameObject.transform.position = originalPos;
    }
}
