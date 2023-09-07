using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ClassChooseButton : MonoBehaviour
{
    public DataManager dataManager;
    public SceneLoader loader;
   
   public void OnPushKnight()
    {
        dataManager.ClassChange(0);
        loader.Button_MoveToMainScene();
    }
    public void OnPushElf()
    {
        dataManager.ClassChange(1);
        loader.Button_MoveToMainScene();
    }
}
