using System;
using UnityEngine;

public class characterclick : MonoBehaviour
{
    public Vector3 turn;
    public GameObject button;
    private void OnMouseDown()
    {
        transform.position = Vector3.left;
    }
}
