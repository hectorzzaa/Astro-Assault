using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{



    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKey("left"))
        {
            //gameObject.transform.Translate(-50f * Time.deltaTime, 0, 0);
           // gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-100 * Time.deltaTime, 0));
            gameObject.transform.Translate(-15F * Time.deltaTime, 0, 0);

        }
        if (Input.GetKey("right"))
        {
            //gameObject.transform.Translate(50f * Time.deltaTime, 0, 0);
           // gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(100 * Time.deltaTime, 0));
            gameObject.transform.Translate(15F*Time.deltaTime, 0, 0);

        }
        if (Input.GetKey(KeyCode.Space))
        {
            gameObject.transform.Translate(0, -15F * Time.deltaTime, 0);
        }
    }
}
