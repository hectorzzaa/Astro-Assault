using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{



    void Start()
    {
        gameObject.transform.position = new Vector3(0.19F, -2.58F, 0);
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //He decidido hacerlo con traslate porque no es necesario que tenga fisicas a la hora de girar o ir hacia abajo

            gameObject.transform.Translate(-15F * Time.deltaTime, 0, 0);

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {

            gameObject.transform.Translate(15F*Time.deltaTime, 0, 0);

        }
        if (Input.GetKey(KeyCode.Space))
        {
            gameObject.transform.Translate(0, -15F * Time.deltaTime, 0);
        }
        if(Input.GetKey(KeyCode.UpArrow)) {
            gameObject.transform.Translate(0, 15F * Time.deltaTime, 0);
        }
    }
}
