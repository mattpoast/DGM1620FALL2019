using System;
using UnityEngine;

public class HealthPack : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        HealthSystem.health += 1;
    }
}
