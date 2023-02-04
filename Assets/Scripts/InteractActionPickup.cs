using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Item {
    testItem,
    testItem2
}

public class InteractActionPickup : InteractAction
{
    // TODO: create real Item enum
    public Item Item;
    
    protected override void Action()
    {
        // TODO: add item to inventory
        // player.Inventory.AddItem()
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
