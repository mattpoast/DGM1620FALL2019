using UnityEngine;

public class Functions : MonoBehaviour
{
    public string playerName;
    public GameObject ghost;
    void Start()
    {
        Instantiate(ConfigGameObject());
    }

    private GameObject ConfigGameObject()
    {
        ghost.layer = 0;
        ghost.active = true;
        ghost.tag = "Ghost";
        ghost.transform.position = Vector3.zero;
        ghost.name = playerName;

        return ghost;
    }
    

    private string WelcomePlayer()
    {
        return playerName + "Welcome to the Game!";
    }

}
