using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlFondo : MonoBehaviour
{

    public float velocidad;
    [SerializeField] private MeshRenderer mesh;

    public Material[] mat;


    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 offset = new Vector2(0,Time.deltaTime*velocidad);
       // mesh.material.mainTextureOffset= offset;
        //Hago que a cumplir una condicion cambie de fondo
        if (Input.GetKey(KeyCode.L))
            {
            mesh.material = mat[1];
        }
        


    }
}
