using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private GameObject uiTopLayer;
    private GameObject uiExpoDiary;

    private CursorControl cursor;
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

    private void Awake() {
        var master = GameObject.Find("Master");
        cursor = master.GetComponent<CursorControl>();

        uiTopLayer = GameObject.Find("TopLayer");
        uiExpoDiary = GameObject.Find("ExpoDiary");
        HideExpoDiary();
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

    public void UiCursorHoverEnter() {
        cursor.setHover(true);
    }
    public void UiCursorHoverExit() {
        cursor.setHover(false);
    }

    public void UiDiaryBtnClick() {
        if(uiTopLayer.activeSelf == true) {
            HideTopLayer();
            ShowExpoDiary();
        }
    }

    private void HideTopLayer() {
        uiTopLayer.SetActive(false);
    }
    private void ShowTopLayer() {
        uiTopLayer.SetActive(true);
    }
    private void HideExpoDiary() {
        uiExpoDiary.SetActive(false);
    }
    private void ShowExpoDiary() {
        uiExpoDiary.SetActive(true);
    }
}
