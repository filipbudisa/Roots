using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireCounter : MonoBehaviour
{
    private int maxWires = 5;
    private int wiresConnected = 0;
    
    public void IncrementWire(){
        wiresConnected++;
        if(wiresConnected == maxWires){
            Done();
        }
    }

    private void Done(){
        Debug.Log("connected");
        var master = GameObject.Find("Master");
        master.GetComponent<GlobalStateManager>().puzzlesCompleted[(int)PuzzleKey.FuseBox] = true;
        Destroy(this.gameObject);
    }
}
