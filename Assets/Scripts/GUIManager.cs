using UnityEngine;
using UnityEngine.SceneManagement;

public class GUIManager : MonoBehaviour
{
    public void MetodoSaludar()
    {
        Debug.Log("hola desde un boton");
    }

    public void MetodoCambiarEscena()
    {
        SceneManager.LoadScene("06_RigidbodyMovement");
    }

    public void MetodoSalir()
    {
        Application.Quit();
    }

}
