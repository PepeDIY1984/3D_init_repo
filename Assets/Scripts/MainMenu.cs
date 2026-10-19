using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;


    private void Start()
    {
        mainMenu.SetActive(false);
    }


    public void Saludar()
    {
        Debug.Log("hola desde el método saludar");
    }

    public void MostrarMenuOptions()
    {
        mainMenu.SetActive(true);
    }

    public void OcultarMenuOptions()
    {
        mainMenu.SetActive(false);
    }

    public void Salir()
    {
        Debug.Log("Has cerrado el juego");
        Application.Quit();
    }


}
