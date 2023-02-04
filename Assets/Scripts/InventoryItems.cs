using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItems : MonoBehaviour
{

    public struct ItemDesc {
        public ItemDesc(string title, string picture) {
            this.title = title;
            this.picture = picture;
        }
        public string title { get; set; }
        public string picture { get; set; }
    }

    public enum Item {
        Matches,
        Torch
    }

    public Dictionary<Item, ItemDesc> ItemDictionary = new Dictionary<Item, ItemDesc>(){
        { Item.Matches, new ItemDesc("Matches", "test.png") },
        { Item.Torch, new ItemDesc("Torch", "test.png") }
    };

    private void Start() {
        var testTitle = ItemDictionary[Item.Torch].title;
    }

}
