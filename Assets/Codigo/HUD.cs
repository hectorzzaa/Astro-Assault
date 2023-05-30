using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HUD : MonoBehaviour
{
   
    //Se crea un array para el numero de vidas cada vida sera un array de GameObject
    public GameObject[] Vidas;
    
    [SerializeField] private TextMeshProUGUI texto;
    
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
        texto.text ="Puntos: "+ puntos.ToString();
    }



}
