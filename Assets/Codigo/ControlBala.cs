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

        //se hace que se traslade hacia arriba dependiendo de una velocidad establecida atraves del editor
   
          transform.Translate(Vector2.up * velocidad * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Consigo extactamente cual de los objetos instanciados es y llamo a su funcion de recibir da�o
        if (collision.CompareTag("nave"))
        {
            collision.GetComponent<EnemigoNave>().recibirDa�o(1);
            Destroy(this.gameObject);
        }
        if (collision.CompareTag("Piedra"))
        {
            collision.GetComponent<EnemigoPiedra>().recibirDa�o(1);
            Destroy(this.gameObject);
        }
        //Hay un objeto al final de juego que sirve como tope, al llegar a �l se destruye la barra

        if (collision.CompareTag("finalBala"))
        {
            Debug.Log("final");
            Destroy(gameObject);
        }

    }
}
