using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuPrincipal : MonoBehaviour
{
    public Canvas menu1;
    public Canvas menu2;
    public Canvas menu3;
    public Canvas menu4;

    void Start()
    {
        
        menu1.gameObject.SetActive(true);
        menu2.gameObject.SetActive(false);
        menu3.gameObject.SetActive(false);
        menu4.gameObject.SetActive(false);
    }

    public void MostrarCanvasMenu1()
    {
        menu1.gameObject.SetActive(true);
        menu2.gameObject.SetActive(false);
        menu3.gameObject.SetActive(false);
        menu4.gameObject.SetActive(false);
    }

    public void MostrarCanvasMenu2()
    {
        menu1.gameObject.SetActive(false);
        menu2.gameObject.SetActive(true);
        menu3.gameObject.SetActive(false);
        menu4.gameObject.SetActive(false);
    }

    public void MostrarCanvasMenu3()
    {
        menu1.gameObject.SetActive(false);
        menu2.gameObject.SetActive(false);
        menu3.gameObject.SetActive(true);
        menu4.gameObject.SetActive(false);
    }
    public void MostrarCanvasMenu4()
    {
        menu1.gameObject.SetActive(false);
        menu2.gameObject.SetActive(false);
        menu3.gameObject.SetActive(false);
        menu4.gameObject.SetActive(true);
    }
}
