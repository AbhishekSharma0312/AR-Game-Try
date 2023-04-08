using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ARPlacementManager : MonoBehaviour
{
    ARRaycastManager m_raycastManager;
    static List<ARRaycastHit> raycast_hits = new List<ARRaycastHit>();
    public GameObject PlayArea;

    public Camera arCamera;

    private void Awake() 
    {
        m_raycastManager = GetComponent<ARRaycastManager>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 centreOfScreen = new Vector3(Screen.width / 2 , Screen.height / 2);
        Ray ray = arCamera.ScreenPointToRay(centreOfScreen);

        if(m_raycastManager.Raycast(ray, raycast_hits, TrackableType.PlaneWithinPolygon))
        {
            Pose hitPose = raycast_hits[0].pose;
            Vector3 positionToBePlaced = hitPose.position;
            PlayArea.transform.position = positionToBePlaced;
        }
    }
}