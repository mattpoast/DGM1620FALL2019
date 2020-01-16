using System;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class CursorOver : MonoBehaviour
{
 public Texture2D defaultMouse;
 public Texture2D objectMouse;
 public Texture2D downClick;
 public Vector2 hotSpot = Vector2.zero;
 public CursorMode curMode = CursorMode.Auto;

 private void Start()
 {
  Cursor.SetCursor(defaultMouse, hotSpot, curMode);
 }

 private void OnMouseEnter()
 {
  if (gameObject.tag == "objectCursor")
  {
   Cursor.SetCursor(objectMouse, hotSpot, curMode);
  }
 }

 private void OnMouseExit()
 {
  Cursor.SetCursor(defaultMouse, hotSpot, curMode);
 }

 public void OnMouseDown()
 {
  if (Input.GetMouseButtonDown(0)) ;
  {
   Cursor.SetCursor(downClick, hotSpot, curMode);
  }
 }
}


