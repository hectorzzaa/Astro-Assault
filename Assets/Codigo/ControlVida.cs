using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlVida : MonoBehaviour
{

    public float velocidad;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movimiento();
    }
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Jugador"))
        {
            Debug.Log("se sumara una vida una vida");
            GameManager.Instance.RecuperarVidas();
            Destroy(this.gameObject);
        }
    }
    public void movimiento()
    {

        transform.Translate(Vector2.down * velocidad * Time.deltaTime);
    }
}
