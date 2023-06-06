using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class EnemigoNave : Enemigo
{
    [SerializeField] private float timer;
    [SerializeField] private Transform controladorDisparoEnemigo;
    public Transform naveJugador;
    private void Update()
    {
        timer += Time.deltaTime;
        while (timer >= 3) 
        {
           timer = 0;
            disparar();

        }


    }
    private void Start()
    {
        //gameObject.transform.position = new Vector3(0.19F, 10F, 0);
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

         StartCoroutine(ActivarBalasConRetardo(GameManager.Instance.cantidadBalas, 0.2f));

         IEnumerator ActivarBalasConRetardo(int numBalas, float retardo)
         {
            ControladorJugador[] navesJugador = FindObjectsOfType<ControladorJugador>();
            foreach (ControladorJugador naveJugador in navesJugador)
            {
                
            for (int i = 0; i < numBalas; i++)
            {
                Vector2 jugadorObjetivo = naveJugador.transform.position - transform.position;
                Debug.Log(jugadorObjetivo);
                GameObject bala = GameManager.Instance.GetListaObjetos();
                if (bala != null)
                {
                    ControladorBalaEnemigo controlBala = bala.GetComponent<ControladorBalaEnemigo>();

                    controlBala.SetDirection(jugadorObjetivo.normalized);
                    controlBala.SetDirectionAndSpeed(jugadorObjetivo.normalized, 30);
                    bala.transform.position = controladorDisparoEnemigo.position;
                    bala.SetActive(true);
                }

                yield return new WaitForSeconds(retardo);
            }
             
            }
    }



    
    }








}
