using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayPlayerName : MonoBehaviour
{
    public DataManager dataManager;
    public TextMeshProUGUI display;
    void Start()
    {
        display.text = dataManager.GetName();
    }
}
