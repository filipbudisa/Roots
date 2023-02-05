using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private GameObject colorWheel;
    static Color[] colors = { new Color(1,1,1,1), //White
                            new Color(0,1,0,1),   //Green
                            new Color(1,0,0,1),   //Red
                            new Color(0,0,1,1),   //Blue
                            new Color(1,1,0,1),   //Yellow
    };
    public int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        colorWheel.GetComponent<Renderer>().material.color = colors[index];
    }

    public void changeColorUp(){
        index--;
        if(index < 0) index = 4;
        colorWheel.GetComponent<Renderer>().material.color = colors[index];
    }

    public void changeColorDown(){
        index++;
        if(index > 4) index = 0;
        colorWheel.GetComponent<Renderer>().material.color = colors[index];
    }
}
