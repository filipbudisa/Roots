using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    private CursorControl cursor;

    private void Awake()
    {
        var master = GameObject.Find("Master");
        cursor = master.GetComponent<CursorControl>();
    }

    void OnMouseEnter()
    {
        cursor.setHover(true);
    }

    void OnMouseExit()
    {
        cursor.setHover(false);
    }

    // When mouse is released over element
    void OnMouseUpAsButton() {
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
    }
}
