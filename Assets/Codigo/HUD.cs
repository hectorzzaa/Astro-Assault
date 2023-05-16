using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HUD : MonoBehaviour
{
    [SerializeField] private GameObject[] Vidas;
     //private TextMeshPro texto;
    [SerializeField] private TextMeshProUGUI texto;
    private float puntos;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RecibirDaño(int numVida)
    {
        
        Vidas[numVida].SetActive(false);
    }
    public void SumarPuntos(float puntosEntarda)
    {

        puntos += puntosEntarda;
        texto.text = "puntos: " + puntos.ToString("0");
        Debug.Log(texto.text);
    }
}
