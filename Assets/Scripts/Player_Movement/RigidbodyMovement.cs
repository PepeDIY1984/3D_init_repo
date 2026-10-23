using UnityEngine;

public class RigidbodyMovement : MonoBehaviour
{
    //Variables de referencia
    private Rigidbody rb;               //Referencia al Rigidbody del player

    public float speed;                 //Velocidad de la bola
    public float jumpForce;             //Fuerza de salto

    public Vector3 respawnPoint;        //Posici�n asignada al respawn
    public float fallLimit;             //L�mite en -y para respawnear




    // METODO START
    void Start()
    {
        rb = GetComponent<Rigidbody>();             //Referencia autom�tica al rb del objeto que tiene el script
        respawnPoint = transform.position;
    }

    // METODO UPDATE
    private void Update()
    {
        if (transform.position.y < fallLimit)
        {
            Respawn();
        }
    }

    // METODO FIXEDUPDATE (parecido al metodo update, mas eficiente para calcular movimiento de GameObjects)
    void FixedUpdate()
    {
        Movement();
    }



    // METODO TRIGGER para derectar el contacto con los coleccionables
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            Destroy(other.gameObject);
        }
    }

    void Movement()
    {
        //Almaceno el input que nos proporciona Unity
        float inputHor = Input.GetAxis("Horizontal");
        float inputVer = Input.GetAxis("Vertical");

        //Creo un Vector 3 cuyo valor es el input en X, 0 en y, y el input en z
        Vector3 movement = new Vector3(inputHor, 0, inputVer);

        //Añado una fuerza al Rigidbody en los ejes X/Z multiplicado por la velocidad
        rb.AddForce(movement * speed);
    }

    void Respawn()
    {
        rb.linearVelocity = Vector3.zero;       //Resetear la velocidad del Rigidbody
        transform.position = respawnPoint;      //Resetar la posición del player
    }
}
