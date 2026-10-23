using UnityEngine;

public class Condicionales : MonoBehaviour
{
    public int vida;

    private void Update()
    {
        if (vida <= 0)
        {
            Debug.Log("Estas muerto");
        }
        else if (vida == 30)
        {
            Debug.Log("Estas regulero");
        }
        else if (vida >= 100)
        {
            Debug.Log("Tienes superpower");
        }
        else
        {
            Debug.Log("Estas vivo");
        }
    }


}
