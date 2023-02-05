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
    Sample,
    FoundPhoto
}

public enum ExpoDiaryKey {
    Entry1,
    Entry2,
    Entry3,
    Entry4,
    Entry5
}

public enum ExpoTapeKey {
    Tape1,
    Tape2,
    Tape3,
    Tape4,
    Tape5
}


public static class MonologueSets
{
    public static Dictionary<MonologueKey, List<MonologueItem>> MonologueDic = new Dictionary<MonologueKey, List<MonologueItem>>() {
        { MonologueKey.Sample, new List<MonologueItem>() {
            new MonologueItem("It's no power.", "Fuse box"),
            new MonologueItem("Too bad...")
        }},
        { MonologueKey.FoundPhoto, new List<MonologueItem>() {
            new MonologueItem("A piece of what was once a photography of a happy family.", "Photo fragment", "PhotoFragment"),
            new MonologueItem("Looks like it's been ripped into pieces.")
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

    public static Dictionary<ExpoTapeKey, MonologueItem> ExpoTapeDic = new Dictionary<ExpoTapeKey, MonologueItem>() {
        { ExpoTapeKey.Tape1, new MonologueItem(
            "It's all her fault. If she had just kept an eye on our daughter, this wouldn't have happened. But no, she had to go take care of the baby. It's always the baby. Always! And now my little girl is gone. Gone! And they expect me to just accept it, to just move on. How the hell am I supposed to do that?",
            "Tape #4",
            null
        )},
        { ExpoTapeKey.Tape2, new MonologueItem(
            "The abuse still haunts me. I never wanted to be like him, but now I fear I've become the monster that hurt me. Stuck in this cycle of repeating the same mistakes. At least I'm not beating them like he used to beat me.",
            "Tape #9",
            null
        )},
        { ExpoTapeKey.Tape3, new MonologueItem(
            "She's been acting so strange lately, talking about playing with our little girl. It's like she's still here, but that can't be. I don't know what to believe anymore. Is she losing her mind? Or am I imagining things in my grief and guilt? I just don't know how to make sense of it all.",
            "Tape #22",
            null
        )},
        { ExpoTapeKey.Tape4, new MonologueItem(
            "It's too much, I can't handle it anymore! She's getting crazier by the day and it's driving me mad. And worst of all, she's acting like everything's great, trying to convince me I'm the one that's having delusions, that it's the alcohol that is making me imagine things.\nJust yesterday I saw her talking to herself, it's clear she's the one that's lost touch with reality. But when I try to bring it up, she just laughs it off, says I'm the one that needs help.\nThat's it, I'm getting her institutionalized. I just can't handle her.",
            "Tape #28",
            null
        )},
        { ExpoTapeKey.Tape5, new MonologueItem(
            "She came back from the hospital, I thought it was all gonna be okay, but nope. What kinda crazy person smashes a table with a baby on it? Tried to stop her, but she got away with Petar. Who knows where that nutcase went...\nLost everyone, can't fix it.\nGonna find solace in the booze bunker. It's my escape these days.",
            "Tape #42",
            null
        )},
    };
}
