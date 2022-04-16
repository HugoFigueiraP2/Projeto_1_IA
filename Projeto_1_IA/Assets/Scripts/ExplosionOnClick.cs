using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionOnClick : MonoBehaviour
{
    [SerializeField] private GameObject target;
    private GameObject explosion;
    Vector3 mouse;
    float x, y;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mouse.x = Input.mousePosition.x;
        x = mouse.x;
        mouse.y = Input.mousePosition.y;
        y = mouse.y;
        if (Input.GetMouseButtonDown(0))
            explosion = Instantiate(target, new Vector3(x, y, 0), Quaternion.identity);
    }
}
