using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class HUD : MonoBehaviour
{
   
    //Se crea un array para el numero de vidas cada vida sera un array de GameObject
    public GameObject[] Vidas;
    
    [SerializeField] private TextMeshProUGUI textoPuntos;
    [SerializeField] private TextMeshProUGUI textoUsuario;
    [SerializeField] private GameObject input;
    
    
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


        List<JugadorData> jugadores = new List<JugadorData>();
        jugadores.Add(new JugadorData { usuario = textoUsuario.text, puntuacion = GameManager.puntosUsuarios });



        GameManager.Instance.GuardarJson(jugadores, "prueba");
    }
    

}
