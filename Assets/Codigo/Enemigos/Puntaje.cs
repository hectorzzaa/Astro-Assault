using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Puntaje : MonoBehaviour
{
    private float puntos;

    private TextMeshProUGUI texto;
    [SerializeField] private GameObject enemigo;
    private void Start()
    {
        texto = GetComponent<TextMeshProUGUI>();

    }

   /* private void Update()
    {
        //puntos += Time.deltaTime;
       
        if (enemigo.IsDestroyed())
        {
            puntos = puntos + 1;

            Debug.Log(puntos);
        }

    }*/

    public void SumarPuntos(float puntosEntarda)
    {
        
        puntos = puntosEntarda+puntos;
        texto.text =texto.text+ puntos.ToString("0");
        Debug.Log(texto.text);
    }


}
