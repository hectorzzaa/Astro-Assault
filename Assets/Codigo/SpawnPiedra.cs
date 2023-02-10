using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnPiedra : MonoBehaviour
{


    [SerializeField] private GameObject enemigo;
    [SerializeField] private GameObject jugador;

    float timer;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 a = this.transform.position;

        movimientoPiedra(a);

    }

    // Update is called once per frame
    void Update()
    {

        //Me aseguro que el spawn de enemigos siempre este alejado del jugador aunque se mueva hacia delante
        transform.position = new Vector3(0, (jugador.transform.position.y+20F), transform.position.z);
        Vector3 a = this.transform.position;
       
        timer += Time.deltaTime;
        while (timer>=3F)
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
        Instantiate(enemigo, position, rotation);
    }

    
}
