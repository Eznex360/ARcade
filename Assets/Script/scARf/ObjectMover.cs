using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    public static float speed = 0.5f;
    public float maxDistance = 5f;
    public float maxLifetime = 5f;

    private Vector3 direction;
    private Vector3 startPosition;
    private float timer;
    public static bool loose = false;

    public delegate void DestroyedByDistanceHandler(GameObject obj);
    public static event DestroyedByDistanceHandler OnDestroyedByDistance;

    void Start()
    {
        direction = Camera.main.transform.forward +
                    new Vector3(Random.Range(-0.5f, 0.5f), Random.Range(-0.5f, 0.5f), Random.Range(0.2f, 1f));
        direction.Normalize();
        startPosition = transform.position;
        timer = 0f;
    }

    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
        timer += Time.deltaTime;

        if (Vector3.Distance(startPosition, transform.position) > maxDistance)
        {
            OnDestroyedByDistance?.Invoke(gameObject);
            Destroy(gameObject);
            loose = true;

        }
        else if (timer >= maxLifetime)
        {
            Destroy(gameObject);
            loose = true;
        }
    }
}