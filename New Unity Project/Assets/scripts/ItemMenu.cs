using System;
using UnityEngine;
using UnityEngine.UI;

public class ItemMenu : MonoBehaviour
{
 public Vector2 dbPosition;
 public Image dashBoard;
 public void OnMouseEnter()
 {
  dashBoard.transform.position = dbPosition;
 }
}
