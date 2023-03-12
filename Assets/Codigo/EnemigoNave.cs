using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class EnemigoNave : Enemigo
{

    public override void decirNombre()
    {
        Debug.Log("Creo un objeto que es una nave Enemiga");

    }

    private void Update()
    {
        movimiento();
    }


    public void movimiento()
    {
        transform.Translate(Vector2.down * 10 * Time.deltaTime);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {



        if (collision.CompareTag("Final"))
        {
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
        Debug.Log("Me destruyo pero soy una nave :DD");
    }
}
