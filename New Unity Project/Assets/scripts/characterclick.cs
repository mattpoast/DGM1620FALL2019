using System;
using UnityEngine;

public class characterclick : MonoBehaviour
{
    public Vector3 turn;
    public GameObject button;
    private void OnMouseDown()
    {
        Vector3 rotateTowards;
        rotateTowards = Vector3.RotateTowards(current: button);
    }
}
