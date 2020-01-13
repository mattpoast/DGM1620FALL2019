using System;
using UnityEngine;
using UnityEngine.UI;

public class ItemMenu : MonoBehaviour
{
 public GameObject dashBoard;
 public GameObject menuButton;
 public Animation itemMenuPop;
 private void Start()
 {
  dashBoard.gameObject.SetActive(false);
    menuButton.gameObject.SetActive(false);
 }

 public void OnMouseEnter()
 {
  dashBoard.gameObject.SetActive(true);

  GetComponent<Animation>();
 }

 public void OnMouseDown()
 {
  menuButton.gameObject.SetActive(true);
 }

 private void OnMouseExit()
 {
  dashBoard.gameObject.SetActive(false);
 }


}
