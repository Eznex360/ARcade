using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PNJController : MonoBehaviour
{
    public static int count = 0;

    public AudioSource boom;
    // La quantité de dégâts infligée au PNJ lorsqu'il est touché par une balle

    // La méthode OnTriggerEnter est appelée lorsque le PNJ est touché par une balle
    private void OnTriggerEnter(Collider other)
    { 
        if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            boom.Play();
            count += 1;
        }
    }
}