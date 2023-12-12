using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CreacionMenu : MonoBehaviour
{
    public Text contadorText;
    public GameObject arbolPrefab;
    public GameObject cabanaPrefab;
    public GameObject puentePrefab;
    public GameObject otroPrefab;
    public GameObject canvasObj;

    private int contadorTotal = 0;

    void Start()
    {
        DesactivarCanvasInicial();
    }

    void DesactivarCanvasInicial()
    {
        Canvas canvas = canvasObj.GetComponent<Canvas>();
        if (canvas != null)
        {
            canvas.enabled = false;
        }
    }

    public void ActivarCanvas()
    {
        Canvas canvas = canvasObj.GetComponent<Canvas>();
        if (canvas != null)
        {
            canvas.enabled = true;
        }
    }

    public void CrearArbol()
    {
        ActivarCanvas();
        CrearObjeto(arbolPrefab);
    }

    public void CrearCabana()
    {
        ActivarCanvas();
        CrearObjeto(cabanaPrefab);
    }

    public void CrearPuente()
    {
        ActivarCanvas();
        CrearObjeto(puentePrefab);
    }

    public void CrearOtro()
    {
        ActivarCanvas();
        CrearObjeto(otroPrefab);
    }

    void CrearObjeto(GameObject prefab)
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        int layerMask = 3 << LayerMask.NameToLayer("Ground");

        if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
        {
            Instantiate(prefab, hit.point, Quaternion.identity);
            contadorTotal++;
            contadorText.text = "Total: " + contadorTotal.ToString();
            Invoke("DesactivarCanvas", 2f);
        }
    }

    void DesactivarCanvas()
    {
        Canvas canvas = canvasObj.GetComponent<Canvas>();
        if (canvas != null)
        {
            canvas.enabled = false;
        }
    }
}
