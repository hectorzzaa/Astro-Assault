using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RecargaScena : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Jugador"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
