using System;
using UnityEngine;
using UnityEngine.UI;

public class ItemMenu : MonoBehaviour
{
 public Vector2 dbPosition;
 public GameObject dashBoard;

 private void Start()
 {
  dashBoard.gameObject.SetActive(false);
 }

 public void OnMouseEnter()
 {
  dashBoard.gameObject.SetActive(true);
  dashBoard.transform.Translate(dbPosition);
  
 }

 private void OnMouseExit()
 {
  dashBoard.gameObject.SetActive(false);
 }
}
