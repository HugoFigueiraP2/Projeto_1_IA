using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject AI_Agent;
    float timer = 0.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        timer = Time.time;
    }

    // Update is called once per frame
    void Update()
    {   
        if(Time.time - timer > 1)
        {
            Instantiate(AI_Agent, transform.position, Quaternion.identity);
            timer = Time.time;
        }
        
    }
}
