using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
   // Este método es llamado cuando el botón "Jugar" es presionado
    public void Jugar()
    {
        // Restablece el tiempo del juego a su velocidad normal (1x)
        Time.timeScale = 1f;

        // Carga la siguiente escena en el orden del Build Settings
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    // Este método es llamado cuando el botón "Salir" es presionado
    public void Salir()
    {
        Debug.Log("Salir.........");

        // Cierra la aplicación
        Application.Quit();
    }
}
