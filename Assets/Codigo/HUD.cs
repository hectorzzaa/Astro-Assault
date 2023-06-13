using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using System.Linq;
using UnityEngine.InputSystem;

public class HUD : MonoBehaviour
{
   
    //Se crea un array para el numero de vidas cada vida sera un array de GameObject
    public GameObject[] Vidas;
    [SerializeField] private string nombreArchivo;
    [SerializeField] private TextMeshProUGUI textoPuntos;
    [SerializeField] private TextMeshProUGUI textoUsuario;
    [SerializeField] private TextMeshProUGUI listaJugadores;
    [SerializeField] private TextMeshProUGUI textoNombre;
    [SerializeField] private TextMeshProUGUI textoPuntuacion;
    [SerializeField] private GameObject input;
  
    [SerializeField] private bool insertado;
    private Controles controles;

    private void Awake()
    {
        if (SceneManager.GetActiveScene().name == "EscenaInsertar")
        {
            controles = new Controles();
            if (GameManager.puntosUsuarios == 0)
            {
                input.SetActive(false);
            }
        }
    }

    private void OnEnable()
    {
        if (SceneManager.GetActiveScene().name == "EscenaInsertar")
        {
            controles.MenuInsertar.Enable();
            controles.MenuInsertar.Aceptar.started+=InsertarNombre;

        }
    }

    private void InsertarNombre(InputAction.CallbackContext obj)
    {
        Debug.Log("input1 " + textoUsuario.text);

       

            List<JugadorData> jugadores = new List<JugadorData>();
            jugadores.Add(new JugadorData { usuario = textoUsuario.text, puntuacion = GameManager.puntosUsuarios });



            GameManager.Instance.GuardarJson(jugadores, nombreArchivo);
            mostrarTabla();
            insertado = false;
        
    }

    //El metodo sirve para que que al ser llamado desactive el indice del array
    //por ejemplo al perde una vida se desactiva la posicion 2
    public void DescativarVidas(int numVida)
    {
        
        Vidas[numVida].SetActive(false);
    }
    //Funciona igual que el metodo desctivarVidas pero en este caso activa atarves del indice
    public void SumarVidas(int numVida)
    {

        Vidas[numVida].SetActive(true);
    }
    //Cuando la funcion es llamada se encarga de actualizar los puntos con los recibidos
    public void ActualizarPuntos(float puntos)
    {
        textoPuntos.text ="Puntos: "+ puntos.ToString();
    }

    

    public string guardarNombre()
    {

       
        return textoUsuario.ToString();
    }

    public void SetInputText(string input2)
    {
        Debug.Log("input1 " + textoUsuario.text);

        if(insertado)
        {

        List<JugadorData> jugadores = new List<JugadorData>();
        jugadores.Add(new JugadorData { usuario = textoUsuario.text, puntuacion = GameManager.puntosUsuarios });



        GameManager.Instance.GuardarJson(jugadores, nombreArchivo);
        mostrarTabla();
        insertado= false;
        }
        
    }

    private void Start()
    {

        
        Debug.Log(SceneManager.GetActiveScene().name);
        if (SceneManager.GetActiveScene().name== "EscenaInsertar")
        {
            insertado = true;
            GameManager.Instance.EscribirJsonVacio(nombreArchivo);
            mostrarTabla();
        }

    }
    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "EscenaInsertar")
        {
            if (GameManager.puntosUsuarios > 0)
            {
                input.SetActive(true);
            }
        }
    }

    private void mostrarTabla()
    {
        //List<JugadorData> jugadores = new List<JugadorData>();
        var jugadores2 = GameManager.Instance.LeerJson(nombreArchivo);
        jugadores2=jugadores2.OrderByDescending(jugador=>jugador.puntuacion).ToList();
        Debug.Log(jugadores2);

        string textoNombreCompleto = "";
        string textoPuntuacionCompleta = "";
        int indice = 1;
        foreach (JugadorData jugador in jugadores2)
        {
            if (indice >= 6)
            {
                break;
            }
            Debug.Log( jugador.usuario + ": " + jugador.puntuacion);
            textoNombreCompleto +=indice+": "+ jugador.usuario + "\n";
            textoPuntuacionCompleta += jugador.puntuacion + "\n";
            indice++;
        }
        textoNombre.text = textoNombreCompleto;
        textoPuntuacion.text = textoPuntuacionCompleta;


    }

}
