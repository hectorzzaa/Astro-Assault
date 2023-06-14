using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuOpcionesController : MonoBehaviour
{
    [SerializeField] private GameObject menu;
    [SerializeField] private GameObject botonPausa;
    // Start is called before the first frame update
   public void Pausa()
    {
        Time.timeScale = 0f;
        menu.SetActive(true);
        botonPausa.SetActive(false);
        AudioManager.Instance.PararMusica();
    }
    public void Reanudar()
    {
        Time.timeScale = 1f;
        menu.SetActive(false);
        botonPausa.SetActive(true);
        AudioManager.Instance.ReanudarMusica();

    }
    public void CargarEscena(string nombreScena)
    {
        SceneManager.LoadScene(nombreScena);
    }
    public void Cerrar()
    {
        Application.Quit();
    }
}
