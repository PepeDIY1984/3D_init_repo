using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float velocidad;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, velocidad); //x,y,z
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-velocidad, 0, 0); //x,y,z
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(velocidad, 0, 0); //x,y,z
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -velocidad); //x,y,z
        }

    }




}
