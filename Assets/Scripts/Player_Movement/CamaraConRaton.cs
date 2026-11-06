
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CamaraConRaton : MonoBehaviour
{
    public float fuerza = 15f;
    public float sensibilidad = 3f;
    public float distancia = 6f;
    public float altura = 2f;
    public Transform camara;

    Rigidbody rb;
    float giro = 0f;
    float inclinacion = 20f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Girar la cámara con el ratón
        giro += Input.GetAxis("Mouse X") * sensibilidad;
        inclinacion -= Input.GetAxis("Mouse Y") * sensibilidad;
        inclinacion = Mathf.Clamp(inclinacion, -20f, 80f);
    }

    void FixedUpdate()
    {
        // Dirección de movimiento según la cámara
        Vector3 adelante = camara.forward;
        Vector3 derecha = camara.right;

        // Evitar que la inclinación afecte al movimiento
        adelante.y = 0;
        derecha.y = 0;

        adelante.Normalize();
        derecha.Normalize();

        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        Vector3 movimiento = adelante * vertical  + derecha * horizontal;

        // Aplicar fuerza a la pelota
        rb.AddForce(movimiento.normalized * fuerza, ForceMode.Acceleration);
    }

    void LateUpdate()
    {
        // Cámara orbitando alrededor de la pelota
        Quaternion rotacion = Quaternion.Euler(inclinacion, giro, 0);

        Vector3 offset = rotacion *new Vector3(0, altura, -distancia);

        camara.position = transform.position + offset;
        camara.LookAt(transform.position);
    }
}
