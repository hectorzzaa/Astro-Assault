using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    [SerializeField] private AudioClip sonidoAmbiente;
    public static GameManager Instance { get; private set; }
   
    private float puntosTotales;
    [SerializeField] private HUD hud;

    [SerializeField] public int vidas = 3;
    //El metodo se llamara al principio de todo incluso si existiese un metodo start()
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


    //metodo para sumar puntos al HUD

    public void SumarPuntos(float puntosEntarda)
    {

        puntosTotales += puntosEntarda;

        hud.ActualizarPuntos(puntosTotales);
    }
    //Metodo que sirve para detectar cuando se debe bajar la vida
    public void RecibirDaño()
    {

        vidas-= 1;
        if (vidas == 0)
        {
            //Si las vidas son 0 se carga la escena del menu principal
            SceneManager.LoadScene(0);
        }
        //Se llama a un metodo en el hud para que se quite una vida visual
        hud.DescativarVidas(vidas);
    }
    //Metodo que sirve para detectar cuando se debe subir la vida
    public void RecuperarVidas()
    {
        //Con este if se asegura que no pueda haber mas de tres vidas y asi evitar
        //que salte la excepcion del incide del array
        if(vidas==3) {
            return;
        }
        //Se llama a un metodo en el hud para que se sume una vida visual
        hud.SumarVidas(vidas);
        vidas += 1;
    }

    //Este metodo es usado para controlar el cambio de escena en un boton del menu principal
    public void CargarEscena(string nombreScena)
    {
       
       //AudioManager.Instance.ReproducirSonido(sonidoAmbiente);
        
        SceneManager.LoadScene(nombreScena);
    }
}
