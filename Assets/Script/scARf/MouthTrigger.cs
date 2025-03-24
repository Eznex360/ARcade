using UnityEngine;
using System.Collections.Generic;

public class MouthTrigger : MonoBehaviour
{
    public static int DestroyCount;
    public static int Score;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"Objet {other.name} touche la moitié basse du visage.");
        Destroy(other.gameObject);
        DestroyCount++;
        Score++;
    }
}