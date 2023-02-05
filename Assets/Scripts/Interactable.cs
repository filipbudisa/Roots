using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    private CursorControl cursor;
    public bool deleteAfterUse = false;
    private bool mouseInside = false;

    private void Awake()
    {
        var master = GameObject.Find("Master");
        cursor = master.GetComponent<CursorControl>();
    }

    void OnMouseEnter()
    {
        cursor.setHover(true);
        mouseInside = true;
    }

    void OnMouseExit()
    {
        cursor.setHover(false);
        mouseInside = false;
    }

    // When mouse is released over element
    void OnMouseUpAsButton()
    {
        var master = GameObject.Find("Master");
        if(master.GetComponent<GlobalStateManager>().uiOpen()) return;
        
        var player = GameObject.Find("Player");
        player.GetComponent<Player>().interact(this);
    }

    public void Interact()
    {
        var actions = GetComponents<InteractAction>();
        foreach (var action in actions)
        {
            action.Interact();
        }

        if (deleteAfterUse)
        {
            if (mouseInside)
            {
                cursor.setHover(false);
            }
            
            Destroy(gameObject);
        }
    }
}
