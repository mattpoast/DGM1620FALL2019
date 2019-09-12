using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MouseEvents : MonoBehaviour
{
   public ParticleSystem mouseDown;

   private void OnMouseDown()
   {
      mouseDown.Emit(100);
   }
}
