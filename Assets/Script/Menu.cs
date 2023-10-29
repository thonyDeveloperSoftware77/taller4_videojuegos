using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Animator transitionAnim; // Referencia al Animator que controla la animaci�n de transici�n
    public string sceneName; // Nombre de la escena a la que se va a cambiar

    public void Iniciar(string Scena)
    {
        sceneName = Scena;
        StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene()
    {
        transitionAnim.SetTrigger("Start"); // Inicia la animaci�n de transici�n
        yield return new WaitForSeconds(1); // Espera el tiempo que dure la animaci�n
        SceneManager.LoadScene(sceneName); // Carga la nueva escena
    }

    public void Salir()
    {
        Application.Quit();
        Debug.Log("Saliendo");
    }
}
