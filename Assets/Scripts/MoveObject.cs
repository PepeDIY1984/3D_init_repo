using UnityEngine;

public class MoveObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Debug.Log("Saltar");
        if (Input.GetKey(KeyCode.D))
            transform.Translate(0.01f,0,0);
        if (Input.GetKey(KeyCode.A))
            transform.Translate(-0.01f, 0, 0);
        if (Input.GetKey(KeyCode.W))
            transform.Translate(0, 0, 0.01f);
        if (Input.GetKey(KeyCode.S))
            transform.Translate(0, 0, -0.01f);
    }
}
