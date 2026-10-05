using System;
using TMPro;
using UnityEngine;

public class RotateCoin : MonoBehaviour
{
    public float velocidad;

    public int contador;

    public TMP_Text textoUI;


    void Update()
    {
        transform.Rotate(velocidad, 0, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        //Leemos textoUI y lo transformamos a Entero
        contador = Convert.ToInt32(textoUI.text);
        contador = contador + 1;
 
        //Cambiamos contador a string y se lo asignamos al textoUI
        textoUI.text = contador.ToString();
        Debug.Log("Tienes "+ contador+ " monedas"); 
        Destroy(gameObject);
    }
}
