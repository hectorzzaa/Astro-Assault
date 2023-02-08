using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnPiedra : MonoBehaviour
{


    [SerializeField] private GameObject enemigo;
    [SerializeField] private GameObject jugador;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(enemigo);

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        while (timer>=3F)
        {

            Vector3 position1 = jugador.transform.position;
            timer = 0;
            
            float x = Random.Range((position1.x - 30F), (position1.x+30F));
            
            Vector2 position = new Vector2(x, 12F);
            Quaternion rotation = new Quaternion();
            Instantiate(enemigo, position, rotation);


        }
    }
    
}
