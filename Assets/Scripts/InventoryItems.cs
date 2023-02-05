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
    Newspaper,
    PhotoFragment1,
    PhotoFragment2,
    PhotoFragment3,
    Recorder,
    DischargeLetter,
    Coin,
    Key
}

public static class InventoryItems
{
    public static Dictionary<Item, ItemDesc> ItemDictionary = new Dictionary<Item, ItemDesc>(){
        { Item.Matches, new ItemDesc("Matches", "test.png") },
        { Item.Newspaper, new ItemDesc("Newspapers", "Novine") },
        { Item.PhotoFragment1, new ItemDesc("Photo fragment", "PhotoFragment") },
        { Item.PhotoFragment2, new ItemDesc("Photo fragment", "PhotoFragment") },
        { Item.PhotoFragment3, new ItemDesc("Photo fragment", "PhotoFragment") },
        { Item.Recorder, new ItemDesc("Recorder", "Recorder") },
        { Item.DischargeLetter, new ItemDesc("Discharge letter", "Discharge") },
        { Item.Coin, new ItemDesc("Sobriety coin", "Coin") },
        { Item.Key, new ItemDesc("Key", "Key") }
    };

}
