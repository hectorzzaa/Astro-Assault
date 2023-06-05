using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class EnemigoNave : Enemigo
{
    [SerializeField] private float timer;
    [SerializeField] private Transform controladorDisparoEnemigo;

    private void Update()
    {
        timer += Time.deltaTime;
        while (timer >= 1) 
        {
           timer = 0;
            disparar();

        }


    }
   


    public void movimiento()
    {
        //transform.Translate(Vector2.down * 10 * Time.deltaTime);
    }



    private void disparar()
    {
        /*for (int i = 0; i < GameManager.Instance.cantidadBalas; i++)
        {
            GameObject bala2 = GameManager.Instance.GetListaObjetos();
            if (bala2 != null)
            {
                bala2.transform.position = controladorDisparoEnemigo.position;
                bala2.SetActive(true);
            }*/

         StartCoroutine(ActivarBalasConRetardo(GameManager.Instance.cantidadBalas, 0.1f));

         IEnumerator ActivarBalasConRetardo(int numBalas, float retardo)
         {
             
                 GameObject bala2 = GameManager.Instance.GetListaObjetos();
                 if (bala2 != null)
                 {
                     bala2.transform.position = controladorDisparoEnemigo.position;
                     bala2.SetActive(true);
                 }
                

                 yield return new WaitForSeconds(retardo);
             
    }



    //Intsancio el objeto de bala usando la posicion del controladorDisparo
    //que esta establecido como hijo del objeto naveJugador

    // Instantiate(bala, controladorDisparo.position, controladorDisparo.rotation);

    //Creo el gameObject
    GameObject bala = GameManager.Instance.GetListaObjetos();
        if (bala != null)
        {
            //Lo instancio usando la posicion del controlador disparo
            //bala.transform.position = controladorDisparo.position;
            bala.SetActive(true);
        }

        //AudioManager.Instance.ReproducirSonido(sonidoDisparo);
    }








}
