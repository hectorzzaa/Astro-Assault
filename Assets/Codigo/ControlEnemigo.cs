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

    public void recibirDa�o(int da�o)
    {

        
        vida -= da�o;
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


class Enemigo
{
    private int vida;

    private string tipoAtaque;

    private string tipoEnemigo;


    public int getVida()
    {
        return vida;
    }
    public void setVida(int vida)
    {
        vida = this.vida;
    }
    public string getTipoAtaque()
    {
        return tipoAtaque;
    }
    public void setTipoAtaque(string tipoAtaque)
    {
        tipoAtaque = this.tipoAtaque;
    }

    public string getTipoEnemigo()
    {
        return tipoEnemigo;
    }
    public void setTipoEnemigo(string tipoEnemigo)
    {
        tipoEnemigo = this.tipoEnemigo;
    }

    public Enemigo(int vida, string tipoAtaque, string tipoEnemigo)
    {
        this.vida = vida;
        this.tipoAtaque = tipoAtaque;
        this.tipoEnemigo = tipoEnemigo;
    }

    public string decirNombre()
    {
        return "se ha creado al objeto" + getTipoEnemigo();
    }
    
    
}
