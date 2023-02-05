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
    [SerializeField] private PuzzleKey puzzleType;
    //Drag and drop a game here 
    [SerializeField] private GameObject puzzle;
    [SerializeField] private GameObject ui;

    protected override void Action(){
        var master = GameObject.Find("Master");
        puzzle.SetActive(true);
    }

    void Awake() {
        var master = GameObject.Find("Master");
        if(master.GetComponent<GlobalStateManager>().puzzlesCompleted[(int)puzzleType]){
            Destroy(this.gameObject);
        }
    }
}
