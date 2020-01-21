using UnityEngine;
public class MenuButton : MonoBehaviour
{
    public GameObject menuButton;
    private void OnMouseDown()
  {
      menuButton.SetActive(true);
    }
  }

