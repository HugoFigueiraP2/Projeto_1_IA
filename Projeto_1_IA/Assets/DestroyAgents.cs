using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAgents : MonoBehaviour
{
    [SerializeField] private GameObject go;
    private GameObject target;

    private void Start()
    {
        target = Instantiate(go);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(GameObject.FindGameObjectWithTag("Cube"));
    }
}
