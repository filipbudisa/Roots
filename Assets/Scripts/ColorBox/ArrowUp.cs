using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowUp : MonoBehaviour
{
    [SerializeField] private ColorChanger ColorChanger;
    
    void OnMouseDown(){
        ColorChanger.changeColorUp();
    }
}
