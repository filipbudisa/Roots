using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalStateManager : MonoBehaviour
{
    public static GlobalStateManager globalStateManager;
    // Start is called before the first frame update
    void Start()
    {
        if(globalStateManager != null && globalStateManager != this){
            Destroy(this.gameObject);
        }else{
            globalStateManager = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    public bool uiOpen(){
        var monolog = GameObject.Find("Monolog");
        return puzzleOpen || (monolog && monolog.activeInHierarchy);

    }

    public bool puzzleOpen { get; set; } = false;

    public bool[] puzzlesCompleted = {false, false, false, false};

}
