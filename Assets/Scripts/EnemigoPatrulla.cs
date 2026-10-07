using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemigoPatrulla : MonoBehaviour
{
    public float velocidad;

    void Update()
    {
        if (transform.position.x>6)
        {
            velocidad = -velocidad;
        }

        if (transform.position.x<-2)
        {
            velocidad = -velocidad;
        }

        transform.Translate(velocidad * Time.deltaTime, 0, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("me he chocado con un enemigo");
        SceneManager.LoadScene("05_InputsAdv");
    }

}
