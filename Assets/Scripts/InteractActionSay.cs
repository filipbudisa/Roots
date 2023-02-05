using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractActionSay : InteractAction
{
    public MonologueKey monologueKey;
    private MonologueSystem monologueSystem;

    protected override void Action()
    {
        monologueSystem.Say(monologueKey);
    }

    private void Awake() {
        var master = GameObject.Find("Master");
        monologueSystem = master.GetComponent<MonologueSystem>();
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
