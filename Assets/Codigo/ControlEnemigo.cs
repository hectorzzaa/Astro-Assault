using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlEnemigo : MonoBehaviour

{
    [SerializeField] private EnemigoPiedra enePiedra;
    //EnemigoPiedra enePiedra = new EnemigoPiedra(1, "a",false);
    //public GameObject gameObject;

    [SerializeField] private float velocidad;
    [SerializeField] private float vida;
    [SerializeField] private GameObject enemigoPiedra;
    [SerializeField] private EnemigoNave eneNave;
    
    //private GameObject puntos;
    // Start is called before the first frame update
    void Start()

    {


       




    }


    
    void Update()
    {

        
        transform.Translate(Vector2.down * velocidad * Time.deltaTime);
        


    }

    /*public void recibirDaño(int daño)
    {

        
        vida -= daño;
        if (vida == 0)
        {
            Debug.Log("se ha destruido la piedra por un disparo");

            Destroy(this.gameObject);

        }
        
    }*/

    private void OnTriggerEnter2D(Collider2D collision)
    {


        
            if (collision.CompareTag("Final"))
            {
                Destroy(this.gameObject);
            }
            if (collision.CompareTag("Jugador"))
            {
                Debug.Log("Te moriste noob");
                Destroy(this.gameObject);

            }
        
           
    }




}



