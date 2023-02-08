using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoJugador : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Transform controladorDisparo;
    [SerializeField] private GameObject bala;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            disparar();

        }
    }

    private void disparar()
    {
        Instantiate(bala, controladorDisparo.position, controladorDisparo.rotation);
    }
}
