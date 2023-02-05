using System.Collections.Generic;

public struct MonologueItem {
    public MonologueItem(string text, string title = null, string picture = null) {
        this.text = text;
        this.title = title;
        this.picture = picture;
    }
    public string text { get; set; }
    public string title { get; set; }
    public string picture { get; set; }
}

public enum MonologueKey {
    None,
    Sample
}

public static class MonologueSets
{
    public static Dictionary<MonologueKey, List<MonologueItem>> MonologueDic = new Dictionary<MonologueKey, List<MonologueItem>>() {
        { MonologueKey.Sample, new List<MonologueItem>() {
            new MonologueItem("It's no power.", "Fuse box"),
            new MonologueItem("Too bad...")
        }},
    };
}
