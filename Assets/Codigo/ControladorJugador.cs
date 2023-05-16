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
    [SerializeField] private GameObject bala;
    [SerializeField] private Transform controladorDisparo;
    [SerializeField] private HUD hud;
   

    void Start()
    {



        gameObject.transform.position = new Vector3(0.19F, -2.58F, 0);
    }


    void Update()
    {

        //establezo un rango de valores

        float x = Mathf.Clamp(transform.position.x,xMinimo,xMaximo);
        float y = Mathf.Clamp(transform.position.y,yMinimo,yMaximo);
        transform.position = new Vector3(x,y,0);

        



       



        if (Input.GetKey(KeyCode.LeftArrow)||Input.GetKey(KeyCode.A))
        {
            //He decidido hacerlo con traslate porque no es necesario que tenga fisicas a la hora de girar o ir hacia abajo

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
        if (Input.GetKeyUp(KeyCode.E))
        {
            disparar();

        }



        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Piedra")|| collision.CompareTag("nave"))
        {
            GameManager.Instance.RecibirDaño();
            
        }
    
    
    }

        private void disparar()
    {
        Instantiate(bala, controladorDisparo.position, controladorDisparo.rotation);
    }
}
