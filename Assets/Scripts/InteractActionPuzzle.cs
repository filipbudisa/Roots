using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum PuzzleKey{
    FuseBox,
    Jigsaw,
    ColorBox,
    Clock
}

public class InteractActionPuzzle : InteractAction
{
    PuzzleKey puzzleType;
    //Drag and drop a game here 
    [SerializeField] private GameObject puzzle;

    protected override void Action(){
        puzzle.SetActive(true);
    }

    void Awake() {
        var master = GameObject.Find("Master");
        if(master.GetComponent<GlobalStateManager>().puzzlesCompleted[(int)puzzleType]){
            Destroy(this.gameObject);
        }
    }
}
