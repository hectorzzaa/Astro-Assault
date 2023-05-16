using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ControlPuntaje : MonoBehaviour
{/*
    int score = 0;
    //public static ControlPuntaje controlPuntaje;
    public Text textoContador;

    void Start()
    {
        //controlPuntaje = this;
        textoContador.text = "Puntos: " + 0;

    }



    public void raiseScore(int s)
    {
        score += s;
        Debug.Log("Puntuacion: " + score);
        textoContador.text = "Puntos: " + score.ToString();
    }*/

    private float puntos;

    private TextMeshProUGUI texto;
    private void Start()
    {
        texto= GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        puntos += Time.deltaTime;
        

    }






}
