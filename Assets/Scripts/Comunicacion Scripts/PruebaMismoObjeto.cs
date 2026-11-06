using UnityEngine;

public class PruebaMismoObjeto : MonoBehaviour
{
    //public GameObject Player; //Solo si el Player esta en otro gameobject

    private void Start()
    {
        //Player.GetComponent<Vida>(); //Solo si el Player esta en otro gameobject
        Vida vida = GetComponent<Vida>();

        Debug.Log("Vida inicial: "+vida.Puntos);
        vida.RecibirDanio(20);
        Debug.Log("Vida después del daño: "+ vida.Puntos);
    }
}