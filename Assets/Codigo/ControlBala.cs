using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ControlBala : MonoBehaviour
{
   
    [SerializeField] private float velocidad;
    [SerializeField] private float da�o;

    [SerializeField] private float cantidadPuntos;
    


    void Update()
    {




        //le digo que se traslade hacia arriba dependiendo de una velocidad que yo establezco en un metodo en el editor
        
       
          transform.Translate(Vector2.up * velocidad * Time.deltaTime);



       




    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        /*if (collision.CompareTag("Piedra")){
            collision.GetComponent<ControlEnemigo>().recibirDa�o(1);
            Destroy(gameObject);
        }*/
        if (collision.CompareTag("nave"))
        {
            collision.GetComponent<EnemigoNave>().recibirDa�o(1);
            Destroy(gameObject);
        }
        if (collision.CompareTag("Piedra"))
        {
            collision.GetComponent<EnemigoPiedra>().recibirDa�o(1);
            //puntaje.SumarPuntos(cantidadPuntos);
            //controlPuntaje.raiseScore(1);
           // GetComponent<ControlPuntaje>().raiseScore(1);

            Destroy(gameObject);
        }
        if (collision.CompareTag("finalBala"))
        {
            Debug.Log("final");
            Destroy(gameObject);
        }

    }
}
