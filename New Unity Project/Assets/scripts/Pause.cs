using UnityEngine;

public class Pause : MonoBehaviour
{
    private bool pause = false;

    public void pauseGame()
    {
        if (pause)
        {
            Time.timeScale = 1;
            pause = false;
        }
        else
        {
            Time.timeScale = 0;
        }
    }
}

