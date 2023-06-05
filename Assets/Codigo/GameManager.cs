using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

   

    public static GameManager Instance { get; private set; }
    [Header("Configuracion puntos usuarios y vidas")]
    public string nombreUsuario; 
    public static float puntosUsuarios;

    [SerializeField] private float puntosTotales;
    [SerializeField] private HUD hud;

    [SerializeField] public int vidas = 3;


    [Header("Configuracion balas")]

    [SerializeField] private GameObject balaEnemigo;

    [SerializeField] private List<GameObject> listaObjetos= new List<GameObject>();

    public int cantidadBalas;







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

    private void Start()
    {
        for(int i = 0; i < cantidadBalas; i++)
        {
            GameObject objeto = Instantiate(balaEnemigo);
            objeto.SetActive(false);
            listaObjetos.Add(objeto);
        }




    }

    public GameObject GetListaObjetos()
    {
        //Recorro la lista
        for (int i = 0; i < listaObjetos.Count; i++)
        {
            //Si el objeto no esta activo en la jerarquia lo devuelve
            if (!listaObjetos[i].activeInHierarchy)
            {
                return listaObjetos[i];
            }

        }

        return null;
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


    //C:\Users\hector\AppData\LocalLow\DefaultCompany\ProyectoUnity\Datos
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

        // Crear la tabla  con los jugadores actualizados
        JugadoresTabla nuevosDatos = new JugadoresTabla(jugadoresExistente);

        // Serializar y guardar en el archivo
        string nuevoJson = JsonUtility.ToJson(nuevosDatos, true);
       
        File.WriteAllText(filePath, nuevoJson);
    }
    public void crearDirectorio()
    {
        string directoryPath = Path.Combine(Application.persistentDataPath, "Datos");
        if (!Directory.Exists(directoryPath))
        {
            // El directorio no existe, crearlo
            Directory.CreateDirectory(directoryPath);
        }
    }

    public void EscribirJsonVacio(string nombreArchivo)
    {
        crearDirectorio();
        string filePath = Path.Combine(Application.persistentDataPath + "/Datos", nombreArchivo + ".json");
        if (!File.Exists(filePath))
        {
            // El archivo no existe, crearlo
            using (StreamWriter sw = File.CreateText(filePath))
            {
                // Escribir un JSON vacío en el archivo
                sw.Write("{}");
            }
        }
    }


    public List<JugadorData> LeerJson(string nombreArchivo)
    {
        string filePath = Path.Combine(Application.persistentDataPath + "/Datos", nombreArchivo + ".json");
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            JugadoresTabla dataWrapper = JsonUtility.FromJson<JugadoresTabla>(json);

            if (dataWrapper != null)
            {
                return dataWrapper.jugadores;
            }
        }

        return null;
    }




    public  void SetInputText(string input)
    {
        Debug.Log(input);
    }
}
