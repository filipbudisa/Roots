using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractActionPickupDiary : InteractAction
{
    public ExpoDiaryKey entryKey;
    private Inventory inventory;
    
    protected override void Action()
    {
        inventory.AddDiary(entryKey);
    }

    protected override bool IsOneTimeUse() {
        return true;
    }

    void Awake() {
        var master = GameObject.Find("Master");
        inventory = master.GetComponent<Inventory>();
        
        if (inventory.HasDiary(entryKey))
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
