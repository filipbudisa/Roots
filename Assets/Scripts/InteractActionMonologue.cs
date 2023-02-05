using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractActionMonologue : InteractAction
{
    public MonologueKey monologueKey;
    private MonologueSystem monologueSystem;

    protected override void Action()
    {
        monologueSystem.Speak(monologueKey);
    }

    private void Awake() {
        var master = GameObject.Find("Master");
        monologueSystem = master.GetComponent<MonologueSystem>();
    }
}
