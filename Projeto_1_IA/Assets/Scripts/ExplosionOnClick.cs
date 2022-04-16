using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ExplosionOnClick : MonoBehaviour
{
    [SerializeField] GameObject target = null;
    private Camera cam = null;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            Ray ray = cam.ScreenPointToRay(Mouse.current.position.ReadValue());
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Instantiate(target, new Vector3(hit.point.x, hit.point.y + target.transform.position.y, hit.point.z), Quaternion.identity);
            }
        }
    }
}
