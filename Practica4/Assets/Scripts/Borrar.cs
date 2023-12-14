using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Borrar : MonoBehaviour
{
    public float radius = 1;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            int layerMask = 1 << 0;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity,layerMask))
            {
                    Destroy(hit.collider.gameObject);
             
            }
        }
    }
}
