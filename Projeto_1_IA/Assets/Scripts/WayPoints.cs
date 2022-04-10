using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WayPoints : MonoBehaviour
{
    [SerializeField] private Vector3[] destinations;
    private int currentDestination;
    protected Vector3 CurrentDestination => destinations[currentDestination];

    // Start is called before the first frame update
    void Start()
    {
        currentDestination = 0;
        transform.position = destinations[0];
    }

    protected void NextDestination()
    {
        currentDestination++;
        if(currentDestination >= destinations.Length)
            currentDestination = 0;
    }
}
