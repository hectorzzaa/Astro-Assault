using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class EnemigoNave : Enemigo
{

   

    private void Update()
    {
        movimiento();
    }


    public void movimiento()
    {
        transform.Translate(Vector2.down * 10 * Time.deltaTime);
    }


    

   
}
