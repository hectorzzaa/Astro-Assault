
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEditor.FilePathAttribute;

public class ControlNivel : MonoBehaviour
{


    [SerializeField] private GameObject salud;
    [SerializeField] private HUD hud;
    [Header("Enemigos y jugador")]
    [SerializeField] private EnemigoPiedra enePiedra;
    [SerializeField] private EnemigoNave eneNave;
    [SerializeField] GameObject jugador;
    [Header("controlNaves")]
    [SerializeField]  int maxNaves;
    [SerializeField] public int numNaves;
                     
    float timer;
  
    float temporizadorVida;

    private void Start()
    {


        Vector2 positionJugador = new Vector2(0.19F, -2.58F);
        Quaternion rotationJugador = new Quaternion();
        Instantiate(jugador, positionJugador, rotationJugador);


        EnemigoNave eneNaveComponent = eneNave.GetComponent<EnemigoNave>();

        // Asignar la variable naveJugador con la instancia de la nave del jugador

       
        






    }


    void Update()
    {
        spawnNave();
        //cada frame llama a los emtodos de spawn
        /* spawVida();
         spawnNave();
         spawnPiedra();*/




    }
    private void spawVida()
    {
        Vector3 a = this.transform.position;

       temporizadorVida+=Time.deltaTime;

        while (temporizadorVida >= 6)
        {
            temporizadorVida = 0;
            SpawnVidas(a);
            
        }


    }

    private void spawnPiedra()
    {
        Vector3 a = this.transform.position;
        timer += Time.deltaTime;
        while (timer >= 3F)
        {
            timer = 0;

            movimientoPiedra(a);

        }
    }
    private void spawnNave()
    {
        Vector3 a = new Vector3(0, 0);
        timer += Time.deltaTime;
        while (GameManager.Instance.numNaves < GameManager.Instance.maxNaves && timer >= 3)
        {
            timer = 0;
            movimientoNave(a);
            if (eneNave==null)
            {
                
                numNaves--;
            }
        }
    }

    private void movimientoPiedra(Vector3 locacion)
    {
        //establezco una posicion aleatorio entre unos valores y luego instancio el objeto
        float x = Random.Range((locacion.x - 30F), (locacion.x + 30F));
        float y = Random.Range(locacion.y, (locacion.y + 94F));
        Vector2 position = new Vector2(x, y);
        Quaternion rotation = new Quaternion();
        Instantiate(enePiedra, position, rotation);
    }
    private void movimientoNave(Vector3 locacion)
    {

        float xminimo = -33f;
        float xMaximo = 33f;
        


        //establezco una posicion aleatorio entre unos valores y luego instancio el objeto
        float x = Random.Range(((locacion.x-13f )+ xminimo), ((locacion.x+13f) + xMaximo));
        float y = Random.Range((locacion.y - 2f), (locacion.y + 94f));
        Vector2 position = new Vector2(x, y);
        Quaternion rotation = new Quaternion();
        //int numerobalas= GameManager.Instance.cantidadBalas+4;
        //GameManager.Instance.ListarBalas(numerobalas);

        GameManager.Instance.numNaves++;
        Instantiate(eneNave, position, rotation);
    }





    private void SpawnVidas(Vector3 locacion)
    {
        float x = Random.Range((locacion.x - 30F), (locacion.x + 30F));
        float y = Random.Range(locacion.y, (locacion.y + 30F));
        Vector2 position = new Vector2(x, y);
        Quaternion rotation = new Quaternion();
        Instantiate(salud, position, rotation);
    }
    

}
