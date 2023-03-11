using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemigos : MonoBehaviour
{
    [SerializeField] private GameObject enemigoPiedra;

    Enemigo enePiedra = new Enemigo(1,"fisico","piedra");
    float timer;


    void Start()
    {
        enePiedra.setObjeto(enemigoPiedra);
    }

    // Update is called once per frame
    void Update()
    {
        
        if(enePiedra.getTipoEnemigo()=="piedra")
        {
            Vector3 a = this.transform.position;
           timer += Time.deltaTime;
            while (timer >= 3F)
            {
                timer = 0;

                movimientoPiedra(a);
            }





        }





    }




    private void movimientoPiedra(Vector3 locacion)
    {
        float x = Random.Range((locacion.x - 30F), (locacion.x + 30F));
        float y = Random.Range(locacion.y, (locacion.y + 30F));
        Vector2 position = new Vector2(x, y);
        Quaternion rotation = new Quaternion();
        Instantiate(enemigoPiedra, position, rotation);
    }


}
