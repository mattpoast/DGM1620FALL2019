using UnityEngine;
using UnityEngine.UI;

public class startScreen : MonoBehaviour
{

    public GameObject screen;
    void Start()
    {
        screen.gameObject.SetActive(true);
    }

    public void OnMouseDown()
    {
        screen.gameObject.SetActive(false);
    }
}
