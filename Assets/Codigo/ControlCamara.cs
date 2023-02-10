using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCamara : MonoBehaviour
{

    [SerializeField] GameObject jugador;
    [SerializeField] Vector3 posicionRelativa;


    // Start is called before the first frame update
    void Start()
    {
        //posicionRelativa = transform.position - jugador.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector2.up * velocidad * Time.deltaTime);

        //transform.position = jugador.transform.position + posicionRelativa;

        transform.position = new Vector3(0,jugador.transform.position.y,transform.position.z);

    }
}
