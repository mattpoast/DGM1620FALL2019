using System;
using UnityEditor.Experimental.UIElements;
using UnityEngine;
    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(Collider))]
public class ApplyForce : MonoBehaviour
{
    private Rigidbody rb;
    public Vector3Data forceDirection;
    public float force = 1f;

    void Start()
    {

        rb = GetComponent<Rigidbody>();
        
    }
}
    

