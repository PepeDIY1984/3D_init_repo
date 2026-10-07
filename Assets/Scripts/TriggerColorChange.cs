using UnityEngine;

public class TriggerColorChange : MonoBehaviour
{
    public GameObject botonOculto;

    private void Start()
    {
        botonOculto.SetActive(false);
    }



    private void OnTriggerEnter(Collider other)
    {
        GetComponent<Renderer>().material.color = Color.green;
        botonOculto.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        GetComponent<Renderer>().material.color = Color.red;
        botonOculto.SetActive(false);
    }

}
