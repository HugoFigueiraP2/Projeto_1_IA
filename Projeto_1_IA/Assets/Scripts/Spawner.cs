using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject AI_Agent;
    public GameObject parent;
    public int numberToSpawn;
    public int limit = 20;
    public float timer = 1.0f;

    float spawnTimer;
    
    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = timer;
    }

    // Update is called once per frame
    void Update()
    {   
        if (parent.transform.childCount < limit)
        {
            spawnTimer -= Time.deltaTime;
            if (spawnTimer <= 0f)
            {
                for (int i = 0; i < numberToSpawn; i++)
                {
                    Instantiate(AI_Agent, new Vector3(this.transform.position.x + GetModifier(),
                        this.transform.position.y + GetModifier()), Quaternion.identity, parent.transform);
                }
                spawnTimer = timer;
            }
        }
        
    }

    float GetModifier()
    {
        float modifier = Random.Range(0f, 1f);
        if (Random.Range(0, 2) > 0)
            return -modifier;
        else
            return modifier;
    }
}
