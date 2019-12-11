using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public GameObject Heart, Heart1, Heart2, GameOver;
    public static int health;

    private void Start()
    {
        health = 3;
        GameOver.gameObject.SetActive(false);
    }

    void Update()
    {
        if (health > 3)
            health = 3;

        switch (health)
        {
           case 3:
               Heart.gameObject.SetActive(true);
               Heart1.gameObject.SetActive(true);
               Heart2.gameObject.SetActive(true);
               break;
           case 2: 
                Heart.gameObject.SetActive(true);
                Heart1.gameObject.SetActive(true);
                Heart2.gameObject.SetActive(false);
                break;
            case 1 :
                Heart.gameObject.SetActive(true);
                Heart1.gameObject.SetActive(false);
                Heart2.gameObject.SetActive(false);
                break;
            case 0:
                Heart.gameObject.SetActive(false);
                Heart1.gameObject.SetActive(false);
                Heart2.gameObject.SetActive(false);
                GameOver.gameObject.SetActive(true);
            Time.timeScale = 0;
                break;
        }

       
    }
}
