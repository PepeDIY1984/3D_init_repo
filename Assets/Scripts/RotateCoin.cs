using TMPro;
using UnityEngine;

public class RotateCoin : MonoBehaviour
{
    public float velocidad;

    public TMP_Text textoUI;


    void Update()
    {
        transform.Rotate(velocidad, 0, 0);
    }




    private void OnTriggerEnter(Collider other)
    {
        textoUI.text = "Has recogido una moneda";
        Debug.Log("algo ha entrado en el area de trigger"); 
        Destroy(gameObject);
    }
}
