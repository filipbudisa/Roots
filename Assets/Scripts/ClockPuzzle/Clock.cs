using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Clock : MonoBehaviour
{
    [SerializeField] private Transform hourHand;
    [SerializeField] private Transform minuteHand;
    [SerializeField] private int hourFinish = 9;
    [SerializeField] private int minuteFinish = 54;
    private Quaternion hourFinishDegreesMin;
    private Quaternion hourFinishDegreesMax;
    private Quaternion minuteFinishDegreesMin;
    private Quaternion minuteFinishDegreesMax;
    private const float 
    hoursToDegrees = 360f / 12f,
    minutesToDegrees = 360f / 60f;
    
    void Start(){
        minuteFinishDegreesMin =  Quaternion.Euler(0f, 0f,((float)minuteFinish - 1.5f)* -minutesToDegrees);
        minuteFinishDegreesMax =  Quaternion.Euler(0f, 0f,((float)minuteFinish + 1.5f)* -minutesToDegrees);
        hourFinishDegreesMin =  Quaternion.Euler(0f, 0f, ((float)hourFinish  - 0.1f )* -hoursToDegrees);
        hourFinishDegreesMax =  Quaternion.Euler(0f, 0f, ((float)hourFinish  + 0.1f )* -hoursToDegrees);
        Debug.Log(hourFinishDegreesMin);
        Debug.Log(hourFinishDegreesMax);
    }

    // Update is called once per frame
    void Update()
    {   
    
        //Debug.Log(hourFinishDegreesMax.eulerAngles.z);
        //Debug.Log(hourHand.eulerAngles.z);
        //Debug.Log(hourFinishDegreesMin.eulerAngles.z);

        if(hourHand.eulerAngles.z <= hourFinishDegreesMin.eulerAngles.z  && hourHand.eulerAngles.z >= hourFinishDegreesMax.eulerAngles.z) {
            if(minuteHand.eulerAngles.z  <= minuteFinishDegreesMin.eulerAngles.z && minuteHand.eulerAngles.z >= minuteFinishDegreesMax.eulerAngles.z)
            {
            Debug.Log("YAY");
            }
        }
        
    }
}
