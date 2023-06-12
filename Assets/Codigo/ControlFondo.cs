using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ControlFondo : MonoBehaviour
{
    [SerializeField]private RawImage imagen;
    Rect rect;
    [SerializeField] private float velocidadMovimiento;
    Vector2 direccionMovimiento;
    // Start is called before the first frame update
    void Start()
    {
        rect = imagen.uvRect;
    }

    // Update is called once per frame
    void Update()
    {
        rect.y +=velocidadMovimiento*Time.deltaTime;
    
        imagen.uvRect = rect;
    }
}
