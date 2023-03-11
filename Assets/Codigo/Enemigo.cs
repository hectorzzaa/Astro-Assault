using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

class Enemigo
{
    [SerializeField] private GameObject prueba;
    private int vida;

    private string tipoAtaque;

    private string tipoEnemigo;

    public GameObject getObjeto()
    {
        return prueba;
    }
    public void setObjeto(GameObject prueba)
    {
        prueba = this.prueba;
    }
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

    public Enemigo()
    {
    }

    public Enemigo(int vida, string tipoAtaque, string tipoEnemigo)
    {
        this.vida = vida;
        this.tipoAtaque = tipoAtaque;
        this.tipoEnemigo = tipoEnemigo;
    }

    public Enemigo(GameObject prueba, int vida, string tipoAtaque, string tipoEnemigo)
    {
        this.prueba = prueba;
        this.vida = vida;
        this.tipoAtaque = tipoAtaque;
        this.tipoEnemigo = tipoEnemigo;
    }

    public string decirNombre()
    {
        return "se ha creado al objeto" + getTipoEnemigo();
    }


}

