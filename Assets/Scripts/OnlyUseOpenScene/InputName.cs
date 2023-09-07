using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InputName : MonoBehaviour
{
    public DataManager dataManager;
    public TextMeshProUGUI Input;
    public SceneLoader loader;
    public void OnPushJoin()
    {
        dataManager.NameChange(Input.text);
        loader.Button_MoveToClassScene();
    }
}
