using UnityEngine;

public class Pause2 : MonoBehaviour
{
    public bool screen;

    void Start()
    {
        screen = false;
    }

    void Update()
    {
        Input.GetKeyDown(KeyCode.Space);
        {
            screen = true;
        }
    }
}