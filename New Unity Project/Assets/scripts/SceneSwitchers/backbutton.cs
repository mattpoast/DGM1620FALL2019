using UnityEngine;
using UnityEngine.SceneManagement;

public class backbutton : MonoBehaviour
{
     void OnMouseDown()
     {
         SceneManager.LoadScene(3);
     }
}

