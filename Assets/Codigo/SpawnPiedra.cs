using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnPiedra : MonoBehaviour
{


    [SerializeField] private GameObject enemigo;

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
            timer = 0;
            float x = Random.Range(-30F, 30F);
            Vector2 position = new Vector2(x, 0);
            Quaternion rotation = new Quaternion();
            Instantiate(enemigo, position, rotation);


        }
    }
    
}
