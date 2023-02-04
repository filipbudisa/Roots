using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractActionPickupTape : InteractAction
{
    public int index;
    
    protected override void Action()
    {
        // TODO: add tape to player inventory
        // player.Inventory.AddTape(index)
        throw new System.NotImplementedException();
    }

    protected override bool IsOneTimeUse() {
        return true;
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
