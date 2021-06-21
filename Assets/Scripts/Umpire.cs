using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Umpire : MonoBehaviour
{
    public GameObject newWhistle;
    void Start()
    {
        
    }


    void Update()
    {
        
    }

    private void OnEnable()
    {
        FindObjectOfType<EventManager>().OnGoal += Whistle;
    }

    private void OnDisable()
    {
        FindObjectOfType<EventManager>().OnGoal += Whistle;
    }

    void Whistle()
    {

        Instantiate(newWhistle, new Vector3 (1f, 1.5f, 9.6f), Quaternion.);
    }
}
