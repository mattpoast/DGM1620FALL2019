using UnityEngine;
using UnityEngine.Video;

public class Tryforanimation : MonoBehaviour
{
    public GameObject entrance;
    public VideoClip animationn;

    private void OnMouseDown()
    { 
        Instantiate(animationn);
    }
}
