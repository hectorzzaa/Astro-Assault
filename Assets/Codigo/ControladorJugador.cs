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
    [SerializeField] private float xMinimo, xMaximo;
    [SerializeField] private float yMinimo, yMaximo;
    //[SerializeField] private GameObject bala;
    [SerializeField] private Transform controladorDisparo;
    [SerializeField] private AudioClip sonidoDisparo;
    [SerializeField] private HUD hud;
    [SerializeField] private Controles controles;
    [SerializeField] private Vector2 pruebavector;
    private void Awake()
    {
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
    }

    

    private void moverJugador(InputAction.CallbackContext obj)
    {
        Vector2 moveDir = obj.ReadValue<Vector2>();
        Debug.Log(moveDir);
        pruebavector= moveDir;
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


        gameObject.transform.Translate(new Vector2(pruebavector.x, pruebavector.y) *velocidad*Time.deltaTime);


    }


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
