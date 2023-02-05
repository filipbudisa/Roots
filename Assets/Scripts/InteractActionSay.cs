using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractActionSay : InteractAction
{
    public string text = "";
    public string title;
    public string picture;
    
    private MonologueSystem monologueSystem;

    protected override void Action()
    {
        monologueSystem.Say(new MonologueItem(text, title, picture));
    }

    private void Awake() {
        var master = GameObject.Find("Master");
        monologueSystem = master.GetComponent<MonologueSystem>();
    }
}
