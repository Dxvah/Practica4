using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuPrincipal : MonoBehaviour
{
    public Canvas menu;
    public Canvas menucamara;
    void Start()
    {
        
    }
    public void MostrarCanvasMenu()
    {
        menu.gameObject.SetActive(true);
        menucamara.gameObject.SetActive(false);
    }
    public void MostrarCanvasCamara()
    {
        menu.gameObject.SetActive(false);
        menucamara.gameObject.SetActive(true);
    }
    
    void Update()
    {
        
    }
}
