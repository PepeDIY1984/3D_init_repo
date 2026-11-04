using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CamaraGiro : MonoBehaviour
{
    [Header("Movimiento")]
    public float fuerza = 20f;
    public float velocidadMaxima = 10f;
    public float velocidadGiro = 120f;

    [Header("Cámara")]
    public Transform camara;
    public Vector3 distancia = new Vector3(0, 3, -6);
    public float suavizado = 8f;

    private Rigidbody rb;

    // Independiente del rodamiento físico de la bola.
    private Quaternion orientacion;
    private Quaternion orientacionCamara;

    private float avance;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.interpolation = RigidbodyInterpolation.Interpolate;

        orientacion = transform.rotation;
        orientacionCamara = orientacion;
    }

    void Update()
    {
        avance = Input.GetAxis("Vertical");

        float giroHorizontal = Input.GetAxis("Horizontal");

        float inclinacion = 0f;
        float giroLateral = 0f;

        if (Input.GetKey(KeyCode.Q)) inclinacion = -1f;
        if (Input.GetKey(KeyCode.E)) inclinacion = 1f;

        if (Input.GetKey(KeyCode.Z)) giroLateral = 1f;
        if (Input.GetKey(KeyCode.C)) giroLateral = -1f;

        float paso = velocidadGiro * Time.deltaTime;

        // Multiplicar por la derecha aplica giros en ejes locales.
        orientacion =
            orientacion *
            Quaternion.AngleAxis(
                giroHorizontal * paso, Vector3.up
            ) *
            Quaternion.AngleAxis(
                inclinacion * paso, Vector3.right
            ) *
            Quaternion.AngleAxis(
                giroLateral * paso, Vector3.forward
            );

        orientacion = orientacion.normalized;
    }

    void FixedUpdate()
    {
        Vector3 adelante = orientacion * Vector3.forward;
        Vector3 arriba = orientacion * Vector3.up;

        rb.AddForce(
            adelante * avance * fuerza,
            ForceMode.Acceleration
        );

        // Limita la velocidad en el plano local de movimiento.
        // Conserva la componente perpendicular a ese plano.
        Vector3 velocidad = rb.linearVelocity;

        Vector3 perpendicular = Vector3.Project(
            velocidad, arriba
        );

        Vector3 sobrePlano = velocidad - perpendicular;

        sobrePlano = Vector3.ClampMagnitude(
            sobrePlano, velocidadMaxima
        );

        rb.linearVelocity = sobrePlano + perpendicular;
    }

    void LateUpdate()
    {
        if (camara == null) return;

        float factor = 1f - Mathf.Exp(
            -suavizado * Time.deltaTime
        );

        orientacionCamara = Quaternion.Slerp(
            orientacionCamara,
            orientacion,
            factor
        );

        // La distancia también se interpreta en ejes locales.
        camara.position =
            transform.position +
            orientacionCamara * distancia;

        Vector3 arribaCamara =
            orientacionCamara * Vector3.up;

        camara.rotation = Quaternion.LookRotation(
            transform.position - camara.position,
            arribaCamara
        );
    }
}