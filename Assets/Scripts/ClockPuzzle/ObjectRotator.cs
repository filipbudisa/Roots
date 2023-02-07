using UnityEngine;
using System.Collections;
 
 public class ObjectRotator : MonoBehaviour 
 {
     
     private bool _isRotating;
     void Update()
     {
         if(_isRotating)
         {
            var cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
          
            Vector3 _direction = cursorPos - transform.position;
            _direction.z = 0;
            _direction.Normalize();
            transform.localRotation = Quaternion.FromToRotation(Vector3.up, _direction);
            


         }
     }
     
     void OnMouseDown()
     {
         // rotating flag
         _isRotating = true;
     }
     
     void OnMouseUp()
     {
         // rotating flag
         _isRotating = false;
     }
     
 }