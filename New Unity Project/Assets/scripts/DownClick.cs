using UnityEngine;

public class DownClick : MonoBehaviour
{
    public Texture2D clicking;
    public Vector2 hotSpot = Vector2.zero;
    public CursorMode curMode = CursorMode.Auto;

    void Update()
    {
        if (Input.GetMouseButtonDown(0));
        {
           Cursor.SetCursor(clicking, hotSpot, curMode);
        }
        
    }
}
