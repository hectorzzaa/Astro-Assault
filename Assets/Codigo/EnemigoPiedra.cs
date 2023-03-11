using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class EnemigoPiedra : Enemigo
{
    //[SerializeField] private GameObject prueba;
    /*public EnemigoPiedra(int vida, string tipoAtaque, bool puedeDisparar)
    {
    }*/
    

    public override void decirNombre()
    {

        Debug.Log("Creo un objeto que es una piedra");

    }
    public override void OnDestroy()
    {
        Debug.Log("Me destruyo pero soy una piedra :DD");
    }

}
