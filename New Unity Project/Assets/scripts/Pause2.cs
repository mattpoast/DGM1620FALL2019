using System.Text;
using UnityEngine;

public class Pause2 : MonoBehaviour
{
    public bool screen;
    public GameObject pauser;
    void Start()
    {
        pauser.gameObject.SetActive(false);
    }

    void Update()
    {
        Input.GetKeyDown(KeyCode.Space);
        {
            screen = true;
        }
        if (screen = true)
        {
            pauser.gameObject.SetActive(true);
        }
    }
}