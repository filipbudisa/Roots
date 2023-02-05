using System.Collections.Generic;

public struct MonologueItem {
    public MonologueItem(string text, string picture = null) {
        this.text = text;
        this.picture = picture;
    }
    public string text { get; set; }
    public string picture { get; set; }
}

public enum MonologueKey {
    Monologue1,
    Monologue2
}

public static class MonologueSets
{
    public static Dictionary<MonologueKey, HashSet<MonologueItem>> MonologueDic = new Dictionary<MonologueKey, HashSet<MonologueItem>>() {
        { MonologueKey.Monologue1, new HashSet<MonologueItem>() {
            new MonologueItem("Test speech 1 - Screen 1"),
            new MonologueItem("Test speech 1 - Screen 2")
        }},
        { MonologueKey.Monologue2, new HashSet<MonologueItem>() {
            new MonologueItem("Test speech 2 - Screen 1"),
            new MonologueItem("Test speech 2 - Screen 2")
        }}
    };
}
