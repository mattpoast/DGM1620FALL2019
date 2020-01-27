using System;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public Animation dumpster;
    private void OnMouseDown()
    {
        GetComponent<Animation>();
    }
}
