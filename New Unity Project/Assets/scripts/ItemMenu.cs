using System;
using UnityEngine;
using UnityEngine.UI;

public class ItemMenu : MonoBehaviour
{
 public float seconds = 3f;
 private WaitForSeconds wfsObj;
 public GameObject dashBoard;
 private void Start()
 {
  dashBoard.gameObject.SetActive(false);
 }

 public void OnMouseEnter()
 {
  dashBoard.gameObject.SetActive(true);
  wfsObj = new WaitForSeconds(seconds);
 }

 private void OnMouseExit()
 {
  dashBoard.gameObject.SetActive(false);
 }
}
