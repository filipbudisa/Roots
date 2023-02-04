using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wire : MonoBehaviour
{
    [SerializeField] private SpriteRenderer wireEnd;
    [SerializeField] private GameObject lightOn;
    [SerializeField] private GameObject wireIn;
    [SerializeField] private WireCounter wireCounter;
    private Vector3 startPoint;
    private Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        startPoint = transform.parent.position;
        startPosition = transform.position;
    }

    private void OnMouseDrag(){
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        newPosition.z = 0;

        Collider2D[] colliders = Physics2D.OverlapCircleAll(newPosition, 0.2f);
        foreach(Collider2D collider in colliders){
            if(collider.gameObject != gameObject){
                UpdateWire(collider.transform.position);
                
                if(transform.parent.name.Equals(collider.transform.parent.name)){
                    collider.GetComponent<Wire>()?.Done();
                    Done();
                    wireCounter.IncrementWire();
                }
                
                return;
            }
        }

        UpdateWire(newPosition);
    }

    private void OnMouseUp(){
        UpdateWire(startPosition);

    }

    private void UpdateWire(Vector3 newPosition){
        transform.position = newPosition;

        Vector3 direction = newPosition - startPoint;
        transform.right = direction * transform.lossyScale.x;

        float dist = Vector2.Distance(startPoint, newPosition);
        wireEnd.size = new Vector2(dist, wireEnd.size.y);
 
    }

    private void Done(){
        lightOn.SetActive(true);
        wireIn.SetActive(false);
        Destroy(this);
    }

}
