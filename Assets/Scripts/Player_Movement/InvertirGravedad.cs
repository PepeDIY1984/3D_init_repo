using UnityEngine;

public class InvertirGravedad : MonoBehaviour
{
    public float fuerzaGravedad = 9.81f;
    public KeyCode tecla = KeyCode.G;

    private Rigidbody rb;
    private bool invertida;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false; //Cancelamos la gravedad por defecto para crear una fuerza personalizada
    }

    void Update()
    {
        if (Input.GetKeyDown(tecla))
        {
            invertida = !invertida;
        }
    }

    void FixedUpdate()
    {
        Vector3 direccion = invertida ? Vector3.up : Vector3.down; //condicional ternario para asignar valor negativo o positivo a la gravedad
        rb.AddForce(direccion * fuerzaGravedad,ForceMode.Acceleration);
    }
}