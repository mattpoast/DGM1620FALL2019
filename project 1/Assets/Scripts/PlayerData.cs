using System;
using UnityEngine;
public class PlayerData : MonoBehaviour
{
    public GameObject player;
    void Start()
    {
        Instantiate(ConfigGameObject());
    }

    private GameObject ConfigGameObject()

    {
        player.layer = 0;
        player.active = true;
        player.transform.position = Vector3.zero;
        
        
        return player;
    }
    





}


