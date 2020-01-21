using UnityEngine;
public class FollowMouse : MonoBehaviour
{
    public Texture2D xRay;
    private CursorMode curMode = CursorMode.Auto;
    private Vector2 hotSpot = Vector2.zero;
    private void OnMouseEnter()
    {
        Cursor.SetCursor(xRay, hotSpot, curMode);
    }
}
