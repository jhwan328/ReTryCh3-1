using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor.Animations;

public class UiManager : MonoBehaviour
{
    public Character Player;
    public TextMeshProUGUI DisplayName;
    public TextMeshProUGUI DisplayClass;
    public GameObject DisplayNameChange;
    public TextMeshProUGUI ChangedName;
    public GameObject DisplayClassChange;

    public AnimatorController knightAnimatorController;
    public AnimatorController elfAnimatorController;

    public void UpdateUI()
    {
        if(Player != null)
        {
            DisplayName.text = Player.Name;
            DisplayClass.text = Player.CuClass.ToString();
        }
        else
        {
            DisplayName.text = "None";
            DisplayClass.text = "None";
        }
    }

    public void SetPlayer(Character player)
    {
        Player = player;
        UpdateUI();
    }
    public void PushDisplayName()
    {
        DisplayName.gameObject.SetActive(false);
        DisplayNameChange.gameObject.SetActive(true);
    }
    public void PushDisplayClass()
    {
        DisplayClass.gameObject.SetActive(false);
        DisplayClassChange.gameObject.SetActive(true);
    }
    public void CancelDisplayClas()
    {
        DisplayClass.gameObject.SetActive(true);
        DisplayClassChange.gameObject.SetActive(false);
        UpdateUI();
    }

    //이 밑으로 기능
    public void PushChangeName()
    {
        Player.SetName(ChangedName.text);
        DisplayName.gameObject.SetActive(true);
        DisplayNameChange.gameObject.SetActive(false);
        UpdateUI();
    }
    public void PushElfClass()
    {
        // 1이면 현재 Elf
        if(Player.GetClassNum() ==1)
        {
            return;
        }else
        Player.ChanegClass(1);
        Player.SetAnimController(elfAnimatorController);
    }
    public void PushKnightClass()
    {
        // 0이면 현재 Knight
        if (Player.GetClassNum() == 0)
        {
            return;
        }else
        Player.ChanegClass(0);
        Player.SetAnimController(knightAnimatorController);
    }
}
