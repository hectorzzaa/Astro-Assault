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
<<<<<<< Updated upstream
=======



    public void GuardarJson(List<JugadorData> nuevosjugadores, string nombreArchivo)
    {
        CrearDirectorio();
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
    public void CrearDirectorio(){


            string folderPath = Path.Combine(Application.persistentDataPath, "Datos");

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
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
>>>>>>> Stashed changes
}
