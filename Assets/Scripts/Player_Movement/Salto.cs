using UnityEngine;

public class Salto: MonoBehaviour
{
    //Variables de referencia
    private Rigidbody rb;               //Referencia al Rigidbody del player

    public float speed;                 //Velocidad de la bola
    public float jumpForce;             //Fuerza de salto

    public Vector3 respawnPoint;        //Posici�n asignada al respawn
    public float fallLimit;             //L�mite en -y para respawnear

    private bool tocandoSuelo=true;



    // METODO START
    void Start()
    {
        rb = GetComponent<Rigidbody>();             //Referencia autom�tica al rb del objeto que tiene el script
        respawnPoint = transform.position;
    }

    // METODO UPDATE
    private void Update()
    {
        Movement();
        if (transform.position.y < fallLimit)
        {
            Respawn();
        }
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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (tocandoSuelo)
            {
            jumpForce = 100;
            }
        }
        else { jumpForce = 0; }

            //Creo un Vector 3 cuyo valor es el input en X, 0 en y, y el input en z
            Vector3 movement = new Vector3(inputHor, jumpForce, inputVer);

        //Añado una fuerza al Rigidbody en los ejes X/Z multiplicado por la velocidad
        rb.AddForce(movement * speed);
    }

    void Respawn()
    {
        rb.linearVelocity = Vector3.zero;       //Resetear la velocidad del Rigidbody
        transform.position = respawnPoint;      //Resetar la posición del player
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    tocandoSuelo = true;
    //}
    //private void OnCollisionExit(Collision collision)
    //{
    //    tocandoSuelo = false;
    //}
}
