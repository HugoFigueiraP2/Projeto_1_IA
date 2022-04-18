using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAgents : MonoBehaviour
{
    public GameObject agent;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(agent);
    }
}
