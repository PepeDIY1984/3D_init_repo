using UnityEngine;

public class Trigger_ActivateObject : MonoBehaviour
{
    public GameObject texto3D;
    public GameObject luz;


    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("hola");
        Destroy(gameObject);
    }


}
