using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform arCamera;
    public float distanceFromCamera = 5.0f;

    private Vector3 relativePosition;

    void Start()
    {
        relativePosition = transform.position - arCamera.position;
    }

    void Update()
    {
        Vector3 newPosition = arCamera.position + arCamera.TransformDirection(relativePosition.normalized * distanceFromCamera);
        transform.position = newPosition;
    }
}
