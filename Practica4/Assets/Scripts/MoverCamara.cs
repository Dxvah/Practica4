using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverCamara : MonoBehaviour
{
    private Vector3 NuevaPosicion;
    public float velocidad;
    public float tiempo;
    private Vector3 OrigenMovimiento;
    public bool modoRaton = false;


    void Update()
    {
        if (modoRaton == true)
        {
            PanCamara();
        }
        else
        {
            MovCamara();
        }
    }

    void PanCamara()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 correccionEjes = new Vector3(Input.mousePosition.x, 0.0f, Input.mousePosition.y);
            OrigenMovimiento = correccionEjes;
        }
        else if (Input.GetMouseButton(0))
        {
            Vector3 correccionEjes = new Vector3(Input.mousePosition.x, 0.0f, Input.mousePosition.y);
            Vector3 Distancia = OrigenMovimiento - correccionEjes;
            transform.position += Distancia * Time.deltaTime;
        }
    }

    void MovCamara()
    {
       


        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            NuevaPosicion += transform.forward * velocidad;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            NuevaPosicion += transform.right * -velocidad;
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            NuevaPosicion += transform.forward * -velocidad;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            NuevaPosicion += transform.right * velocidad;
        }

        transform.position = Vector3.Lerp(transform.position, NuevaPosicion, Time.deltaTime * tiempo);
    }
}
