using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UI;

public class GUIManager : MonoBehaviour
{
    public ARPlacementManager m_arPlacementManager;
    public ARPlaneManager m_arPlaneManager;
    public ARSessionOrigin m_arSessionOrigin;

    public GameObject panel;
    public GameObject AdjustButton;
    public GameObject PlaceButton;
    public GameObject PlayButton;
    public GameObject SliderBar;
    public GameObject CentreImage;
    
    public Slider scaleSlider;

    // Start is called before the first frame update
    void Start()
    {
        AdjustButton.SetActive(false);
        PlayButton.SetActive(false);
        PlaceButton.SetActive(true);
        scaleSlider.onValueChanged.AddListener(OnSliderValueChanged);
    }

    public void OnSliderValueChanged(float value)
    {
        if(scaleSlider != null)
        {
            m_arSessionOrigin.transform.localScale = Vector3.one / value;
        }
    }

    public void OnPlayButtonPresed()
    {
        TrafficManager.Instance.PlayGameButtonPressed();
        panel.SetActive(false);
    }

    public void EnablePlacementAndPlaneDetection()
    {
        m_arPlacementManager.enabled = true;
        m_arPlaneManager.enabled = true;
        ActivateOrDeactivateAllPlanes(true);
        AdjustButton.SetActive(false);
        PlayButton.SetActive(false);
        PlaceButton.SetActive(true);
        SliderBar.SetActive(true);
    }

    public void DisablePlacementAndPlaneDetection()
    {
        m_arPlacementManager.enabled = false;
        m_arPlaneManager.enabled = false;
        ActivateOrDeactivateAllPlanes(false);
        AdjustButton.SetActive(true);
        PlayButton.SetActive(true);
        PlaceButton.SetActive(false);
        SliderBar.SetActive(false);
    }

    public void ActivateOrDeactivateAllPlanes(bool value)
    {
        foreach (var plane in m_arPlaneManager.trackables)
        {
            plane.gameObject.SetActive(value);
        }
    }
    
}