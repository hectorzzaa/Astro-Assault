using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlEnemigo : MonoBehaviour

{
    EnemigoPiedra enePiedra = new EnemigoPiedra(1, "a",false);
    

    [SerializeField] private float velocidad;
    [SerializeField] private float vida;
    [SerializeField] private GameObject enemigoPiedra;
    
    private GameObject puntos;
    // Start is called before the first frame update
    void Start()

    {
        //enePiedra.setObjeto(enemigoPiedra);
        
        enePiedra.decirNombre();


    }


    
    void Update()
    {
        if (!enePiedra.getPuedeDisparar())
        {

        }
            transform.Translate(Vector2.down * velocidad * Time.deltaTime);
    }

    public void recibirDaño(int daño)
    {

        
        vida -= daño;
        if (vida == 0)
        {

            Destroy(this.gameObject);

        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (!enePiedra.getPuedeDisparar())
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




}



