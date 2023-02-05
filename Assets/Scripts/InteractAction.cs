using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InteractAction : MonoBehaviour {

    public bool oneTime;
    private bool used = false;

    public void Interact(){
        bool oneTimeUse = oneTime || IsOneTimeUse();
        if (oneTimeUse && used) return;

        used = true;
        Action();
    }

    protected virtual bool IsOneTimeUse() {
        return false;
    }

    protected abstract void Action();
}