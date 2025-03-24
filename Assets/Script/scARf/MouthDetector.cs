using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class MouthDetector : MonoBehaviour
{
    private ARFace arFace;
    public GameObject mouthTriggerPrefab;

    private Transform mouthTrigger;
    private int noseIndex = 9;
    private int chinIndex = 17;

    void Start()
    {
        arFace = GetComponent<ARFace>();
        if (arFace == null)
        {
            Debug.LogError("ARFace component not found!");
            return;
        }
        arFace.updated += OnFaceUpdated;
        mouthTrigger = Instantiate(mouthTriggerPrefab).transform;
        mouthTrigger.gameObject.SetActive(true);
    }

    private void OnFaceUpdated(ARFaceUpdatedEventArgs eventArgs)
    {
        if (arFace.vertices.Length == 0) return;
        Vector3 nosePos = arFace.transform.TransformPoint(arFace.vertices[noseIndex]);
        Vector3 chinPos = arFace.transform.TransformPoint(arFace.vertices[chinIndex]);
        Vector3 triggerPosition = Vector3.Lerp(nosePos, chinPos, 0.7f); 
        mouthTrigger.position = triggerPosition;
    }

    private void OnDestroy()
    {
        arFace.updated -= OnFaceUpdated;
        if (mouthTrigger != null)
            Destroy(mouthTrigger.gameObject);
    }
}