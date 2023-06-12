using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;


public class ControladorJugador : MonoBehaviour
{

    [SerializeField] private float velocidad;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float xMinimo, xMaximo;
    [SerializeField] private float yMinimo, yMaximo;
    //[SerializeField] private GameObject bala;
    [SerializeField] private Transform controladorDisparo;
    [SerializeField] private AudioClip sonidoDisparo;
    [SerializeField] private HUD hud;
    [SerializeField] private Controles controles;
    [SerializeField] private Vector2 direccionJugador;
    [SerializeField] private bool puedeHacerDash;
    [SerializeField] private bool sePuedeMover;
    [SerializeField] private int tiempoEspera;
    [SerializeField] private float velocidadDash;
    [SerializeField] private float duraccionDash;



    private void Awake()
    {
        puedeHacerDash = true;
        rb = GetComponent<Rigidbody2D>();
        controles= new Controles();
        
    }
    private void OnEnable()
    {
        controles.Juego.Enable();
        //detecto cada vez que se pulsa un boton o se mantiene una direccion
        controles.Juego.Movmiento.performed+=moverJugador;
        //cuando dejo de moverlo vuelve a 0
        controles.Juego.Movmiento.canceled+=moverJugador;
        //En este caso solo detecta cuando lo pulso
        controles.Juego.disparo.started+=disparar;

        controles.Juego.Dash.started += Dash;

       
    }

    private void Dash(InputAction.CallbackContext obj)
    {
        if (puedeHacerDash)
        {
        StartCoroutine(Dash2());

        }
    }

    private IEnumerator Dash2()
    {
        puedeHacerDash = false;
        rb.gravityScale = 0;
        rb.velocity = new Vector2(transform.localScale.x* velocidadDash, 0);



        yield return new WaitForSeconds(duraccionDash);
        rb.velocity = Vector2.zero;
        puedeHacerDash = true;


    }

    private void moverJugador(InputAction.CallbackContext obj)
    {
        Vector2 moveDir = obj.ReadValue<Vector2>();
        direccionJugador = moveDir;
    }

    void Start()
    {
       
        //Al poner una posicion estandar en el metodo start()
        //me aseguro que el jugador empiece en el mismo sitio siempre
        //gameObject.transform.position = new Vector3(0.19F, -2.58F, 0);
    }


    void Update()
    {
        //se establece un rango de valores 
        float x = Mathf.Clamp(transform.position.x,xMinimo,xMaximo);
        float y = Mathf.Clamp(transform.position.y,yMinimo,yMaximo);
        //Con el rango de valores estableido me aseguro que el objeto no pueda salir de la camara
        transform.position = new Vector3(x,y,0);

        //rb.velocity = new Vector2(direccionJugador.x, direccionJugador.y);
       gameObject.transform.Translate(new Vector2(direccionJugador.x, direccionJugador.y) *velocidad*Time.deltaTime);
        if (Input.GetKey(KeyCode.Space)&&puedeHacerDash)
        {
            Debug.Log("se pulsa espacio");
            //StartCoroutine(Dash2());
            // StartCoroutine(Dash());
        }

    }
   /* private void FixedUpdate()
    {
        rb.velocity = new Vector2(direccionJugador.x*velocidad, direccionJugador.y* velocidad);
    }*/



    /* private IEnumerator Dash()
     {
         sePuedeMover = false;
         puedeHacerDash = false;
         yield return new WaitForSeconds(1);
         sePuedeMover = true;
         puedeHacerDash = true;
         transform.position = new Vector2(20*transform.localScale.x,0);
     }*/

    private void OnTriggerEnter2D(Collider2D collision)
    {

    
    
    }


        private void disparar(InputAction.CallbackContext obj)
    {

        //Instantiate(bala, controladorDisparo.position, controladorDisparo.rotation);
        if (SceneManager.GetActiveScene().name == "EscenaJuego")
        { 
        

            StartCoroutine(ActivarBalasConRetardo(GameManager.Instance.cantidadBalasJuagador, 0.1f));

          IEnumerator ActivarBalasConRetardo(int numBalas, float retardo)
          {
              //for (int i = 0; i < numBalas; i++)
              //{
                  GameObject bala = GameManager.Instance.GetListaObjetosJugador();
                  if (bala != null)
                  {
                      bala.transform.position = controladorDisparo.position;
                      bala.SetActive(true);
                  }
                  //else
                  //{
                      // Si no se encuentra más balas disponibles, puedes romper el bucle o tomar alguna otra acción
                      //break;
                  //}

                  yield return new WaitForSeconds(retardo);
              //}
          }



              //Intsancio el objeto de bala usando la posicion del controladorDisparo
              //que esta establecido como hijo del objeto naveJugador

          // Instantiate(bala, controladorDisparo.position, controladorDisparo.rotation);

              //Creo el gameObject
          /*    GameObject bala=GameManager.Instance.GetListaObjetosJugador();
          if (bala!=null)
          {
              //Lo instancio usando la posicion del controlador disparo
              bala.transform.position = controladorDisparo.position;
              bala.SetActive(true);
            GameManager.Instance.municion++;
          }
          */
          AudioManager.Instance.ReproducirSonido(sonidoDisparo);
        }
    }
}
