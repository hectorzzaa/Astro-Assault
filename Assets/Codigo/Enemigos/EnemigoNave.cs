using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class EnemigoNave : Enemigo
{
    
    [Header("Obejtos")]
    [SerializeField] private Transform controladorDisparoEnemigo;
    [SerializeField] private GameObject controlNivel;
    [SerializeField] private GameObject jugador;
    [Header("Valores necesarios")]
    [SerializeField] private float timer;
    [SerializeField] private int distanciaMaximaObjetivo;
    [SerializeField] private float velocidadMovimiento ;
    [SerializeField] private float velocidadBala;

    private void OnBecameVisible()
    {
        Debug.Log("soy visible");
        disparar();
    }

    private void Start()
    {

        jugador = GameObject.FindGameObjectWithTag("Jugador");

        //gameObject.transform.position = new Vector3(0.19F, 10F, 0);

    }


    private void Update()
    {
        //transform.Translate(Vector2.down * 10 * Time.deltaTime);
         SeguirJugador();
        
    }
    private void SeguirJugador()
    {
        float distancia = Vector3.Distance(transform.position, jugador.transform.position);
        
        if (distancia < distanciaMaximaObjetivo)
        {
            if (distancia > 20)
            {
                transform.position = Vector3.MoveTowards(transform.position, jugador.transform.position, velocidadMovimiento * Time.deltaTime);
            }
            else
            {
                // Solo moverse en el eje X
                Vector3 direccionMovimiento = new Vector3(jugador.transform.position.x - transform.position.x, 0f, 0f);
                transform.position += direccionMovimiento.normalized * velocidadMovimiento * Time.deltaTime;
            }

            disparar();

        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, jugador.transform.position, velocidadMovimiento * Time.deltaTime);

        }
       




       
    }

    private void OnDestroy()
    {
       

        GameManager.Instance.numNaves--;
        //GameManager.Instance.BorrarBalasLista(4);
        Debug.Log(GameManager.Instance.numNaves);
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

         StartCoroutine(ActivarBalasConRetardo(GameManager.Instance.cantidadBalasEnemigo, 0.2f));

         IEnumerator ActivarBalasConRetardo(int numBalas, float retardo)
         {
            //Creo un array para guadrar todos los objetos que tengan el script de ControladorJugador
            //es cierto que solo va ha haber uno pero es necesario hacerlo asi para que la referecia funcione correctamente
            ControladorJugador[] navesJugador = FindObjectsOfType<ControladorJugador>();
            foreach (ControladorJugador naveJugador in navesJugador)
            {
                
            for (int i = 0; i < numBalas; i++)
            {
                Vector2 jugadorObjetivo = naveJugador.transform.position - transform.position;
               
                GameObject bala = GameManager.Instance.GetListaObjetos();
                if (bala != null)
                {
                    ControladorBalaEnemigo controlBala = bala.GetComponent<ControladorBalaEnemigo>();

                    controlBala.SetDirection(jugadorObjetivo.normalized);
                    controlBala.SetDirectionAndSpeed(jugadorObjetivo.normalized, velocidadBala);
                    bala.transform.position = controladorDisparoEnemigo.position;
                    bala.SetActive(true);
                       
                }
                
                yield return new WaitForSeconds(retardo);

            }
             
            }
    }



    
    }








}
