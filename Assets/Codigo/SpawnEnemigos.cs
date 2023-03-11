using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemigos : MonoBehaviour
{
    [SerializeField] private GameObject enemigoPiedra;

    Enemigo enePiedra = new Enemigo(1, "fisico", "piedra");



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
