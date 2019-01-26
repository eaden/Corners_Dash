using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor_Mouse : MonoBehaviour {

    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = new Vector2(0.5f,0.5f);

    private void Start()
    {
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }
}
