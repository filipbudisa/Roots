using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    // Change cursor on hover
    public Texture2D pointerTexture;
    public Texture2D hoverTexture;
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
    void OnMouseUp() {
        Debug.Log("OnMouseUp");

        // TODO: Do this
        //var playerPrefab = Instantiate(Resources.Load("Player"));
        //playerPrefab.interact(this);
    }
}
