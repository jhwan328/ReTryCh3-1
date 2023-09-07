using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DataManager : MonoBehaviour
{
    static public DataManager instance = null;

    static public string PlayerName;
    static public CharacterClass PlayerClass;



    public enum CharacterClass
    {
        Knight,
        Elf
    }

    private void Awake()
    {
        if (null == instance)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void ClassChange(int num)
    {
        switch (num)
        {
            case 0:
                PlayerClass = CharacterClass.Knight;
                break;
            case 1:
                PlayerClass = CharacterClass.Elf;
                break;
            default:
                break;
        }
    }

    public void NameChange(string name)
    {
        PlayerName = name;
    }
    public string GetName()
    {
        return PlayerName;
    }
    public int GetClassNum()
    {
        if( PlayerClass == CharacterClass.Knight ) return 0;
        else return 1;
    }
}
