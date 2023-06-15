using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

 public class  Enemigo: MonoBehaviour
{


    [SerializeField] private float vida;

    [SerializeField] private string tipoAtaque;

    [SerializeField]
    private float puntos;

    [SerializeField] private Boolean puedeDisparar;

    //[SerializeField] private int id;


    public float getVida()
    {
        return vida;
    }
    public void setVida(float vida)
    {
        this.vida=vida;
    }

    public float getPuntos()
    {
        return puntos;
    }
    public void setPuntos(float puntos)
    {
        this.puntos = puntos;
    }

    public String getTipoAtaque()
    {
        return tipoAtaque;
    }
    public void setTipoAtaque(String tipoAtaque)
    {
        this.tipoAtaque=tipoAtaque;
    }
    public Boolean getPuedeDisparar()
    {
        return puedeDisparar;
    }
    public void getPuedeDisparar(Boolean puedeDisparar)
    {
        this.puedeDisparar = puedeDisparar;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        
        //con la colision se establece que cuando colisione con el enemigo este se destuya y
        //llame a la instancia del GameManager y al metodo de recibir daño
        if (collision.CompareTag("Jugador"))
        {
            GameManager.Instance.RecibirDaño();
            Destroy(this.gameObject);

        }
    }




    public virtual void recibirDaño(float daño)
    {
        float vida = getVida();

        //bajo la vida
        vida -= daño;
        setVida(vida);
        //Si la vida llega a 0 o menor se llama al metodo de sumar los puntos
        //y se destruye el enemigo
        if (vida <= 0)
        {
            GameManager.Instance.SumarPuntos(getPuntos());
            Destroy(this.gameObject);
            

        }
        

    }
   






}



