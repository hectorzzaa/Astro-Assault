using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using System.Linq;

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
    [SerializeField] private GameObject boton;
    [SerializeField] private bool insertado;
    
    
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

    public void ActivarInput()
    {
        input.SetActive(true);
    }
    public void DesactivarInput()
    {
        input.SetActive(false);
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
        if (!insertado&& SceneManager.GetActiveScene().name == "EscenaInsertar")
        {
            boton.SetActive(false);
            input.SetActive(false);
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
        foreach (JugadorData jugador in jugadores2)
        {
            Debug.Log(jugador.usuario + ": " + jugador.puntuacion);
            textoNombreCompleto += jugador.usuario + "\n";
            textoPuntuacionCompleta += jugador.puntuacion + "\n";

        }
        textoNombre.text = textoNombreCompleto;
        textoPuntuacion.text = textoPuntuacionCompleta;


    }

}
