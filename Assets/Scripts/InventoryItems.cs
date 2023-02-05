using System.Collections.Generic;

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

public static class InventoryItems
{
    public static Dictionary<Item, ItemDesc> ItemDictionary = new Dictionary<Item, ItemDesc>(){
        { Item.Matches, new ItemDesc("Matches", "test.png") },
        { Item.Torch, new ItemDesc("Torch", "test.png") }
    };

}
