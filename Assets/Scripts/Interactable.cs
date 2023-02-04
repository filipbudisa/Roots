using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    // Change cursor on hover
    private Texture2D pointerTexture;
    private Texture2D hoverTexture;
    private CursorMode cursorMode = CursorMode.Auto;
    private Vector2 hotSpot = Vector2.zero;
    void OnMouseEnter()
    {
        Debug.Log("OnMouseEnter");
        Cursor.SetCursor(hoverTexture, Vector2.zero, cursorMode);
    }

    void OnMouseExit()
    {
        Debug.Log("OnMouseExit");
        Cursor.SetCursor(pointerTexture, Vector2.zero, cursorMode);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        pointerTexture = Resources.Load<Texture2D>("cursor-pointer");
        hoverTexture = Resources.Load<Texture2D>("cursor-hover");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // When mouse hovers over element
    void OnMouseOver() {
        //Debug.Log("OnMouseOver");
    }

    // When mouse is released over element
    void OnMouseUpAsButton() {
        Debug.Log("OnMouseUpAsButton");

        // TODO: Do this
        //var player = GameObject.Find("Player");
        //playerPrefab.interact(this);
    }
}
