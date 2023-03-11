using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlEnemigo : MonoBehaviour

{
    Enemigo enemigoPiedra = new Enemigo(1, "a", "piedra");
    

    [SerializeField] private float velocidad;
    [SerializeField] private float vida;
    
    private GameObject puntos;
    // Start is called before the first frame update
    void Start()

    {
        Debug.Log(enemigoPiedra.decirNombre());


    }


    // Update is called once per frame
    void Update()
    {
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
        if (collision.CompareTag("Final"))
        {
            Destroy(this.gameObject);
        }
        if (collision.CompareTag("Jugador"))
        {
            Debug.Log("Te moriste noob");
        }
    }




}



