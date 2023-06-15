using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class EnemigoNave : Enemigo
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
                    //Consigo la direccion de donde esta el jugador
                    Vector2 jugadorObjetivo = naveJugador.transform.position - transform.position;
                    //Guardo en una variable de tipo GameObjet la lista de balas  para poner activarla en la escena
                    GameObject bala = GameManager.Instance.GetListaObjetos();
                    if (bala != null)
                    {
                        //Extraigo el controladorBala del objeto bala
                        ControladorBalaEnemigo controlBala = bala.GetComponent<ControladorBalaEnemigo>();
                        
                        //Establezco la direccion de la bala hacia el jugador, su velocidad y su rotacion para que sea visible
                        controlBala.SetDirectionAndSpeed(jugadorObjetivo.normalized, velocidadBala);
                        //Le digo donde empezieza el disparo ene ste caso el objeto hijo Controlador Disapro
                        bala.transform.position = controladorDisparoEnemigo.position;
                        bala.SetActive(true);
                       
                    }
                    //lo que esperara entre cada disparo
                    yield return new WaitForSeconds(retardo);

                }
             
            }
         }
    }//fin metodo








}
