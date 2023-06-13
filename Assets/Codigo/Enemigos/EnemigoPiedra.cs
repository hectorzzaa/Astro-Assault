using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemigoPiedra : Enemigo
{
    //[SerializeField] private GameObject prueba;
    /*public EnemigoPiedra(int vida, string tipoAtaque, bool puedeDisparar)
    {
    }*/
    
    [SerializeField] float velocidad;








    //se hace que se traslade hacia abajo dependiendo de una velocidad establecida atraves del editor
    private void Update()
    {



        transform.Translate(Vector2.down * velocidad * Time.deltaTime);
        
    }




  

   




}
