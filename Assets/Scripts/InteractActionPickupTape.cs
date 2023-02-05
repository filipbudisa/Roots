using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractActionPickupTape : InteractAction
{
    public ExpoTapeKey tapeKey;
    private Inventory inventory;
    
    protected override void Action()
    {
        inventory.AddTape(tapeKey);
    }

    protected override bool IsOneTimeUse() {
        return true;
    }

    void Awake() {
        var master = GameObject.Find("Master");
        inventory = master.GetComponent<Inventory>();
        
        if (inventory.HasTape(tapeKey))
        {
            Destroy(gameObject);
        }
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
