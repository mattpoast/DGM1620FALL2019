﻿using System;
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

// Start is called before the first frame update
    void Start()
    {
        print("Hello World");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
