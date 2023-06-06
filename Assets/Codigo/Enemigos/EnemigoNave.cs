using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class EnemigoNave : Enemigo
{
    [SerializeField] private float timer;
    [SerializeField] private Transform controladorDisparoEnemigo;
    [SerializeField] private GameObject controlNivel;
    public Transform naveJugador;
    public float distanciaObjeto = 50f;
    public float rangoDisparo = 5f;
    public float velocidadMovimiento = 5f;
    public bool haDisparado=false;
    private void Update()
    {
        transform.Translate(Vector2.down * 10 * Time.deltaTime);
        // SeguirJugador();
        GameObject jugador = GameObject.FindGameObjectWithTag("Jugador");

        if (jugador != null)
        {
            float distancia = Vector3.Distance(transform.position, jugador.transform.position);

            if (distancia <= rangoDisparo && transform.position.y>-6)
            {
                timer += Time.deltaTime;
                while (timer >= 1)
                {
                    timer = 0;
                disparar();
                    haDisparado = true;
        
                }
            }
        }


       


    }


    private void OnDestroy()
    {
       

        GameManager.Instance.numNaves--;
        //GameManager.Instance.BorrarBalasLista(4);
        Debug.Log(GameManager.Instance.numNaves);
    }


    private void Start()
    {

        

        //gameObject.transform.position = new Vector3(0.19F, 10F, 0);
        haDisparado = false;
    }


    public void movimiento()
    {
        //transform.Translate(Vector2.down * 10 * Time.deltaTime);
    }

    private void SeguirJugador()
    {
        Vector3 jugadorObjetivo = naveJugador.transform.position;
        Vector3 direccion = (jugadorObjetivo - transform.position).normalized;
        Vector3 nuevaPosicion = transform.position + direccion * velocidadMovimiento * Time.deltaTime;

        // Mantener la distancia deseada entre el objeto y el jugador
        if (Vector3.Distance(nuevaPosicion, jugadorObjetivo) > distanciaObjeto)
        {
            nuevaPosicion = jugadorObjetivo + (nuevaPosicion - jugadorObjetivo).normalized * distanciaObjeto;
        }

        transform.position = nuevaPosicion;

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
                    controlBala.SetDirectionAndSpeed(jugadorObjetivo.normalized, 30);
                    bala.transform.position = controladorDisparoEnemigo.position;
                    bala.SetActive(true);
                       
                }
                
                yield return new WaitForSeconds(retardo);
                haDisparado = true;
            }
             
            }
    }



    
    }








}
