using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DateCalculation : MonoBehaviour
{
    // [SerializeField] private Vector4 _timeSpan;
    // private DateTime
    [SerializeField] private DateAndTimeInfo _timeSpan;
    
    // Start is called before the first frame update
    void Start()
    {
        DateTime today = DateTime.Now;
        TimeSpan duration = new TimeSpan(_timeSpan.Day, 
            _timeSpan.Hour, 
            _timeSpan.Minute, 
            _timeSpan.Second);
        DateTime deliveryDay = today.Add(duration);
        Debug.Log($"Before {today.Day}/{today.Month}/{today.Year}, After {deliveryDay.Day}/{deliveryDay.Month}/{deliveryDay.Year}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

[Serializable]
public struct DateAndTimeInfo
{
    public int Day;
    public int Hour;
    public int Minute;
    public int Second;
}
