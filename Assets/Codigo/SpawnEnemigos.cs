
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemigos : MonoBehaviour
{



    [SerializeField] private bool finPiedra;
    [SerializeField] private EnemigoPiedra enePiedra;
    float timer;


    
    void Start()
    {



        finPiedra= false;
        enePiedra.setVida(123);
        
        enePiedra.setPuntos(1);
        
        enePiedra.setTipoAtaque("mele");

        enePiedra.decirNombre();
        
    }


    void Update()
    {


        if(!finPiedra) {
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

    private void movimientoPiedra(Vector3 locacion)
    {
        float x = Random.Range((locacion.x - 30F), (locacion.x + 30F));
        float y = Random.Range(locacion.y, (locacion.y + 30F));
        Vector2 position = new Vector2(x, y);
        Quaternion rotation = new Quaternion();
        Instantiate(enePiedra, position, rotation);
    }


}
