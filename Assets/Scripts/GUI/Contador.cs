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

    public void PausarContador()
    {

        if (Time.timeScale==0)
        {
            Debug.Log("tiempo reanudado");
            Time.timeScale = 1;
            //GameObject.Find("ButtonPauseText").GetComponent<TextMeshProUGUI>().text = "Pausar";
        }
        else
        {
            Debug.Log("tiempo en pausa");
            Time.timeScale = 0;
            //GameObject.Find("ButtonPauseText").GetComponent<TextMeshProUGUI>().text = "Reanudar";
        }
    }
}
