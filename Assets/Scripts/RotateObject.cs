using UnityEngine;

public class RotateObject : MonoBehaviour
{

    public float velocidad = 0.01f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(velocidad, 0, 0);
    }
}
