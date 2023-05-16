using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

 class  Enemigo: MonoBehaviour
{


    [SerializeField] private int vida;

    [SerializeField] private string tipoAtaque;

    [SerializeField]
    private float puntos;

    [SerializeField] private Boolean puedeDisparar;

    [SerializeField] private int id;



    [SerializeField] private Puntaje puntaje;


   
    public void SetClasePuntos(Puntaje punto)
    {
        puntaje = punto;
    }
    public Puntaje getPuntaje()
    {
        return puntaje;
    }


    public int getVida()
    {
        return vida;
    }
    public void setVida(int vida)
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


        vida -= daño;
        if (vida == 0)
        {
            Debug.Log("se ha destruido el objeto por un disparo");

            Destroy(this.gameObject);

        }


    }
    public void gestionarPuntos(int puntosRecibidos)
    {
        int puntos = 0;

        puntos = puntos + puntosRecibidos;

        Debug.Log("Puntaje: "+ puntos.ToString());



    }






}



