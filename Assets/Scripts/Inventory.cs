using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private List<Item> Items;
    public bool HasItem(Item item) {
        return Items.Contains(item);
    }
    public void AddItem(Item item) {
        Items.Add(item);
    }
    public void RemoveItem(Item item) {
        Items.Remove(item);
    }

    private List<int> TapeIndexList;
    public bool HasTape(int index) {
        return TapeIndexList.Contains(index);
    }
    public void AddTape(int index) {
        TapeIndexList.Add(index);
    }
    public void RemoveTape(int index) {
        TapeIndexList.Remove(index);
    }

    private List<int> DiaryIndexList;
    public bool HasDiary(int index) {
        return DiaryIndexList.Contains(index);
    }
    public void AddDiary(int index) {
        DiaryIndexList.Add(index);
    }
    public void RemoveDiary(int index) {
        DiaryIndexList.Remove(index);
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
