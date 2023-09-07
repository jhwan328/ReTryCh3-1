using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Clock : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    private void Update()
    {
        // 현재 시간을 얻습니다.
        DateTime currentTime = DateTime.Now;

        // 시간을 원하는 형식으로 포맷합니다.
        string Time = currentTime.ToString("HH:mm:ss");

        // TextMeshPro에 형식화된 시간을 표시합니다.
        timeText.text = Time;
    }
}
