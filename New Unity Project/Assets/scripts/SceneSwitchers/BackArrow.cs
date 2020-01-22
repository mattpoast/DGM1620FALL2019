using UnityEngine;
using UnityEngine.SceneManagement;
public class BackArrow : MonoBehaviour
{ 
    private void OnMouseDown()
    {
        SceneManager.LoadScene(0);
    }
}
