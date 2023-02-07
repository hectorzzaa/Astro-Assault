using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlScore : MonoBehaviour
{
    private Text textoPuntos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void elevarContador(int punto)
    {
        Debug.Log("Puntuacion: "+punto);
        textoPuntos.text = "Puntuacion: " + punto.ToString();
    }
}
