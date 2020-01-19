using System;
using UnityEditor.Experimental.UIElements.GraphView;
using UnityEngine;

public class DownClick : MonoBehaviour
{
    public Texture2D clicking;
    public Texture2D defaultMouse;
    public Vector2 hotSpot = Vector2.zero;
    public CursorMode curMode = CursorMode.Auto;

    private void Start()
    {
        Cursor.SetCursor(defaultMouse, hotSpot, curMode);
    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Cursor.SetCursor(clicking, hotSpot, curMode);
        }
        else
        {
            Cursor.SetCursor(defaultMouse, hotSpot, curMode);
        }
    }
}

