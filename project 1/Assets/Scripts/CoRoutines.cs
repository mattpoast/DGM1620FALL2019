using System.Collections;
using System.Diagnostics.Contracts;
using UnityEngine;
public class CoRoutines : MonoBehaviour
{
    public bool canRun = true;
    public int index = 3;
    public float seconds = 1f;
    private WaitForSeconds wfsObj;
    
    public void Run()
    {
  wfsObj = new WaitForSeconds(seconds);
        StartCoroutine(routine: OnRun());
    }

    IEnumerator OnRun()
    {
        while (canRun)

        {
          Debug.Log(index);
            index--;
            yield return wfsObj;
            

        }

    }
}

