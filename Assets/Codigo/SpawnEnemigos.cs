
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpawnEnemigos : MonoBehaviour
{
    [SerializeField] private HUD hud;
    [SerializeField] private bool finPiedra;
    [SerializeField] private EnemigoPiedra enePiedra;
    [SerializeField] private EnemigoNave eneNave;
    /*[SerializeField]
    private Puntaje puntaje;*/
    float timer;


    
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

        enePiedra.setHud(hud);
        eneNave.setHud(hud);

    }


    void Update()
    {
        spawnNave();

        if (!finPiedra) {
            spawnPiedra();
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


}
