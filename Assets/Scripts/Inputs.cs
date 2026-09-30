using UnityEngine;

public class Inputs : MonoBehaviour
{
    public float velocidad;

    void Start()
    {
        Debug.Log(transform.position.z);
    }

    void Update()
    {
        // transform.Rotate(0, 1, 0);
        /*transform.Translate(0, 0,velocidad);

        if (transform.position.z > 10)
        {
            velocidad = -velocidad;
        }
        else if (transform.position.z < -10)
        {
            velocidad = -velocidad;
        }*/

        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("has pulsado la tecla w");
            transform.Translate(0, 0, velocidad);
        }

    }
}
