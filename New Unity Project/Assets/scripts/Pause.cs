using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject pauseScreen;
    private bool pause = false;

    private void Start()
    {
        pauseScreen.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            pauseScreen.gameObject.SetActive(true);
            if (pause)
            {
                Time.timeScale = 1;
            }
            else
            {
                pauseScreen.gameObject.SetActive(false);
                Time.timeScale = 0;
                pause = !pause;
            }
        }
    }
}

