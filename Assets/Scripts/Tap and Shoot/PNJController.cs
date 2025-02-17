using UnityEngine;

public class PNJController : MonoBehaviour
{
    public static int count = 0;

    public AudioSource boom;
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
