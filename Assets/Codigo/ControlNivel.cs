
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class ControlNivel : MonoBehaviour
{


    [SerializeField] private GameObject salud;
    [SerializeField] private HUD hud;
    [SerializeField] private bool finPiedra;
    [SerializeField] private EnemigoPiedra enePiedra;
    [SerializeField] private EnemigoNave eneNave;
    
    /*[SerializeField]
    private Puntaje puntaje;*/
    float timer;
    float temporizadorVida;



    void Start()
    {
        


        /*eneNave.setVida(1);

        finPiedra = false;
     
        
        //enePiedra.setPuntos(1);
        
        enePiedra.setTipoAtaque("mele");

        enePiedra.decirNombre();

        eneNave.decirNombre();

        //enePiedra.setPuntaje( puntaje);*/

        enePiedra.getPuedeDisparar(true);

        //enePiedra.SetClasePuntos(puntaje);

        //eneNave.SetClasePuntos(puntaje);

       

    }


    void Update()
    {
        spawnNave();
        spawVida();
        if (!finPiedra) {
            spawnPiedra();
        }
        
        

    }
    private void spawVida()
    {
        Vector3 a = this.transform.position;

       temporizadorVida=Time.deltaTime;

        while (temporizadorVida > 10&&GameManager.Instance.vidas<3)
        {
            temporizadorVida = 0;
            MovimientoVida(a);
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
        Vector3 a = this.transform.position;
        timer += Time.deltaTime;
        while (timer >= 3F)
        {
            timer = 0;
            float x = 0;
            float y = 18;
            Vector2 position = new Vector2(x, y);
            Quaternion rotation = new Quaternion();
            Instantiate(eneNave, position, rotation);

        }
    }

    private void movimientoPiedra(Vector3 locacion)
    {
        float x = Random.Range((locacion.x - 30F), (locacion.x + 30F));
        float y = Random.Range(locacion.y, (locacion.y + 30F));
        Vector2 position = new Vector2(x, y);
        Quaternion rotation = new Quaternion();
        Instantiate(enePiedra, position, rotation);
    }
    private void MovimientoVida(Vector3 locacion)
    {
        float x = Random.Range((locacion.x - 30F), (locacion.x + 30F));
        float y = Random.Range(locacion.y, (locacion.y + 30F));
        Vector2 position = new Vector2(x, y);
        Quaternion rotation = new Quaternion();
        Instantiate(salud, position, rotation);
    }


}
