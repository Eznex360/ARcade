using System;
using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;
using UnityEngine.SceneManagement;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject Burger;
    public GameObject HotDog;
    public string WinScene;
    public Camera arCamera;
    public float spawnDistance = 0.5f;
    public static float spawnInterval = 3f;

    private void Update()
    {
        if (MouthTrigger.DestroyCount > 0)
        {
            ObjectMover.speed += 0.01f;
            MouthTrigger.DestroyCount = 0;
            spawnInterval -= 0.01f;
        }

        if (ObjectMover.loose)
            SceneManager.LoadScene(WinScene);
    }

    void Start()
    {
        StartCoroutine(SpawnObjects());
    }

    GameObject RandomChoose(GameObject first, GameObject second)
    {
        int randomValue = Random.Range(0, 2);
        if (randomValue == 0)
            return first;
        return second;
    }

    IEnumerator SpawnObjects()
    {
        while (true)
        {
            SpawnObject();
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    void SpawnObject()
    {
        if (arCamera == null)
        {
            Debug.LogError("AR Camera not assigned!");
            return;
        }
        Vector3 spawnPosition = arCamera.transform.position + 
                                arCamera.transform.forward * spawnDistance + 
                                arCamera.transform.up * -0.1f;
        if (Physics.Raycast(arCamera.transform.position, spawnPosition - arCamera.transform.position, out RaycastHit hit, spawnDistance))
        {
            Debug.Log("Un obstacle bloque la vue, ajustement...");
            spawnPosition = hit.point - arCamera.transform.forward * 0.1f;
        }

        Quaternion spawnRotation = Quaternion.LookRotation(arCamera.transform.forward);
        GameObject newObject = Instantiate(RandomChoose(HotDog,Burger), spawnPosition, spawnRotation);
        newObject.AddComponent<ObjectMover>();
    }
    
    
}