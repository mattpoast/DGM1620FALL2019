using System;
using UnityEngine;

public class ChangeCursor : MonoBehaviour
{
    public Texture2D downClick;
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Cursor.SetCursor(downClick);
    }
}
