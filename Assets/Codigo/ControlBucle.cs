using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBucle : MonoBehaviour
{
    [SerializeField] private GameObject jugador;
    [SerializeField] private Transform start;
    [SerializeField] private Transform end;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(end.position.y);
        bucle();
    }

    private void bucle()
    {
        //Debug.Log(jugador.transform.position.y);

        if (jugador.transform.position.y >= end.position.y)
        {
            Debug.Log("final");
        }
    }

}
