using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InteractAction : MonoBehaviour {

    protected abstract bool oneTime { get; set; }
    private bool used = false;

    public void Interact(){
        if (oneTime && !used){
            used = true;
            Action();
        }
        else if (!used) Action();
    }

    protected abstract void Action();
}