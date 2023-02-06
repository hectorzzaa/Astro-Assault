using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnPiedra : MonoBehaviour
{

    private Enemigo ene;
    [SerializeField] private GameObject enemigo;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(enemigo);
    }

    // Update is called once per frame
    void Update()
    {
       /* if (ene.estaDestruido)
        {
            Instantiate(enemigo);
        }
        else
        {
            Debug.Log("aaaa");
        }*/

    }
    
}
