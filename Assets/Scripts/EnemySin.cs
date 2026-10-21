using UnityEngine;

public class EnemySin : MonoBehaviour
{
    public Vector3 eje = Vector3.right;
    public float amplitud = 3f;

    [Min(0f)]
    public float velocidad = 1f;

    private Vector3 posicionInicial;
    private float tiempo;

    void Start()
    {
        posicionInicial = transform.position;
    }

    void Update()
    {
        // Acumulamos el tiempo según la velocidad.
        tiempo += Time.deltaTime * velocidad;

        float desplazamiento = Mathf.Sin(tiempo  * 2f * Mathf.PI) * amplitud;

        transform.position = posicionInicial+ eje.normalized * desplazamiento;
    }
}