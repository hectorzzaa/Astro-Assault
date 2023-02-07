using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnPiedra : MonoBehaviour
{


    [SerializeField] private GameObject enemigo;
    int contador = 0;

    // Start is called before the first frame update
    void Start()
    {
        
            Instantiate(enemigo);


    }

    // Update is called once per frame
    void Update()
    {



        //ene = GameObject.Find("Enemigo Object").GetComponent<Enemigo>();
        while (contador < 3&&enemigo.GetComponent<Enemigo>().estaDestruido)
        {
            float x = Random.Range(-30F, 30);
            Vector2 position = new Vector2(x,0);
            Quaternion rotation = new Quaternion();
            Instantiate(enemigo,position,rotation);
            enemigo.GetComponent<Enemigo>().estaDestruido = false;
            Debug.Log(enemigo.GetComponent<Enemigo>().estaDestruido);


            contador++;
        }
       

    }
    
}
