using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoverCamara : MonoBehaviour
{
    private Vector3 NuevaPosicion;
    public float velocidad;
    public float tiempo;
    private Vector3 OrigenMovimiento;
    private bool movimientoRaton = false;
    public Canvas miCanvas;

    void Update()
    {
        
        if (miCanvas.gameObject.activeSelf)
        {
            
            if (Input.GetKeyDown(KeyCode.X))
            {
                movimientoRaton = true;
            }
            else if (Input.GetKeyDown(KeyCode.O))
            {
                movimientoRaton = false;
            }

            
            if (movimientoRaton)
            {
                PanCamara();
            }
            else
            {
                MovCamara();
            }
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
