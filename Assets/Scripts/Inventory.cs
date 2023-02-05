using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private HashSet<Item> Items;
    public bool HasItem(Item item) {
        return Items.Contains(item);
    }
    public void AddItem(Item item) {
        Items.Add(item);
        UpdateInventoryUI();
    }
    public void RemoveItem(Item item) {
        Items.Remove(item);
        UpdateInventoryUI();
    }

    private HashSet<int> TapeIndexList;
    public bool HasTape(int index) {
        return TapeIndexList.Contains(index);
    }
    public void AddTape(int index) {
        TapeIndexList.Add(index);
        UpdateInventoryUI();
    }
    public void RemoveTape(int index) {
        TapeIndexList.Remove(index);
        UpdateInventoryUI();
    }

    private HashSet<int> DiaryIndexList;
    public bool HasDiary(int index) {
        return DiaryIndexList.Contains(index);
    }
    public void AddDiary(int index) {
        DiaryIndexList.Add(index);
        UpdateInventoryUI();
    }
    public void RemoveDiary(int index) {
        DiaryIndexList.Remove(index);
        UpdateInventoryUI();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void UpdateInventoryUI() {
        // TODO: create inventory UI
    }
}
