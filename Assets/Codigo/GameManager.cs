using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject naveJugador;
   
    [SerializeField] private AudioClip sonidoAmbiente;
    public static GameManager Instance { get; private set; }

    public string nombreUsuario; 
    public static float puntosUsuarios=40; 

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
            puntosUsuarios = puntosTotales;
           
           /* naveJugador.SetActive(false);
            hud.ActivarInput();*/
            //GuardarJson(jugador,"prueba");
           // var p= hud.guardarNombre();

            SceneManager.LoadScene(3);

           
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



    public void GuardarJson(List<JugadorData> nuevosjugadores, string nombreArchivo)
    {
        List<JugadorData> jugadoresExistente = new List<JugadorData>();

        // Verificar si el archivo existe
        string filePath = Path.Combine(Application.persistentDataPath+"/Datos", nombreArchivo + ".json");
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            JugadoresTabla dataWrapper = JsonUtility.FromJson<JugadoresTabla>(json);
            jugadoresExistente = dataWrapper.jugadores;
        }

        jugadoresExistente.AddRange(nuevosjugadores);

        // Crear el wrapper con los jugadores actualizados
        JugadoresTabla nuevosDatos = new JugadoresTabla(jugadoresExistente);

        // Serializar y guardar en el archivo
        string nuevoJson = JsonUtility.ToJson(nuevosDatos, true);
        //nuevoJson = nuevoJson.Replace("}\n{", "},\n{");
        File.WriteAllText(filePath, nuevoJson);
    }







    public  void SetInputText(string input)
    {
        Debug.Log(input);
    }
}
