using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class Level : MonoBehaviour
{
    public Texture2D movable;
    private Player player = null;

    public void setPlayer(Player player)
    {
        this.player = player;
    }
    
    private void OnMouseUpAsButton()
    {
        // TODO: find player and call moveTo
    }

    public bool canMove(Vector2 point)
    {
        return movable.GetPixelBilinear(point.x, point.y).b == 1;
    }

    public Vector2 closestMovable(Vector2 point)
    {
        float step = 1.0f / 160.0f;

        for (; point.y >= 0; point.y -= step)
        {
            if (canMove(point))
            {
                return point;
            }
        }
        
        return new Vector2(-1, -1);
    }
}
