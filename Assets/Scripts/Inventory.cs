using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;

public class Inventory : MonoBehaviour
{
    private GameObject uiTopLayer;
    private GameObject uiExpoDiary;
    private TextMeshProUGUI uiExpoDiaryTitle;
    private TextMeshProUGUI uiExpoDiaryDesc;
    private GameObject uiExpoTapes;
    private TextMeshProUGUI uiExpoTapesTitle;
    private TextMeshProUGUI uiExpoTapesDesc;

    private CursorControl cursor;
    private List<Item> Items = new List<Item>();
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

    private List<ExpoTapeKey> TapesKeyList = new List<ExpoTapeKey>();
    public bool HasTape(ExpoTapeKey tapeKey) {
        return TapesKeyList.Contains(tapeKey);
    }
    public void AddTape(ExpoTapeKey tapeKey) {
        TapesKeyList.Add(tapeKey);
        UpdateInventoryUI();
    }
    public void RemoveTape(ExpoTapeKey tapeKey) {
        TapesKeyList.Remove(tapeKey);
        UpdateInventoryUI();
    }

    private List<ExpoDiaryKey> DiaryEntryList = new List<ExpoDiaryKey>();
    public bool HasDiary(ExpoDiaryKey entryKey) {
        return DiaryEntryList.Contains(entryKey);
    }
    public void AddDiary(ExpoDiaryKey entryKey) {
        DiaryEntryList.Add(entryKey);
        UpdateInventoryUI();
    }
    public void RemoveDiary(ExpoDiaryKey entryKey) {
        DiaryEntryList.Remove(entryKey);
        UpdateInventoryUI();
    }
    public bool HasAnyDiaryEntry() {
        return DiaryEntryList.Count > 0;
    }

    private void Awake() {
        var master = GameObject.Find("Master");
        cursor = master.GetComponent<CursorControl>();

        uiTopLayer = GameObject.Find("TopLayer");
        uiExpoDiary = GameObject.Find("ExpoDiary");
        uiExpoDiaryTitle = uiExpoDiary.transform.Find("TitleText").GetComponent<TextMeshProUGUI>();
        uiExpoDiaryDesc = uiExpoDiary.transform.Find("DescText").GetComponent<TextMeshProUGUI>();
        HideExpoDiary();
        uiExpoTapes = GameObject.Find("ExpoTapes");
        uiExpoTapesTitle = uiExpoTapes.transform.Find("TitleText").GetComponent<TextMeshProUGUI>();
        uiExpoTapesDesc = uiExpoTapes.transform.Find("DescText").GetComponent<TextMeshProUGUI>();
        HideExpoTapes();
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
    public void UiTapesBtnClick() {
        if(uiTopLayer.activeSelf == true) {
            HideTopLayer();
            ShowExpoTapes();
        }
    }

    private void HideTopLayer() {
        uiTopLayer.SetActive(false);
    }
    private void ShowTopLayer() {
        uiTopLayer.SetActive(true);
    }
    private void HideExpoDiary() {
        uiExpoDiaryDesc.SetText("");
        uiExpoDiaryTitle.SetText("");
        uiExpoDiary.SetActive(false);
    }
    private void ShowExpoDiary() {
        DiaryEntry[] diaryEntries = uiExpoDiary.transform.GetComponentsInChildren<DiaryEntry>();
        foreach (var diaryEntry in diaryEntries)
        {
            diaryEntry.gameObject.SetActive(HasDiary(diaryEntry.expoDiaryKey));
        }
        uiExpoDiary.SetActive(true);
    }
    private void HideExpoTapes() {
        uiExpoTapesDesc.SetText("");
        uiExpoTapesTitle.SetText("");
        uiExpoTapes.SetActive(false);
    }
    private void ShowExpoTapes() {
        TapeEntry[] TapesEntries = uiExpoTapes.transform.GetComponentsInChildren<TapeEntry>();
        foreach (var TapesEntry in TapesEntries)
        {
            TapesEntry.gameObject.SetActive(HasTape(TapesEntry.expoTapeKey));
        }
        uiExpoTapes.SetActive(true);
    }

    public void HideAllWindows() {
        HideExpoDiary();
        HideExpoTapes();
        ShowTopLayer();
        // TODO
        //HideInventory();
    }
}
