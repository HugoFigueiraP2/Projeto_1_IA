using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPC_AI_One : MonoBehaviour
{
    [SerializeField] private Transform destiny;
    private NavMeshAgent npc;
    private int rnd;

    // Start is called before the first frame update
    void Start()
    {
        npc = GetComponent<NavMeshAgent>();
        npc.SetDestination(destiny.position);
    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.name == "Destiny")
        {
            rnd = Random.Range(0, 5);
            Invoke("Destination", rnd);
        }
    }

    private void Destination()
    {
        npc.SetDestination(destiny.position);
    }
}
