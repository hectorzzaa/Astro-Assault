using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

class Enemigo: MonoBehaviour
{


    [SerializeField] private int vida;

    [SerializeField] private string tipoAtaque;

    [SerializeField] private int puntos;

    [SerializeField] private Boolean puedeDisparar;


    public int getVida()
    {
        return vida;
    }
    public void setVida(int vida)
    {
        this.vida=vida;
    }

    public int getPuntos()
    {
        return puntos;
    }
    public void setPuntos(int puntos)
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


    public virtual void OnDestroy()
    {
        Debug.Log("Me destruyo pero no tengo identidad");
    }
    public virtual void decirNombre()
    {
        Debug.Log("Creo un objeto sin identidad :c");

    }

    public virtual void recibirDaño(int daño)
    {
        int vida = getVida();
        Debug.Log(vida);

        vida -= daño;
        if (vida == 0)
        {
            Debug.Log("se ha destruido el objeto por un disparo");

            Destroy(this.gameObject);

        }

    }
}



