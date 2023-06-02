using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HUD : MonoBehaviour
{
   

    public GameObject[] Vidas;
<<<<<<< Updated upstream
    
    [SerializeField] private TextMeshProUGUI texto;
=======

    [SerializeField] private TextMeshProUGUI textoPuntos;
    [SerializeField] private TextMeshProUGUI textoUsuario;
    [SerializeField] private GameObject input;
>>>>>>> Stashed changes
    
    
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


<<<<<<< Updated upstream
=======
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

       var listaJugadores=GameManager.Instance.LeerJson("prueba");
       Debug.Log(listaJugadores[0].puntuacion);
       
    
    }
    
>>>>>>> Stashed changes

}
