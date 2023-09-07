using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public DataManager dataManager;
    public UiManager uiManager;
    public SpawnManager spawnManager;


    private void Start()
    {
        dataManager = FindObjectOfType<DataManager>();
        
        
        if (dataManager == null)
        {
            Debug.LogError("DataManager not found in the scene.");
            return;
        }

        uiManager.SetPlayer(spawnManager.SpawnPlayer(dataManager.GetName(), dataManager.GetClassNum()));
    }

   
}
