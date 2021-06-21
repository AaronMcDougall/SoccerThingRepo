using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventManager : MonoBehaviour
{
    public event Action OnGoal;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "SoccerBall")
        {
            if (OnGoal != null)
            {
                OnGoal();
            }
        }
    }
}
