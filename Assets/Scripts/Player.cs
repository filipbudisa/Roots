using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Level level;
    private Animator anim;
    private SpriteRenderer renderer;

    private bool moving = false;
    private Vector2 origin = new Vector2(-1, -1);
    private Vector2 destination = new Vector2(-1, -1);
    private const float Speed = 0.6f;
    private const float MinDistance = 0.01f;

    private Interactable movingTo = null;

    private void Awake()
    {
        var levelObj = GameObject.Find("Background");
        level = levelObj.GetComponent<Level>();
        level.setPlayer(this);
        
        anim = GetComponent<Animator>();
        renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        var delta = Time.deltaTime;
        movement(delta);
    }

    void movement(float dt)
    {
        if (!moving) return;

        var direction = destination - (Vector2) transform.parent.position;
        var distance = direction.magnitude;
        direction.Normalize();
        
        if (distance < MinDistance)
        {
            stopMove();

            if (movingTo)
            {
                movingTo.Interact();
                movingTo = null;
            }
            
            return;
        }

        var move = direction * dt * Speed;
        bool arrived = distance < move.magnitude;
        if (arrived)
        {
            gameObject.transform.parent.position = destination;
            
            stopMove();
            
            if (movingTo)
            {
                movingTo.Interact();
                movingTo = null;
            }
        }
        else
        {
            gameObject.transform.parent.position = gameObject.transform.parent.position + (Vector3) move;   
        }
    }

    public void interact(Interactable obj)
    {
        var pos = level.closestMovable(obj.gameObject.transform.position);
        if (pos.x == -1) return;
        moveTo(pos);
        if (!moving)
        {
            if (movingTo)
            {
                movingTo.Interact();
            }

            movingTo = null;
        }
        else
        {
            movingTo = obj;   
        }
    }

    public void moveTo(Vector2 point)
    {
        if (!level.canMove(point)) return;
        movingTo = null;

        origin = gameObject.transform.parent.position;
        destination = point;
        var direction = destination - origin;

        renderer.flipX = direction.x < 0;

        if (direction.magnitude < MinDistance)
        {
            stopMove();
            return;
        }

        startMove();
    }

    private void startMove()
    {
        if (moving) return;
        moving = true;
        anim.SetBool("isWalking", true);
    }

    private void stopMove()
    {
        if (!moving) return;
        moving = false;
        anim.SetBool("isWalking", false);
    }

}
