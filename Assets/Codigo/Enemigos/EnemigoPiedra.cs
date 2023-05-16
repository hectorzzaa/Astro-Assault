using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

class EnemigoPiedra : Enemigo
{
    //[SerializeField] private GameObject prueba;
    /*public EnemigoPiedra(int vida, string tipoAtaque, bool puedeDisparar)
    {
    }*/
    
    [SerializeField] float velocidad;
    [SerializeField]
    private float cantidadPuntos;
    [SerializeField]


    

    public override void decirNombre()
    {

        Debug.Log("Creo un objeto que es una piedra");

    }
    public void movimiento()
    {

        transform.Translate(Vector2.down * velocidad * Time.deltaTime);
    }

    private void Update()
    {

       

        movimiento();
        //Debug.Log(getVida());
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {



        if (collision.CompareTag("Final"))
        {
            //gestionarPuntos(getPuntos());
            Destroy(this.gameObject);
        }
        if (collision.CompareTag("Jugador"))
        {
            
            Destroy(this.gameObject);

        }
        if (collision.CompareTag("bala"))
        {
           
            //getPuntaje().SumarPuntos(getPuntos());

            //getHud().SumarPuntos(getPuntos());
            GameManager.Instance.SumarPuntos(getPuntos());

        }



    }

    public override void OnDestroy()
    {
        Debug.Log("Me destruyo pero soy una piedra :DD");
       // elevarContador(1);
       
    }

   




}
