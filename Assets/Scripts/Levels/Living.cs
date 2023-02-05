using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Living : MonoBehaviour
{
    private void Awake()
    {
        var master = GameObject.Find("Master");
        var state = master.GetComponent<GlobalStateManager>();

        if (!state.waterRunning)
        {
            var anim = GetComponent<Animator>();
            Destroy(anim);

            var doorCellar = GameObject.Find("DoorCellar");
            Destroy(doorCellar);
        }
    }
}
