using System;
using UnityEngine;
using UnityEngine.UI;

public class VideoPlanePlacement : MonoBehaviour
{
    [SerializeField] private Text _debugText;

    private void OnEnable()
    {
        _debugText.text = "Enable";
    }
    // public void Awake()
    // {
    //     VideoManager.Instance.SetTransformToPlane(transform);
    //     VideoManager.Instance.Play();
    // }
    
    private void OnDisable()
    {
        _debugText.text = "Disable";
    }
    
    public void Place()
    {
        _debugText.text = "touch!";
        VideoManager.Instance.SetTransformToPlane(transform);
        VideoManager.Instance.Play();
    }
}
