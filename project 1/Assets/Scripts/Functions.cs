using UnityEngine;

public class Functions : MonoBehaviour
{
    public string playerName;
    public GameObject player;
    void Start()
    {
        Instantiate(ConfigGameObject());
    }

    private GameObject ConfigGameObject()
    {
        player.layer = 0;
        player.active = true;
        player.tag = "player";
        player.transform.position = Vector3.zero;
        player.name = playerName;

        return player;
    }
    

    private string WelcomePlayer()
    {
        return playerName + "Welcome to the Game!";
    }

}
