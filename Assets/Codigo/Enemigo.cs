using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour

{





    [SerializeField] private float vida;
    private GameObject puntos;
    // Start is called before the first frame update
    void Start()

    {

       
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void recibirDa�o(int da�o)
    {

        
        vida -= da�o;
        if (vida == 0)
        {

            Destroy(this.gameObject);

        }
        
    }



}
