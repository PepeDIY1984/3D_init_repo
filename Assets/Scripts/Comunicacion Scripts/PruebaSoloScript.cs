using UnityEngine;

public class PruebaSoloScript : MonoBehaviour
{
    public Vida vida;

    void Start()
    {
        Debug.Log("Vida inicial: " + vida.Puntos);
        vida.RecibirDanio(20);
        Debug.Log("Vida después del daño: " + vida.Puntos);
    }
}
