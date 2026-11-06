using UnityEngine;

public class Vida : MonoBehaviour
{
    public int Puntos = 100;

    public void RecibirDanio(int cantidad)
    {
        Puntos =  Puntos - cantidad;
    }
}