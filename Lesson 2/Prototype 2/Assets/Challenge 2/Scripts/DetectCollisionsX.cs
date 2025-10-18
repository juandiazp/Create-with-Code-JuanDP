using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
    
        // Verificar si el objeto con el que colisionamos es un perro
        if (other.CompareTag("Dog"))
        {
            // Destruir la bola
            Destroy(gameObject);
        }
    }
}
