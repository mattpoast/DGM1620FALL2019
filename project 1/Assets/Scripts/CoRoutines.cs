using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;
using UnityEngine.XR.WSA.Input;

public class CoRoutines : MonoBehaviour
{
    private int i = 3;
    IEnumerator Start()
    {
        while (i > 0)
        {
            yield return new WaitForSeconds(1f);
            Debug.Log(i);
            i--;
        } 
        yield return new WaitForSeconds(1f);
        Debug.Log("GO!");
}
}
