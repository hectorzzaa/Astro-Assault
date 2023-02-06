using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBala : MonoBehaviour
{

    [SerializeField] private float velocidad;
    [SerializeField] private float daño;


    void Update()
    {
        //le digo que se traslade hacia arriba dependiendo de una velocidad que yo establezco en un metodo en el editor
        transform.Translate(Vector2.up*velocidad*Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Piedra")){
            Debug.Log("LE DI");
        }
    }
}
