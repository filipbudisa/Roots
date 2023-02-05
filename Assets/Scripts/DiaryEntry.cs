using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DiaryEntry : MonoBehaviour
{
    public ExpoDiaryKey expoDiaryKey;

    private GameObject uiExpoDiary;
    private TextMeshProUGUI uiExpoDiaryTitle;
    private TextMeshProUGUI uiExpoDiaryDesc;

    public void Click() {
        uiExpoDiaryTitle.SetText(MonologueSets.ExpoDiaryDic[expoDiaryKey].title);
        uiExpoDiaryDesc.SetText(MonologueSets.ExpoDiaryDic[expoDiaryKey].text);
    }

    private void Awake() {
        uiExpoDiary = GameObject.Find("ExpoDiary");
        uiExpoDiaryTitle = uiExpoDiary.transform.Find("TitleText").GetComponent<TextMeshProUGUI>();
        uiExpoDiaryDesc = uiExpoDiary.transform.Find("DescText").GetComponent<TextMeshProUGUI>();
    }

    public void Show() {
        gameObject.SetActive(true);
    }

    public void Hide() {
        gameObject.SetActive(true);
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
