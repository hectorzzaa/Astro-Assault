using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlScore : MonoBehaviour
{
    [SerializeField] EnemigoPiedra enemigoPiedra;
    private Text textoPuntos;
    int puntos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //elevarContador(enemigoPiedra.getPuntos());
    }

   
    /*public void elevarContador(int puntosEnemigo)
    {
        puntos = puntos + puntosEnemigo;
        Debug.Log("Puntuacion: "+ puntos);
        //textoPuntos.text = "Puntuacion: " + puntos.ToString();
    }*/
}
