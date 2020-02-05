using System.Text;
using UnityEngine;

public class Pause2 : MonoBehaviour
{
    public bool screen;
    public GameObject pauser;
   private void Start()
    {
        pauser.gameObject.SetActive(false);
    }
    void Update()
    {
        Input.GetKeyDown(KeyCode.Space);
        {
            pauser.gameObject.SetActive(true);
        }
    }
}