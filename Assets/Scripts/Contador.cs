using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class Contador : MonoBehaviour
{

    public TextMeshProUGUI textoGUI;
    float contador = 0;
    float contadorEntero = 0;

    void Update()
    {
        contador = contador + Time.deltaTime;
        contadorEntero= Mathf.FloorToInt(contador);
        textoGUI.text = contadorEntero.ToString();
    }
}
