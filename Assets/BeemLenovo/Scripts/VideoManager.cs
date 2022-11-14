using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoManager : Singleton<VideoManager>
{
    [SerializeField] private List<VideoClip> _videoClips;

    [Space(10)]
    [SerializeField] private VideoPlayer _videoPlayer;
    [SerializeField] private Transform _videoPlane;
    
    public void SwitchTo(int index)
    {
        _videoPlayer.clip = _videoClips[index];
    }

    public void Play()
    {
        _videoPlayer.Play();
    }

    public void SetTransformToPlane(Transform value)
    {
        _videoPlane.position = value.position;
        _videoPlane.rotation = value.rotation;
    }
}
