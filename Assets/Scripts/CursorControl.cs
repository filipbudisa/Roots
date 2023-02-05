using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorControl : MonoBehaviour
{
    private Texture2D pointerTexture;
    private Texture2D hoverTexture;

    private void Awake()
    {
        pointerTexture = Resources.Load<Texture2D>("Cursor_None");
        hoverTexture = Resources.Load<Texture2D>("Cursor_Hover");
        setHover(false);
    }

    public void setHover(bool hover)
    {
        if (hover)
        {
            Cursor.SetCursor(hoverTexture, Vector2.zero, CursorMode.Auto);
        }
        else
        {
            Cursor.SetCursor(pointerTexture, Vector2.zero, CursorMode.Auto);
        }
    }

}
