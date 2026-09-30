using UnityEngine;

public class RotateCoin : MonoBehaviour
{
    public float velocidad;
    void Update()
    {
        transform.Rotate(velocidad, 0, 0);
    }

}
