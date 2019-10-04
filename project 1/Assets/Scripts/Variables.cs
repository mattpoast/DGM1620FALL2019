using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Variables : MonoBehaviour
{
    public float floatValue =5f;
public int intValue = 20;
public string stringValue = "bob";
public int firePower;
public UnityEvent Event;

private void OnTriggerEnter(Collider other)
{
    Event.Invoke();

}

private void OnParticleTrigger()
{
    Event.Invoke();
}

}
