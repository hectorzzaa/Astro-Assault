using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlEnemigo : MonoBehaviour

{
    Enemigo enePiedra = new Enemigo(1, "a", "piedra");
    

    [SerializeField] private float velocidad;
    [SerializeField] private float vida;
    [SerializeField] private GameObject enemigoPiedra;
    
    private GameObject puntos;
    // Start is called before the first frame update
    void Start()

    {
        enePiedra.setObjeto(enemigoPiedra);
        
        Debug.Log(enePiedra.decirNombre());


    }


    
    void Update()
    {
        if (enePiedra.getTipoEnemigo() == "piedra")
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


        if (enePiedra.getTipoEnemigo() == "piedra")
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



