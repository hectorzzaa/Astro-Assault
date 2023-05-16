using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HUD : MonoBehaviour
{
   

    public GameObject[] Vidas;
    
    [SerializeField] private TextMeshProUGUI texto;
    
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //texto.text = GameManager.Instance.PuntosTotales.ToString();
    }

    public void DescativarVidas(int numVida)
    {
        
        Vidas[numVida].SetActive(false);
    }
    public void ActualziarPuntos(float puntos)
    {
        texto.text ="Puntos: "+ puntos.ToString();
    }



}
