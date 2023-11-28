using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;



public class TimeUI : MonoBehaviour
{
    public Text DayTxt;
    public Text TimeTxt;


    void Update()
    {
        GetCurrentDate();
    }
    public void GetCurrentDate()
    {
        string MonthAndDay = DateTime.Now.ToString(("MM월 dd일"));
        DayTxt.text = "날짜 : " + MonthAndDay;

        string DayTime = DateTime.Now.ToString("t");
        TimeTxt.text = "시간 : " + DayTime;
    }

}
