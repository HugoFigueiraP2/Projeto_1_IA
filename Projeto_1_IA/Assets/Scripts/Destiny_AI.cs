using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destiny_AI : WayPoints
{
    private void OnTriggerEnter(Collider col)
    {
        if(col.name == "AI_Agent")
        {
            NextDestination();
            transform.position = CurrentDestination;
        }
    }
}
