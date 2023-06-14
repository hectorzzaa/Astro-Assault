using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class GameOverControlador : MonoBehaviour
{
    [SerializeField] private GameObject menu;
    [SerializeField] private GameObject objetoEvento;
    // Start is called before the first frame update
    
    private void Start()
    {
        GameManager.Instance.MuerteJugador+=ActivarMenu;
    }

    private void ActivarMenu(object sender, EventArgs e)
    {
       menu.SetActive(true);
        GameManager.Instance.CambiarElementoEvento(objetoEvento);
        Time.timeScale = 0f;
        AudioManager.Instance.PararMusica();
    }
    public void Reiniciar(string nombreScena)
    {

        SceneManager.LoadScene(nombreScena);
        Time.timeScale = 1f;
    }
    public void CargarEscena(string nombreScena)
    {

      

        SceneManager.LoadScene(nombreScena);
    }
}
