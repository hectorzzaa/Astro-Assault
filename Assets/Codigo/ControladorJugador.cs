using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{

    [SerializeField] private float velocidad;

    void Start()
    {
        gameObject.transform.position = new Vector3(0.19F, -2.58F, 0);
    }


    void Update()
    {
        
        
        if (Input.GetKey(KeyCode.LeftArrow)||Input.GetKey(KeyCode.A))
        {
            //He decidido hacerlo con traslate porque no es necesario que tenga fisicas a la hora de girar o ir hacia abajo

            gameObject.transform.Translate(Vector2.left * (velocidad * Time.deltaTime));


        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {

            gameObject.transform.Translate(Vector2.right * (velocidad * Time.deltaTime));


        }
        else if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.Translate(0, -20F * Time.deltaTime, 0);
        }
        else if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            gameObject.transform.Translate(Vector2.up * (velocidad * Time.deltaTime));
        }
    }
}
