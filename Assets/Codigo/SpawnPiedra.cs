using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnPiedra : MonoBehaviour
{

    private Enemigo ene;
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

       
        while (contador < 3)
        {
            float x = Random.Range(-30F, 30);
            Vector2 position = new Vector2(x,0);
            Quaternion rotation = new Quaternion();
            Instantiate(enemigo,position,rotation);
            
            
            contador++;
        }
        /*if (ene.estaDestruido)
        {
           
            Instantiate(enemigo);
        }
        else
        {
            Debug.Log("aaaa");
        }*/

    }
    
}
