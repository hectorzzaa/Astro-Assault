using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour

{





    [SerializeField] private float vida;
    public bool estaDestruido=false;

    // Start is called before the first frame update
    void Start()
    {
        vida = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void recibirDaño(int daño)
    {
        vida -= daño;
        if (vida == 0)
        {
            estaDestruido= true;
            Destroy(gameObject);
        }
        
    }



}
