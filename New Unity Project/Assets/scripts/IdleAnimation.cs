using System;
using UnityEngine;

public class IdleAnimation : MonoBehaviour
{
    private float waiting;
    public GameObject idleObject;


    private void Start()
    {
        idleObject.gameObject.SetActive(false);
    }

    void Update()
    {
        if (waiting >= 7f)
        {
            idleObject.gameObject.SetActive(true);
        }
        else 
        {
            idleObject.gameObject.SetActive(false);
        }

    }
}
