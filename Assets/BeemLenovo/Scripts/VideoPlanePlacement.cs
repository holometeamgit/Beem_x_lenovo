using UnityEngine;

public class VideoPlanePlacement : MonoBehaviour
{
    public void Awake()
    {
        VideoManager.Instance.SetTransformToPlane(transform);
        VideoManager.Instance.Play();
    }
}
