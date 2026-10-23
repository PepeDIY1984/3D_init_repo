using UnityEngine;

public class Variables : MonoBehaviour
{
    void Start()
    {
        string nombre = "Pepe";
        int vida = 100;
        double velocidad = 33.44;
        float aceleracion = 21.3f;

        Debug.Log("Tu nombre es: "+nombre);
        Debug.Log ("Tu vida es: "+vida);
        Debug.Log("Tu velocidad máxima es: "+velocidad);
        Debug.Log("Tu aceleración es: "+aceleracion);



    }

}
