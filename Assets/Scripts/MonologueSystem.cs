using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonologueSystem : MonoBehaviour
{
    public void Speak(MonologueKey monologueKey) {
        foreach (var monologueItem in MonologueSets.MonologueDic[monologueKey])
        {
            // TODO: create speech box UI
            //Say(monologueItem.text, monologueItem.picture);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
