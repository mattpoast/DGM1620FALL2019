﻿using UnityEngine;

public class MouseEvents : MonoBehaviour
{

   private Camera cam;
   public Vector3Data data;
   
   
   private void start()
   {
      cam = Camera.main;
      
   }
   
   private void OnMouseDown()
   {
       
       var ray = cam.ScreenPointToRay(Input.mousePosition);

       if (Physics.Raycast(ray, out var hit))
       {
           data.value = hit.point;
       }
       
       Debug.Log(hit);
   }
}
