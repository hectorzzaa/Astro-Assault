using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class AudioManager : MonoBehaviour
{
    private AudioSource audioSource;
    public static AudioManager Instance { get; private set; }

    void Awake()
    {

        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.Log("Hay mas de un audio manager");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
    }
   //Metodo para cuando quiera que se reproduzca una musica o sonido
    public void ReproducirSonido(AudioClip audio)
    {
        audioSource.PlayOneShot(audio);
    }
    //Paro la musica cuando hace falta
    public void PararMusica()
    {
        audioSource.Stop();
    }
    //Vuelvo a poner la musica si hace falta
    public void ReanudarMusica()
    {
        audioSource.Play();
    }
}
