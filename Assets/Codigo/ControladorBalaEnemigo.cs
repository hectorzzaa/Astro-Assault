using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorBalaEnemigo : MonoBehaviour
{
    private Vector3 direction;
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector2.down * 20 * Time.deltaTime);
        transform.position += direction * speed * Time.deltaTime;

    }

    public void SetDirectionAndSpeed(Vector3 dir, float spd)
    {
        direction = dir.normalized;
        speed = spd;
    }
    public void SetDirection(Vector3 dir)
    {
        direction = dir.normalized;

        // Rotar el sprite de la bala
        transform.rotation = Quaternion.LookRotation(Vector3.forward, direction);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Final"))
        {
            Debug.Log("dado");
            gameObject.SetActive(false);
        }
        if (collision.CompareTag("Jugador"))
        {
            Debug.Log("dado");
            gameObject.SetActive(false);
        }
    }
}
