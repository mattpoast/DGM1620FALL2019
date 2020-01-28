using System;
using UnityEngine;
using UnityEngine.Video;

public class Animation : MonoBehaviour
{
    public VideoClip dumpster;

    private void OnMouseDown()
    {
        VideoPlayer.Instantiate(dumpster);
    }
}
