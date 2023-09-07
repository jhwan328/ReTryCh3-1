using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Animations;

public class Character : MonoBehaviour
{
    public enum CharacterClass 
    {
        Knight,
        Elf
    }

    public CharacterClass CuClass;
    public string Name;
    public Animator animator;
     
    public void SetState(string name , int num)
    {
       
        Name = name;
        if(num == 0)
        {
            CuClass = CharacterClass.Knight;        
        }
        else
        {
            CuClass = CharacterClass.Elf;
        }
    }
    public void SetName(string name)
    {
        Name = name;
    }

    public int GetClassNum()
    {
        if(CuClass == CharacterClass.Knight)
        {
            return 0;
        }
        if(CuClass == CharacterClass.Elf)
        {
            return 1;
        }
        return 0;
    }
    public void ChanegClass(int num)
    {
        switch(num) 
        {
            case 0:
                CuClass = CharacterClass.Knight;
                break;
            case 1:
                CuClass = CharacterClass.Elf;
                break;
            default:
                break;
        }
        return;
    }

    public void SetAnimController(AnimatorController controller)
    {
        animator=this.GetComponent<Animator>();
        animator.runtimeAnimatorController = controller;
    }
   
}
