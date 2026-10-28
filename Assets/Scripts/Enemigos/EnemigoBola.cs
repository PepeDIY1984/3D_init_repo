using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class EnemigoBola : MonoBehaviour
{
    [SerializeField] private Transform jugador;
    [SerializeField] private float velocidad = 4f;
    [SerializeField] private float distanciaParada = 1.5f;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (jugador == null) return;

        // Calcula la dirección en el suelo, ignorando la altura.
        Vector3 direccion = jugador.position - rb.position;
        direccion.y = 0f;

        if (direccion.magnitude <= distanciaParada)
        {
            rb.linearVelocity = new Vector3(0f, rb.linearVelocity.y, 0f);
            return;
        }

        direccion.Normalize();

        // Mantiene la velocidad vertical para que la gravedad siga funcionando.
        rb.linearVelocity = new Vector3(
            direccion.x * velocidad,
            rb.linearVelocity.y,
            direccion.z * velocidad
        );


        ////VERSION CON LOOKAT
        //direccion.Normalize();

        //rb.MoveRotation(Quaternion.LookRotation(direccion));

        //rb.velocity = new Vector3(
        //    direccion.x * velocidad,
        //    rb.velocity.y,
        //    direccion.z * velocidad
        //);
    }
}