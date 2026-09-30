using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float velocidad;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //Debug.Log("me muevo hacia delante");
            transform.Translate(0, 0, velocidad); //x,y,z
        }
        if (Input.GetKey(KeyCode.A))
        {
            //Debug.Log("me muevo hacia izq");
            transform.Translate(-velocidad, 0, 0); //x,y,z
        }
        if (Input.GetKey(KeyCode.D))
        {
            //Debug.Log("me muevo hacia dech");
            transform.Translate(velocidad, 0, 0); //x,y,z
        }
        if (Input.GetKey(KeyCode.S))
        {
            //Debug.Log("me muevo hacia atrás");
            transform.Translate(0, 0, -velocidad); //x,y,z
        }

    }
}
