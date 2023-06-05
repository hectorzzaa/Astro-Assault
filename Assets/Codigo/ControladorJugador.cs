using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;


public class ControladorJugador : MonoBehaviour
{

    [SerializeField] private float velocidad;
    [SerializeField] private float xMinimo, xMaximo;
    [SerializeField] private float yMinimo, yMaximo;

    [SerializeField] private Transform controladorDisparo;
    [SerializeField] private AudioClip sonidoDisparo;
    [SerializeField] private HUD hud;
   

    void Start()
    {
        //Al poner una posicion estandar en el metodo start()
        //me aseguro que el jugador empiece en el mismo sitio siempre
        gameObject.transform.position = new Vector3(0.19F, -2.58F, 0);
    }


    void Update()
    {
        //se establece un rango de valores 
        float x = Mathf.Clamp(transform.position.x,xMinimo,xMaximo);
        float y = Mathf.Clamp(transform.position.y,yMinimo,yMaximo);
        //Con el rango de valores estableido me aseguro que el objeto no pueda salir de la camara
        transform.position = new Vector3(x,y,0);
        //Se comprueba cuando se pulsa una tecla para asi aplicar una fuerza
        if (Input.GetKey(KeyCode.LeftArrow)||Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Translate(Vector2.left * (velocidad * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Translate(Vector2.right * (velocidad * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.Translate(Vector2.down * (velocidad * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            gameObject.transform.Translate(Vector2.up * (velocidad * Time.deltaTime));
        }
        //En este caso en vez de mover la nave llama al metodo disparar
        if (Input.GetKeyUp(KeyCode.E))
        {
            disparar();
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

    
    
    }


        private void disparar()
    {

      /* StartCoroutine(ActivarBalasConRetardo(GameManager.Instance.cantidadBalas, 0.1f));

        IEnumerator ActivarBalasConRetardo(int numBalas, float retardo)
        {
            for (int i = 0; i < numBalas; i++)
            {
                GameObject bala = GameManager.Instance.GetListaObjetos();
                if (bala != null)
                {
                    bala.transform.position = controladorDisparo.position;
                    bala.SetActive(true);
                }
                else
                {
                    // Si no se encuentra más balas disponibles, puedes romper el bucle o tomar alguna otra acción
                    break;
                }

                yield return new WaitForSeconds(retardo);
            }
        }



            //Intsancio el objeto de bala usando la posicion del controladorDisparo
            //que esta establecido como hijo del objeto naveJugador
            
        // Instantiate(bala, controladorDisparo.position, controladorDisparo.rotation);
        
            //Creo el gameObject
            GameObject bala=GameManager.Instance.GetListaObjetos();
        if (bala!=null)
        {
            //Lo instancio usando la posicion del controlador disparo
            bala.transform.position = controladorDisparo.position;
            bala.SetActive(true);
        }
        
        AudioManager.Instance.ReproducirSonido(sonidoDisparo);
      */
    }
}
