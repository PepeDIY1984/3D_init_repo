using UnityEngine;

public class CheckPointRespawn : MonoBehaviour
{
    private Rigidbody rb;

    public Transform repawn01;
    public Transform repawn02;


    void Start()
    {
        rb = GetComponent<Rigidbody>();             //Referencia autom�tica al rb del objeto que tiene el script
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("checkpoint01"))
        {
            transform.position = repawn01.transform.position;
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }

        if (other.CompareTag("checkpoint02"))
        {
            transform.position = repawn02.transform.position;
        }
    }

}
