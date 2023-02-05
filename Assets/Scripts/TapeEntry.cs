using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Image = UnityEngine.UI.Image;

public class TapeEntry : MonoBehaviour
{
    public ExpoTapeKey expoTapeKey;

    private GameObject uiExpoTape;
    private TextMeshProUGUI uiExpoTapeTitle;
    private TextMeshProUGUI uiExpoTapeDesc;
    private Image image;

    public void Click() {
        uiExpoTapeTitle.SetText(MonologueSets.ExpoTapeDic[expoTapeKey].title);
        uiExpoTapeDesc.SetText(MonologueSets.ExpoTapeDic[expoTapeKey].text);
    }

    private void Awake() {
        uiExpoTape = GameObject.Find("ExpoTape");
        uiExpoTapeTitle = uiExpoTape.transform.Find("TitleText").GetComponent<TextMeshProUGUI>();
        uiExpoTapeDesc = uiExpoTape.transform.Find("DescText").GetComponent<TextMeshProUGUI>();

        image = gameObject.transform.Find("Image").GetComponent<Image>();
        if (MonologueSets.ExpoTapeDic[expoTapeKey].picture != null) {
            var path = "Items/" + MonologueSets.ExpoTapeDic[expoTapeKey].picture;
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
