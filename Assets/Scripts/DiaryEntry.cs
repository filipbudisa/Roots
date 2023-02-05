using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Image = UnityEngine.UI.Image;

public class DiaryEntry : MonoBehaviour
{
    public ExpoDiaryKey expoDiaryKey;

    private GameObject uiExpoDiary;
    private TextMeshProUGUI uiExpoDiaryTitle;
    private TextMeshProUGUI uiExpoDiaryDesc;
    private Image image;

    public void Click() {
        uiExpoDiaryTitle.SetText(MonologueSets.ExpoDiaryDic[expoDiaryKey].title);
        uiExpoDiaryDesc.SetText(MonologueSets.ExpoDiaryDic[expoDiaryKey].text);
    }

    private void Awake() {
        uiExpoDiary = GameObject.Find("ExpoDiary");
        uiExpoDiaryTitle = uiExpoDiary.transform.Find("TitleText").GetComponent<TextMeshProUGUI>();
        uiExpoDiaryDesc = uiExpoDiary.transform.Find("DescText").GetComponent<TextMeshProUGUI>();

        image = gameObject.transform.Find("Image").GetComponent<Image>();
        if (MonologueSets.ExpoDiaryDic[expoDiaryKey].picture != null) {
            var path = "Items/" + MonologueSets.ExpoDiaryDic[expoDiaryKey].picture;
            Texture2D tex = Resources.Load<Texture2D>(path);
            image.sprite = Sprite.Create(tex, new Rect(0, 0, 20, 20), new Vector2(0.5f, 0.5f));
        }
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
