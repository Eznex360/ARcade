using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform cam;
    public int enemyNumber = 30;
    public float spawnRange = 5f;

    public void SpawnEnemy()
    {
        for (int i = 0; i < enemyNumber; i++)
        {
            float x = cam.transform.position.x + Random.Range(-spawnRange, spawnRange);
            float y= cam.transform.position.y + Random.Range(-spawnRange, spawnRange);
            float z = cam.transform.position.z + Random.Range(-spawnRange, spawnRange);
            Vector3 spawnPos = new Vector3(x, y, z);
            Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
        }
    }

    public void spawn()
    {
        float x = cam.transform.position.x + Random.Range(-spawnRange, spawnRange);
        float y= cam.transform.position.y + Random.Range(-spawnRange, spawnRange);
        float z = cam.transform.position.z + Random.Range(-spawnRange, spawnRange);
        Vector3 spawnPos = new Vector3(x, y, z);
        Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
    }
    void Start()
    {
        SpawnEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
