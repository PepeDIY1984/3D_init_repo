using System;
using TMPro;
using UnityEngine;

public class Trigger_ActivateObject : MonoBehaviour
{
    public TMP_Text scoreText;
    int puntuacion;

    private void OnTriggerEnter(Collider other)
    {
        puntuacion =Convert.ToInt32(scoreText.text);
        puntuacion++;
        scoreText.text = puntuacion.ToString();
        Debug.Log("hola");
        Destroy(gameObject);
    }


}
