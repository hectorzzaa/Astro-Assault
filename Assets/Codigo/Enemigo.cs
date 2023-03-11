using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

class Enemigo
{
    [SerializeField] private GameObject prueba;

    private int vida;

    private string tipoAtaque;

    private Boolean puedeDisparar;


    public int getVida()
    {
        return vida;
    }
    public void setVida(int vida)
    {
        vida = this.vida;
    }
    public String getTipoAtaque()
    {
        return tipoAtaque;
    }
    public void setTipoAtaque(String tipoAtaque)
    {
        tipoAtaque = this.tipoAtaque;
    }
    public Boolean getPuedeDisparar()
    {
        return puedeDisparar;
    }
    public void getPuedeDisparar(Boolean puedeDisparar)
    {
        puedeDisparar = this.puedeDisparar;
    }


    public virtual void OnDestroy()
    {
        Debug.Log("Me destruyo pero no tengo identidad");
    }
    public virtual void decirNombre()
    {
        Debug.Log("Creo un objeto sin identidad :c");

    }

    public Enemigo()
    {
    }

    public Enemigo(int vida, string tipoAtaque, bool puedeDisparar)
    {
        this.vida = vida;
        this.tipoAtaque = tipoAtaque;
        this.puedeDisparar = puedeDisparar;
    }

    public Enemigo(GameObject prueba, int vida, string tipoAtaque, bool puedeDisparar)
    {
        this.prueba = prueba;
        this.vida = vida;
        this.tipoAtaque = tipoAtaque;
        this.puedeDisparar = puedeDisparar;
    }
}

class EnemigoPiedra : Enemigo
{
    public EnemigoPiedra(int vida, string tipoAtaque, bool puedeDisparar)
    {
    }

    public override void decirNombre()
    {
        Debug.Log("Creo un objeto que es una piedra");

    }
    public override void OnDestroy()
    {
        Debug.Log("Me destruyo pero soy una piedra :DD");
    }

}

