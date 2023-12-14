using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorrarTodo : MonoBehaviour
{
    public List<GameObject> objetosEnEscena;
    void Update()
    {
        GameObject.FindGameObjectsWithTag("arbol");



    }
    public void BorrarTodosObjetos()
    {
        foreach (GameObject arbol in objetosEnEscena)
        {
            
            Destroy(arbol.gameObject);
        }
    }
}
