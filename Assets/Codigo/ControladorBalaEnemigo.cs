using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorBalaEnemigo : MonoBehaviour
{
    private Vector3 direction;
    private float speed;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
        //temporizador para que la bala de desactive y
        //no se quede fuera de la pantalla infinitamente

        while (timer > 3)
        {
            timer = 0;
            gameObject.SetActive(false);
        }
        //Con la posicion y velocidad hago que la bala se mueva en la direccione establecida
        transform.position += direction * speed * Time.deltaTime;

    }

    public void SetDirectionAndSpeed(Vector3 dir, float spd)
    {
        direction = dir.normalized;
        speed = spd;
        transform.rotation = Quaternion.LookRotation(Vector3.forward, direction);
    }
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Final"))
        {
            
            gameObject.SetActive(false);
        }
        if (collision.CompareTag("Jugador")&&ControladorJugador.recibeDaño)
        {
            GameManager.Instance.RecibirDaño();
            gameObject.SetActive(false);
        }
    }
}
