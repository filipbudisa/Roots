using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;

public class MonologueSystem : MonoBehaviour
{
    private GameObject ui;
    private Image image;
    private TextMeshProUGUI text;
    private TextMeshProUGUI title;

    private bool active = false;
    private int lineIndex = 0;
    private MonologueKey currentMonolog = MonologueKey.None;

    private void Awake()
    {
        ui = GameObject.Find("Monolog");
        image = ui.transform.Find("Image").GetComponent<Image>();
        text = ui.transform.Find("Text").GetComponent<TextMeshProUGUI>();
        title = ui.transform.Find("Title").GetComponent<TextMeshProUGUI>();
        Hide();
    }

    public void Click()
    {
        if (!active) return;
        var lines = MonologueSets.MonologueDic[currentMonolog];
        if (++lineIndex >= lines.Count)
        {
            active = false;
            Hide();
            return;
        }
        
        SayLine(lines[lineIndex]);
    }

    public void Speak(MonologueKey monologueKey) {
        Show();
        var lines = MonologueSets.MonologueDic[monologueKey];
        currentMonolog = monologueKey;
        lineIndex = 0;
        SayLine(lines[0]);
        active = true;
    }

    private void SayLine(MonologueItem item)
    {
        text.text = item.text;
        title.text = string.IsNullOrEmpty(item.title) ? "Petar" : item.title;

        var path = "Items/" + (string.IsNullOrEmpty(item.picture) ? "Petar" : item.picture);
        Texture2D tex = Resources.Load<Texture2D>(path);
        image.sprite = Sprite.Create(tex, new Rect(0, 0, 20, 20), new Vector2(0.5f, 0.5f));
    }

    private void Show()
    {
        ui.SetActive(true);
    }

    private void Hide()
    {
        ui.SetActive(false);
    }
}
