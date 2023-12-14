using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CreacionMenu : MonoBehaviour
{
    public GameObject arbolPrefab;
    public GameObject cabanaPrefab;
    public GameObject puentePrefab;
    public GameObject otroPrefab;

    private GameObject objetoACrear;

    float radioAreaInfluencia = 55f;

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            int layerMask = 1 << LayerMask.NameToLayer("Ground");

            if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
            {
                if (objetoACrear != null)
                {
                    Collider[] colliders = Physics.OverlapSphere(hit.point, radioAreaInfluencia);
                    Debug.Log("Cantidad de colliders detectados: " + colliders.Length);

                    if (colliders.Length == 1)
                    {
                        Instantiate(objetoACrear, hit.point, Quaternion.identity);   
                    }
                    else
                    {
                        Debug.Log("Hay objetos muy cerca.");
                    }
                }
            }
        }
    }

   
    public void SeleccionarArbol()
    {
        objetoACrear = arbolPrefab;
        Debug.Log("objeto creado");
    }

    public void SeleccionarCabana()
    {
        objetoACrear = cabanaPrefab;
        Debug.Log("objeto creado");
    }

    public void SeleccionarPuente()
    {
        objetoACrear = puentePrefab;
        Debug.Log("objeto creado");
    }

    public void SeleccionarOtro()
    {
        objetoACrear = otroPrefab;
        Debug.Log("objeto creado");
    }
}
