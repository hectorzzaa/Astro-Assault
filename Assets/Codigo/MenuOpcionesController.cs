using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class MenuOpcionesController : MonoBehaviour
{
    private Controles controles;

    [SerializeField] private GameObject menu;
    [SerializeField] private GameObject botonPausa;
    // Start is called before the first frame update


    private void Awake()
    {
        controles = new Controles();


    }
    private void OnEnable()
    {
        controles.MenuPausa.Enable();
        controles.MenuPausa.EntrarMenu.started += Pausa;
       //controles.MenuPausa.SalirMenu.started += Reanudar;
        //controles.MenuPausa.Aceptar.started += Reanudar;
        
    }


    public void Pausa(InputAction.CallbackContext obj)
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
