using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractActionPickup : InteractAction
{
    public Item item;
    private Inventory inventory;

    protected override void Action()
    {
        inventory.AddItem(item);
    }

    protected override bool IsOneTimeUse() {
        return true;
    }

    void Awake() {
        var master = GameObject.Find("Master");
        inventory = master.GetComponent<Inventory>();

        if (inventory.HasItem(item))
        {
            Destroy(gameObject);
        }
    }
}
