using System;
using UnityEngine;
using UnityEngine.Events;

public class enumSwitch : MonoBehaviour
{
   public enum States
   {
       Start,
       Playing,
       End
   }

   public States currentState;

   public UnityEvent OnStartEvent, OnPlayEvent, OnEndEvent;
   
    void Update()
    {
        switch (currentState)
        {
            case States.Start:
              OnStartEvent.Invoke();
                break;
            case States.Playing:
                OnPlayEvent.Invoke();
                break;
            case States.End:
                OnEndEvent.Invoke();
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}
