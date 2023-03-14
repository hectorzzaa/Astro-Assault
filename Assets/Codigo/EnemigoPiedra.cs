using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class EnemigoPiedra : Enemigo
{
    //[SerializeField] private GameObject prueba;
    /*public EnemigoPiedra(int vida, string tipoAtaque, bool puedeDisparar)
    {
    }*/
    [SerializeField] float velocidad;
    

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
            gestionarPuntos(getPuntos());
            Destroy(this.gameObject);
        }
        if (collision.CompareTag("Jugador"))
        {
            Debug.Log("Te moriste noob");
            Destroy(this.gameObject);

        }


    }

    public override void OnDestroy()
    {
        Debug.Log("Me destruyo pero soy una piedra :DD");
        elevarContador(getPuntos());
       
    }

    public void elevarContador(int puntosEnemigo)
    {
        int puntosElevados=getPuntosTotal();
        puntosElevados = puntosElevados + puntosEnemigo;
        Debug.Log("Puntuacion: " + puntosElevados);
        //textoPuntos.text = "Puntuacion: " + puntos.ToString();
    }




}
