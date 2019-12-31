using UnityEngine;

public class NewPause : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Time.timeScale = 0;
        }
    }
}
