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

public enum ExpoDiaryKey {
    Entry1,
    Entry2,
    Entry3,
    Entry4,
    Entry5
}


public static class MonologueSets
{
    public static Dictionary<MonologueKey, List<MonologueItem>> MonologueDic = new Dictionary<MonologueKey, List<MonologueItem>>() {
        { MonologueKey.Sample, new List<MonologueItem>() {
            new MonologueItem("It's no power.", "Fuse box"),
            new MonologueItem("Too bad...")
        }},
    };

    public static Dictionary<ExpoDiaryKey, MonologueItem> ExpoDiaryDic = new Dictionary<ExpoDiaryKey, MonologueItem>() {
        { ExpoDiaryKey.Entry1, new MonologueItem(
            "She's gone. My baby is gone. I can't stop thinking about that day, the water, the sound of her struggling. It's all my fault! Why did I have to leave her, even for a second? I should have been there. (The guilt is suffocating me.) I see her everywhere, a shadow, a whisper, a memory. I can't escape her or the pain. I just want to run away and never come back. I don't know what's happening to me. I feel like I'm falling apart.",
            "Entry #1",
            null
        )},
        { ExpoDiaryKey.Entry2, new MonologueItem(
            "She's gone. My baby is gone. I can't stop thinking about that day, the water, the sound of her struggling. It's all my fault! Why did I have to leave her, even for a second? I should have been there. (The guilt is suffocating me.) I see her everywhere, a shadow, a whisper, a memory. I can't escape her or the pain. I just want to run away and never come back. I don't know what's happening to me. I feel like I'm falling apart.",
            "Entry #2",
            null
        )},
        { ExpoDiaryKey.Entry3, new MonologueItem(
            "She's gone. My baby is gone. I can't stop thinking about that day, the water, the sound of her struggling. It's all my fault! Why did I have to leave her, even for a second? I should have been there. (The guilt is suffocating me.) I see her everywhere, a shadow, a whisper, a memory. I can't escape her or the pain. I just want to run away and never come back. I don't know what's happening to me. I feel like I'm falling apart.",
            "Entry #3",
            null
        )},
        { ExpoDiaryKey.Entry4, new MonologueItem(
            "She's gone. My baby is gone. I can't stop thinking about that day, the water, the sound of her struggling. It's all my fault! Why did I have to leave her, even for a second? I should have been there. (The guilt is suffocating me.) I see her everywhere, a shadow, a whisper, a memory. I can't escape her or the pain. I just want to run away and never come back. I don't know what's happening to me. I feel like I'm falling apart.",
            "Entry #4",
            null
        )},
        { ExpoDiaryKey.Entry5, new MonologueItem(
            "She's gone. My baby is gone. I can't stop thinking about that day, the water, the sound of her struggling. It's all my fault! Why did I have to leave her, even for a second? I should have been there. (The guilt is suffocating me.) I see her everywhere, a shadow, a whisper, a memory. I can't escape her or the pain. I just want to run away and never come back. I don't know what's happening to me. I feel like I'm falling apart.",
            "Entry #5",
            null
        )},
    };
}
