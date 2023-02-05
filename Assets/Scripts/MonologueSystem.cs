using System.Collections.Generic;

public struct MonologueItem {
    public MonologueItem(string text, string picture = "test.png") {
        this.text = text;
        this.picture = picture;
    }
    public string text { get; set; }
    public string picture { get; set; }
}

public enum Monologue {
    Monologue1,
    Monologue2
}

public static class MonologueSystem
{
    public static Dictionary<Monologue, HashSet<MonologueItem>> MonologueDic = new Dictionary<Monologue, HashSet<MonologueItem>>() {
        { Monologue.Monologue1, new HashSet<MonologueItem>() {
            new MonologueItem("Test speech 1 - Screen 1"),
            new MonologueItem("Test speech 1 - Screen 2")
        }},
        { Monologue.Monologue2, new HashSet<MonologueItem>() {
            new MonologueItem("Test speech 2 - Screen 1"),
            new MonologueItem("Test speech 2 - Screen 2")
        }}
    };
}
