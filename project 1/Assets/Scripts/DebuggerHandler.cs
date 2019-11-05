using UnityEngine;

public class DebuggerHandler : MonoBehaviour
{
    public DeBugger debuggerObj;

    public void SwitchDebugger(DeBugger newDeBuggerObj)
    {
        debuggerObj = newDeBuggerObj;
    }
}
