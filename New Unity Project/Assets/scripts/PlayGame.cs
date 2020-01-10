using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
  private void OnMouseDown()
  {
    SceneManager.LoadScene(0);
  }
}
