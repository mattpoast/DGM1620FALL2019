using UnityEngine;
using UnityEngine.SceneManagement;

public class enterRoom : MonoBehaviour
{
    public GameObject door;

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(0);
    }
}

