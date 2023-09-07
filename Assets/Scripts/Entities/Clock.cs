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
        // ���� �ð��� ����ϴ�.
        DateTime currentTime = DateTime.Now;

        // �ð��� ���ϴ� �������� �����մϴ�.
        string Time = currentTime.ToString("HH:mm:ss");

        // TextMeshPro�� ����ȭ�� �ð��� ǥ���մϴ�.
        timeText.text = Time;
    }
}
