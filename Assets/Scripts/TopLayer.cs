using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopLayer : MonoBehaviour
{
    private Inventory inventory;
    private GameObject tapeRecorderBtn;
    private GameObject diaryEntriesBtn;

    private void Awake() {
        var master = GameObject.Find("Master");
        inventory = master.GetComponent<Inventory>();
        tapeRecorderBtn = transform.Find("TapesBtn").gameObject;
        diaryEntriesBtn = transform.Find("DiaryBtn").gameObject;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        tapeRecorderBtn.SetActive(false);
        diaryEntriesBtn.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // Hide Tape Recorder UI icon if player doesn't have it
        if (!tapeRecorderBtn.activeSelf && inventory.HasItem(Item.Recorder)) {
            tapeRecorderBtn.SetActive(true);
        }

        // Show Diary UI icon when first page is collected
        if (!diaryEntriesBtn.activeSelf && inventory.HasAnyDiaryEntry()) {
            diaryEntriesBtn.SetActive(true);
        }
    }
}
