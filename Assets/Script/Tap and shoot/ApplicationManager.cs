using UnityEngine;

public class ApplicationManager : MonoBehaviour
{
    [SerializeField] public GameObject enemyPrefab1;
    [SerializeField] public GameObject enemyPrefab2;
    [SerializeField] public GameObject enemyPrefab3;
    [SerializeField] public GameObject enemyPrefab4;
    [SerializeField] public GameObject enemyPrefab5;
    [SerializeField] public Transform cam;
    public static int enemyNumber = 50;
    [SerializeField] public float spawnRange = 30f; // Variable à ajuster

    public void SpawnEnemy(GameObject enemyPrefab)
    {
        for (int i = 0; i < enemyNumber/5; i++)
        {
            float x = cam.transform.position.x + Random.Range(-spawnRange, spawnRange);
            float y= cam.transform.position.y + Random.Range(-spawnRange, spawnRange);
            float z = cam.transform.position.z + Random.Range(-spawnRange, spawnRange);
            Vector3 spawnPos = new Vector3(x, y, z);
            Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
        }
    }

    public void spawn(GameObject enemyPrefab) // Fonction test
    {
        float x = cam.transform.position.x + Random.Range(-spawnRange, spawnRange);
        float y= cam.transform.position.y + Random.Range(-spawnRange, spawnRange);
        float z = cam.transform.position.z + Random.Range(-spawnRange, spawnRange);
        Vector3 spawnPos = new Vector3(x, y, z);
        Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
    }
    void Start()
    {
        SpawnEnemy(enemyPrefab1);
        SpawnEnemy(enemyPrefab2);
        SpawnEnemy(enemyPrefab3);
        SpawnEnemy(enemyPrefab4);
        SpawnEnemy(enemyPrefab5);
    }
}
