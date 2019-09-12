using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WooHoo : MonoBehaviour
{
    public ParticleSystem woop;

    private void OnMouseDown()
    {
        woop.Emit(50);
    }
}
