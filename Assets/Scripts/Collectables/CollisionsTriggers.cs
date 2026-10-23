using UnityEngine;

public class CollisionsTriggers : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("GameObjecConTrigger"))
        {
            Debug.Log("He entrado en un trigger");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("GameObjecConColision"))
        {
            Debug.Log("He colisionado con un collider");
        }
    }
}
