using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowDown : MonoBehaviour
{
    [SerializeField] private ColorChanger ColorChanger;
    
    void OnMouseDown(){
        ColorChanger.changeColorDown();
    }
}
