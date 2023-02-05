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
    Monologue2,
    Sample,
    None
}

public static class MonologueSets
{
    public static Dictionary<MonologueKey, List<MonologueItem>> MonologueDic = new Dictionary<MonologueKey, List<MonologueItem>>() {
        { MonologueKey.Monologue1, new List<MonologueItem>() {
            new MonologueItem("Test speech 1 - Screen 1"),
            new MonologueItem("Test speech 1 - Screen 2")
        }},
        { MonologueKey.Monologue2, new List<MonologueItem>() {
            new MonologueItem("Test speech 2 - Screen 1"),
            new MonologueItem("Test speech 2 - Screen 2")
        }},
        { MonologueKey.Sample, new List<MonologueItem>() {
            new MonologueItem("It's no power."),
            new MonologueItem("Too bad...")
        }}
    };
}
