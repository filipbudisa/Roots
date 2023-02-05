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
            "Today, I went to the playground. And there she was, waiting for me. My baby girl, with a smile on her face. We played together, like we used to. I pushed her on the swings as we laughed together. It felt so real, so alive. I don't think I've felt this happy in a long time. (It was like a dream come true.) Others are saying she's not really there, but I can feel her. I know she's here with me.",
            "Entry #2",
            null
        )},
        { ExpoDiaryKey.Entry3, new MonologueItem(
            "I'm feeling better today. The doctors here have been very kind to me. I'm listening to them and taking my medicine regularly. I just don't want to feel so lost all the time. I even got to go outside and walk around the garden today. It was so nice to feel the sun on my face. I can't wait to go home and be with my family again. They've been visiting me every week and it's been such a joy to see them, despite me missing them dearly. Except for my baby girl, she is the only one that visits me every day. I just wish she would talk to me.",
            "Entry #3",
            null
        )},
        { ExpoDiaryKey.Entry4, new MonologueItem(
            "I'm back! I'm finally back home with my family. I missed them so much while I was away. It was hard, but I'm feeling so much better now. Željko looks relieved whenever he isn't drinking, so I guess that he is getting better as well. I just couldn't wait to play with my baby girl again. We're going to have so much fun together. I missed her so much, but now she's back and everything is perfect.",
            "Entry #4",
            null
        )},
        { ExpoDiaryKey.Entry5, new MonologueItem(
            "Roses are red\nHer favorite hue\nI hold her in my hand\nWithout her I'm blue\nThe fields of green\nThat I have seen\nHave a reflection of yellow\nI stroke her hair\nWhile she eats a marshmallow\n\nPS: I know red isn't her favorite color, but pink is hard to rhyme with.",
            "Entry #5",
            null
        )},
    };
}
