using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorBox : MonoBehaviour
{
    [SerializeField] private ColorChanger lock1;
    [SerializeField] private ColorChanger lock2;
    [SerializeField] private ColorChanger lock3;
    [SerializeField] private ColorChanger lock4;

    private void Update() {
        if( lock1.index == 2 &&
            lock2.index == 3 &&
            lock3.index == 1 &&
            lock4.index == 4){
                Debug.Log("YAY");
            }   
    }
}
