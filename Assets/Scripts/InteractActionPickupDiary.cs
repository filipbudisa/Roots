using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractActionPickupDiary : InteractAction
{
    public int index;
    private Inventory inventory;
    
    protected override void Action()
    {
        inventory.AddDiary(index);
    }

    protected override bool IsOneTimeUse() {
        return true;
    }

    void Awake() {
        var master = GameObject.Find("Master");
        inventory = master.GetComponent<Inventory>();
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
