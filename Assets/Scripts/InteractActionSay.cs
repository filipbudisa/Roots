using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractActionSay : InteractAction
{
    public string text;

    protected override void Action()
    {
        // TODO: Kreiraj monolog sistem
        // player.say(text)
        Debug.Log(text);
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
