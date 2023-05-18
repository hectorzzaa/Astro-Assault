using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    [SerializeField]
    public static GameManager Instance { get; private set; }
    public float PuntosTotales { get { return puntosTotales; } }
    private float puntosTotales;
    [SerializeField] private HUD hud;
    [SerializeField] public int vidas = 3;
    void Awake()
    {
        if (Instance == null)
        {
            Instance= this;
        }
        else
        {
            Debug.Log("Hay mas de un game manager");
        }
    }



    public void SumarPuntos(float puntosEntarda)
    {

        puntosTotales += puntosEntarda;

        hud.ActualziarPuntos(puntosTotales);
    }
    public void RecibirDaño()
    {

        vidas-= 1;
        if (vidas == 0)
        {
            SceneManager.LoadScene(0);
        }
        hud.DescativarVidas(vidas);
    }
    public void CargarEscena(string nombreScena)
    {
        SceneManager.LoadScene(nombreScena);
    }
}
