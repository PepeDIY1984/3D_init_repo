using System;
using UnityEngine;

public class Parenting : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("hijo"))
        {
            // Lo convierto en hijo de la bola conservando su posición
            collision.gameObject.transform.SetParent(transform, true);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("comida"))
        {
            Destroy(other.gameObject);
            transform.localScale = new Vector3(2, 2,2);
        }
    }

}
