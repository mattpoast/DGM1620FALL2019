using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sitoncouch : MonoBehaviour
{
    public Vector3 position;

    private void OnTriggerEnter(Collider other)
    {
        position.x = +1;
    }
}
